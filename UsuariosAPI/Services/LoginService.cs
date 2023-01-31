using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using UsuariosAPI.Data.Requests;

namespace UsuariosAPI.Services
{
    public class LoginService
    {
        private SignInManager<IdentityUser<int>> _signInManager;

        public LoginService(SignInManager<IdentityUser<int>> signInManager)
        {
            _signInManager = signInManager;
        }

        public Result LogaUsuario(LoginRequest request)
        {
            var resultadiIdentity = _signInManager.
                PasswordSignInAsync(request.Username, request.Password, false, false);
            if (resultadiIdentity.Result.Succeeded)
            {
                return Result.Ok();
            }
            return Result.Fail("Login falhou");
        }
    }
}
