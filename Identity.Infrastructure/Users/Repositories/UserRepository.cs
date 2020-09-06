﻿using Identity.Domain.Users;
using Identity.Domain.Users.Repositories;
using Identity.Infrastructure.Utils.Common;
using Identity.Infrastructure.Utils.Context;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Infrastructure.Users.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IdentityContext context) : base(context) { }
    }
}
