using CMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Repositories.EntityFramework.Contexts
{
	public class CMSContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
	}
}
