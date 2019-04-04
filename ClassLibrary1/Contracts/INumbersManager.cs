using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Contracts
{
    public interface INumbersManager
    {
        /// <summary>
        /// Returns an approximate decimal value of Pi calculating using the method of alternatively 
        /// adding and subtraction sequential odd fractions
        /// </summary>
        /// <param name="digitsToCompute"></param>
        /// <returns></returns>
        decimal ApproximatePiWithOddFractions(int digitsToCompute);

        /// <summary>
        /// Returns an approximate decimal value of Pi based on 355/113
        /// This is accurate to 7 digits
        /// </summary>
        /// <param name="digitsToCompute"></param>
        /// <returns></returns>
        decimal ApproximatePiWithFraction(int digitsToCompute);

        /// <summary>
        /// Returns an approximation of the value of e
        /// </summary>
        /// <param name="digitsToCompute"></param>
        /// <returns></returns>
        decimal ApproximateE(int digitsToCompute);

        /// <summary>
        /// Return a Fibonacci sequence up the Nth position
        /// </summary>
        /// <param name="numToGenerate"></param>
        /// <returns></returns>
        List<int> GenerateFibonacciSequence(int numToGenerate);

        List<int> GeneratePrimeFactorization(int input);

        int FetchNextPrimeNumber(int input);

        decimal CalculateTileCost(float w, float h, decimal cost);

        //bool IsPrimeNumber(int input);
    }
}
