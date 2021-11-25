using System;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/meiopgto")]
    public class MeioPgtoController : ControllerBase
    {
        private readonly DataContext _context;
        public MeioPgtoController(DataContext context)
        {
            _context = context;
        }

       //POST: api/meiopgto/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] MeioPgto meiopgto)
        {
            _context.MeioPgtos.Add(meiopgto);
            _context.SaveChanges();
            return Created("", meiopgto);
        }

        //GET: api/meiopgto/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.MeioPgtos.ToList());
    }
}