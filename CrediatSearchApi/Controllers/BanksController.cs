using CrediatSearchApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrediatSearchApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly CreditContext _context;

        public BanksController(CreditContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await _context.Bank.Include(bank => bank.Credits).ToArrayAsync());
        }
    }
}
