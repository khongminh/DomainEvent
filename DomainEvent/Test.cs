using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DomainEvent
{
	[TestFixture]
	class Test
	{
		[Test]
		public void DoSomethingShouldMakeCustomerPreferred()
		{
			var c = new Customer();
			Customer preferred = null;

			DomainEvent.Register<CustomerBecamePreferred>(p => preferred = p.Customer);

			c.DoSomething();
			Assert.AreEqual(preferred, c);
		}
	}
}
