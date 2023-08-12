using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOAN_WEBBANHANG.Controllers
{
    public class ShopcoronController : Controller
    {
        // GET: Shopcoron
        public ActionResult Index()
        {
            return View();
        }

        // GET: Shopcoron/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shopcoron/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shopcoron/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shopcoron/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shopcoron/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shopcoron/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shopcoron/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
