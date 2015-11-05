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

		public double CalcDx()
		{
            double MX = CalcMx();

            return
                1d / (N - 1) * X.Sum((xi) => Math.Pow((xi - MX), 2));
        }

		public double CalcKe()
		{
            double MX = CalcMx();
            double DX = CalcDx();

            return ( 1d / (N - 1) * X.Sum((xi) => Math.Pow((xi - MX), 4)))/(Math.Pow(DX ,2)) - 3 ;
		}

		public double CalcKa()
		{
            double MX = CalcMx();
            double DX = CalcDx();
            
            return 
                (1d / N  * X.Sum((xi) => Math.Pow((xi - MX), 3)))/(Math.Pow(DX, 3d/2));
		}

		public NumericCharacteristic()
		{
            X = RandomProcess.Inst.Sample;
            N = RandomProcess.Inst.N;
		}

	}
}

