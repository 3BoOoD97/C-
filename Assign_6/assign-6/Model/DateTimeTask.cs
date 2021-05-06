using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_6.Model
{
    class DateTimeTask
    {
        private DateTime dateAndTime;

        public DateTimeTask(DateTime dateAndTime)
        {
            this.dateAndTime = dateAndTime;
        }


        public string getDate()
        {
            string date_ = dateAndTime.ToString("yyyy-MM-dd"); //Get only date
            return date_;
        }

        public string getTime()
        {
            string time = dateAndTime.ToString("HH: mm:ss"); // Get only time
            return time;
        }

        public DateTime getDateTime()
        {
            return dateAndTime;
        }
    }
}
