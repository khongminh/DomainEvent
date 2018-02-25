using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent
{
	public class CustomerBecamePreferred : IDomainEvent
	{
		public Customer Customer { get; set; }
	}
}
