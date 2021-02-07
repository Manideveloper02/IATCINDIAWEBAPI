using IATCINDIA.APPLICATION.CommonServices.Class;
using IATCINDIA.APPLICATION.DomainModels;
using IATCINDIA.DATA.Repository;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public ActionResult<string> GetValueFromSp()
        {
            SPRepository getSp = new SPRepository();
            var dictionary = new Dictionary<string, object> { { "@Mode", "View" } };
            var getDepartments = getSp.ExecuteQuery("sp_EventManagement_website", dictionary);
            string JSONString = CommonServices<string>.ConvertJSONString(getDepartments );
            return JSONString;


        }
    }
}
