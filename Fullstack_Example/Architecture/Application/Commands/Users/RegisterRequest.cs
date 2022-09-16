using Fullstack_Example.Architecture.Application.DataObjects.Security;
using Fullstack_Example.Architecture.Application.DataObjects.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fullstack_Example.Architecture.Application.Commands.Users
{
    public class RegisterRequest : BaseRequest, IRequest<object?>
    {
        public RegisterRequest(Command command) : base(command)
        {
        }
    }

    public class RegisterRequestHandler : BaseAuthenticate, IRequestHandler<RegisterRequest, object?>
    {
        public RegisterRequestHandler(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<object?> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            var requestData = request?.RequestData?.ToString();
            if (request == null || requestData == null) return default;

            var model = JsonConvert.DeserializeObject<RegisterDto>(requestData);
            if (model == null) return default;

            var userExists = await userManager.FindByNameAsync(model.UserName);
            if (userExists != null)
                return new Response { Status = "Error", Message = "User already exists!" };

            AppUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded) return new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." };

            return new Response { Status = "Success", Message = "User created successfully!" };
        }
    }
}
