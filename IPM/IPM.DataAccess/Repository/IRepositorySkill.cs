using IPM.DataEntities.Models;
using System.Collections.Generic;

namespace IPM.DataAccess.Repository
{
    public interface IRepositorySkill : IRepository<Skills>
    {
        IEnumerable<Skills> GetAllSkill();
    }
}