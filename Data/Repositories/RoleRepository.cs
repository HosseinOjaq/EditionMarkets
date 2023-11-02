﻿using Common;
using Data.Contracts;
using Entities;
using Entities.Entities.Users;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository, IScopedDependency
    {
        public RoleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Role> ReturnRoleService(int Id)
        {
            List<Role> exists = Table.Where(a => a.Id == Id).ToList();
            return exists;
        }
    }
}
