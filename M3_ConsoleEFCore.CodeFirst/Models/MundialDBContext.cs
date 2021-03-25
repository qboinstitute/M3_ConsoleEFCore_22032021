using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_ConsoleEFCore.CodeFirst.Models
{
    public class MundialDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string myConnectionString = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialDB;Trusted_Connection=true;MultipleActiveResultSets=true";

            optionsBuilder.UseSqlServer(myConnectionString).LogTo(Console.WriteLine, LogLevel.Information);


            base.OnConfiguring(optionsBuilder);
        }


        public virtual DbSet<Player> Player { get; set; }

        public virtual DbSet<Team> Team { get; set; }


    }
}
