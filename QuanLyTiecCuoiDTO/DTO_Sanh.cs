using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanh
    {
        public DTO_Sanh() { }
        public DTO_Sanh(string tenSanh, char maLoaiSanh, int soLuongBanToiDa, string ghiChu)
        {
            this.tenSanh = tenSanh;
            this.maLoaiSanh = maLoaiSanh;
            this.soLuongBanToiDa = soLuongBanToiDa;
            this.ghiChu = ghiChu;
        }
        public string maSanh;
        public string tenSanh;
        public char maLoaiSanh;
        public int soLuongBanToiDa;
        public string ghiChu;
    }
}
