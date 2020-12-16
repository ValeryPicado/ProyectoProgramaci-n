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
    public class CarritoController : Controller
    {
        private readonly SolutionDBContext _context;

        public CarritoController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Pais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Carrito>>> GetCarrito()
        {
            return new Solution.BS.Carrito(_context).GetAll().ToList();
        }

        // GET: api/Pais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Carrito>> GetCarrito(int id)
        {
            var carrito = new Solution.BS.Carrito(_context).GetOneById(id);

            if (carrito == null)
            {
                return NotFound();
            }

            return carrito;
        }

        // PUT: api/Paises/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrito(int id, data.Carrito carrito)
        {
            if (id != carrito.IdCarrito)
            {
                return BadRequest();
            }

            try
            {
                new Solution.BS.Carrito(_context).Update(carrito);
            }
            catch (Exception)
            {
                if (!CarritoExists(id))
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
        public async Task<ActionResult<data.Carrito>> PostCarrito(data.Carrito carrito)
        {
            new Solution.BS.Carrito(_context).Insert(carrito);

            return CreatedAtAction("GetCarrito", new { id = carrito.IdCarrito }, carrito);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Carrito>> DeleteCarrito(int id)
        {
            var carrito = new Solution.BS.Carrito(_context).GetOneById(id);
            if (carrito == null)
            {
                return NotFound();
            }

            new Solution.BS.Carrito(_context).Delete(carrito);

            return carrito;
        }

        private bool CarritoExists(int id)
        {
            return (new Solution.BS.Carrito(_context).GetOneById(id) != null);
        }
    }
}
