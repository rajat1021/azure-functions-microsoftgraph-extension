﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Microsoft.Azure.WebJobs.Extensions.AuthTokens
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Threading.Tasks;

    internal interface IEasyAuthClient
    {
        Task<EasyAuthTokenStoreEntry> GetTokenStoreEntry(JwtSecurityToken jwt, TokenAttribute attribute);

        Task RefreshToken(JwtSecurityToken jwt, TokenAttribute attribute);

        string GetBaseUrl();
    }
}
