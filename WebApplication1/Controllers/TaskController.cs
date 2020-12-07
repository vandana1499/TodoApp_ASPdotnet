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
       
        private TaskOperation taskOpObj;
        public TaskController()
        {
            taskOpObj = new TaskOperation();
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
        public string postTask([FromBody] String tasks)
        {
            
            taskOpObj.AddTask(tasks);
            return "Successfully created the task";
        }

        //put delete yet to be added


    }
}
