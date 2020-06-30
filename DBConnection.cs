using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReviewSystem
{
    class DBConnection
    {
        public SqlConnection dbConnection() {
       string connectionString = "Data Source=DESKTOP-4K3TGBB;Database=MoviewReview;Integrated Security=true";
        SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
    }
       
    }
}
