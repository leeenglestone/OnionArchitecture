using System.Collections.Generic;
using PetStore.Domain.Interfaces;

namespace PetStore.Service.Interfaces
{
    public interface IPetService
    {
        IEnumerable<IPet> GetAll();
    }
}
