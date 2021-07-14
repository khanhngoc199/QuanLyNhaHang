using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class nguyenLieuDAO
    {
        private static nguyenLieuDAO instance;

        public static nguyenLieuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nguyenLieuDAO();

                return nguyenLieuDAO.instance;
            }

            private set
            {
                nguyenLieuDAO.instance = value;
            }
        }
        private nguyenLieuDAO() { }
        public DataTable getnl()
        {
            return Database.Instance.ExecuteQuery(" SELECT * FROM dbo.NGUYENLIEU ");
        }
        public bool insertnl(int maNL, string tenNL, float donGia, string donViTinh, string ten)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertNguyenLieu", new SqlParameter("@manl", maNL), new SqlParameter("@tennl", tenNL), new SqlParameter("@dongia", donGia), new SqlParameter("@donvitinh", donViTinh), new SqlParameter("@ten", ten));
            return n > 0;
        }
        public bool updatenl(int maNL, string tenNL, float donGia, string donViTinh, string ten)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_updateNLL", new SqlParameter("@manl", maNL), new SqlParameter("@tennl", tenNL), new SqlParameter("@ten", ten), new SqlParameter("@dongia", donGia), new SqlParameter("@donvitinh ", donViTinh));
            return n > 0;
        }
        public bool deletenl(int ma)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_deleteNL", new SqlParameter("@manl", ma));
            return n > 0;
        }
        public List<nguyenLieuDTO> getlistnl()
        {
            List<nguyenLieuDTO> group = new List<nguyenLieuDTO>();
            DataTable table = Database.Instance.ExecuteQuery("SELECT * FROM dbo.NGUYENLIEU");
            foreach (DataRow row in table.Rows)
            {
                nguyenLieuDTO nhom = new nguyenLieuDTO(row);
                group.Add(nhom);
            }
            return group;
        }
    }
}
