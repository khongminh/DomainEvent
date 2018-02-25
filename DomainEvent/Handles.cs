using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent
{
	public interface Handles<T> where T: IDomainEvent
	{
		void Handle(T args);
	}
}
