using GoTaxi.Data.Dtos;
using GoTaxi.Entities;
using Mapster;

namespace GoTaxi.Data.Extensions;
public static class ParseToDtoExtension
{
    public static UserDto ParseToDto(this User user)
    {
        return user.Adapt<UserDto>();
    }

    public static List<UserDto> ParseToDtos(this List<User>? users)
    {
        var dtos = new List<UserDto>();
        if(users == null || users.Count == 0)
        {
            return dtos;
        }
        dtos.AddRange(users.Select(user => user.ParseToDto()));
        return dtos;
    }
}
