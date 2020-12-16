using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Producto : ICRUD<data.Producto>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Producto(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Producto t)
        {
            new Solution.DAL.Producto(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Producto> GetAll()
        {
            return new Solution.DAL.Producto(_solutionDBContext).GetAll();
        }

        public data.Producto GetOneById(int id)
        {
            return new Solution.DAL.Producto(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Producto t)
        {
            t.Id = null;
            new Solution.DAL.Producto(_solutionDBContext).Insert(t);
        }

        public void Update(data.Producto t)
        {
            new Solution.DAL.Producto(_solutionDBContext).Update(t);
        }
    }
}
