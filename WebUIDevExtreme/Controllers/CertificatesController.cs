using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class CertificatesController : BaseController<Certificates>
    {
        public CertificatesController(IUnitOfWork<Certificates> context) : base(context)
        {
        }

    }
}
