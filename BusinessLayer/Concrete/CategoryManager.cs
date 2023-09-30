using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
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
        Repository<Category> repocategory = new Repository<Category>();
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public void CategoryStatusFalseBL(int id)
        {
            Category category = repocategory.Find(x => x.CategoryID == id);
            category.CategoryStatus = false;
            repocategory.Update(category);
        }
        public void CategoryStatusTrueBL(int id)
        {
            Category category = repocategory.Find(x => x.CategoryID == id);
            category.CategoryStatus = true;
            repocategory.Update(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
