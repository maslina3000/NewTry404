using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace stTest.Models
{
    public class AnswerContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public AnswerContext(DbContextOptions<AnswerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
