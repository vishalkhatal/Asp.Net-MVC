using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using mvcCrud.Models;

namespace mvcCrud.Controllers
{
    
    public class EmployeeController : Controller
    {
        EmployeeEntities empdata = new EmployeeEntities();
        // GET: Employee
        [HttpGet]
        public ActionResult GetData()
        {
            var emp=empdata.Employees.ToList();
            return View(emp);
        }
        [HttpGet]
        public ActionResult Index()
        {
            var emp = empdata.Employees.ToList();
            return View(emp);
        }
        [HttpGet]
        public ActionResult AddorEdit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddorEdit(Employee employee)
        {
            if (ModelState.IsValid)
              { 
            empdata.Employees.Add(employee);
            empdata.SaveChanges();
            return RedirectToAction("GetData");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Update(int Id)
        {
          var empEdit=  empdata.Employees.Single(x => x.EmpId == Id);
           
            return View(empEdit);
        }
        [HttpPost]
        public ActionResult Update(int Id, Employee employee)
        {
         
            if (ModelState.IsValid)
            {
                var empEdit = empdata.Employees.Single(x => x.EmpId == Id);
                empEdit.EmpName = employee.EmpName;
                empEdit.Age = employee.Age;
                empEdit.Designation = employee.Designation;
                empEdit.Salary = employee.Salary;
                empdata.SaveChanges();
                return RedirectToAction("GetData");
            }

            return View();
        }
        [HttpGet]
        public ActionResult delete(int Id)
        {
            var empDelete = empdata.Employees.Single(x => x.EmpId == Id);
            
            return View(empDelete);
        }
        [HttpPost]
        public ActionResult delete(int Id, Employee employee)
        {
            var empDelete = empdata.Employees.Single(x => x.EmpId == Id);
            empdata.Employees.Remove(empDelete);
            empdata.SaveChanges();
            return RedirectToAction("getdata");

           
        }
    }
}