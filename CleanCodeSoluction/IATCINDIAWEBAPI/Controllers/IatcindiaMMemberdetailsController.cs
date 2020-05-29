using IATCINDIAWEBAPI.Data.EFCore;
using IATCINDIAWEBAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IATCINDIAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IatcindiaMMemberdetailsController : MyDBController<IatcindiaMMemberdetails, EFCoreIatcMemberRepository>
    {

        public IatcindiaMMemberdetailsController(EFCoreIatcMemberRepository repository):base(repository)
        {
        }

        
    }
}
