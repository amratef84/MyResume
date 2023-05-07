using Core.Entities;
using Core.InterFace;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class AddressesController : BaseController<Address>
    {
        private readonly IUnitOfWork<Address> context;

        public AddressesController(IUnitOfWork<Address> context) : base(context)
        {
            this.context = context;
        }
        [HttpGet("action")]
        public virtual async Task<IActionResult> Lookup(DataSourceLoadOptionsBase loadOptions)
        {
            var data = await context.Entity.GetAll();
            var value = data.Select(x => new { Id = x.Id, Name = x.City + " " + x.Country +""+x.Street });
            return Ok(DataSourceLoader.Load(value, loadOptions));
        }
    }
}
