# ASP.NET MVC: Models

The data and logic your application deals with is represented in C# by classes called models. You can pass these models from your controller to your view and display information about them on your page.    

## Exploring the code

* `Models\Actor.cs` contains the model that describes what an actor is.
* `Controllers\ActorController.cs` passes Actor-objects to the views.
* `Views\Actors\*.cshtml` retrieve information from the model and put them on the page.

If you want to try and implement a model yourself, you can check out the `start`-branch, which is the starting point for this example.