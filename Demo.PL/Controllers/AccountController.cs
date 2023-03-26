using AutoMapper;
using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(IMapper mapper, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        #region Register

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                var mapUser = new ApplicationUser();
                mapUser = _mapper.Map<RegisterViewModel, ApplicationUser>(userVM);

                var result = await _userManager.CreateAsync(mapUser, userVM.Password);
                if(result.Succeeded)
                    return RedirectToAction(nameof(Login));
    
                foreach(var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);  
            }
            return View(userVM);
        }
        #endregion

        #region Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLogin.Email);
                if(user != null)
                {
                    bool flag = await _userManager.CheckPasswordAsync(user, userLogin.Password);
                    if(flag)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, userLogin.Password, userLogin.RememberMe, false);
                        if (result.Succeeded)
                            return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError(string.Empty, "Password is not correct!");
                }
                ModelState.AddModelError(string.Empty, "Email is not existed!");
            }
            return View(userLogin);
        }

        #endregion

        #region Logout
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        #endregion

        #region Forget Password
        public IActionResult ForgetPassword()
        {
            return View();
        }
        public async Task<IActionResult> SendEmail(ForgetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user); // Token is valid for one time for this user
                    var resetPasswordLink = Url.Action("ResetPassword", "Account", new { Email = model.Email, Token = token }, Request.Scheme);
                    var email = new Email()
                    {
                        Subject = "Reset Your Password",
                        To = model.Email,
                        Body = resetPasswordLink
                    };

                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckYourEmail));

                }
                ModelState.AddModelError(string.Empty, "Email in Not Existed");
            }
            return View(model);
        }

        public IActionResult CheckYourEmail()
        {
            return View();
        }
        #endregion

        #region Reset Password

        public IActionResult ResetPassword(string email, string token)
        {
            TempData["Email"] = email;
            TempData["Token"] = token;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string email = TempData["Email"] as string;
                string token = TempData["Token"] as string;

                var user = await _userManager.FindByEmailAsync(email);

                var result = await _userManager.ResetPasswordAsync(user, token, viewModel.NewPassword);
                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));

                foreach (var change in result.Errors)
                    ModelState.AddModelError(string.Empty, change.Description);

            }
            return View(viewModel);


        }
        #endregion
    }
}
