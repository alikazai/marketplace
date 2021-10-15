using Marketplace.Framework;
using System;

namespace Marketplace.Domain
{
    public class Money  : Value<Money>
    {
        public decimal Amount { get; }
        
        protected Money(decimal amount)
        {
            if(decimal.Round(amount, 2) != amount)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot have more than two decimals");

            Amount = amount;
        }

        //public Money(decimal amount) => Amount = amount;

        public Money Add(Money summand) => new Money(Amount + summand.Amount);

        public Money Subtract(Money subtrahend) => new Money(Amount - subtrahend.Amount);

        public static Money operator +(Money summand1, Money summand2) => summand1.Add(summand2);

        public static Money operator -(Money minuend, Money subtrahend) => minuend.Subtract(subtrahend);

        public static Money FromDecimal(decimal amount) => new Money(amount);
        public static Money FromString(string amount) => new Money(decimal.Parse(amount));

    }
}
