namespace SimpleMVVMAndMediator.Model
{
    public class User
    {
        public string Name;
        public string Address;
        public string Description;
        public User(string name, string address, string description) 
        {
            Name = name;
            Address = address;
            Description = description;
        }
    }
}
