using DataAccess.Abstacts;
using Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICatagoryDal

    {

        List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category() { categoryId = 1, categoryName="Programlama"};
            Category category2 = new Category() { categoryId = 2, categoryName = "Tümü" };

            categories = new List<Category>() { category1, category2 };

        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            categories.Add(category);
            categories.Remove(category);
        }
    }
}
