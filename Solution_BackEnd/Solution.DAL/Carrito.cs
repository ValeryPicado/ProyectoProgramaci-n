using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;


namespace Solution.DAL
{
    public class Carrito : ICRUD<data.Carrito>
    {
        private Repository<data.Carrito> _repository = null;
        public Carrito(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Carrito>(solutionDBContext);
        }
        public void Delete(data.Carrito t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Carrito> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Carrito GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Carrito t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Carrito t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
