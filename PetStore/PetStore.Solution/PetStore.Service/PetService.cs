using PetStore.Domain.Interfaces;
using PetStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Service
{
    public class PetService : IPetService
    {
        IPetRepository _petRepository;

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
