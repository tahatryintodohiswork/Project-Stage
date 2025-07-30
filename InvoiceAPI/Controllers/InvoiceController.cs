using InvoiceAPI.Data;
using InvoiceAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SINVOICEController : ControllerBase
    {
        private readonly InvoiceDbContext _context;

        public SINVOICEController(InvoiceDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SINVOICE>>> GetSINVOICE()
        {
            var resultat = await _context.SINVOICEs
                .Include(x => x.Details).Take(10)
                .ToListAsync();
            return resultat;
        }
        [HttpGet("{num}")]
        public async Task<IActionResult> GetInvoiceWithDetails(string num)
        {
            var invoice = await _context.SINVOICEs
                .Include(i => i.Details)
                .FirstOrDefaultAsync(i => i.NUM_0 == num);

            if (invoice == null)
                return NotFound();

            return Ok(invoice);
        }
        [HttpPost]
        public async Task<ActionResult<SINVOICE>> CreateInvoice(SINVOICE invoice)
        {
            if (invoice == null || invoice.Details == null)
                return BadRequest("Invalid invoice format");

            _context.SINVOICEs.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSINVOICE), new { num = invoice.NUM_0 }, invoice);
        }
        [HttpPut("{num}")]
        public async Task<IActionResult> UpdateInvoice(string num, SINVOICE updatedInvoice)
        {
            var existingInvoice = await _context.SINVOICEs
                .Include(i => i.Details)
                .FirstOrDefaultAsync(i => i.NUM_0 == num);
            if (existingInvoice == null)
                return NotFound();
            _context.SINVOICEDs.RemoveRange(existingInvoice.Details);
            _context.Entry(existingInvoice).CurrentValues.SetValues(updatedInvoice);
            existingInvoice.Details = updatedInvoice.Details;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{num}")]
        public async Task<IActionResult> DeleteInvoicewithDetails(string num)
        {
            var invoice = await _context.SINVOICEs
                .FirstOrDefaultAsync(i => i.NUM_0 == num);
            if (invoice == null)
                return NotFound();
            var details = await _context.SINVOICEDs
                .Where(d => d.NUM_0 == num)
                .ToListAsync();
            _context.SINVOICEDs.RemoveRange(details);
            _context.SINVOICEs.RemoveRange(invoice);
            await _context.SaveChangesAsync();
            
            return NoContent();
        }
    }
}