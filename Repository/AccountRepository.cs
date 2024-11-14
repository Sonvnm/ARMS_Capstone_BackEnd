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
    public class AccountRepository
    {
        private readonly ArmsDbContext _context;
        public AccountRepository(ArmsDbContext context) { _context = context; }

        public async Task<Account> GetAccountByUserId(Guid userId)
        {
            try
            {
                Account Account = await _context.Accounts
                    .Include(x=>x.Major)
                    .Include(x => x.StudentProfile)
                    .SingleOrDefaultAsync(x => x.Id== userId);
                return Account;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
