using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{ 
    enum CURRENCY{EURO, USDOLLARS, YEN};

    struct Money
    {
        public double Amount { get; set; }
        public CURRENCY Currency { get; set; }

        const double OneEuroToYen = 134.3645;
        const double OneEuroToUSD = 1.35269;

        public Money(double amount, CURRENCY currency) : this()
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public double Convert(CURRENCY toCurrency)
        {
            //First, convert currency to euro as we have the conversion rate for it
            double convertedToEuro = this.Amount;
            if (this.Currency != CURRENCY.EURO)
            {
                if (this.Currency == CURRENCY.USDOLLARS)
                {
                    convertedToEuro = Amount / OneEuroToUSD;
                }
                else if (this.Currency == CURRENCY.YEN)
                {
                    convertedToEuro = Amount / OneEuroToYen;
                }
            }

            //Now, convert that to the chosen currency

            if (toCurrency == CURRENCY.EURO)
            {
                return convertedToEuro;
            }
            else if (toCurrency == CURRENCY.USDOLLARS)
            {
                return convertedToEuro * OneEuroToUSD;
            }
            else if (toCurrency == CURRENCY.YEN)
            {
                return convertedToEuro * OneEuroToYen;
            }

            return 0.0;
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency == b.Currency)
            {
                return new Money(a.Amount + b.Amount, a.Currency);
            }
            else
            {
                return new Money(a.Amount + b.Convert(a.Currency), a.Currency);
            }

        }
    }
}
