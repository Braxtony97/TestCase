using System.Collections.Generic;
using Interfaces;

namespace Infrastructure.Gameplay
{
    public class Equipment : IEquipment
    {
        public IReadOnlyList<IItem> Items => _items;

        private readonly List<IItem> _items = new ();

        public void AddItem(IItem item) => 
            _items.Add(item);
    }
}