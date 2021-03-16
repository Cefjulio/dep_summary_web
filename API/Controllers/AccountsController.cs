using System.Collections.Generic;
using System.Threading.Tasks;
using Infracstructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {

        private readonly StoreContext _context;
        
        public AccountsController(StoreContext context){
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Account>>> GetAccounts(){
            var accounts = await _context.Accounts.ToListAsync();
            return Ok(accounts);
        }

    [HttpGet("{id}")]
    public async Task<ActionResult<Account>> GetAccount(int id){
          return await _context.Accounts.FindAsync(id);
      }


    }
}