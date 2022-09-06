using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Modules.Core.Data;
using WebStore.Modules.Core.Models;

namespace WebStore.Modules.Core.Extensions
{
    public class WebStoreUserStore : UserStore<User, Role, WebStoreDbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>, IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public WebStoreUserStore(WebStoreDbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
