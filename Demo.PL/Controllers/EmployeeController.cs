using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string SearchValue)
        {
            var employees = Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(SearchValue))
                employees = await _employeeRepository.GetAll();

            else
            {
                employees = _employeeRepository.SearchEmployeesByName(SearchValue);
                ViewData["SearchPage"] = "SearchPageSuccess";  
            }

            var mapEmployeesVM = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return View(mapEmployeesVM);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _departmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid) // Server Side Valdiation
            {
                employeeVM.ImageName = DocumentSettings.UploadFile(employeeVM.Image, "images");
                var mapEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                await _employeeRepository.Add(mapEmployee);
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }

        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var employee = await _employeeRepository.Get(id.Value);
            if (employee == null)
                return NotFound();

            var mapEmployeeVM = _mapper.Map<Employee, EmployeeViewModel>(employee);
            return View(ViewName, mapEmployeeVM);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Departments = _departmentRepository.GetAll();
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var mapEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    await _employeeRepository.Update(mapEmployee);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(employeeVM);
                }

            }
            return View(employeeVM);
        }
        [Display(Name = "Department")]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var mapEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    int result = await _employeeRepository.Delete(mapEmployee);
                    if (result > 0)
                        DocumentSettings.DeleteFile(employeeVM.ImageName, "images");
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(employeeVM);
                }
            }
            return View(employeeVM);
        }
    }
}
