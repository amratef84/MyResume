using Core.Entities;
using Core.InterFace;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class ProfileController : BaseController<Profile>
    {
        private readonly IUnitOfWork<Profile> context;

        public ProfileController(IUnitOfWork<Profile> context) : base(context)
        {
            this.context = context;
        }

        [HttpGet("action")]
        public virtual async Task<IActionResult> Lookup(DataSourceLoadOptionsBase loadOptions)
        {
            var data = await context.Entity.GetAll();
            var value = data.Select(x => new { Id=x.Id,Name= x.FristName+" "+x.LastName });
            return Ok(DataSourceLoader.Load(value, loadOptions));
        }
    }
    
}
