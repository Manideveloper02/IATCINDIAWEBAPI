using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IATCINDIAWEBAPI.Models;
using IATCINDIAWEBAPI.Data.EFCore;

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
