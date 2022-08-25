using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Core.DataAccess.EntityFramework;
using CMS.Domain.Entities;
using CMS.Infrastructure.Repositories.EntityFramework.Contexts;

namespace CMS.Infrastructure.Repositories.EntityFramework
{
	public class EfCategoryRepository: EfEntityRepositoryBase<Category,CMSContext>
	{
	}
}
