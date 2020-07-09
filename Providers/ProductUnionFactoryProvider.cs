using Interfaces;
using ProductUnion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Providers
{
    public class ProductUnionFactoryProvider
    {
        public static ProductBaseUnionFactory ProductBaseUnionFactory(string productValue)
        {
            if (productValue.Contains("PaymentofProduct"))
            {
                return new ProductUnionFactory();
            }
            else
            if (productValue.Contains("PaymentofBook"))
            {
                return new ProductUnionFactory();
            }
            else
            if (productValue.Contains("PaymentofMembership"))
            {
                return new ProductUnionFactory();
            }
            else
            if (productValue.Contains("UpgradetoMembershp"))
            {
                return new ProductUnionFactory();
            }
            else
            if (productValue.Contains("MembershiporUpgrade"))
            {
                return new ProductUnionFactory();
            }
            else
            if (productValue.Contains("LearningtoSki"))
            {
                return new ProductUnionFactory();
            }
            else
            if (productValue.Contains("PhysicalProductorBook"))
            {
                return new ProductUnionFactory();
            }
            else
                return null;
        }
    }
}
