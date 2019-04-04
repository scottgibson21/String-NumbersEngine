using MortgageCalculator.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public class MortgageCalculationRequest
    {
        //Interest charged per payment, i.e. yearly interested/ payments per year
        public decimal CadenceInterest { get; set; }
        public int TotalCadencePayments { get; set; }
        public decimal Principal { get; set; }
        public int Term { get; set; }
        public decimal Interest { get; set; }
        public EPaymentCadence PaymentCadence { get; set; }

        


    }
}
