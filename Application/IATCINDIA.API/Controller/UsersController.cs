using IATCINDIA.APPLICATION.DomainModels;
using IATCINDIA.DATA.Repository;
using IATCINDIA.DOMAIN.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace IATCINDIA.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : MyMDBController<IatcMUser, IatcUserRepository>
    {
        public UsersController(IatcUserRepository repository) : base(repository)
        {
        }

        [HttpGet("GetValueFromSp")]
        public string GetValueFromSp()
        {

            DataSet ds = new DataSet();
            GetSpRepository getSp = new GetSpRepository( );
            ds = getSp.GetTs();
            return "stored-procedure Executed";


        }
    }
}
