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
    public class nhanVienDAO
    {
        private static nhanVienDAO instance;

        public static nhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhanVienDAO();

                return nhanVienDAO.instance;
            }

            private set
            {
                nhanVienDAO.instance = value;
            }
        }
        private nhanVienDAO() { }
        public DataTable getNhanvien()
        {
            return Database.Instance.ExecuteQuery("SELECT * FROM DBO.NHANVIEN");
        }
        public bool insertNhanvien(int maNV, string tenNV, string boPhan, string dienThoai, string diaChi, string gioiTinh, DateTime ngaySinh)
        {          
            int n = Database.Instance.ExecuteNonQuery("USP_insertNhanVien", new SqlParameter("@manv", maNV), new SqlParameter("@tenbp", boPhan), new SqlParameter("@ten", tenNV), new SqlParameter("@gioitinh", gioiTinh), new SqlParameter("@ngaysinh", ngaySinh), new SqlParameter("@diachi", diaChi), new SqlParameter("@dienthoai", dienThoai));
            return n > 0;
        }
        public bool updateNhanvien(int maNV, string tenNV, string boPhan, string dienThoai, string diaChi, string gioiTinh, DateTime ngaySinh)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_update", new SqlParameter("@manv", maNV), new SqlParameter("@tenbp", boPhan), new SqlParameter("@ten", tenNV), new SqlParameter("@gioitinh", gioiTinh), new SqlParameter("@ngaysinh", ngaySinh), new SqlParameter("@diachi", diaChi), new SqlParameter("@dienthoai", dienThoai));
            return n > 0;
        }
        public bool deleteNhanvien(int maNV)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_deleteNhanVien", new SqlParameter("@manv", maNV));
            return n > 0;
        }
        public DataTable getbp()
        {
            return Database.Instance.ExecuteQuery(" SELECT * FROM dbo.BOPHAN ");
        }
        public List<boPhanDTO> getlist()
        {
            List<boPhanDTO> group = new List<boPhanDTO>();
            DataTable table = Database.Instance.ExecuteQuery(" SELECT * FROM dbo.BOPHAN ");
            foreach (DataRow row in table.Rows)
            {
                boPhanDTO nhom = new boPhanDTO(row);
                group.Add(nhom);
            }
            return group;
        }
        public bool insertbophan(int ma, string ten)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertBoPhan", new SqlParameter("@ma", ma), new SqlParameter("@ten", ten));
            return n > 0;
        }
    }
}
