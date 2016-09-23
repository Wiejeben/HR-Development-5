namespace Prototype
{
    class User : Model<User>
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
