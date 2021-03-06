﻿using System;
using System.Collections.Generic;
using OPOLEbiegaPL.Model;

namespace OPOLEbiegaPL.Data.Stores
{
    public static class EventStore
    {
            public static List<Event> Store = new List<Event>
            {
                EventFactory(1, "Wyjazd1", "Bieszczady", new DateTime(2016, 2, 24, 6, 0, 0)),
                EventFactory(2, "Wyjazd2", "Radków", new DateTime(2016, 3, 17, 6, 0, 0)),
                EventFactory(3, "Wyjazd3", "Tatry", new DateTime(2016, 4, 24, 6, 0, 0)),
                EventFactory(4, "Wyjazd4", "Beskidy", new DateTime(2016, 5, 12, 6, 0, 0)),
                EventFactory(5, "Wyjazd5", "Tatry", new DateTime(2016, 5, 22, 6, 0, 0)),
                EventFactory(6, "Wyjazd6", "Tatry", new DateTime(2016, 6, 11, 6, 0, 0)),
                EventFactory(7, "Wyjazd7", "Góry stołowe", new DateTime(2016, 7, 24, 6, 0, 0)),
            };

        public static Event EventFactory(int id, string name, string place, DateTime date)
        {
            return new Event
            {
                Id = id,
                Name = name,
                Date = date,
                Details = "Długość trasy: 35km, przewyższenia: 1800m",
                Place = place,
                EventReport = "Jakiś opis",
                ImageURL = "http://www.elle.pl/gfx/00/01/07/db/image-1gmvbib_jpg/thumb_900x800_10.jpg/__/majowka-w-polsce-gory-fot-fotolia-com.jpg",
                GalleryURL = "https://sites.google.com/site/pieknewidokipl/home/gorywpolsce"
            };
        }
    }
}
