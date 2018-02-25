using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DomainEvent
{
	public static class DomainEvent
	{
		[ThreadStatic]
		private static List<Delegate> actions;

		public static UnityContainer Container { get; set; }

		public static void Register<T>(Action<T> callback) where T : IDomainEvent
		{
			if (actions == null)
				actions = new List<Delegate>();

			actions.Add(callback);
		}

		public static void ClearCallbacks()
		{
			actions = null;
		}

		public static void Raise<T>(T args) where T:IDomainEvent
		{
			if(Container != null)
			{
				foreach (var handler in Container.ResolveAll<Handles<T>>())
				{
					handler.Handle(args);
				}
			}

			if(actions != null)
			{
				foreach (var action in actions)
				{
					if (action is Action<T>)
						((Action<T>)action)(args);
				}
			}
		}
	}
}
