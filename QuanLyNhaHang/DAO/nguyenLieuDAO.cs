using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            return Database.Instrance.ExecuteQuery(" SELECT * FROM dbo.NGUYENLIEU ");
        }
        public bool insertnnl(int maNNL, string tenNL, float donGia, string donViTinh, string ten)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertNguyenLieu @manl  , @tennl , @dongia , @donvitinh , @ten ", new object[] { maNNL, tenNL, donGia, donViTinh, ten });
            return n > 0;
        }
        public bool updatennl(int maNNL, string tenNL, float donGia, string donViTinh, string ten)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_updateNL @manl  , @tennl , @ten , @dongia , @donvitinh  ", new object[] { maNNL, tenNL, ten, donGia, donViTinh });
            return n > 0;
        }
        public bool deletenl(int ma)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_deleteNL @manl  ", new object[] { ma });
            return n > 0;
        }
        public List<nguyenLieuDTO> getlistnl()
        {
            List<nguyenLieuDTO> group = new List<nguyenLieuDTO>();
            DataTable table = Database.Instrance.ExecuteQuery("SELECT * FROM dbo.NGUYENLIEU");
            foreach (DataRow row in table.Rows)
            {
                nguyenLieuDTO nhom = new nguyenLieuDTO(row);
                group.Add(nhom);
            }
            return group;
        }
    }
}
