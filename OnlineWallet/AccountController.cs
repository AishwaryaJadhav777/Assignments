using Pro.Models;
using Pro.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        UsersEntities1 objUserEntities = new UsersEntities1();
        
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
                if (!objUserEntities.UserTables.Any(m => m.Email == obj.Email))
                {
                    UserTable objUser = new DBModel.UserTable();
                    objUser.UserName = obj.UserName;
                    objUser.Email = obj.Email;
                    objUser.Password = obj.Password;
                    objUser.Date_of_Birth = DateTime.Now;
                    objUser.Contact = obj.Contact;
                    objUser.IFSC_Code = obj.IFSC_Code;
                    objUser.Account_Number = obj.Account_Number;
                    objUser.Account_Type = obj.Account_Type;


                    objUserEntities.UserTables.Add(objUser);
                    objUserEntities.SaveChanges();
                    obj = new UserModel();
                    obj.Message = "Registeration Successfully";
                    ViewBag.data = "User is Successfully Added";

                    //return RedirectToAction("Index", "Home");
                    //return View("Register");


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
            if (ModelState.IsValid)
            {
                if (objUserEntities.UserTables.Where(m => m.UserName == objLoginModel.UserName && m.Password == objLoginModel.Password).FirstOrDefault() == null)
                {

                    ModelState.AddModelError("Error", "Invalid UserName or Password");
                    return View();
                }
                else
                {
                    Session["UserName"] = objLoginModel.UserName;
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