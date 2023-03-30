using Microsoft.AspNetCore.Mvc;
using MessageBoardClient.Models;

namespace MessageBoardClient.Controllers;

public class MessageController : Controller
{
  public IActionResult Index()
  {
    List<Message> messages = Message.GetMessages();
    return View(messages);
  }
}