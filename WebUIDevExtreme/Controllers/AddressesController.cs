using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class AddressesController : BaseController<Address>
    {
        public AddressesController(IUnitOfWork<Address> context) : base(context)
        {
        }

    }
}
