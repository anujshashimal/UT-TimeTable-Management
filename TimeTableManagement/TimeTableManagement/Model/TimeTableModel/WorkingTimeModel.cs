using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeTableModel
{
    class WorkingTimeModel
    {
        private int id;
        private String day;
        private float workingTime;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public String Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public float WorkingTime
        {
            get
            {
                return workingTime;
            }

            set
            {
                workingTime = value;
            }
        }
    }
}
