using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            return Database.Instrance.ExecuteQuery("SELECT * FROM DBO.NHANVIEN");
        }
        public bool insertNhanvien(int maNV, string tenNV, string boPhan, string dThoai, string dChi, string gioitinh, DateTime ngaysinh)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_insernhanvienprc2 @mnv , @tenbp , @ten , @gioitinh , @ngaysinh , @diachi , @dienthoai ", new object[] { maNV, boPhan, tenNV, gioitinh, ngaysinh, dChi, dThoai });
            return n > 0;
        }
        public bool updateNhanvien(int maNV, string tenNV, string boPhan, string dThoai, string dChi, string gioitinh, DateTime ngaysinh)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_update3 @mnv , @tenbp , @ten , @gioitinh , @ngaysinh , @diachi , @dienthoai ", new object[] { maNV, boPhan, tenNV, gioitinh, ngaysinh, dChi, dThoai });
            return n > 0;
        }
        public bool deleteNhanvien(int maNV)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_DELETENvien @mnv", new object[] { maNV });
            return n > 0;
        }
        public DataTable getbp()
        {
            return Database.Instrance.ExecuteQuery(" SELECT * FROM dbo.CHUCNANG ");
        }
        public List<chucNangDTO> getlist()
        {
            List<chucNangDTO> group = new List<chucNangDTO>();
            DataTable table = Database.Instrance.ExecuteQuery(" SELECT * FROM dbo.CHUCNANG ");
            foreach (DataRow row in table.Rows)
            {
                chucNangDTO nhom = new chucNangDTO(row);
                group.Add(nhom);
            }
            return group;
        }
        public bool insertbophan(int ma, string ten)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_insertbophan @ma , @ten ", new object[] { ma, ten });
            return n > 0;
        }
    }
}
