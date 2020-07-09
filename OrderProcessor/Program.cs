using Interfaces;
using Providers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace OrderProcessor
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<string> paymentValue = new List<string>
            {
                "PaymentofProduct"//,
                //"PaymentofBook"
                //"PaymentofMembership",
                //"UpgradetoMembershp",
                //"MembershiporUpgrade",
                //"LearningtoSki",
                //"PhysicalProductorBook"
            };
            for (int i = 0; i < paymentValue.Count; i++)
            {
                PaymentDetails(paymentValue[i]);
            }
        }

        public static string PaymentDetails(string paymentReason)
        {
            
                ProductBaseUnionFactory abstractFactory = ProductUnionFactoryProvider.ProductBaseUnionFactory(paymentReason);
                if (abstractFactory == null)
                {
                    Console.WriteLine("Sorry. This payment details ' {0} ' is not valid. ", (paymentReason));
                }
                else
                {
                if (paymentReason == "PaymentofProduct")
                {
                    abstractFactory.GeneratePackingSlip();
                    return "Success";
                }
                else
                if (paymentReason == "PaymentofBook")
                {
                    abstractFactory.GenerateDuplicatePackingSlipforRoyalityDep();
                    return "Success";
                }
                else
                if (paymentReason == "PaymentofMembership")
                {
                    abstractFactory.Upgrade();
                    return "Success";
                }
                else
                if (paymentReason == "UpgradetoMembershp")
                {
                    abstractFactory.ActivateMembership();
                    return "Success";
                }
                else
                if (paymentReason == "MembershiporUpgrade")
                {
                    abstractFactory.EmailTheOwnerInformActivation();
                    return "Success";
                }
                else
                if (paymentReason == "LearningtoSki")
                {
                    abstractFactory.FreeFirstAidVideoToPackingSlip();
                    return "Success";
                }
                else
                if (paymentReason == "PhysicalProductorBook")
                {
                    abstractFactory.GenerateCommissionPayment();
                    return "Success";
                }
                else
                {
                    return "Not Success";
                }
              }
            Console.ReadLine();
            return "Success";
            
        }
       
    }
}
