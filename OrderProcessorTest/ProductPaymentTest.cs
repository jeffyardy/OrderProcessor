﻿using Interfaces;
using NUnit.Framework;
using Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessorTest
{
    [TestFixture]
    public class ProductPaymentTest
    {

        string outputValue;
        string expectedResult = "Success";
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void PaymentPositiveTest()
        {
            //Act


            List<string> paymentReason = new List<string>
            {
                "PaymentofProduct"//,
                //"PaymentofBook",
                //"PaymentofMembership",
                //"UpgradetoMembershp",
                //"MembershiporUpgrade",
                //"LearningtoSki",
                //"PhysicalProductorBook"
            };

            outputValue = OrderProcessor.Program.PaymentDetails(paymentReason[0]);

            //Assert
            Assert.AreEqual(outputValue, expectedResult);
        }


        [Test]
        public void PaymentNegativeTest()
        {
            //Act
            List<string> paymentReason = new List<string>
            {
                "PaymentofProductNewValue"//,
                //"PaymentofBook",
                //"PaymentofMembership",
                //"UpgradetoMembershp",
                //"MembershiporUpgrade",
                //"LearningtoSki",
                //"PhysicalProductorBook"
            };

            outputValue = OrderProcessor.Program.PaymentDetails(paymentReason[0]);

            //Assert
            Assert.AreNotEqual(outputValue, expectedResult);
        }

    }
}
