using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service.AccountSer;
using Service.AdmissionTimeSer;
using Service.MajorSer;
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(Roles = "Admin")]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IMajorService _majorService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public AccountController(IAccountService accountService, IMapper mapper, UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration, UserInput userInput,IMajorService majorService)
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
                                    return fullname.Contains(searchTerm) || phone.Contains(searchTerm)|| major.Contains(searchTerm);
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
            try
            {
                var account = await _userManager.FindByIdAsync(id.ToString());
                if (account == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy người dùng!"
                    });
                }
                var resetPasswordResult = await _userManager.RemovePasswordAsync(account);
                if (!resetPasswordResult.Succeeded)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                    });
                }
                var result = await _userManager.AddPasswordAsync(account, "A123@123a");
                if (!result.Succeeded)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đăng lại mật khẩu không thành công!"
                    });
                }
                return Ok(new ResponseViewModel
                {
                    Status = true,
                    Message = "Đăng lại mật khẩu thành công"
                });
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
        [HttpGet("get-accounts-student")]
        public async Task<IActionResult> GetAccountsRequest(string? CampusId, string? Search, int CurrentPage, TypeAccount? TypeAccount)
        {
            try
            {
                ResponeModel<Account_DTO> result = new ResponeModel<Account_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                // Lấy danh sách tài khoản
                List<Account> accounts = await _accountService.GetAccountsRequest(CampusId);
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
                if (TypeAccount!=null)
                {
                    accounts = accounts
                        .Where(ac => ac.TypeAccount == TypeAccount)
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
        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                // Map DTO to the Account entity
                var account = _mapper.Map<Account>(model);
                if (model.UserName==null) {
                    account.UserName = model.StudentCode;
                }
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Trùng tên đăng nhập!"
                    });
                }
                account.isAccountActive = false;
                // Create the account in the Identity system
                var result = await _userManager.CreateAsync(account, "A123@123a");

                if (!result.Succeeded)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                    });
                }
                // Assign roles to the account
                if (!string.IsNullOrEmpty(model.RoleName))
                {
                    var roleExists = await _roleManager.RoleExistsAsync(model.RoleName);
                    if (!roleExists)
                    {
                        return BadRequest(new ResponseViewModel
                        {
                            Status = false,
                            Message = "Vai trò người dùng không tồn tại!"
                        });
                    }

                    await _userManager.AddToRoleAsync(account, model.RoleName);
                }

                return Ok(new ResponseViewModel
                {
                    Status = true,
                    Message = "Tạo tài khoản thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                });
            }
        }
        [HttpPut("update-account/{id}")]
        public async Task<IActionResult> UpdateAccount(Guid id, [FromBody] UpdateAccountDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                // Find the account by ID
                var account = await _userManager.FindByIdAsync(id.ToString());
                if (account == null)
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Tài khoản không tồn tại!"
                    });

                // Update account properties
                account.Fullname = model.Fullname ?? account.Fullname;
                account.Phone = model.Phone ?? account.Phone;
                account.Dob = model.Dob ?? account.Dob;
                account.Gender = model.Gender ?? account.Gender;
                account.isAccountActive = model.isAccountActive;
                account.Email = model.Email?? account.Email;
                account.TypeAccount = model.TypeAccount;

                // Update account in the database
                var updateResult = await _userManager.UpdateAsync(account);
                if (!updateResult.Succeeded)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                    });
                }

                // Update roles if provided
                if (!string.IsNullOrEmpty(model.RoleName))
                {
                    var currentRoles = await _userManager.GetRolesAsync(account);
                    await _userManager.RemoveFromRolesAsync(account, currentRoles);

                    var roleExists = await _roleManager.RoleExistsAsync(model.RoleName);
                    if (!roleExists)
                        return BadRequest(new ResponseViewModel
                        {
                            Status = false,
                            Message = "Vai trò người dùng không tồn tại!"
                        });

                    await _userManager.AddToRoleAsync(account, model.RoleName);
                }

                return Ok(new ResponseViewModel
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                });
            }
        }

    }
}
