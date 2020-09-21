using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using System.Windows.Forms;
using System.Data;

namespace TimeTableManagement.Controller.LocationConn
{
    class roomsConn
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public roomsConn()
        {
            con = DBConnection.getDBConnection();
        }
    }
}
