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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authordal;
        Repository<Author> repoauthor = new Repository<Author>();
        //Tüm yazar listesini getirme işlemleri
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }
        //Yeni yazar ekleme işlemleri
        public void AddAuthorBL(Author p)
        {
            //Parametreden gönderilen değerlerin geçerliliğinin kontrolü
            //if (p.AuthorName =="" || p.AboutShort=="" || p.AuthorTitle =="")
            //{
            //    return -1;
            //}
            repoauthor.Insert(p);
        }
        //Yazarı ID değerine göre edit(Düzenleme) sayfasına taşıma
        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorID == id);
        }
        public void EditAuthor(Author p)
        {
            Author author = repoauthor.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorAbout = p.AuthorAbout;
            author.AboutShort = p.AboutShort;
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorTitle = p.AuthorTitle;
            author.Mail = p.Mail;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            repoauthor.Update(author);
        }

        public List<Author> GetList()
        {
            return _authordal.List();
        }

        public void AuthorAdd(Author author)
        {
            throw new NotImplementedException();
        }

        public Author GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

        public void AuthorUpdate(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
