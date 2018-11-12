namespace pmcrr.Controllers {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using System.Data.SqlClient;

    using pmcrr.DataContext;
    using pmcrr.Models;

    [Route("api/outfit")]
    [ApiController]
    public class OutfitController: Controller {
        private readonly ApplicationDbContext _context;
        public OutfitController(ApplicationDbContext context) {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Outfit>> GetAllOutfit() {
            return _context.Outfit.ToList();
        }
        
        [HttpGet("{id}", Name = "GetOutfit")]
        public ActionResult<Outfit> GetOutfitById(long id) {
            var outfit = _context.Outfit.First(o => o.id == id);
            if (outfit != null)
                return outfit;
            return NotFound();
        }

        [HttpGet("{id}/wearing")]
        public ActionResult<List<Wearing>> GetIncludedWearing(long id) {
            var includedWearing = from wearing in _context.Wearing
                                    join oaw in _context.OutfitAndWearing
                                    on wearing.id equals oaw.wearingId
                                    where oaw.outfitId == id
                                    select wearing;
            return includedWearing.ToList();
        }

        [HttpPost]
        public ActionResult Create(Outfit outfit) {
            _context.Outfit.Add(outfit);
            _context.SaveChanges();
            return CreatedAtRoute("GetOutfit", new { id = outfit.id }, outfit);
        }

    }
}