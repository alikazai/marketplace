using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domain
{
    public class Price : Money
    {
        public Price(decimal amount) : base(amount)
        {
            if(amount < 0)
                throw new ArgumentException(nameof(amount), "Price cannot be negative");
        }
    }
}
