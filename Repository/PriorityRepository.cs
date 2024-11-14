using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PriorityRepository
    {
        private readonly ArmsDbContext _context;
        public PriorityRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<PriorityDetail>> GetPriorities()
        {
            try
            {
                List<PriorityDetail> PriorityDetails = await _context.PriorityDetails.ToListAsync();
                return PriorityDetails;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
    }
}
