using PetStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Domain.Model
{
    public class Pet : IPet
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
