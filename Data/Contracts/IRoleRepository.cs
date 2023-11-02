﻿using Data.Repositories;
using Entities;
using Entities.Entities.Users;
using System.Collections.Generic;

namespace Data.Contracts
{
    public interface IRoleRepository : IRepository<Role>
    {
        IEnumerable<Role> ReturnRoleService(int Id);
    }
}
