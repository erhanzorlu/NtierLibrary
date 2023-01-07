using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Abstract
{
    public interface ICrudRepository<T>
    {
        public string Create(T Entity);
        public string Update(T Updated);
        public T FindId(int id);
        public string Delete(int id);

        public List<T> GetAll();

    }
}
