using Interfaces;

namespace Infrastructure.Gameplay.Items
{
    public abstract class Item : IItem
    {
        public string Name { get; }
        
        protected Item (string name)
        {
            Name = name;
        }
    }
}