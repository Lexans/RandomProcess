using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	/// <summary>
	/// Случайный процесс, моделирумый системой. Паттерн Одиночка
	/// </summary>
	public sealed class RandomProcess
	{
		public double[] Sample;

		public int N;

		public IModeling Stochastic;


        /// <summary>
        /// объект-одиночка
        /// </summary>
        private static RandomProcess inst = null;
        public static RandomProcess Inst
        {
            get
            {
                if (inst == null)
                {
                    inst = new RandomProcess();
                }
                return inst;
            }
        }



		private RandomProcess()
		{

		}

		/// <summary>
		/// получение новой выборки Sample объема N
		/// </summary>
		public void Generate()
		{
            Sample = new double[N];
 
            for (int i = 0; i < N; i++)
            {
                Sample[i] = Stochastic.GetSample();
            }
		}

		public void ToFile(string FileName)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// сброс состояния синглтон класса
		/// </summary>
		public void Reset()
		{
            inst = null;
		}

	}
}

