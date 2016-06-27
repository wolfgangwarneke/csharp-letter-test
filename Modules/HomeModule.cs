using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/hello"] = _ => "Hello friend!";
      Get["/goodbye"] = _ => "Goodbye friend!";
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Jessica");
        myLetterVariables.SetSender("John");
        return View["hello.cshtml", myLetterVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
    }
  }
}
