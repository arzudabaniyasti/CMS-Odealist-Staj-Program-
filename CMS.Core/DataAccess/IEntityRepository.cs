using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CMS.Core.Entities;
namespace CMS.Core.DataAccess
{
	public interface IEntityRepository <T> where T:class,IEntity,new()
	{
		//veritabanından istediğim tek bir nesneyi istediğim filtreye(ex:id) göre çekmek
		//linq expression eklendi araştır
		T Get(Expression<Func<T, bool>> filter);
		//listeyi getir filtre yoksa tümünü getir
		IList<T> GetList(Expression<Func<T, bool>> filter = null);
		//gönderdiğim t'yi ekle
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);

		
	}
}
