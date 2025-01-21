using GoTaxi.Common.Constants;
using GoTaxi.Data.Dtos;
using GoTaxi.Common.Models.UserModels;
using GoTaxi.Data.Contracts;
using GoTaxi.Data.Extensions;
using GoTaxi.Entities;
using Microsoft.AspNetCore.Identity;
using GoTaxi.Data.Exceptions;

namespace GoTaxi.Service.Services.UserServices;
public class AdminService
{
    private readonly IUserRepository _userRepository;
    public AdminService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto> Register(AdminRegisterModel model)
    {
        var user = new User()
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Username = model.UserName,
            PhoneNumber = model.PhoneNumber,
            Role = Roles.admin
        };
        var passwordHash = new PasswordHasher<User>().HashPassword(user, model.Password);
        user.HashPassword = passwordHash;
        await _userRepository.Add(user);
        return user.ParseToDto();
    }

    public async Task<string> Login(AdminLoginModel model)
    {
        var user = await _userRepository.GetUserByUsername(model.UserName);
        if(user is null)
        {
            throw new Exception("Invalid username");
        }
        var result = new PasswordHasher<User>().VerifyHashedPassword(user, user.HashPassword, model.Password);
        if(result == null)
        {
            throw new Exception("Password failed");
        }
        return "zorsan"
    }
}
