using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialCoreApplication.Models
{
    public class TutorialDbContext:DbContext
    {
        public DbSet<Tutorial> tutorial { get; set; }
        public DbSet<UserInfo> userinfo { get; set; }
    }
}
