using IPM.Business.Helper;
using IPM.DataEntities.Models;
using IPM.Service.ServiceSkill;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPM.Web.Controllers.ApiController
{
    [Route("api/[controller]/[action]")]
    public class SkillController : Controller
    {
        private IServiceSkill _serviceSkill;

        public SkillController(IServiceSkill serviceSkill)
        {
            _serviceSkill = serviceSkill;
        }

        // GET: api/values
        [HttpGet]
        public JsonResult GetListPageSkill(int pageNumber, int pageSize, string keySearch)
        {
            var data = new Data<Skills>();
            data.ListData = _serviceSkill.GetListPageSkill(pageNumber, pageSize, keySearch);
            if (data.ListData != null)
            {
                data.Content = "Load dữ liệu thành công";
                data.Alert = "Success";
                data.Status = true;
            }
            else
            {
                data.Content = "Load dữ liệu thất bại";
                data.Alert = "Error";
                data.Status = false;
            }
            return Json(data);
        }

        // GET api/values/5
        [HttpGet]
        public JsonResult GetOneSkill(int id)
        {
            var skill = _serviceSkill.GetOneSkill(id);
            return Json(skill);
        }

        // POST api/values
        [HttpPost]
        public JsonResult InsertSkill([FromBody]Skills value)
        {
            bool checkInsert = _serviceSkill.InsertSkill(value);
            var message = new Message();
            if (checkInsert)
            {
                message.Content = "Add information of skill success";
                message.Alert = "Success";
                message.Status = true;
            }
            else
            {
                message.Content = "Add information of skill fail";
                message.Alert = "Error";
                message.Status = false;
            }

            return Json(message);
        }

        // PUT api/values/5
        [HttpPut]
        public JsonResult UpdateSkill([FromBody]Skills value)
        {
            bool checkDelete = _serviceSkill.UpdateSkill(value);
            var message = new Message();
            if (checkDelete)
            {
                message.Content = "Update information of skill success";
                message.Alert = "Success";
                message.Status = true;
            }
            else
            {
                message.Content = "Update information of skill fail";
                message.Alert = "Error";
                message.Status = false;
            }
            return Json(message);
        }

        // DELETE api/values/5
        [HttpDelete]
        public JsonResult DeleteSkill(int id)
        {
            bool checkDelete = _serviceSkill.DeleteSkill(id);
            var message = new Message();
            if (checkDelete)
            {
                message.Content = "Delete information of skill success";
                message.Alert = "Success";
                message.Status = true;
            }
            else
            {
                message.Content = "Delete information of skill fail";
                message.Alert = "Error";
                message.Status = false;
            }
            return Json(message);
        }
    }
}