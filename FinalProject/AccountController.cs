using OnlineWallet.DBModel;
using OnlineWallet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineWallet.Controllers
{
    public class AccountController : Controller
    {
        UserEntities objUserEntities = new UserEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            UserModel obj = new UserModel();
            return View(obj);
        }
        [HttpPost]
        public ActionResult Register(UserModel obj)
        {
            if (ModelState.IsValid)
            {
                if (!objUserEntities.Users.Any(m => m.EmailID == obj.EmailID ))
                {
                    User objUser = new DBModel.User();
                    objUser.CreatedOn = DateTime.Now;
                    objUser.EmailID = obj.EmailID;
                    objUser.FirstName = obj.FirstName;
                    objUser.LastName = obj.LastName;
                    objUser.Password = obj.Password;
                    

                    objUserEntities.Users.Add(objUser);
                    objUserEntities.SaveChanges();
                    obj = new UserModel();
                    //obj.Message = "Registeration Successfully";
                    ViewBag.data = "User is Successfully Added";

                    //return RedirectToAction("Index", "Home");


                }
                else
                {
                    ModelState.AddModelError("Error", "Email Address is Already Exist");
                    return View();
                }
            }
            return View();
        }
        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }
        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            if(ModelState.IsValid)
            {
                if(objUserEntities.Users.Where(m=>m.EmailID==objLoginModel.EmailID && m.Password==objLoginModel.Password).FirstOrDefault()==null)
                {
        
                    ModelState.AddModelError("Error", "Invalid Email or Password");
                    return View();
                }
                else
                {
                    Session["EmailID"] = objLoginModel.EmailID;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}