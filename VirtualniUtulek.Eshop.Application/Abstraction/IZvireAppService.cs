using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IZvireAppService
    {
        IList<Zvire> Select();
        Task Create(Zvire zvire);
        bool Delete(int id);
    }
}
