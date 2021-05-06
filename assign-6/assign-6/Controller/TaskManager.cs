using assign_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_6
{
    class TaskManager
    {
        DateTimeTask dateAndTime;
        Description description;
        Priority priority;

        public TaskManager(DateTime dateAndTime, PriorityType priority, string description) // constructor
        {
            this.dateAndTime = new DateTimeTask(dateAndTime);
            this.priority = new Priority(priority);
            this.description = new  Description( description);
        }

        public string getDescription()
        {
            return description.getDescription();
        }

        public string getDate()
        {
            
            return dateAndTime.getDate();
        }

        public string getTime()
        {
            return dateAndTime.getTime();
        }

        public DateTime getDateTime()
        {
            return dateAndTime.getDateTime();
        }

        public PriorityType getPriorityType()
        {
            return priority.getPriorityType();
        }



    }
}
