using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2_Booking.Izdavac.WinUI.Izdavac
{
    public partial class frm_SmjestajSlike : Form
    {
        Bitmap Sacuvana = null;
        string SacuvanaPath = null;
        private int _SmjestajId;

        private readonly APIService _InsertSlikaService = new APIService("smjestaj/insertimage");
        private readonly APIService _GetSlikaService = new APIService("smjestaj/getimages");

        public frm_SmjestajSlike(int SmjestajId)
        {
            InitializeComponent();
            _SmjestajId = SmjestajId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap Image = new Bitmap(open.FileName);
                Sacuvana = ResizeImage(Image, 400, 275);
                pictureBox1.Image = Sacuvana;
                SacuvanaPath = open.FileName;
            }
        }

        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private async void btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            if ( Sacuvana != null )
            {
                SlikaModel s = new SlikaModel
                {
                    SlikaFile = File.ReadAllBytes(SacuvanaPath),
                    SmjestajId = _SmjestajId
                };
                await _InsertSlikaService.Insert<SlikaModel>(s);

                Sacuvana = null;
                SacuvanaPath = null;
                pictureBox1.Image = null;

                frm_SmjestajSlike_Load(null,null);
            }

        }

        private async void frm_SmjestajSlike_Load(object sender, EventArgs e)
        {
            SlikaGetRequest request = new SlikaGetRequest
            {
                SmjestajId = _SmjestajId
            };
            List<SlikaModel> Slike = await _GetSlikaService.Get<List<SlikaModel>>(request);
            foreach ( SlikaModel s in Slike )
            {
                Image returnimage = null;
                using (MemoryStream ms = new MemoryStream(s.SlikaFile))
                {
                    returnimage = Image.FromStream(ms);
                }
                imageList.Images.Add(returnimage);

                listView1.View = View.LargeIcon;

                imageList.ImageSize = new Size(128, 128);

                listView1.LargeImageList = imageList;


                for (int j = 0; j < this.imageList.Images.Count; j++)
                {

                    ListViewItem item = new ListViewItem();

                    item.ImageIndex = j;

                    listView1.Items.Add(item);

                }
            }
        }
    }
}
