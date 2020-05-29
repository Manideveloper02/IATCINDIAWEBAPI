using IATCINDIAWEBAPI.Data.EFCore;
using IATCINDIAWEBAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IATCINDIAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : MyDBController<TestSp, EFCoreTestRepository>
    {

        public TestController(EFCoreTestRepository repository) : base(repository)
        {
        }
    }
}