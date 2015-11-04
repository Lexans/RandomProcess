using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class PirsonCrit : ICriterion
	{
        public double SignificanceLevel;

        public ProbCurves Source;

		public bool CheckCriterion(out double CritPoint, out double Statistic)
		{
            Statistic = CalcStatistic();
            CritPoint = CalcCriticalPoint();

            return (Statistic < CritPoint);
                
        }

		private double CalcCriticalPoint()
		{
            int N = Source.nIntervals;

            Dictionary<int, Dictionary<double,double>> quantTable = new Dictionary<int, Dictionary<double,double>>
            {
                {   9, new Dictionary<double,double> {{0.1, 14.684}, {0.05, 16.919}, {0.02, 19.679}, {0.01, 21.666}, {0.001, 27.877}}    },
                {   10, new Dictionary<double,double> {{0.1, 15.987}, {0.05, 18.307}, {0.02, 21.161}, {0.01, 23.209}, {0.001, 29.588}}    },
                {   11, new Dictionary<double,double> {{0.1, 17.275}, {0.05, 19.675}, {0.02, 22.618}, {0.01, 24.725}, {0.001, 31.264}}    },		
                {   12, new Dictionary<double,double> {{0.1, 18.549}, {0.05, 21.026}, {0.02, 24.054}, {0.01, 26.217}, {0.001, 32.909}}    },			
                {   13, new Dictionary<double,double> {{0.1, 19.812}, {0.05, 22.362}, {0.02, 25.472}, {0.01, 27.688}, {0.001, 34.528}}    },
                {   14, new Dictionary<double,double> {{0.1, 21.064}, {0.05, 23.685}, {0.02, 26.873}, {0.01, 29.141}, {0.001, 36.123}}    }
            };

            return quantTable[N - 1][SignificanceLevel];
		}

		private double CalcStatistic()
		{
            double N = Source.nIntervals;
            double n = RandomProcess.Inst.N;

            double result = 0;
            for (int k = 0; k < N; k++)
			{
                double pk = ((IDistrLaw) RandomProcess.Inst.Stochastic).DistributionFunc(Source.Bounds[k+1]) -
                        ((IDistrLaw) RandomProcess.Inst.Stochastic).DistributionFunc(Source.Bounds[k]);

                double vk = Source.Freqs[k];

                result += Math.Pow((vk - n * pk), 2) / (n * pk);
			}

            return result;
		}

		public PirsonCrit(ProbCurves Src)
		{
            SignificanceLevel = 0.05;
            this.Source = Src;
		}

	}
}

