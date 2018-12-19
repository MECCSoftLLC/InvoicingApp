using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoicing.Core.Base;
using Invoicing.Core.Services;
using Invoicing.Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invoicing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiBaseController
    {
        IAccountService AccountService;

        public AccountController(IAccountService accountService)
        {
            AccountService = accountService;
        }


        [HttpPost("Login")]
        public string Login([FromBody] LoginViewModel loginData)
        {
            Boolean success = AccountService.Login(loginData.Email, loginData.Password);

            return new RequestResult()
            {
                State = success ? RequestState.Success : RequestState.Failed
            }.Serialize();
        }

        [HttpPost("Signup")]
        public string Signup([FromBody] SignupViewModel signupData)
        {
            Boolean success = AccountService.Signup(signupData);

            if (success)
                return Login(new LoginViewModel()
                {
                    Email = signupData.Email, Password = signupData.Password
                });
            else
                return new RequestResult()
                {
                    State = RequestState.Failed
                }.Serialize();
        }

    }
}