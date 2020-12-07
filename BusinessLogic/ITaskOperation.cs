using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace BusinessLogic
{
    interface ITaskOperation
    {
        void AddTask(string task);
        List<string> ShowTaskByID(int? id);

        List<Tasks> showAllTask();
        void DeleteTask(Tasks obj);
        void EditTask(Tasks obj);
        
    }
}
