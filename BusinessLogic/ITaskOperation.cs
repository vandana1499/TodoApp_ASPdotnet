using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace BusinessLogic
{
    interface ITaskOperation
    {
        void AddTask(Tasks obj);
        void ShowTask(Tasks obj);
        void DeleteTask(Tasks obj);
        void EditTask(Tasks obj);
    }
}
