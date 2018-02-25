using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent
{
	public class CustomerBecamePreferredHandler : Handles<CustomerBecamePreferred>
	{
		public void Handle(CustomerBecamePreferred args)
		{
			
		}
	}
}
