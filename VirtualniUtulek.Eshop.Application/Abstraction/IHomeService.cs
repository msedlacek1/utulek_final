using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualniUtulek.Eshop.Application.ViewModels;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IHomeService
    {
        CarouselZvireViewModel GetIndexViewModel();
    }
}
