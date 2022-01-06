using Microsoft.AspNetCore.Authorization;
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
    public class TrainingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public List<Training> trainingen;

        public TrainingController(ApplicationDbContext context)
        {
            _context = context;
            trainingen = new List<Training>();
            //trainingen.Add(new Training() { ID=1, Datum = "Maandag", TrainingsDuur = "17.00 - 19.00", Locatie="Vossenberg", AantalBeschikbareVelden=12});
            //trainingen.Add(new Training() { ID=2, Datum = "Woensdag", TrainingsDuur = "20.00 - 23.30", Locatie = "Vossenberg", AantalBeschikbareVelden = 6 });
        }

        public async Task<IActionResult> Index()
        {
            TrainingListViewModel viewModel = new TrainingListViewModel();
            viewModel.Trainingen = await _context.Trainingen.ToListAsync();
            return View(viewModel);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Datum,TrainingsDuur,Locatie, AantalBeschikbareVelden")] Training training)
        {
            if (ModelState.IsValid)
            {
                _context.Add(training);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            CreateTrainingViewModel vm = new CreateTrainingViewModel()
            {
                Datum = training.Datum,
                TrainingsDuur = training.TrainingsDuur,
                Locatie = training.Locatie,
                AantalBeschikbareVelden = training.AantalBeschikbareVelden
            };
            return View(training);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Training training = await _context.Trainingen.FindAsync(id);

            if (training == null)
            {
                return NotFound();
            }
            EditTrainingViewModel vm = new EditTrainingViewModel()
            {
                Datum = training.Datum,
                TrainingsDuur = training.TrainingsDuur,
                Locatie = training.Locatie,
                AantalBeschikbareVelden = training.AantalBeschikbareVelden
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Datum, TrainingsDuur, Locatie, AantalBeschikbareVelden")] Training training)
        {
            training.ID = id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(training);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingExist(training.ID))
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
            EditTrainingViewModel vm = new EditTrainingViewModel()
            {
                Datum = training.Datum,
                TrainingsDuur = training.TrainingsDuur,
                Locatie = training.Locatie,
                AantalBeschikbareVelden = training.AantalBeschikbareVelden
            };
            return View(vm);
        }

        private bool TrainingExist(int id)
        {
            Training training = _context.Trainingen.Find(id);
            if (training != null)
            {
                return true;
            }
            return false;
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Training training = await _context.Trainingen.FindAsync(id);

            if (training == null)
            {
                return NotFound();
            }
            DeleteTrainingViewModel vm = new DeleteTrainingViewModel()
            {
                Datum = training.Datum,
                TrainingsDuur = training.TrainingsDuur,
                Locatie = training.Locatie,
                AantalBeschikbareVelden = training.AantalBeschikbareVelden
            };
            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var training = await _context.Trainingen.FindAsync(id);
            _context.Trainingen.Remove(training);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
