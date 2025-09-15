using Microsoft.AspNetCore.Mvc;
// using Application.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateAccount()
        {
            return Ok(new { Success = true, Data = "Det funkar" });
        }

        [HttpGet]
        public ActionResult ListAllAccounts()
        {
            return Ok(new { Success = true, Data = "Det funkar" });
        }

        [HttpGet("{id}")]
        public ActionResult FindAccount(string id)
        {
            return Ok(new { Success = true, Data = "Det funkar" });
        }
    }
}
