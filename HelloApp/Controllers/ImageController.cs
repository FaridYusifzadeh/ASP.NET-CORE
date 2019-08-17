using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloApp.Models;
using HelloApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Adress = "Images Action";
            ViewBag.Name = "Ferid Qaqa";

            Studentimage studentimage = new Studentimage
            {
                Student = Images.GetStudents(),
                Allimage = Images.GetImages(),
                Numbers = Images.GetNumbers()
            };

            return View(studentimage);
        }
        public IActionResult Image(int id)
        {
            Image image = Images.GetImages().Where(i => i.Id == id).FirstOrDefault();

            //if (image == null)
            //{
            //    return notfound();
            //}

            return File("~/img/"+image.Link,"image/jpg");
        }
    }
}