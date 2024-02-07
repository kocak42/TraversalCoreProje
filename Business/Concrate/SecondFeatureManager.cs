using Business.Abstract;
using Core.Utilities.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class SecondFeatureManager: ISecondFeatureService
    {
        ISecondFeatureDal _SecondFeatureDal;

        public SecondFeatureManager(ISecondFeatureDal SecondFeatureDal)
        {
            _SecondFeatureDal = SecondFeatureDal;
        }

        public void TAdd(SecondFeature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SecondFeature t)
        {
            throw new NotImplementedException();
        }

        public SecondFeature TGetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<SecondFeature> TGetList()
        {
            return _SecondFeatureDal.GetList();
        }

        public void TUpdate(SecondFeature t)
        {
            throw new NotImplementedException();
        }
    }
}
