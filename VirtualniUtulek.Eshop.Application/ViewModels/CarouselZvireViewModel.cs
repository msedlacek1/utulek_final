using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Application.ViewModels
{
    public class CarouselZvireViewModel
    {
        public IList<Carousel> Carousels { get; set; }
        public IList<Zvire> Zvirata { get; set; }
    }
}
