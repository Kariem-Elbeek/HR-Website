using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        public readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["Message"] = "Hello ViewData";
            ViewBag.Trial = "Hello ViewBag";
            TempData["Message"] = "Hello from TempData";
            var departments = await _departmentRepository.GetAll();
            var empDepartmentsVM = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(empDepartmentsVM);
        }

        //[HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
        {
            if (ModelState.IsValid) // Server Side Validation
            {
                var mapDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                await _departmentRepository.Add(mapDepartment);
                TempData["SuccessfullCreation"] = "Department is successfully created!";
                return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
        }

        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound(); // 404 Page
            var department = await _departmentRepository.Get(id.Value); // Value because of Nullable
            if (department == null)
                return NotFound();
            var mapDepartmentVM = _mapper.Map<Department, DepartmentViewModel>(department);

            return View(ViewName, mapDepartmentVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id, "Edit");

            ///if (id == null)
            ///    return NotFound(); // 404 Page
            ///var department = _departmentRepository.Get(id.Value); // Value because of Nullable
            ///if (department == null)
            ///    return NotFound();
            ///return View(department);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, DepartmentViewModel departmentVM)
        {

            if (id != departmentVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var empDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                    await _departmentRepository.Update(empDepartment);
                    return RedirectToAction(nameof(Details), new { id = departmentVM.Id });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(departmentVM);
                }
            }
            return View(departmentVM);
            //if (ModelState.IsValid) // Server Side Validation
            //{
            //    _departmentRepository.Update(department);
            //    return RedirectToAction(nameof(Details));
            //}
            //return View(department);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            try
            {
                var empDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                    await _departmentRepository.Delete(empDepartment);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(departmentVM);
            }
        }
    }
}
