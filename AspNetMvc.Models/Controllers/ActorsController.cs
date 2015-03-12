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
    }
}