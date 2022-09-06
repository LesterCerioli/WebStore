using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Modules.Core.Models;
using WebStore.Modules.Core.Data;

namespace WebStore.Modules.Core.Extensions
{
    public class WebStoreRoleStore : RoleStore<Role, WebStoreDbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public WebStoreRoleStore(WebStoreDbContext context) : base(context)
        {
        }
    }
}
