using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class NumericCharacteristic
	{
        double[] X;
        int N;
        

		public double CalcMx()
		{
            return X.Sum()/N;
        }

		public double CalcDX()
		{
            double MX = CalcMx();

            return
                1 / (N - 1) * X.Sum((xi) => Math.Pow((xi - MX), 2));
        }

		public double CalcKe()
		{
			throw new System.NotImplementedException();
		}

		public double CalcKa()
		{
			throw new System.NotImplementedException();
		}

		public NumericCharacteristic()
		{
            X = RandomProcess.Inst.Sample;
            N = RandomProcess.Inst.N;
		}

	}
}

