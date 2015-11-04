using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public interface IDistrLaw  : IModeling
	{
		double CalcDx();

		double CalcKa();

		double CalcKe();

		double CalcMx();

		double DensityFunc(double x);

		double DistributionFunc(double x);
	}
}

