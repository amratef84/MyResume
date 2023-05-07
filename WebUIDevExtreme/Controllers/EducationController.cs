using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class EducationController : BaseController<Education>
    {
        public EducationController(IUnitOfWork<Education> context) : base(context)
        {
        }

    }
}
