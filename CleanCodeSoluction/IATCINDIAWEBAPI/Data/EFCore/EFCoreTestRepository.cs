using IATCINDIAWEBAPI.Data.EFCore;
using IATCINDIAWEBAPI.Models;

namespace IATCINDIAWEBAPI.Controllers
{
    public class EFCoreTestRepository : EFCoreRepository<TestSp, IatcindiaContext>
    {
        public EFCoreTestRepository(IatcindiaContext context) : base(context)
        { }
    }
}