using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController(IAccountRepository repository) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> ListAllAccounts()
        {
            return Ok(new { Success = true, Data = await repository.ListAllAccounts() });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> FindAccount(string id)
        {
            return Ok(new { Success = true, Data = await repository.GetAccount(id) });
        }

        [HttpPost]
        public async Task<ActionResult> CreateAccount(Account account)
        {
            var response = await repository.CreateAccount(account);
            if (response is null) return StatusCode(500);

            return CreatedAtAction(nameof(FindAccount), new { id = response }, account);
        }
    }


}
