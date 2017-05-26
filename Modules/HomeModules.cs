using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["homepage.cshtml"];
      };
      Get["/add_new_contact"] = _ => {
        return View["add_new_contact.cshtml"];
      };
    }
  }
}
