using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace BusinessLogic
{
    public interface ITaskOperation
    {
        void AddTask(List<string> tl, string name,string email,string FavouriteThingYouLike);
        List<string> ShowTaskByID(int? id);

        List<Tasks> showAllTask();
        void DeleteTask(Tasks obj);
        void EditTask(Tasks obj);
        
    }
}
