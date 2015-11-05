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
            return Dx;
		}

		public double CalcKa()
		{
            return 0;
		}

		public double CalcKe()
		{
            return 0;
		}

		public double CalcMx()
		{
            return Mx;
		}

		public double DensityFunc(double x)
		{
            return (1 / (Math.Sqrt(2 * Math.PI) * Dx)) * Math.Exp((-Math.Pow(x-Mx,2))/2*Math.Pow(Dx,2));
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
            this.Dx = Dx;
            this.Mx = Mx;
		}

	}
}

