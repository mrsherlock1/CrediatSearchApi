using CrediatSearchApi.Models;
using CrediatSearchApi.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace CrediatSearchApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CreditsController : ControllerBase
    {
        private readonly CreditContext _context;

        public CreditsController(CreditContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Credit> GetCredits([FromQuery] FilterCredits filter)
        {
            IQueryable<Credit> credits = _context.Credits
                .Include(
                    credit => credit.Bank
                );

            if(filter.BankName != null ) {

                credits = credits.Where(credit => credit.Bank.Name.Contains(filter.BankName));
            }

            if(filter.MinimumAmount != null)
            {
                credits = credits.Where(credit => credit.MinimumAmount >= filter.MinimumAmount);
            }

            return credits.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> PostCredit(Credit credit)
        {
            _context.Credits.Add(credit);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutCredit(int id, Credit credit)
        {
            if (id != credit.Id)
            {
                return BadRequest();
            }

            _context.Entry(credit).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
