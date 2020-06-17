﻿using Microsoft.AspNetCore.Http;
using Microsoft.Identity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FSA.IncidentsManagement.Misc
{
    /// <summary>
    /// There must be a logged in user throughout the lifetime of the application.
    /// Except when there isnt. Meaning Dev.
    /// Class ensures a logged in username is present.
    /// </summary>
    public class UserInfo
    {
        private readonly IHttpContextAccessor httpContextAccess;

        public UserInfo(IHttpContextAccessor httpContext)
        {
            this.httpContextAccess = httpContext;
        }

        public string GetUserId()
        {
#if DEBUG
            return this.httpContextAccess.HttpContext.User.GetObjectId() ?? "Developer Mode";
#endif
            return this.httpContextAccess.HttpContext.User.GetObjectId();
        }
    }
}
