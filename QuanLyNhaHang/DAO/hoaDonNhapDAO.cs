using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class hoaDonNhapDAO
    {
        private static hoaDonNhapDAO instance;

        public static hoaDonNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new hoaDonNhapDAO();

                return hoaDonNhapDAO.instance;
            }

            private set
            {
                hoaDonNhapDAO.instance = value;
            }
        }
        private hoaDonNhapDAO() { }
        public bool insert(int maHD, int maNV, string ten)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertHDNhap @mahdn , @manv , @tenncc ", new object[] { maHD, maNV, ten });
            return n > 0;

        }
        public bool insertct(int maCTHD, int maHD, int maNL, float soLuong)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_insertCTHDNV @macthd , @mahd , @manl , @soluong", new object[] {  maCTHD,  maHD,  maNL,  soLuong });
            return n > 0;

        }
        public DataTable getcthd()
        {
            return Database.Instrance.ExecuteQuery("SELECT DISTINCT a.MACTHDN, a.MAHDN, a.MANL,a.SOLUONG,c.DONGIA FROM dbo.CHITIETHOADONNHAP a ,dbo.HOADONNHAP b,dbo.NGUYENLIEU c WHERE a.MANL = c.MANL");
        }
        public List<hoaDonNhapDTO> gettt()
        {
            List<hoaDonNhapDTO> list = new List<hoaDonNhapDTO>();
            DataTable tb = Database.Instrance.ExecuteQuery("SELECT DISTINCT a.MACTHDN, a.MAHDN, a.MANL,a.SOLUONG,c.DONGIA FROM dbo.CHITIETHOADONNHAP a ,dbo.HOADONNHAP b,dbo.NGUYENLIEU c WHERE a.MANL = c.MANL");
            foreach (DataRow row in tb.Rows)
            {
                hoaDonNhapDTO menu = new hoaDonNhapDTO(row);
                list.Add(menu);
            }
            return list;
        }
    }
}
