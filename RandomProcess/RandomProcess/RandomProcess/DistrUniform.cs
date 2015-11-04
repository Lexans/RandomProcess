using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class DistrUniform : IDistrLaw
	{
		public double A;

		public double B;

        public static Random rand = new Random();

		public double CalcDx()
		{
            return Math.Pow((B - A), 2) / 12;
		}

		public double CalcKa()
		{
            return 0;
        }

		public double CalcKe()
		{
            return -1.2;
		}

		public double CalcMx()
		{
            return (A + B) / 2;
        }

		public double DensityFunc(double x)
		{
            if (x >= A && x <= B)
                return 1 / (B - A);
            else
                return 0;
		}

		public double DistributionFunc(double x)
		{
            if (x < A)
                return 0;
            else if (x >= B)
                return 1;
            else
                return (x - A) / (B - A);

        }

		public double GetSample()
		{
            return A + (B - A) * rand.NextDouble();
		}

		public DistrUniform(double A, double B)
		{
            this.A = A;
            this.B = B;
		}

	}
}

