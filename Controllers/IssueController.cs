using System;
using System.Collections.Generic;//
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Tracking.Data;
using Tracking.Modals;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : Controller
    {
        private readonly IssueDbContext _context;

        public IssueController(IssueDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
        {
            return await _context.Issues.ToListAsync();
        }
    }
}

