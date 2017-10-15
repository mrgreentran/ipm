using IPM.DataAccess.Repository;
using IPM.DataEntities.Models;
using System;
using System.Collections.Generic;

namespace IPM.Business.BusinessSkill
{
    public class BusinessSkill : IBusinessSkill
    {
        private IRepositorySkill _repositorySkill;

        public BusinessSkill(IRepositorySkill repositorySkill)
        {
            _repositorySkill = repositorySkill;
        }

        public IEnumerable<Skills> GetListAllSkill()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skills> GetListPageSkill(int pageNumber, int pageSize, string keySearch)
        {
            return _repositorySkill.GetListPage(pageNumber, pageSize, keySearch);
        }   

        public bool InsertSkill(Skills item)
        {
            return _repositorySkill.Insert(item);
        }

        public Skills GetOneSkill(int id)
        {
            return _repositorySkill.GetOne(id);
        }

        public bool DeleteSkill(int id)
        {
            return _repositorySkill.Delete(id);
        }

        public bool UpdateSkill(Skills item)
        {
            return _repositorySkill.Update(item);
        }
    }
}