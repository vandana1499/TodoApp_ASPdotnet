using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Threading.Tasks;
using BusinessLogic;


namespace WebApplication1.Controllers
{
    
    [ApiController]
    [Route("[controller]")]

    public class TaskController : Controller
    {
       
        private ITaskOperation taskOpObj;
        public TaskController(ITaskOperation itskop)
        {
            //taskOpObj = new TaskOperation();
            taskOpObj = itskop;
        }
       

        [HttpGet]
        public string get()
        {
            return "Welcome to Todo Application";
        }
        [HttpGet]
        [Route("getAllTask")]
        public List<Tasks> getAllTask()
        {

            return taskOpObj.showAllTask();
        }

        [HttpGet]
        [Route("getTask/{id?}")]
        public List<String> getTask(int? id)
        {
            
           return taskOpObj.ShowTaskByID(id);
        }

        [HttpPost]
        [Route("postTask")]
        public string postTask([FromBody] Tasks obj)
        {
            
            taskOpObj.AddTask(obj.TaskList,obj.Name,obj.Email,obj.FavouriteThingYouLike);
            return "Successfully created the task";
        }

        //put delete yet to be added


    }
}
