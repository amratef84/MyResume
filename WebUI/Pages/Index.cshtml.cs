using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUnitOfWork<Profile> _context;
        private readonly IRepository<Profile> _dbSet;
        public IndexModel(ILogger<IndexModel> logger, IUnitOfWork<Profile> context)
        {   _context = context;
            _dbSet = context.Entity;
            _logger = logger;
           
        }

        public void OnGet()
        {

        }
        public  Profile GetProfile()
        {
            var data =  _dbSet.GetAll().Result;
            var profile = data.LastOrDefault();
           // profile.Address = _dbSet.GetById(profile.AddressId).Result;
            return profile;
        }
    }
}