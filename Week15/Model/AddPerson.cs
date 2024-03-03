using MyCoreApp.Controllers;
using Week15.Model;
using System;

namespace Week15.Model
{
    public class AddPerson
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobPosition { get; set; }
        public double Salary { get; set; }
        public double WorkExperience { get; set; }
        public Address PersonAddress { get; set; }
    }
}
