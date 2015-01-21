using PetStore.Domain.Interfaces;

namespace PetStore.Domain.Model
{
    public class Pet : IPet
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
