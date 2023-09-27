namespace WrathForged.Database.Models.Auth
{
    public class InstanceList
    {
        public int Id { get; set; }
        public int Realm { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public int Port { get; set; }
        public int PlayerCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }

        public virtual Realmlist? RealmList { get; set; }
        public virtual ICollection<InstanceMaps> InstanceMaps { get; set; } = new List<InstanceMaps>();
        public virtual ICollection<InstanceCharacters> InstanceCharacters { get; set; } = new List<InstanceCharacters>();
    }
}
