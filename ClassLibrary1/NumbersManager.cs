using Numbers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Numbers
{
    public class NumbersManager : INumbersManager
    {
       
        public decimal ApproximatePiWithOddFractions(int digitsToCompute)
        {
            //Pi initally set to 1, "add" variable allows alternating adding/subtraction while looping
            decimal pi = (decimal)1;
            bool add = false;

            //i increments by 2 to generate suquential odd fractions
            for (int i = 3; i <= 9999; i += 2)
            {
                if (add == true)
                {
                    pi += (decimal)1 / (decimal)i;
                    add = false;
                }
                else
                {
                    pi -= (decimal)1 / (decimal)i;
                    add = true;
                }
            }

            //Multiple by four since above technique approximates pi/4
            pi = pi * 4;
            return Math.Round(pi, digitsToCompute);
            
        }

        public decimal ApproximatePiWithFraction(int digitsToCompute)
        {

            decimal pi = (decimal)355 / (decimal)113;
            return Math.Round(pi, digitsToCompute);

        }

        public decimal ApproximateE(int digitsToCompute)
        {
            //eFinal accumulates value to return while e acts as the multiplier
            decimal e = (decimal)1 + (decimal)1/(decimal)1000000;
            decimal eFinal = e;

            for (int i = 0; i < 1000000; i++){
                eFinal = eFinal * e;
            }

            return Math.Round(eFinal, digitsToCompute);
        }

        public List<int> GenerateFibonacciSequence(int numToGenerate)
        {
            //0 or negative input is considered invalid
            if (numToGenerate <= 0)
            {
                return null;
            }

            //n represents n, n1 represents (n-1), n2 represents (n-2)
            //Both n1 and n2 are initialized to base cases
            int n;
            int n1 = 1;
            int n2 = 1;
            List<int> fibSequence = new List<int>();

            //Base case: return fibSequence with 1 if numToGenerate is 1
            fibSequence.Add(n1);

            if (numToGenerate == 1)
            {
                return fibSequence;
            }

            //Base case: return fibSequence with 1,1 if numToGenerate is 2
            fibSequence.Add(n2);

            if (numToGenerate == 2)
            {
                return fibSequence;
            }

            for (int i = 0; i < numToGenerate - 2; i++)
            {

                n = n1 + n2;
                n2 = n1;
                n1 = n;

                fibSequence.Add(n);
            }

            return fibSequence;

        }

        public List<int> GeneratePrimeFactorization(int input)
        {
            if (input <= 0)
            {
                return null;
            }

            List<int> primeFactors = new List<int>();

            if (input <= 2)
            {
                primeFactors.Add(input);
                return primeFactors;
            }

            for (int i = 2; i < input; i++)
            {
                if (!IsPrimeNumber(i))
                {
                    continue;
                }

                if (input % i == 0)
                {
                    primeFactors.Add(i);
                    input = input / i;
                    primeFactors.AddRange(GeneratePrimeFactorization(input));
                    break;
                }
            }

            if (!primeFactors.Any())
            {
                primeFactors.Add(input);
            }

            return primeFactors;
        }

        public int FetchNextPrimeNumber(int input)
        {
            if (input <= 1)
            {
                return 2;
            }

            int nextPrime = input + 1;
            bool cont = true;

            while (cont)
            {
                if (IsPrimeNumber(nextPrime))
                {
                    break;
                }
                else
                {
                    nextPrime++;
                }
            }

            return nextPrime;
        }

        public decimal CalculateTileCost(float w, float h, decimal costPerUnit)
        {
            if (w <= 0 || h <= 0)
            {
                throw new System.ArgumentException("Width and height parameters must be greater than zero");
            }

            float area = w * h;
            decimal totalCost = Math.Round((decimal)area * costPerUnit, 2);
            return totalCost;
        }

        #region helpers
        private bool IsPrimeNumber(int input)
        {
            if (input <= 1)
            {
                return false;
            }

            if (input == 2)
            {
                return true;
            }

            bool isPrime = true;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }


        #endregion

    }
}
