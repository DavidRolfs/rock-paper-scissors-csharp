using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace Object.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        Object newObject = new Object(Request.Form["player1"], Request.Form["player2"]);
        return View["result.cshtml", newObject];
      };
    }
  }
}
