using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController(IAccountService accountService) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateAccount([FromBody] CreateAccountDto model)
        {
            var result = await accountService.CreateAccount(model);
            return Ok(new { Success = true, Data = result });
        }

        [HttpGet]
        public async Task<ActionResult> ListAllAccounts()
        {
            var result = await accountService.ListAllAccounts();
            return Ok(new { Success = true, Data = result });
        }

        [HttpGet("{id}")]
        public ActionResult FindAccount(string id)
        {
            return Ok(new { Success = true, Data = "Det funkar" });
        }
    }
}
