using First_Store.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Store.Application.Interfaces.Context
{
   public interface IDataBaseContext
    {
         DbSet<User> Users { get; set; }
         DbSet<Role> Roles { get; set; }
         DbSet<UserInRole> UserInRoles { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellation = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellation = new CancellationToken());

    }
}
