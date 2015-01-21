using System.Collections.Generic;

namespace PetStore.Domain.Interfaces
{
    public interface IPetRepository
    {
        IEnumerable<IPet> GetAll();
    }
}
