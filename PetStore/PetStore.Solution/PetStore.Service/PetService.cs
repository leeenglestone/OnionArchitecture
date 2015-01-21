using System.Collections.Generic;
using PetStore.Domain.Interfaces;
using PetStore.Service.Interfaces;

namespace PetStore.Service
{
    public class PetService : IPetService
    {
        readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public IEnumerable<IPet> GetAll()
        {
            return _petRepository.GetAll();
        }
    }
}
