using System.Collections.Generic;

namespace Interfaces
{
    public interface IEquipment
    {
        void AddItem(IItem item);
        IReadOnlyList<IItem> Items { get; }
    }
}