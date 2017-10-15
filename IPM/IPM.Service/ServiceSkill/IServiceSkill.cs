using IPM.DataEntities.Models;
using System.Collections.Generic;

namespace IPM.Service.ServiceSkill
{
    public interface IServiceSkill
    {
        IEnumerable<Skills> GetListPageSkill(int pageNumber, int pageSize, string keySearch);

        bool InsertSkill(Skills item);
        Skills GetOneSkill(int id);
        bool DeleteSkill(int id);
        bool UpdateSkill(Skills item);
    }
}