using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Domain.Interfaces
{
    public interface IPet
    {
         int Age { get; set; }
         string Name { get; set; }
    }
}
