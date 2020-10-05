using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Tim Cordero
// corderot1@lasalle.edu   
// 9/25/20
// This program should demonstrate the connection between webpages and a database. The table on the webpage displays the database.
// The database is filled with professors
// There are tabs to edit and delete a certain professor from the database
// In the navbar, there is a tab to create a new professor to add to the database
// The Last Name, First Name, Email, Department, and Position are all required fields when creating and editing a professor

namespace Assignment3.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }

        [Required(ErrorMessage ="Please enter a Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }

        public string Building { get; set; }

        public string OfficeNumber { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Please enter an Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="Please enter a Department")]
        public string Department { get; set; }

        [Required(ErrorMessage ="Please enter a Position")]
        public string Poistion { get; set; }

        public string Discipline { get; set; }

        public string Specialty { get; set; }
    }
}
