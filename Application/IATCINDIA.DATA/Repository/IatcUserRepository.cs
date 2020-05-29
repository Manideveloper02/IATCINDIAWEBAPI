using IATCINDIA.APPLICATION.DomainModels;

namespace IATCINDIA.DATA.Repository
{
    public class IatcUserRepository : EFCoreRepository<IatcMUser, IatcindiaContext>
    {
        public IatcUserRepository(IatcindiaContext context) : base(context)
        {

        }
    }
}
