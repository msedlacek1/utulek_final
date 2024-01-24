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
    public class HomeService : IHomeService
    {
        EshopDbContext _eshopDbContext;
        public HomeService(EshopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        public CarouselZvireViewModel GetIndexViewModel()
        {
            CarouselZvireViewModel viewModel = new CarouselZvireViewModel();
            viewModel.Zvirata = _eshopDbContext.Zvirata.ToList();
            viewModel.Carousels = _eshopDbContext.Carousels.ToList();
            return viewModel;
        }
    }
}
