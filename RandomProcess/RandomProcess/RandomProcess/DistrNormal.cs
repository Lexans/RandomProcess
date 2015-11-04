using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class DistrNormal : IDistrLaw
	{
		public double Dx;

		public double Mx;

        public static Random rand = new Random();

		public double CalcDx()
		{
			throw new System.NotImplementedException();
		}

		public double CalcKa()
		{
			throw new System.NotImplementedException();
		}

		public double CalcKe()
		{
			throw new System.NotImplementedException();
		}

		public double CalcMx()
		{
			throw new System.NotImplementedException();
		}

		public double DensityFunc(double x)
		{
			throw new System.NotImplementedException();
		}

		public double DistributionFunc(double x)
		{
			throw new System.NotImplementedException();
		}

		public Double GetSample()
		{
			throw new System.NotImplementedException();
		}

		public DistrNormal(double Dx, double Mx)
		{
		}

		public double GetSample()
		{
			throw new System.NotImplementedException();
		}

	}
}

