using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.ViewModels;
using System.Linq;

public class AccountController : Controller
{
    private readonly ApplicationDbContext db;

    public AccountController(ApplicationDbContext context)
    {
        db = context;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            User user = new User
            {
                FullName = model.FullName,
                Email = model.Email,
                Password = model.Password,
                Role = model.Role
            };

            db.Users.Add(user);
            db.SaveChanges();

            return RedirectToAction("Login");
        }

        return View(model);
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        var user = db.Users.FirstOrDefault(x =>
            x.Email == model.Email && x.Password == model.Password);

        if (user != null)
        {
            if (user.Role == "Teacher")
                return RedirectToAction("Index", "TeacherDashboard");

            else
                return RedirectToAction("Index", "StudentDashboard");
        }

        ViewBag.Message = "Invalid Email or Password";

        return View();
    }
}