﻿using System;
using System.Collections.Generic;
using OPOLEbiegaPL.Model;

namespace OPOLEbiegaPL.Data.Stores
{
    public static class AnnouncementStore
    {
        public static List<Announcement> Store = new List<Announcement>
        {
            AnnouncementFactory(1, "Wyjazd1", "Bieszczady", new DateTime(2016, 8, 24, 6, 0, 0)),
            AnnouncementFactory(2, "Wyjazd2", "Radków", new DateTime(2016, 9, 17, 6, 0, 0)),
            AnnouncementFactory(3, "Wyjazd3", "Tatry", new DateTime(2016, 9, 24, 6, 0, 0)),
            AnnouncementFactory(4, "Wyjazd4", "Beskidy", new DateTime(2016, 10, 12, 6, 0, 0)),
            AnnouncementFactory(5, "Wyjazd5", "Tatry", new DateTime(2016, 10, 22, 6, 0, 0)),
            AnnouncementFactory(6, "Wyjazd6", "Tatry", new DateTime(2016, 11, 11, 6, 0, 0)),
            AnnouncementFactory(7, "Wyjazd7", "Góry stołowe", new DateTime(2016, 11, 24, 6, 0, 0)),
        };

        public static Announcement AnnouncementFactory(int id, string name, string place, DateTime date)
        {
            return new Announcement
            {
                Id = id,
                Name = name,
                Date = date,
                Details = "Długość trasy: 35km, przewyższenia: 1800m",
                Place = place,
                Description = "Jakiś opis",
                FacebookURL = "https://www.facebook.com/events/1803282573228690/",
                ImageURL = "http://opalenica24.info/wp-content/uploads/2014/10/logo-biegacz.gif"
            };
        }
    }
}
