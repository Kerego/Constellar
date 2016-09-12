using Constellar.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constellar.Sample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ConstellarEngine engine = new ConstellarEngine();
			engine.Resolve<object>();
		}
	}
}
