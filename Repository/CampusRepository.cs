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
    public class CampusRepository
    {
        private readonly ArmsDbContext _context;
        public CampusRepository(ArmsDbContext context) { _context = context; }
        public async Task<int> CountCampus()
        {
            try
            {
                int campus = _context.Campuses.Count();
                return campus;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        //public async Task<List<AlumiStudent>> GetAlumiStudents()
        //{
        //    try
        //    {
        //        List<AlumiStudent> AlumiStudents = await _context.AlumiStudents
        //            .Include(x=>x.SpecializeMajor)
        //            .Include(x => x.Campus)
        //            .ToListAsync();
        //        return AlumiStudents;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw;
        //    }
        //}

        public async Task<List<Slider>> GetSliders(string campusId)
        {
            try
            {
                List<Slider> sliders = await _context.Sliders
                    .Where(x => x.CampusId.Equals(campusId))
                    .ToListAsync();
                return sliders;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<List<Campus>> GetCampusesAsync()
        {
            try
            {
                List<Campus> campuses = await _context.Campuses.ToListAsync();
                return campuses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Campus> GetCampus(string campusId)
        {
            try
            {
                Campus Campus = await _context.Campuses.FirstOrDefaultAsync(x => x.CampusId.Equals(campusId));
                return Campus;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
