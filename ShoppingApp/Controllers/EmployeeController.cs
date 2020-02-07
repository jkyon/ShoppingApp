

namespace ShoppingApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Shopping.BusinessLayer.Services;
    using Shopping.DAL.Models;

    public class EmployeeController : Controller
    {

        /// <summary>
        /// Holds an instance of employee repo
        /// </summary>
        private readonly IEmployeeRepository employeeRepository;


        /// <summary>
        /// Holds an instance of employee type repo
        /// </summary>
        private readonly IEmployeeTypeRepository employeeTypeRepository;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeRepository"></param>
        /// <param name="employeeTypeRepository"></param>
        public EmployeeController(IEmployeeRepository employeeRepository, IEmployeeTypeRepository employeeTypeRepository)
        {
            this.employeeRepository = employeeRepository;
            this.employeeTypeRepository = employeeTypeRepository;
        }


        /// <summary>
        /// Shows the employee list
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(this.employeeRepository.GetEmployees);
        }


        /// <summary>
        /// Navigates to create view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.EmployeeTypes = this.employeeTypeRepository.GetEmployeeTypes;
            return this.View();
        }

        /// <summary>
        /// Creates a new employee
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                this.employeeRepository.AddEmployee(model);
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
            return this.View(this.employeeRepository.GetEmployee(id));
        }

        /// <summary>
        /// Deletes a employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            this.employeeRepository.DeleteEmployee(id);
            return this.RedirectToAction("Index");
        }

    }
}