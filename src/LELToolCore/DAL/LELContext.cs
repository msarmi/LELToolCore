using LELToolCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.DAL
{
    public class LELContext : DbContext
    {
		public LELContext(DbContextOptions<LELContext> options)
		  :base(options)
		{
			
		}

		public LELContext():base() {
			
		}

		public DbSet<LELProject> LELProjects { get; set; }
		public DbSet<Symbol> Symbols { get; set; }		
		public DbSet<Synonym> Synonyms { get; set; }
	}
}
