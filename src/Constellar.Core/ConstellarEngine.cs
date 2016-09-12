using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constellar.Core
{
	public interface IAbstraction
	{

	}



    public class ConstellarEngine
    {

        public ConstellarEngine()
        {
        }

		public T Resolve<T>() where T : new()
		{
			return new T();
		}
    }
}
