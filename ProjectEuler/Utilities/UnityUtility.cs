using Microsoft.Practices.Unity;
using ProjectEuler.Interfaces;
using ProjectEuler.Problems;

namespace ProjectEuler.Utilities
{
	public class UnityUtility
	{
		public static IUnityContainer RegisterTypes()
		{
			var container = new UnityContainer();
			container.RegisterType<IFileUtility, FileUtility>();
			container.RegisterType<IProblem, Problem022>();
			return container;
		}
	}
}
