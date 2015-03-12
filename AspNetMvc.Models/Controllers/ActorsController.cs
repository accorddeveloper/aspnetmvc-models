using System.Web.Mvc;

namespace AspNetMvc.Models
{
    public class ActorsController : Controller
    {
        public ActionResult Details()
        {
            // Here we create information about a single actor. In most cases, you would get this
            // data from an external source, like a database, but for the purposes of this example,
            // we just create the object directly in code.
            var actor = new Actor()
            {
                FirstName = "Hugh",
                LastName = "Jackman",
                Nationality = "Australian"
            };

            // You can pass a model from the action to the view by passing it as a parameter to
            // View().
            return View(actor);
        }

        public ActionResult Index()
        {
            // Here we create information about a number of actors. In most cases, you would get
            // this data from an external source, like a database, but for the purposes of this
            // example, we just create the array directly in code.
            var actors = new Actor[]
            {
                new Actor()
                {
                    FirstName = "Hugh",
                    LastName = "Jackman",
                    Nationality = "Australian"
                },

                new Actor()
                {
                    FirstName = "Gary",
                    LastName = "Oldman",
                    Nationality = "English"
                },

                new Actor()
                {
                    FirstName = "Keira",
                    LastName = "Knightley",
                    Nationality = "English"
                },

                new Actor()
                {
                    FirstName = "Morgan",
                    LastName = "Freeman",
                    Nationality = "American"
                },

                new Actor()
                {
                    FirstName = "Jennifer",
                    LastName = "Connelly",
                    Nationality = "American"
                },

                new Actor()
                {
                    FirstName = "Russell",
                    LastName = "Crowe",
                    Nationality = "New Zealand"
                },

                new Actor()
                {
                    FirstName = "William",
                    LastName = "Shatner",
                    Nationality = "Canadian"
                }
            };

            // You can pass a collection of models from the action to the view by passing the
            // collection as a parameter to View().
            return View(actors);
        }
    }
}