using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BusinessLogic
{
   public class TaskOperation:ITaskOperation
    {
        public static List<Tasks> AllTasks = new List<Tasks>();
        public List<string> ShowTaskByID(int? id)
        {
            Tasks obj = AllTasks.Find(x => x.id == id);
            if(obj==null)
            {
                List<string> str = new List<string>();
                str.Add("No such tasks present");
                return str;
            }
            return obj.TaskList;

        }
        public List<Tasks> showAllTask()
        {
            return AllTasks;
        }
        public void AddTask(List<string> tl,string name,string email,string FavouriteThingYouLike)
        {

            Tasks obj = new Tasks();
            obj.id = Tasks.counter++;
            obj.Name = name;
            obj.Email = email;
            obj.FavouriteThingYouLike = FavouriteThingYouLike;
            for (int i=0;i<tl.Count;i++)
            {
                obj.TaskList.Add(tl[i]);
            }
            AllTasks.Add(obj);


        }
        public void DeleteTask(Tasks taskObj)
        {
            
        }
        public void EditTask(Tasks taskObj)
        {

            
        }
    }
}
