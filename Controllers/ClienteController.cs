using System;
using medium_dio_artigo_fluentvalidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace medium_dio_artigo_fluentvalidation.Controllers
{
  public class ClienteController : Controller
  {
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Cliente model)
    {
      if (ModelState.IsValid) return RedirectToAction("Index", "Home");
      return View(model);
    }
  }
}