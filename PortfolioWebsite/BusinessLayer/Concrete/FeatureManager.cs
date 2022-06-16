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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public void TAdd(Feature parameter)
        {
            _featureDAL.Insert(parameter);
        }

        public void TDelete(Feature parameter)
        {
            _featureDAL.Delete(parameter);
        }

        public Feature TGetById(int id)
        {
            return _featureDAL.getById(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDAL.getList();
        }

        public void TUpdate(Feature parameter)
        {
            _featureDAL.Update(parameter);
        }
    }
}
