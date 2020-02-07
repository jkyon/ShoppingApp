

namespace ShoppingApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Shopping.BusinessLayer.Services;
    using Shopping.DAL.Models;

    public class EmployeeTypeController : Controller
    {
        private readonly IEmployeeTypeRepository employeeTypeRepository;

        public EmployeeTypeController(IEmployeeTypeRepository employeeTypeRepository)
        {
            this.employeeTypeRepository = employeeTypeRepository;
        }


        public IActionResult Index()
        {
            return View(this.employeeTypeRepository.GetEmployeeTypes);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeType model)
        {
            if (ModelState.IsValid)
            {
                this.employeeTypeRepository.AddType(model);
                return this.RedirectToAction("Index");
            }

            return this.View();
        }


        /// <summary>
        /// Shows the details of a employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            return this.View(this.employeeTypeRepository.GetEmployeeType(id));
        }

        /// <summary>
        /// Deletes a employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            this.employeeTypeRepository.DeleteEmployeeType(id);
            return this.RedirectToAction("Index");
        }

    }
}