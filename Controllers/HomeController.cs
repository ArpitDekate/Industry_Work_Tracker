using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LarsenNToubro.Models;
using Microsoft.AspNet.Identity;

namespace LarsenNToubro.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private ProjectContext db = new ProjectContext();

        public ActionResult Index()
        {
            var list = db.Contact_History;

            ViewBag.Data = list;

            //for opportunity converted
            var list1 = db.Opportunity;
            ViewBag.Data1 = list1;

            //for opportunity active
            var list2 = db.Opportunity;
            ViewBag.Data2 = list2;

            //for opportunity lost
            var list3 = db.Opportunity;
            ViewBag.Data3 = list2;

            return View(db.Contact_Details.ToList());
            //  return View(); 
        }

        /*        
         *        [HttpGet] 
                public ActionResult Opportunity(int id)
                {
                    Opportunity opportunity = db.Opportunity.Single(opp => opp.Opportunity_id == id);
                    int a = db.Opportunity.DefaultIfEmpty().Max(r => r == null ? 0 : r.Opportunity_id);
                    int b = a+1;
                    opportunity.Opportunity_id = b;

                    return View(opportunity);
                }
        */

        public ActionResult Opportunity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Opportunity(Opportunity opp)
        {
            try {

                // if (ModelState.IsValid)
                //   {
                db.Opportunity.Add(opp);
                db.SaveChanges();
                return RedirectToAction("Index");
                // }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    //Violation of primary key. Handle Exception
                }
                else throw;
            }
            return View();
        }

        public ActionResult Contact_Details()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact_Details(Contact_Details conn)
        {
            try
            {
                int a = db.Contact_Details.DefaultIfEmpty().Max(r => r == null ? 0 : r.Opportunity_id);
                conn.Opportunity_id = a + 1;
                db.Contact_Details.Add(conn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (SqlException)
            {

            }
            return View();
        }

        public ActionResult Industry_Records()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Industry_Records(Industry_Records ind, Company_Information com, Lt_Ts_Operations lt)
        {
            try
            {
                int a = db.Industry_Records.DefaultIfEmpty().Max(r => r == null ? 0 : r.Client_id);
                com.Client_id = a + 1;
                lt.Client_id = a + 1;
                db.Industry_Records.Add(ind);
                db.Company_Information.Add(com);
                db.Lt_Ts_Operations.Add(lt);
                db.SaveChanges();
                ViewBag.result = "Data Inserted";
                return RedirectToAction("Index");
            }
            catch (SqlException)
            {

            }
            return View();
        }

        public ActionResult Contact_History()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact_History(Contact_History ch)
        {
            try
            {
                db.Contact_History.Add(ch);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (SqlException)
            {
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Action_Items()
        {
            ViewBag.data = db.Contact_History.ToList();
            return PartialView("Action_Items");
        }

        public ActionResult Opportunity_Converted()
        {

            ViewBag.data1 = db.Opportunity.ToList();

            return PartialView("Opportunity_Converted");
        }

        public ActionResult Opportunity_Active()
        {

            ViewBag.data2 = db.Opportunity.ToList();

            return PartialView("Opportunity_Active");
        }
        public ActionResult Opportunity_Lost()
        {

            ViewBag.data3 = db.Opportunity.ToList();

            return PartialView("Opportunity_Lost");
        }
        public ActionResult CH_hyperlink()
        {

            ViewBag.data3 = db.Opportunity.ToList();

            return PartialView("CH_hyperlink");
        }
        public ActionResult Partial1()
        {
            ViewBag.data = db.Contact_History.ToList();
            return PartialView("Partial1");
        }

        public ActionResult Login()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Login(Login_Page lp)
        {
            String s = "abcd";
            String p = "pqrs";
           
            var l = db.Login_Page.ToList();

            if (ModelState.IsValid)
            {
                var user = (from userlist in db.Login_Page
                            where userlist.Username ==lp.Username && userlist.Password == lp.Password
                            select new
                            {
                                userlist.Username,
                                userlist.Password
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["Username"] = user.FirstOrDefault().Username;
                    Session["Password"] = user.FirstOrDefault().Password;
                    return Redirect("/home/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");     
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }
    }
}