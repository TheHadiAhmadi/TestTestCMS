﻿namespace TestTestCMS.Web.Api.Models;

public class UserLoginResponse
{
    public Guid UserId { get; set; }
    public string Token { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
}