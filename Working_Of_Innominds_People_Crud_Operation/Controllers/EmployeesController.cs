using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Working_Of_Innominds_People_Crud_Operation.BusinessLayer.EmployeeFolder;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeLayer Employee;
        public EmployeesController(IEmployeeLayer employee)
        {
            Employee = employee;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var obj = Employee.GetAllEmployee();
            return View(obj);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
           var data= Employee.InsertEmployee(employee);
            if(data!=null)
            {
                return RedirectToAction("Index");
            }
            
            return View(employee);
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var category = Employee.GetByDataBasedOnEmpNameOrEmpId(id);
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConform(int id)
        {
            Employee.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var data = Employee.GetByDataBasedOnEmpNameOrEmpId(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var category = Employee.GetByDataBasedOnEmpNameOrEmpId(id);
            return View(category);
        }

        [HttpPost, ActionName("Edit")]

        public ActionResult Edit(int id, Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee.UpdateData(employee);
            }
            return RedirectToAction("Index");
        }
    }
}
