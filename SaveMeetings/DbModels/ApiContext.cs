using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveMeetings.DbModels
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options){}

        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Race> Race { get; set; }

    }
}
