using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Tasks
    {
        public Tasks()
        {
            TaskList = new List<string>();
        }
        public static int counter=0;
        public List<String> TaskList { get; set; }
        public int id { get; set; }
    }

}
