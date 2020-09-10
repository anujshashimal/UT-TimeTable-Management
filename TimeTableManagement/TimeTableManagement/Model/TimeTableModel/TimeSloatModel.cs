using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeTableModel
{
    class TimeSloatModel
    {
        private int id;
        private String type;
        private float startTime;
        private float endTime;

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

        public float StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public float EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }

    }
}
