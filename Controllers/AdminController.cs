using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eticaret.MvcWebUI.Models;
using Eticaret.MvcWebUI.App_Classes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Drawing;
using System.Threading;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;



namespace Eticaret.MvcWebUI.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        public AdminController(IHostingEnvironment hostingEnvironment)
        {
            _appEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {


            return View();
        }
        public IActionResult Deneme()
        {
            return View(Context.Baglanti.Urunler.ToList());
        }
        public IActionResult Urunler()
        {

            ViewBag.Kategoriler = Context.Baglanti.Kategori.ToList();
            ViewBag.Markalar = Context.Baglanti.Marka.ToList();
            return View(Context.Baglanti.Urunler.ToList());
            
        }
       
        [HttpGet]
        public IActionResult UrunEkle()
        {
            ViewBag.Kategoriler = Context.Baglanti.Kategori.ToList();
            ViewBag.Markalar = Context.Baglanti.Marka.ToList();
            return View();


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UrunEkle([Bind("UrunId,MarkaId,KategoriId,UrunAdi,Acıklama,AlisFiyat,SatisFiyat,EklenmeTarihi,SonKullanmaTarihi")]Urunler urn)
        {
            Context.Baglanti.Add(urn);
            await Context.Baglanti.SaveChangesAsync();

            return RedirectToAction("Urunler");
        }
       
        public ActionResult Markalar()
        {
            

            return View(Context.Baglanti.Marka.ToList());
        }

        [HttpGet]
        public IActionResult MarkaEkle()
        {
            

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkaEkle([Bind("MarkaAdi,MarkaLogo")]Marka emp)
        {

            
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;
                        //There is an error here
                        
                        var uploads = Path.Combine(_appEnvironment.WebRootPath, "Resimler\\MarkaLogolari");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                               // Image img=Image
                                   
                              //  Bitmap bm = new Bitmap(Request.Body);
                                
                                await file.CopyToAsync(fileStream);
                                string filePath = "ResimLer\\MarkaLogolari\\" + fileName;
                                emp.MarkaLogo= filePath;

                            }

                        }
                    }
                }

            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            
            Context.Baglanti.Add(emp);
            await Context.Baglanti.SaveChangesAsync();
            return RedirectToAction("Markalar");
        }

        public ActionResult Kategoriler()
        {


            return View(Context.Baglanti.Kategori.ToList());
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KategoriEkle([Bind("KategoriId,KategoriTür")]Kategori ktg)
        {
            Context.Baglanti.Add(ktg);
            await Context.Baglanti.SaveChangesAsync();
            return RedirectToAction("Kategoriler");
            
        }
        
        public IActionResult OzellikTipLeri()
        {
            ViewBag.Kategoriler = Context.Baglanti.Kategori.ToList();
            return View(Context.Baglanti.OzellikTip.ToList());
        }
        [HttpGet]
        public IActionResult OzellikTipEkle()
        {
            ViewBag.Kategoriler = Context.Baglanti.Kategori.ToList();


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OzellikTipEkle([Bind("OzellikId,OzellikAdi,OzellikAcıklama,KategoriId")]OzellikTip ozt)
        {
            Context.Baglanti.Add(ozt);
            await Context.Baglanti.SaveChangesAsync();
            return RedirectToAction("OzellikTipleri");
        }

       

        public IActionResult OzellikDegerleri()
        {
            return View(Context.Baglanti.OzellikDeger.ToList());
        }
        [HttpGet]
        public IActionResult OzellikDegerEkle()
        {
            ViewBag.OzellikTipLeri = Context.Baglanti.OzellikTip.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OzellikDegerEkle([Bind("OzellikDegerId,OzellikDegerAdi,OzellikDegerAcıklama,OzellikTipId")] OzellikDeger ozd)
        {
            Context.Baglanti.Add(ozd);
            await Context.Baglanti.SaveChangesAsync();
            return RedirectToAction("OzellikDegerleri");
        }


        public IActionResult UrunOzellikleri()
        {
            ViewBag.OzellikTipleri = Context.Baglanti.OzellikTip.ToList();
            ViewBag.Ozellikdegerleri = Context.Baglanti.OzellikDeger.ToList();
            ViewBag.Urunler = Context.Baglanti.Urunler.ToList();

            return View(Context.Baglanti.UrunOzellik.ToList());
        }
        [HttpGet]
        public IActionResult UrunOzellikEkle()
        {
            ViewBag.Urunler=Context.Baglanti.Urunler.ToList();
            ViewBag.TipiNe = Context.Baglanti.OzellikTip.ToList();
            ViewBag.DegerNe = Context.Baglanti.OzellikDeger.ToList();
            ViewBag.Kategoriler = Context.Baglanti.Kategori.ToList();
          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UrunOzellikEkle([Bind("UrunOzellikId,OzellikTipId,OzellikDegerId")] UrunOzellik uoz)
        {
            Context.Baglanti.Add(uoz);
            await Context.Baglanti.SaveChangesAsync();
            return RedirectToAction("UrunOzellikleri");
        }

        
        
        public JsonResult wert(int? katId)
        {
            if (katId != null)
            {
                var data = Context.Baglanti.OzellikTip.Where(x => x.KategoriId == katId).ToList();

                return Json(data);
            }
            else
            {
                var data = Context.Baglanti.OzellikTip.ToList();

                return Json(data);
            }

           
           
        }

        public IActionResult UrunOzelliTipkWidget(int? katId)
        {
            if (katId != null)
            {
               var data = Context.Baglanti.OzellikTip.Where(x => x.KategoriId == katId).ToList();
                
                return  PartialView(data);
            }
            else {
                var data = Context.Baglanti.OzellikTip.ToList();
                
                return PartialView(data);
            }
        }
        
        public PartialViewResult UrunOzellikDegerWidger(int? tipId)
        {
            if (tipId!=null)
            {
                var data = Context.Baglanti.OzellikDeger.Where(x => x.OzellikTipId == tipId).ToList();
                return PartialView(data);
            }
            else
            {
                var data = Context.Baglanti.OzellikDeger.ToList();
                return PartialView(data);
            }

        }
        

        public IActionResult UrunOzellikSil(int urunId, int TipId,int DegerId)
        {
            UrunOzellik uo = Context.Baglanti.UrunOzellik.FirstOrDefault(x => x.OzellikDegerId == urunId && x.OzellikTipId == TipId && x.OzellikDegerId == DegerId);
            Context.Baglanti.Remove(uo);
            Context.Baglanti.SaveChanges();
            return RedirectToAction("UrunOzellikleri");
        }

    }
}