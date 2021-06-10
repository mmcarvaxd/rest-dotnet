using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_dotnet_final.Model.Context
{
    public class MysqlContext : DbContext
    {
        public MysqlContext()
        {

        }

        public MysqlContext(DbContextOptions<MysqlContext> options) : base (options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
