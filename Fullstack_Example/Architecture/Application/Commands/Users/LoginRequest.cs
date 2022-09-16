using Fullstack_Example.Architecture.Application.DataObjects.Users;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fullstack_Example.Architecture.Application.Commands.Users
{
    public class LoginRequest : BaseRequest, IRequest<object?>
    {
        public LoginRequest(Command command) : base(command)
        {
        }
    }

    public class LoginRequestHandler : BaseAuthenticate, IRequestHandler<LoginRequest, object?>
    {
        public LoginRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (request == null || requestData == null) return default;

            var model = JsonConvert.DeserializeObject<LoginDto>(requestData);
            if (model == null) return default;

            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var token = GetToken(authClaims);
                return new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                };
            }
            return default;
        }
    }
}
