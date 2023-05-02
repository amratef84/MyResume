using Core.InterFace;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace WebUIDevExtreme.Controllers
{
    //[ApiController]
    // [Route("[controller]")]
    [Route("api/[controller]/[action]")]
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
             var data =  await _dbSet.GetAll();
            //loadOptions.
            // load
           return Ok(DataSourceLoader.Load(data, loadOptions));
           // return Ok(data);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(Guid id)
        {
            var entity = await _dbSet.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Insert(TEntity entity)
        {
            //TEntity entity1;
            //entity1.GetType().TypeHandle.
           // JsonConvert.PopulateObject(entity, TEntity);
            await _dbSet.Add(entity);
             _context.Save();
            return Ok(entity);
            //return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
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
