using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class JobManager : IGenericService<Job>  
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public Job TGetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public List<Job> TGetList()
        {
            return _jobDal.GetList();
        }

        public void TInsert(Job t)
        {
            _jobDal.Insert(t);
        }

        public void TRemove(Job t)
        {
            _jobDal.Delete(t);
        }

        public void TUpdate(Job t)
        {
            _jobDal.Update(t);
        }
    }
}
