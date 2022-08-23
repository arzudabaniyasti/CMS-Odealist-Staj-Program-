using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Core.Entities;


namespace CMS.Domain.Entities
{
	public class Category: AuditableBaseEntity,IEntity
	{

		public string CategoryName { get; set; }
		public bool CategoryStatus { get; set; }

	}
}
