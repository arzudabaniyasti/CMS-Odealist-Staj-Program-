using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Core.Entities;
using System.Linq.Expressions;
//bunu yaptığımız zaman dataaccess.concrete.entityframework.efproductdal içerisinde delete update ... tamam hazır halde
namespace CMS.Core.DataAccess.EntityFramework
{
	//burada entity repository içerisindeki metotları her entity için implement etmek yerine 
	//burada bir kez yazacağız
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
	where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public void Add(TEntity entity)
		{
			using (var context=new TContext())
			{
				var addedEntity=context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}
		public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				//filtre yoksa tümünü filtre varsa filtreye göre getir
				return filter == null 
					? context.Set<TEntity>().ToList()
					: context.Set<TEntity>().Where(filter).ToList();

			}
		}

		public void Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updateEntity = context.Entry(entity);
				updateEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
