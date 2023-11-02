﻿using System.Threading;
using System.Threading.Tasks;
using Data.Repositories;
using Entities.DTOs.Token;
using Entities.DTOs.UsersDtos.Admin;
using Entities.Entities.Users;
using Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using WebFramework.Api;

namespace MyApi.Controllers.v2
{
    [ApiVersion("2")]
    public class UsersController : v1.UsersController
    {
        public UsersController(IUserRepository userRepository,
            ILogger<v1.UsersController> logger,
            IJwtService jwtService,
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            SignInManager<User> signInManager)
            : base(userRepository, logger, jwtService, userManager, roleManager, signInManager)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tokenRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<ActionResult> Token([FromForm] TokenRequest tokenRequest, CancellationToken cancellationToken)
        {
            return base.Token(tokenRequest, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<ApiResult<User>> SignUp(CreateUserAdminDto userDto, CancellationToken cancellationToken)
        {
            return base.SignUp(userDto, cancellationToken);
        }
    }
}
