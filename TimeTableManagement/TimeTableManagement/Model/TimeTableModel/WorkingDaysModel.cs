using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeTableModel
{
    class WorkingDaysModel
    {
        private int id;
        private String day;
        private String type;

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

        public String Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

    }
}
