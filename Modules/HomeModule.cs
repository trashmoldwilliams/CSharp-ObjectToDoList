using Nancy;
using System.Collections.Generic;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/hello"] = _ => "Hello friend!";
    }
  }
}
