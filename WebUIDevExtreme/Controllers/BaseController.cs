using Core.Entities;
using Core.InterFace;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebUIDevExtreme.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    [Route("api/[controller]")]
    public class BaseController<TEntity> : Controller where TEntity : class
    {
        private readonly IUnitOfWork<TEntity> _context;
        private readonly IRepository<TEntity> _dbSet;

        public BaseController(IUnitOfWork<TEntity> context)
        {
            _context = context;
            _dbSet = context.Entity;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get(DataSourceLoadOptionsBase loadOptions)
        {
            var data = await _dbSet.GetAll();
            return Ok(DataSourceLoader.Load(data, loadOptions));
        }
        //[HttpGet]
        //public virtual async Task<IActionResult> Get()
        //{
        //    var data = await _dbSet.GetAll();
        //    return Ok(data);
        //}

        [HttpGet("{Id}")]
        public virtual async Task<IActionResult> GetById(Guid Id)
        {
            var entity = await _dbSet.GetById(Id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
        [HttpPost]
        //public IActionResult Post(string entity)
        //{
        //    //var newEmployee = new Employee();
        //    //JsonConvert.PopulateObject(values, newEmployee);

        //    //if (!TryValidateModel(newEmployee))
        //    //    return BadRequest();

        //    //_data.Employees.Add(newEmployee);
        //    //_data.SaveChanges();

        //    return Ok();
        //}
        [HttpPost]
        public virtual async Task<IActionResult> Post(TEntity entity)
        {
            await _dbSet.Add(entity);
            _context.Save();
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(Guid id, string entity)
        {
            if (entity==null)
            {
                return BadRequest();
            }

            var value =await _dbSet.GetById(id);
            JsonConvert.PopulateObject(entity, value);

            _dbSet.Update(value);

            //if (!TryValidateModel(order))
            //    return BadRequest(ModelState.GetFullErrorMessage());

            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!_context..(e => e.Id == id))
            //    {
            //        return NotFound();
            //    }
            //    throw;
            //}
            return NoContent();
        }
        //[HttpGet]
        //public Task<IActionResult> Lookup(DataSourceLoadOptions loadOptions)
        //{
        //    //var lookup = from i in _nwind.Customers
        //    //             let text = i.CompanyName + " (" + i.Country + ")"
        //    //             orderby i.CompanyName
        //    //             select new
        //    //             {
        //    //                 Value = i.CustomerID,
        //    //                 Text = text
        //    //             };

        //    return DataSourceLoader.Load(_dbSet.GetAll(), loadOptions);
        //}
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _dbSet.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _dbSet.Delete(entity);
            _context.Save();
            return NoContent();
        }
    }
}
