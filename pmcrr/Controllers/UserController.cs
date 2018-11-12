using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using pmcrr.DataContext;
using pmcrr.Models;

namespace  pmcrr.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController: Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<User>> getAll() {
            return _context.User.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<User> getById(long id) {
            var item = _context.User.First(i =>  i.id == id);
            if (item != null)
            {
                return item;
            }
            return NotFound();
        }

        [HttpGet("{id}/wearing")]
        public ActionResult<List<Wearing>> getWearingOfAUser(long id)
        {
            var ownedWearings = from wearing in _context.Wearing
                                where (wearing.ownerId == id)
                                select wearing;
            return ownedWearings.ToList();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return CreatedAtRoute("GetUser", new { id = user.id}, user);
        }

    }
}