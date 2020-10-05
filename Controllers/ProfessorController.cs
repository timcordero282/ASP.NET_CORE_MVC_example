using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class ProfessorController : Controller
    {
        private ProfessorContext context { get; set; }

        public ProfessorController(ProfessorContext ctx)
        {
            context = ctx;
        }

        //ADDING
        [HttpGet]

        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Professor());       
        }

        //EDITING
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var prof = context.Professors.Find(id);
            return View(prof);
        }

        [HttpPost]
        public IActionResult Edit(Professor prof)
        {
            if (ModelState.IsValid)
            {
                if (prof.ProfessorID == 0)
                { // adding                    
                    context.Professors.Add(prof);
                }
                else
                {  // updating                    
                    context.Professors.Update(prof);
                }
                context.SaveChanges(); // change DB
                return RedirectToAction("Index", "Home");  // put up list view   

            }
            else
            {  // user error                
                ViewBag.Action = (prof.ProfessorID == 0) ? "Add" : "Edit";
                return View(prof);
            }
        }

        // DELETING
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usr = context.Professors.Find(id); // find user to be deleted
            return View(usr);
        }
        [HttpPost]
        public IActionResult Delete(Professor usr)
        {
            context.Professors.Remove(usr);
            context.SaveChanges();
            return RedirectToAction("Index", "Home"); // display list of users        
        }

    }
}
