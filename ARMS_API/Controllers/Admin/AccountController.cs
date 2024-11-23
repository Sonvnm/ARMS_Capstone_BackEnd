using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.MajorSer;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IMajorService _majorService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public AccountController(IAccountService accountService, IMapper mapper, UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration, UserInput userInput, IMajorService majorService)
        {
            _accountService = accountService;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _mapper = mapper;
            _userInput = userInput;
            _majorService = majorService;
        }
        [HttpGet("get-accounts")]
        public async Task<IActionResult> GetAccounts(string? CampusId, string? Search, int CurrentPage, string? role)
        {
            try
            {
                ResponeModel<Account_DTO> result = new ResponeModel<Account_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                // Lấy danh sách tài khoản
                List<Account> accounts = await _accountService.GetAccounts(CampusId);
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    accounts = accounts
                    .Where(account =>
                    {
                        string fullname = _userInput.NormalizeText(account?.Fullname ?? "");
                        string phone = _userInput.NormalizeText(account?.Phone ?? "");
                        string major = _userInput.NormalizeText(account?.Major?.MajorName ?? "");
                        return fullname.Contains(searchTerm) || phone.Contains(searchTerm) || major.Contains(searchTerm);
                    })
                                .ToList();
                }
                // Lấy vai trò cho từng tài khoản
                var rolesDictionary = new Dictionary<string, string>();
                foreach (var account in accounts)
                {
                    var roles = await _userManager.GetRolesAsync(account);
                    rolesDictionary[account.Id.ToString()] = roles.FirstOrDefault() ?? "No Role";
                }
                // Lọc theo vai trò nếu có tham số 'role'
                if (!string.IsNullOrEmpty(role))
                {
                    accounts = accounts
                        .Where(account =>
                        {
                            if (rolesDictionary.TryGetValue(account.Id.ToString(), out var roleName))
                            {
                                return roleName.Equals(role, StringComparison.OrdinalIgnoreCase);
                            }
                            return false;
                        })
                        .ToList();
                }


                // Paging
                result.PageCount = (int)Math.Ceiling(accounts.Count() / (double)result.PageSize);
                var accs = accounts
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();
                var accountDTOs = _mapper.Map<List<Account_DTO>>(accs);

                foreach (var dto in accountDTOs)
                {
                    if (rolesDictionary.TryGetValue(dto.Id.ToString(), out var roleName))
                    {
                        dto.RoleName = roleName;
                    }
                }
                result.Item = accountDTOs;
                result.TotalItems = accounts.Count;

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("get-account/{id}")]
        public async Task<IActionResult> GetAccounts(Guid id)
        {
            try
            {
                var account = await _userManager.FindByIdAsync(id.ToString());
                account.Major = await _majorService.GetMajor(account.MajorId);
                // Lấy vai trò cho từng tài khoản
                var rolesDictionary = new Dictionary<string, string>();
                var roles = await _userManager.GetRolesAsync(account);
                rolesDictionary[account.Id.ToString()] = roles.FirstOrDefault() ?? "No Role";
                var accountDTO = _mapper.Map<Account_DTO>(account);
                if (rolesDictionary.TryGetValue(account.Id.ToString(), out var roleName))
                {
                    accountDTO.RoleName = roleName;
                }

                return Ok(accountDTO);
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("reset-password/{id}")]
        public async Task<IActionResult> ResetPassword(Guid id)
        {
            return Ok(Ok());
        }
        [HttpGet("get-accounts-student")]
        public async Task<IActionResult> GetAccountsRequest()
        {
            return Ok(Ok());
        }
        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount()
        {
            return Ok(Ok());

        }
        [HttpPut("update-account/{id}")]
        public async Task<IActionResult> UpdateAccount()
        {
            return Ok(Ok());
        }
    }
}
