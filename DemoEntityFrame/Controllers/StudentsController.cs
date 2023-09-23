using Microsoft.AspNetCore.Mvc;
using System;

public class StudentsController : Controller
{
    private readonly AppDbContext context;

    public StudentsController(AppDbContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        var students = context.Students.ToList();

        return View(students);
    }
}
