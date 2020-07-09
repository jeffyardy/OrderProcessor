using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductUnion
{
    // Concrete Product
    public class PhysicalProductService : IGeneratePackingSlip
    {
        public PhysicalProductService()
        {
            Console.WriteLine("Generate Packing slip.");
        }

    }


    public class BookService : IGenerateDuplicatePackingSlipforRoyalityDep
    {
        public BookService()
        {
            Console.WriteLine("Create a duplicate packing slip for the royality department");
        }
    }


    public class MembershipService : IActivateMembership
    {
        public MembershipService()
        {
            Console.WriteLine("Active the Membership");
        }
    }

    public class UpgradeToaMembershipService: IUpgrade
    {
        public UpgradeToaMembershipService()
        {
            Console.WriteLine("Upgrade the Membership");
        }
    }


    public class UpgradeOrMembershipService: IEmailTheOwnerInformActivation
    {
        public UpgradeOrMembershipService()
        {
            Console.WriteLine("Email the owner and inform them of the activation or upgration");
        }
        
    }

    public class VideoLearningToSkiService: IFreeFirstAidVideoToPackingSlip
    {
        public VideoLearningToSkiService()
        {
            Console.WriteLine("Add a free first add Video to the packin slip");
        }
    }


    public class MembershipOrUpgradeService: IGenerateCommissionPayment
    {
        public MembershipOrUpgradeService()
        {
            Console.WriteLine("Generate the commission payment to the Agent");
        }
    }



    //concrete Factory
    public class ProductUnionFactory : ProductBaseUnionFactory
    {
        public override IActivateMembership ActivateMembership()
        {
            MembershipService membershipService = new MembershipService();
            return membershipService;
        }

        public override IEmailTheOwnerInformActivation EmailTheOwnerInformActivation()
        {
            UpgradeOrMembershipService membershipService = new UpgradeOrMembershipService();
            return membershipService;
        }

        public override IFreeFirstAidVideoToPackingSlip FreeFirstAidVideoToPackingSlip()
        {
            VideoLearningToSkiService videoLearningToSkiService = new VideoLearningToSkiService();
            return videoLearningToSkiService;
        }

        public override IGenerateCommissionPayment GenerateCommissionPayment()
        {
            MembershipOrUpgradeService membershipOrUpgradeService = new MembershipOrUpgradeService();
            return membershipOrUpgradeService;
        }

        public override IGenerateDuplicatePackingSlipforRoyalityDep GenerateDuplicatePackingSlipforRoyalityDep()
        {
            BookService bookService = new BookService();
            return bookService;
        }

        public override IGeneratePackingSlip GeneratePackingSlip()
        {
            PhysicalProductService physicalProductService = new PhysicalProductService();
            return physicalProductService;
        }

        public override IUpgrade Upgrade()
        {
            UpgradeToaMembershipService membershipService = new UpgradeToaMembershipService();
            return membershipService;
        }
    }



}
