using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TAdd(About parameter)
        {
            _aboutDAL.Insert(parameter);
        }

        public void TDelete(About parameter)
        {
            _aboutDAL.Delete(parameter);
        }

        public About TGetById(int id)
        {
            return _aboutDAL.getById(id);
        }

        public List<About> TGetList()
        {
            return _aboutDAL.getList();
        }

        public void TUpdate(About parameter)
        {
            _aboutDAL.Update(parameter);
        }
    }
}
