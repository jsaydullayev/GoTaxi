﻿namespace GoTaxi.Data.Exceptions;
public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(Guid userId)
        : base($"User with Id: {userId} not found.") 
    { }
}
