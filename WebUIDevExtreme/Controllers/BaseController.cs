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
        public virtual async Task<IActionResult> Update(Guid id, TEntity entity)
        {
            //if (id != entity.)
            //{
            //    return BadRequest();
            //}
            //_context.Entry(entity).State = EntityState.Modified;
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!_dbSet.Any(e => e.Id == id))
            //    {
            //        return NotFound();
            //    }
            //    throw;
            //}
            return NoContent();
        }

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
