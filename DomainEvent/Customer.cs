using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent
{
	public class Customer
	{
		public void DoSomething()
		{
			DomainEvent.Raise(new CustomerBecamePreferred() { Customer = this });
		}
	}
}
