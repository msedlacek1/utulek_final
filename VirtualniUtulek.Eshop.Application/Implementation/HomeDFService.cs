using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualniUtulek.Eshop.Infrastructure.Database;
using VirtualniUtulek.Eshop.Application.Abstraction;
using VirtualniUtulek.Eshop.Application.ViewModels;

namespace VirtualniUtulek.Eshop.Application.Implementation
{
    public class HomeDFService : IHomeService
    {
        public CarouselZvireViewModel GetIndexViewModel()
        {
            CarouselZvireViewModel viewModel = new CarouselZvireViewModel();
            viewModel.Zvirata = DatabaseFake.Zvirata;
            viewModel.Carousels = DatabaseFake.Carousels;
            return viewModel;
        }
    }
}
