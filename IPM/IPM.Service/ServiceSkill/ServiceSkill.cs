using IPM.Business.BusinessSkill;
using IPM.DataEntities.Models;
using System.Collections.Generic;

namespace IPM.Service.ServiceSkill
{
    public class ServiceSkill : IServiceSkill
    {
        private IBusinessSkill _businessSkill;

        public ServiceSkill(IBusinessSkill businessSkill)
        {
            _businessSkill = businessSkill;
        }
          

        public IEnumerable<Skills> GetListPageSkill(int pageNumber, int pageSize, string keySearch)
        {
            return _businessSkill.GetListPageSkill(pageNumber, pageSize, keySearch);
        }

        public bool InsertSkill(Skills item)
        {
            return _businessSkill.InsertSkill(item);
        }

        public Skills GetOneSkill(int id)
        {
            return _businessSkill.GetOneSkill(id);
        }

        public bool DeleteSkill(int id)
        {
            return _businessSkill.DeleteSkill(id);
        }

        public bool UpdateSkill(Skills item)
        {
            return _businessSkill.UpdateSkill(item);
        }
    }
}