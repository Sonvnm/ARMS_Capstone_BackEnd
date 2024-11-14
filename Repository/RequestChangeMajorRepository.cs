using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRequestChangeMajorRepository
    {
        Task<IEnumerable<RequestChangeMajor>> GetByCampusIdAsync(string campusId);
        Task<IEnumerable<RequestChangeMajor>> GetByAccountIdAsync(Guid accountId);
    }

    public class RequestChangeMajorRepository : IRequestChangeMajorRepository
    {
        private readonly ArmsDbContext _context;

        public RequestChangeMajorRepository(ArmsDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<RequestChangeMajor>> GetByCampusIdAsync(string campusId)
        {
            if (string.IsNullOrWhiteSpace(campusId))
                throw new ArgumentException("Campus ID cannot be null or empty.", nameof(campusId));

            try
            {
                return await _context.RequestChangeMajors
                    .Include(rcm => rcm.Account)
                        .ThenInclude(account => account.StudentProfile)
                    .Where(rcm => rcm.CampusId == campusId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving RequestChangeMajors by campus ID.", ex);
            }
        }

        public async Task<IEnumerable<RequestChangeMajor>> GetByAccountIdAsync(Guid accountId)
        {
            try
            {
                return await _context.RequestChangeMajors
                    .Include(rcm => rcm.Account)
                        .ThenInclude(account => account.StudentProfile)
                    .Include(rcm => rcm.Major)
                    .Where(rcm => rcm.AccountId == accountId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error retrieving RequestChangeMajors by account ID.", ex);
            }
        }
    }
}
