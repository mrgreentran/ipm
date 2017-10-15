using IPM.DataAccess.DataReader;
using IPM.DataEntities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace IPM.DataAccess.Repository
{
    public class RepositorySkill : IRepositorySkill
    {
        public IEnumerable<Skills> GetAllSkill()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skills> GetListPage(int pageNumber, int pageSize, string keySearch)
        {
            using (IPMContext db = new IPMContext())
            {
                db.Database.OpenConnection();
                DbCommand cmd = db.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = "Skill_SELECT_PAGE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PageNumber", SqlDbType.Int) { Value = pageNumber });
                cmd.Parameters.Add(new SqlParameter("@PageSize", SqlDbType.Int) { Value = pageSize });
                cmd.Parameters.Add(new SqlParameter("@KeySearch", SqlDbType.NVarChar) { Value = !string.IsNullOrEmpty(keySearch) ? keySearch : (object)DBNull.Value });
                IEnumerable<Skills> listSkill;
                using (var reader = cmd.ExecuteReader())
                {
                    listSkill = reader.MapToList<Skills>();
                }
                return listSkill;
            }
        }     

        public bool Insert(Skills item)
        {
            try
            {
                using (IPMContext db = new IPMContext())
                {
                    db.Database.OpenConnection();
                    DbCommand cmd = db.Database.GetDbConnection().CreateCommand();
                    cmd.CommandText = "Skill_INSERT";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = item.Name });
                    cmd.Parameters.Add(new SqlParameter("@Active", SqlDbType.Bit) { Value = item.Active });
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Skills GetOne(int id)
        {
            Skills skill = new Skills();
            try
            {
                using (IPMContext db = new IPMContext())
                {
                    db.Database.OpenConnection();
                    DbCommand cmd = db.Database.GetDbConnection().CreateCommand();
                    cmd.CommandText = "Skill_GET_ONE";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });                 
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {                          
                            skill.Id = reader.GetInt32(0);
                            skill.Name = reader.GetString(1);
                            skill.Active = reader.GetBoolean(2);
                        }
                    }
                    return skill;
                }
            }
            catch (Exception ex)
            {
                return skill;
            }
        }
        public bool Update(Skills item)
        {
            try
            {
                using (IPMContext db = new IPMContext())
                {
                    db.Database.OpenConnection();
                    DbCommand cmd = db.Database.GetDbConnection().CreateCommand();
                    cmd.CommandText = "Skill_UPDATE";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = item.Id });
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = item.Name });
                    cmd.Parameters.Add(new SqlParameter("@Active", SqlDbType.Bit) { Value = item.Active });
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (IPMContext db = new IPMContext())
                {
                    db.Database.OpenConnection();
                    DbCommand cmd = db.Database.GetDbConnection().CreateCommand();
                    cmd.CommandText = "Skill_DELETE";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar) { Value = id });                 
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}