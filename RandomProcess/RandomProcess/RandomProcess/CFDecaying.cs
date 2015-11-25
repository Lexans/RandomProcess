using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class CFDecaying : ICorrFunc
	{
		public double A;

        public static Random rand = new Random();

        private double yn_1;

        public double Dt
        {
            get
            {
                return 0.4 / A;
            }
        }

        public int PointsAmount
        {
            get
            {
                return 8;
            }
        }

		public double CorrFunc(double tau)
		{
            return Math.Exp(-1 * A * Math.Abs(tau));
        }

		public double GetSample()
		{
            double y = A * Dt;
            double p = Math.Exp(-1 * y);
            double a0 = Math.Sqrt(1-Math.Pow(p, 2));
            double b1 = p;

            double yn = a0 * rand.NextDouble()+b1*yn_1;
            yn_1 = yn;

            return yn;
        }

		public CFDecaying(double A)
		{
            this.A = A;
            yn_1 = 0;
		}

	}
}

