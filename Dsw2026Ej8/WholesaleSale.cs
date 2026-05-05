using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal subtotal) : base(subtotal)
        {
        }

        public override decimal CalculateTotal()
        {
            return Subtotal * 0.90m;
        }
    }
}
