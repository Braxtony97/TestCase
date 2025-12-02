namespace Interfaces
{
    public interface IPlayer
    {
        int Health { get; set; }
        int Lives { get; set; }
        string Nickname { get; set; }
        string[] Skills { get; set; }
        
        IEquipment Equipment { get; }
    }
}