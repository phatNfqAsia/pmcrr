namespace pmcrr.Controllers {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using System.Data.SqlClient;

    using pmcrr.DataContext;
    using pmcrr.Models;
 
    [Produces("application/json")]
    [Route("api/wearing")]
    [ApiController]
    public class WearingController: Controller
    {
        private readonly ApplicationDbContext _context;
        public WearingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Wearing>> getAll() {
            return _context.Wearing.ToList();
        }

        [HttpGet("{id}", Name = "GetWearing")]
        public ActionResult<Wearing> getById(long id) {
            var item = _context.Wearing.First(i => i.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }


        [HttpGet("{id}/outfit", Name = "findRelevantOutfits")]
        public ActionResult<List<Outfit>> getRelevantOutfits(long id) {
            var relevantOutfits = from OAW in _context.OutfitAndWearing
                                join outfit in _context.Outfit
                                on OAW.outfitId equals outfit.id
                                where OAW.wearing.id ==  id
                                select outfit;
            return relevantOutfits.ToList();
        }

        [HttpPost]
        public ActionResult AddWearingToWardrobe(Wearing wearing)
        {     
            try {
                _context.Wearing.Add(wearing);
                _context.SaveChanges();
            }
            catch
            {
                return Conflict();
            }
            return CreatedAtRoute("GetWearing", new {id = wearing.id}, wearing);
        }


        [HttpPost("{wearingId}/outfit/{outfitId}")]
        public ActionResult CombineToOutfit(int outfitId, int wearingId) {
            try {
                var oaw = new OutfitAndWearing(){ outfitId = outfitId, wearingId = wearingId};
                _context.OutfitAndWearing.Add(oaw);
                _context.SaveChanges();
                return Json(new {message = $"combine this wearing to outfit {wearingId}"});
            }
            catch(Exception ex) {
                return Conflict();
            }
        }
    }
}