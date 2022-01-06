using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopProject.Data;
using ShopProject.Models;
using ShopProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
            //producten = new List<Product>();
        }

        public async Task<IActionResult> KlantIndex()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Producten = await _context.Producten.ToListAsync();
            return View(viewModel);
        }

        public async Task<IActionResult> Index()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Producten = await _context.Producten.ToListAsync();
            return View(viewModel);
        }

        public IActionResult Search(ProductListViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.ProductSearch))
            {
                viewModel.Producten = _context.Producten.Where(b => b.Naam.Contains(viewModel.ProductSearch)).ToList();
            }
            else
            {
                ProductListViewModel vm = new ProductListViewModel();
                vm.Producten = _context.Producten.ToList();
                return View("KlantIndex", vm);
            }
            return View("KlantIndex", viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("productId,Naam,Prijs,productBeschrijving, EenhedenInVoorraad, EenhedenInBestelling, InCatalogus, CategorieId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            CreateProductViewModel vm = new CreateProductViewModel()
            {
                Naam = product.Naam,
                Prijs = product.Prijs,
                productBeschrijving = product.productBeschrijving,
                EenhedenInVoorraad = product.EenhedenInVoorraad,
                EenhedenInBestelling = product.EenhedenInBestelling,
                InCatalogus = product.InCatalogus,
                categorieId = product.categorieId
            };
            return View(product);
        }

        public IActionResult Detail(int id)
        {
            Product product = _context.Producten.Where(prod => prod.productId == id).FirstOrDefault();
            if (product != null)
            {
                DetailProductViewModel viewModel = new DetailProductViewModel()
                {
                    Naam = product.Naam,
                    Prijs = product.Prijs,
                    productBeschrijving = product.productBeschrijving,
                    EenhedenInVoorraad = product.EenhedenInVoorraad,
                    EenhedenInBestelling = product.EenhedenInBestelling,
                    InCatalogus = product.InCatalogus,
                    //categorieId = product.categorieId
                };
                return View(viewModel);
            }
            else
            {
                ProductListViewModel vm = new ProductListViewModel();
                //vm.Producten = await _context.Producten.ToListAsync();
                return View("KlantIndex", vm);
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Producten.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            DeleteProductViewModel vm = new DeleteProductViewModel()
            {
                Naam = product.Naam,
                Prijs = product.Prijs,
                productBeschrijving = product.productBeschrijving,
                EenhedenInVoorraad = product.EenhedenInVoorraad,
                EenhedenInBestelling = product.EenhedenInBestelling,
                InCatalogus = product.InCatalogus,
                categorieId = product.categorieId
            };
            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Producten.FindAsync(id);
            _context.Producten.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Producten.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            EditProductViewModel vm = new EditProductViewModel()
            {
                Naam = product.Naam,
                Prijs = product.Prijs,
                productBeschrijving = product.productBeschrijving,
                EenhedenInVoorraad = product.EenhedenInVoorraad,
                EenhedenInBestelling = product.EenhedenInBestelling,
                InCatalogus = product.InCatalogus,
                categorieId = product.categorieId
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naam, Prijs, productBeschrijving, EenhedenInVoorraad, EenhedenInBestelling, InCatalogus, categorieId")] Product product)
        {
            product.productId = id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExist(product.productId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            EditProductViewModel vm = new EditProductViewModel()
            {
                Naam = product.Naam,
                Prijs = product.Prijs,
                productBeschrijving = product.productBeschrijving,
                EenhedenInVoorraad = product.EenhedenInVoorraad,
                EenhedenInBestelling = product.EenhedenInBestelling,
                InCatalogus = product.InCatalogus,
                categorieId = product.categorieId
            };
            return View(vm);
        }

        private bool ProductExist(int id)
        {
            Product product = _context.Producten.Find(id);
            if (product != null)
            {
                return true;
            }
            return false;
        }
    }
}
