namespace Vituha.Play.EntityFramework.CodeFirst
{
    public sealed class Company
    {
        public int Id { get; }

        public string Name { get; private set; }

        public Company(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public void Rename(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new InvalidCompanyNameException();
            }

            Name = newName;
        }
    }
}
