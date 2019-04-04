using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public class MortgageCalculationResult
    {

        public decimal PaymentTotal { get; set; }
        public List<decimal> InterestPayments { get; set; }
        public List<decimal> PrincipalPayments { get; set; }
        public List<decimal> RemainingBalance { get; set; }

        public MortgageCalculationResult()
        {
            InterestPayments = new List<decimal>();
            PrincipalPayments = new List<decimal>();
            RemainingBalance = new List<decimal>();
        }

    }
}
