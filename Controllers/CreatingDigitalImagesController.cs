using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TT_GeeksForLess_Vladyslav_Slyzkoukhyi;
using TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Models;

namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Controllers
{
    public class CreatingDigitalImagesController : Controller
    {
        private readonly FolderContext _context;

        public CreatingDigitalImagesController(FolderContext context)
        {
            _context = context;
        }

        // GET: CreatingDigitalImages
        public async Task<IActionResult> Index()
        {
              return _context.CreatingDigitalImages != null ? 
                          View(await _context.CreatingDigitalImages.ToListAsync()) :
                          Problem("Entity set 'FolderContext.CreatingDigitalImages'  is null.");
        }
        
        //// GET: CreatingDigitalImages/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.CreatingDigitalImages == null)
        //    {
        //        return NotFound();
        //    }

        //    var creatingDigitalImages = await _context.CreatingDigitalImages
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (creatingDigitalImages == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(creatingDigitalImages);
        //}

        //// GET: CreatingDigitalImages/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}
        // GET: CreatingDigitalImages/Create
        public IActionResult CreatingDigitalImages()
        {
            return View();
        }
        public IActionResult Resources()
        {
            return View();
        }
        public IActionResult Evidence()
        {
            return View();
        }
        public IActionResult GraphicProducts()
        {
            return View();
        }
        public IActionResult PrimarySources()
        {
            return View();
        }
        public IActionResult SecondarySources()
        {
            return View();
        }
        public IActionResult Process()
        {
            return View();
        }
        public IActionResult FinalProduct()
        {
            return View();
        }

        //// POST: CreatingDigitalImages/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,ResourcesId,GraphicProductId,EvidenceId")] CreatingDigitalImages creatingDigitalImages)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(creatingDigitalImages);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(creatingDigitalImages);
        //}

        //// GET: CreatingDigitalImages/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.CreatingDigitalImages == null)
        //    {
        //        return NotFound();
        //    }

        //    var creatingDigitalImages = await _context.CreatingDigitalImages.FindAsync(id);
        //    if (creatingDigitalImages == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(creatingDigitalImages);
        //}

        //// POST: CreatingDigitalImages/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ResourcesId,GraphicProductId,EvidenceId")] CreatingDigitalImages creatingDigitalImages)
        //{
        //    if (id != creatingDigitalImages.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(creatingDigitalImages);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CreatingDigitalImagesExists(creatingDigitalImages.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(creatingDigitalImages);
        //}

        //// GET: CreatingDigitalImages/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.CreatingDigitalImages == null)
        //    {
        //        return NotFound();
        //    }

        //    var creatingDigitalImages = await _context.CreatingDigitalImages
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (creatingDigitalImages == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(creatingDigitalImages);
        //}

        //// POST: CreatingDigitalImages/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.CreatingDigitalImages == null)
        //    {
        //        return Problem("Entity set 'FolderContext.CreatingDigitalImages'  is null.");
        //    }
        //    var creatingDigitalImages = await _context.CreatingDigitalImages.FindAsync(id);
        //    if (creatingDigitalImages != null)
        //    {
        //        _context.CreatingDigitalImages.Remove(creatingDigitalImages);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CreatingDigitalImagesExists(int id)
        //{
        //  return (_context.CreatingDigitalImages?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
