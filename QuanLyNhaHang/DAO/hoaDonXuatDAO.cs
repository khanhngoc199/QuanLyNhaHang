using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class hoaDonXuatDAO
    {
        private static hoaDonXuatDAO instance;

        public static hoaDonXuatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new hoaDonXuatDAO();

                return hoaDonXuatDAO.instance;
            }

            private set
            {
                hoaDonXuatDAO.instance = value;
            }
        }
        private hoaDonXuatDAO() { }
        public int getidhdbyidban(int idban)
        {
            List<hoaDonXuatDTO> list = new List<hoaDonXuatDTO>();
            DataTable db;
            db = Database.Instrance.ExecuteQuery("EXEC USP_getmaHDByIdBan @maban ", new object[] { idban });
            if (db.Rows.Count > 0)
            {
                hoaDonXuatDTO hd = new hoaDonXuatDTO(db.Rows[0]);
                return hd.MaHD;
            }
            return -1;
        }
        public bool thanhtoan(int maban)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_thanhToan @maban ", new object[] { maban });
            return n > 0;
        }
    }
}
