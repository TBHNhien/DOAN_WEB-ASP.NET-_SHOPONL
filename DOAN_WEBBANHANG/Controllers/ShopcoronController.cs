using DOAN_WEBBANHANG.Models.BUS;
using PagedList;
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
        public ActionResult Index(int page = 1 , int pagesize = 3) //page size là số lượng sản phẩm hiển thị lên trong 1 trang
        {
            var db = ShopOnlineBUS.DanhSach().ToPagedList(page,pagesize);
            return View(db);
        }

        // GET: Shopcoron/Details/5
        public ActionResult Details(String id)
        {
            var db = ShopOnlineBUS.ChiTiet(id);
            return View(db);
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
