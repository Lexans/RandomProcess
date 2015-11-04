using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public interface ICorrFunc  : IModeling
	{
		double CorrFunc(double tau);

	}
}

