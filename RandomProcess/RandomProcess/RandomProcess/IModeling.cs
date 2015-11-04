using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public interface IModeling 
	{
		/// <summary>
		/// получение случайной реализации
		/// </summary>
		double GetSample();

	}
}

