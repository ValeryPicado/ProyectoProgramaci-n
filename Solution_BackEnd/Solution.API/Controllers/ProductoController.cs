using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.DAL.EF;
using data = Solution.DO.Objects;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly SolutionDBContext _context;

        public ProductoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Pais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Producto>>> GetProducto()
        {
            return new Solution.BS.Producto(_context).GetAll().ToList();
        }

        // GET: api/Pais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Producto>> GetProducto(int id)
        {
            var producto = new Solution.BS.Producto(_context).GetOneById(id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        // PUT: api/Paises/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, data.Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            try
            {
                new Solution.BS.Producto(_context).Update(producto);
            }
            catch (Exception)
            {
                if (!ProductoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Paises
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Producto>> PostProducto(data.Producto producto)
        {
            new Solution.BS.Producto(_context).Insert(producto);

            return CreatedAtAction("GetProducto", new { id = producto.Id }, producto);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Producto>> DeleteProducto(int id)
        {
            var producto = new Solution.BS.Producto(_context).GetOneById(id);
            if (producto == null)
            {
                return NotFound();
            }

            new Solution.BS.Producto(_context).Delete(producto);

            return producto;
        }

        private bool ProductoExists(int id)
        {
            return (new Solution.BS.Producto(_context).GetOneById(id) != null);
        }
    }
}
