using IPM.DataEntities.Models;
using System.Collections.Generic;

namespace IPM.Business.BusinessSkill
{
    public interface IBusinessSkill
    {
        IEnumerable<Skills> GetListPageSkill(int pageNumber, int pageSize, string keySearch);

        IEnumerable<Skills> GetListAllSkill();
        bool InsertSkill(Skills item);
        Skills GetOneSkill(int id);
        bool DeleteSkill(int id);
        bool UpdateSkill(Skills item);
        
    }
}