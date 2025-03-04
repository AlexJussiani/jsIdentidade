﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace JS.Identidade.Domain.Models
{
    public interface IAspNetUser
    {
        string Name { get; }
        Guid ObterUserId();      
        string ObterUserEmail(); 
        string ObterUserToken();
        string ObterUserRefreshToken();
        bool EstaAutenticado();
        bool PossuiRole(string role);
        IEnumerable<Claim> ObterClaims();
        HttpContext ObterHttpContext();
    }
}