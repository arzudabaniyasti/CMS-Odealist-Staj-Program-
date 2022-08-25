using CMS.Core.DataAccess;
using CMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Repositories
{
	public interface ICategoryRepository : IEntityRepository<Category>
	{
	}
}
