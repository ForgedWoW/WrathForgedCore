namespace WrathForged.Database.Models.Auth
{
    public class InstanceMaps
    {
        public int InstanceId { get; set; }
        public int MapId { get; set; }

        public virtual required InstanceList InstanceList { get; set; }
    }
}
