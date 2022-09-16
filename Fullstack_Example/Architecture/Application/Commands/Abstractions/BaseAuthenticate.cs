using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fullstack_Example.Architecture.Application.Commands.Abstractions
{
    public abstract class BaseAuthenticate
    {
        protected readonly UserManager<AppUser> userManager;
        protected readonly RoleManager<IdentityRole> roleManager;
        protected readonly IConfiguration configuration;

        public BaseAuthenticate(IServiceProvider serviceProvider)
        {
            userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>(); ;
            roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            configuration = serviceProvider.GetRequiredService<IConfiguration>();
        }

        protected JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
