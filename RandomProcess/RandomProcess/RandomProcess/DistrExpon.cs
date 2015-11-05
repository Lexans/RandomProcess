using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class DistrExpon : IDistrLaw
	{
		public double Intensity;

        public static Random rand = new Random();

		public double CalcDx()
		{
            return 1 / Math.Pow(Intensity, 2);
		}

		public double CalcKa()
		{
            return 2;
		}

		public double CalcKe()
		{
            return 6;
		}

		public double CalcMx()
		{
            return 1 / Intensity;
		}

		public double DensityFunc(double x)
		{
            if (0 < x)
                return Intensity * Math.Exp(-Intensity * x);
            else
                return 0;
		}

		public double DistributionFunc(double x)
		{
            if (0 < x)
                return 1 - Math.Exp(-Intensity * x);
            else
                return 0;
		}

		public double GetSample()
		{
            return (-1 / Intensity) * Math.Log(1-rand.NextDouble());
		}

		public DistrExpon(double Intensity)
		{
            this.Intensity = Intensity;
		}

	}
}

