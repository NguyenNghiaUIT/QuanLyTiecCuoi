using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSanh
    {
        public DTO_LoaiSanh() { }
        public DTO_LoaiSanh(char maLoaiSanh, decimal donGiaBanToiThieu)
        {
            this.maLoaiSanh = maLoaiSanh;
            this.donGiaBanToiThieu = donGiaBanToiThieu;
        }
        public char maLoaiSanh { get; set; }
        public decimal donGiaBanToiThieu { get; set; }
    }
}
