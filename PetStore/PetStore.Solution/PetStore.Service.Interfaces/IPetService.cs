using PetStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Service.Interfaces
{
    public interface IPetService
    {
        IEnumerable<IPet> GetAll();
    }
}
