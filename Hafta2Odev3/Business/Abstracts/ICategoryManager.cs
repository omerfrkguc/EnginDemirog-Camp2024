using Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        List<ICategoryManager> GetAll();
        void Add(Category category);
        void Delete(Category category);

        void Update(Category category);
    }
}
