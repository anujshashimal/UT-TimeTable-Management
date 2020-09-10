using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeTableModel
{
    class NumberOfWorkingDaysModel
    {
        private int id;
        private int weekdayDays;
        private int weekendDays;

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

        public int WeekdayDays
        {
            get
            {
                return weekdayDays;
            }

            set
            {
                weekdayDays = value;
            }
        }

        public int WeekendDays
        {
            get
            {
                return weekendDays;
            }

            set
            {
                weekendDays = value;
            }
        }

    }
}
