using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_6.Model
{
    enum PriorityType
    {
        Critical,
        Important,
        Normal,
        Low
    }
    class Priority
    {

        private PriorityType priority;

        public Priority (PriorityType priority)
        {
            this.priority = priority;
        }





        public PriorityType getPriorityType()
        {
            return priority;
        }
    }
}
