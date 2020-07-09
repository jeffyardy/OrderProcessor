using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{

    public abstract class ProductBaseUnionFactory
    {
        public abstract IGeneratePackingSlip GeneratePackingSlip();
        public abstract IGenerateDuplicatePackingSlipforRoyalityDep GenerateDuplicatePackingSlipforRoyalityDep();
        public abstract IActivateMembership ActivateMembership();
        public abstract IUpgrade Upgrade();
        public abstract IEmailTheOwnerInformActivation EmailTheOwnerInformActivation();
        
        public abstract IFreeFirstAidVideoToPackingSlip FreeFirstAidVideoToPackingSlip();
        public abstract IGenerateCommissionPayment GenerateCommissionPayment();

    }
    public interface IGeneratePackingSlip { }
    public interface IGenerateDuplicatePackingSlipforRoyalityDep { }
    public interface IActivateMembership { }
    public interface IUpgrade { }
    public interface IEmailTheOwnerInformActivation { }
    
    public interface IFreeFirstAidVideoToPackingSlip { }
    public interface IGenerateCommissionPayment { }

}
