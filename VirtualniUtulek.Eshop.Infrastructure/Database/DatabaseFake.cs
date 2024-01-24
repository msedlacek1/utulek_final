﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Infrastructure.Database
{
    public class DatabaseFake
    {
        public static IList<Zvire> Zvirata { get; set; }
        public static IList<Carousel> Carousels { get; set; }

        static DatabaseFake()
        {
            DatabaseInit dbInit = new DatabaseInit();
            Zvirata = dbInit.GetZvirata();
            Carousels = dbInit.GetCarousels();
        }
    }
}
