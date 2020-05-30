using IATCINDIA.APPLICATION.DomainModels;
using IATCINDIA.DATA.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
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
        public ActionResult<IEnumerable<Department>> GetValueFromSp()
        {
            SPRepository getSp = new SPRepository();
            var dictionary = new Dictionary<string, object> { { "@Id", 1 } };
            var getDepartments = getSp.ExecuteQuery("GetDepartment", dictionary);
            string JSONString = JsonConvert.SerializeObject(getDepartments.Tables[0]);
            List<Department> bsObj = JsonConvert.DeserializeObject<List<Department>>(JSONString);
            return bsObj;


        }
    }
}
