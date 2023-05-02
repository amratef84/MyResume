using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class ProfileController : BaseController<Profile>
    {
        public ProfileController(IUnitOfWork<Profile> context) : base(context)
        {
        }

    }
    
}
