using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.ArmsContext;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Repository;

namespace Service.AccountSer
{
    public class AccountService : IAccountService
    {
        private readonly AccountRepository _accountRepository;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public AccountService(ArmsDbContext context, UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _accountRepository = new AccountRepository(context);
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public Task<Account> GetAccountByUserId(Guid userId)
       => _accountRepository.GetAccountByUserId(userId);

        public Task<List<Account>> GetAccounts(string campusId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Account>> GetAccountsRequest(string campusId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Account>> GetAccountStudent(string campusId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Account>> GetAO(string campusId)
        {
            throw new NotImplementedException();
        }
    }
}
