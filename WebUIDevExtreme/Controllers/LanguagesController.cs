using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class LanguagesController : BaseController<Languages>
    {
        public LanguagesController(IUnitOfWork<Languages> context) : base(context)
        {
        }
    }
}
