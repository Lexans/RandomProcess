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
            double MX = CalcMx();
            double DX = CalcDX();

            return ( 1 / (N - 1) * X.Sum((xi) => Math.Pow((xi - MX), 4)))/(Math.Pow(DX ,2)) ;
		}

		public double CalcKa()
		{
            double MX = CalcMx();
            double DX = CalcDX();
            
            return 
                (1 / N  * X.Sum((xi) => Math.Pow((xi - MX), 3)))/(Math.Pow(Math.Sqrt(DX), 3));
		}

		public NumericCharacteristic()
		{
            X = RandomProcess.Inst.Sample;
            N = RandomProcess.Inst.N;
		}

	}
}

