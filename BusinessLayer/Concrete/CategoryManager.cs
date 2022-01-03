using BusinessLayer.Abstract;
using DataAxcessLayer.EntityFramework;
using DataAxcessLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepostory efCategoryRepostory;
        public CategoryManager()
        {
            efCategoryRepostory = new EfCategoryRepostory();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepostory.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepostory.Delete(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepostory.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepostory.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepostory.Update(category);
        }
    }
}
