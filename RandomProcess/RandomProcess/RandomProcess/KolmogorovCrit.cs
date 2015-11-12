using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
    public sealed class KolmogorovCrit : ICriterion
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
            int N = RandomProcess.Inst.N;

            Dictionary<double, double> quantTable = new Dictionary<double, double>
            {
                {0.1, 1.22},
                {0.05, 1.36},
                {0.02, 1.52},
                {0.01, 1.63},
                {0.001, 1.95}
            };

            return quantTable[SignificanceLevel] / Math.Sqrt(N);
        }

        private double CalcStatistic()
        {
            double xMin = Source.Bounds[0];
            double xMax = Source.Bounds.Last();

            double result = 0;
            for (double x = xMin; x < xMax; x += 0.01)
            {
                double Dn = Source.DistrFunc(x) - ((IDistrLaw)RandomProcess.Inst.Stochastic).DistributionFunc(x);
                if (Dn > result)
                    result = Dn;
            }
            return result;
        }

        public KolmogorovCrit(ProbCurves Src)
        {
            SignificanceLevel = 0.05;
            this.Source = Src;
        }

    }
}

