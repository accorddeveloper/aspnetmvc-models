namespace AspNetMvc.Models
{
    // A model describes the characteristics of an entity the application needs to work with. In
    // this case, the Actor-model describes everything we want to know about an actor.
    public class Actor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
    }
}