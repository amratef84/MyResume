using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class ExperienceController : BaseController<Experience>
    {
        public ExperienceController(IUnitOfWork<Experience> context) : base(context)
        {
        }
    }
}
