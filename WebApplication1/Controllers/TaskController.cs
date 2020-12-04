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
        [Route("getAll")]
        public string getTask()
        {
            return "Hello";
            //return id.Value.ToString();
        }

      
    }
}
