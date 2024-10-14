using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Data.DTO;
using Data.Models;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ARMS_API.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        
        public AuthenticationController(UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            try
            {
                if (model == null || model.username == null || model.CampusId == null)
                {
                    throw new Exception("Không nhận được thông tin người dùng");
                }
                //var user = await _userManager.FindByEmailAsync(model.email);
                var user = await _userManager.Users
                                        .Where(user => user.CampusId == model.CampusId && user.UserName == model.username && user.isAccountActive == true)
                                        .FirstOrDefaultAsync();
                if (user == null)
                {
                    throw new Exception("Tài khoản của bạn không tồn tại trong campus hiện tại");
                }

                //login by password
                if (model.password != null)
                {
                    if (user != null && !await _userManager.CheckPasswordAsync(user, model.password))
                    {
                        return Unauthorized();
                    }
                }
                var userRoles = await _userManager.GetRolesAsync(user);
                var role = userRoles.FirstOrDefault();
                var authClaims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Fullname),
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                if (!String.IsNullOrEmpty(user.AvatarURL))
                {
                    authClaims.Add(new Claim("AvatarUrl", user.AvatarURL));
                }
                var Bear = GetToken(authClaims);

                ResponseLogin respone = new ResponseLogin();
                respone.Bear = new JwtSecurityTokenHandler().WriteToken(Bear);
                respone.Expiration = Bear.ValidTo;
                respone.CampusId = model.CampusId;
                respone.Role = role;
                return Ok(respone);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi trong quá trình xử lý"
                });
            }
        }
        [HttpPost("gg/login-with-google")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWithGoogle()
        {
            return Ok();
        }
        private async Task<FirebaseAdmin.Auth.FirebaseToken> VerifyGoogleTokenWithFirebase(string idToken)
        {
            try
            {
                // Khởi tạo Firebase Admin SDK nếu chưa
                FirebaseService.InitializeFirebase();

                // Xác minh token với Firebase
                var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
                return decodedToken;
            }
            catch (FirebaseAuthException firebaseAuthEx)
            {
                Console.WriteLine($"Firebase authentication error: {firebaseAuthEx.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error verifying token: {ex.Message}");
                return null;
            }
        }
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var expirationTimeUtc = DateTime.UtcNow.AddHours(72);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.SpecifyKind(expirationTimeUtc, DateTimeKind.Utc),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
