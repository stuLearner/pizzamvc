﻿using Pizza.Contracts.Security.ServiceContracts;
using Pizza.Contracts.Security.ViewModels;

namespace Pizza.Contracts.Security
{
    public interface IAuthService
    {
        LoginResult<TUserViewModel> LoginUser<TUserViewModel>(LoginRequest loginRequest) 
            where TUserViewModel : PizzaUserViewModel, new();

        ChangePasswordResult ChangePassword(ChangePasswordRequest changePasswordRequest);
    }
}