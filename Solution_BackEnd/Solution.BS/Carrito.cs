using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Carrito : ICRUD<data.Carrito>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Carrito(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Carrito t)
        {
            new Solution.DAL.Carrito(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Carrito> GetAll()
        {
            return new Solution.DAL.Carrito(_solutionDBContext).GetAll();
        }

        public data.Carrito GetOneById(int id)
        {
            return new Solution.DAL.Carrito(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Carrito t)
        {
            t.IdCarrito = null;
            new Solution.DAL.Carrito(_solutionDBContext).Insert(t);
        }

        public void Update(data.Carrito t)
        {
            new Solution.DAL.Carrito(_solutionDBContext).Update(t);
        }
    }
}
