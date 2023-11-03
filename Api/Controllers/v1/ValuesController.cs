using WebFramework.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Api.Controllers.v1
{
    [ApiVersion("1")]
    public class ValuesController : BaseController
    {
        [HttpPost]
        public string get()
        {
            return "fgfgfg";
        }
    }
}
