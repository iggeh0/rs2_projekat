﻿using RS2_Booking.Model;
        private readonly API_Service_Mobile _otkaziService = new API_Service_Mobile("rezervacija/promjenistatus");
            RezervacijaChangeStatusRequest request = new RezervacijaChangeStatusRequest();
            request.RezervacijaId = RezervacijaId;
            request.StatusId = 3;
            IsBusy = true;
            await _otkaziService.Insert<RezervacijaChangeStatusRequest>(request);
            StatusRezervacijeId = 2;
            StatusRezervacijeNaziv = "Otkazano od strane klijenta";
            Aktivna = false;
        }
                Aktivna = true;          
            UkupnoUplaceno = new double();

        public bool _Aktivna;