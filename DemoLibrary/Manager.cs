namespace DemoLibrary
{
    public class Manager : Person
    {
        public string GetAllNames()
        {
            return $"{FirstName}, {LastName}, {formerLastName}";
        }
    }
}
