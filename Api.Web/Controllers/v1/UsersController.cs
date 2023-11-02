﻿using Common.Exceptions;
using Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebFramework.Api;
using Microsoft.AspNetCore.Identity;
using Entities.DTOs.UsersDtos.Admin;
using Entities.DTOs.Token;
using Microsoft.AspNetCore.Cors;
using WebFramework.Filters;
using Entities.Entities.Users;
using Entities.Users;

namespace MyApi.Controllers.v1
{
    [AllowAnonymous]
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiResultFilter]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserRepository userRepository;
        private readonly ILogger<UsersController> logger;
        private readonly IJwtService jwtService;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly SignInManager<User> signInManager;

        public UsersController(IUserRepository userRepository, ILogger<UsersController> logger, IJwtService jwtService,
            UserManager<User> userManager, RoleManager<Role> roleManager, SignInManager<User> signInManager)
        {
            this.userRepository = userRepository;
            this.logger = logger;
            this.jwtService = jwtService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }
       
        [HttpPost(nameof(SignUp))]        
        public virtual async Task<ApiResult<User>> SignUp(CreateUserAdminDto userDto, CancellationToken cancellationToken)
        {
            var isExists = await userManager.Users.AnyAsync(x => x.UserName == userDto.UserName);
            if (isExists)
                return BadRequest("نام کاربری تکراری است");
            var user = new User
            {
                Age = userDto.Age,
                FullName = userDto.FullName,
                Gender = userDto.Gender,
                UserName = userDto.Email,
                Email = userDto.Email
            };
            var result = await userManager.CreateAsync(user, userDto.Password);
            return user;
        }

        /// <summary>
        /// This method generate JWT Token
        /// </summary>
        /// <param name="tokenRequest">The information of token request</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost(nameof(Token))]        
        [EnableCors("AllowCors")]
        public virtual async Task<ActionResult> Token([FromForm] TokenRequest tokenRequest, CancellationToken cancellationToken)
        {
            if (!tokenRequest.grant_type.Equals("password", StringComparison.OrdinalIgnoreCase))
                throw new Exception("OAuth flow is not password.");

            var user = await userManager.FindByNameAsync(tokenRequest.username);
            if (user is null)
                throw new BadRequestException("نام کاربری یا رمز عبور اشتباه است");

            var isPasswordValid = await userManager.CheckPasswordAsync(user, tokenRequest.password);
            if (!isPasswordValid)
                throw new BadRequestException("نام کاربری یا رمز عبور اشتباه است");

            var jwt = await jwtService.GenerateAsync(user);
            return new JsonResult(jwt);
        }
    }
}
