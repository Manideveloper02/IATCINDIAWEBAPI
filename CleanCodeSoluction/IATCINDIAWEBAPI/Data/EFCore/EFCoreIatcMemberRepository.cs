using IATCINDIAWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IATCINDIAWEBAPI.Data.EFCore
{
    public class EFCoreIatcMemberRepository : EFCoreRepository<IatcindiaMMemberdetails, IatcindiaContext>
    {
        public EFCoreIatcMemberRepository(IatcindiaContext context) : base(context)
        { }
    }
}
