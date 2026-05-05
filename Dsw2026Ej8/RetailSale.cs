using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale : Sale
    {
        public RetailSale(decimal subtotal) : base(subtotal)
        {
        }

        public override decimal CalculateTotal()
        {
            return Subtotal;
        }
    }
}
