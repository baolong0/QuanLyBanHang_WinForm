using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Quanlybanhang
{
    class Functions
    {
        public static SqlConnection Con; //Khai báo đối tượng kết nối
        public static void Connect()//Connect
        {
            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=APPLE3F59;initial catalog=Quanlybanhang; Integrated Security=True";
            Con.Open();
            if (Con.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();//Giải phóng tài nguyên
                Con = null;
            }
        }
    }
}
