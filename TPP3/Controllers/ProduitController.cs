using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPP3.Models;

namespace TPP3.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()

        {
            ViewBag.Message = "Hello to the home page of TP3";
            return View();
        }


        public ActionResult DisplayOneProduct()
        {
            // Création d'une instance de Produit
            var produit = new Produit
            {

                Id = 1,
                Name = "Produit 1",
                Prix = 9.99
            };


            ViewBag.P = produit;
            return View();
        }
        public ActionResult DisplayManyproducts()
        {
            List<Produit> produits = new List<Produit>
        {
            new Produit { Id = 1, Name = "Produit 1", Prix = 100.99 },
            new Produit { Id = 2, Name = "Produit 2", Prix = 55.80 },
            new Produit { Id = 3, Name = "Produit 3", Prix = 1999.99 }
        };

            // ViewData bch trj3 liste des produits lil vue
            ViewData["ListeProduits"] = produits;

            // nrj donnee fil vue
            return View("DisplayManyproducts");
        }
    }
}