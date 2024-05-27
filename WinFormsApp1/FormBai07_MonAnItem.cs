using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class FormBai07_MonAnItem : UserControl
    {

        public FormBai07_MonAnItem()
        {
            InitializeComponent();
        }

        public string tenMonAn
        {
            get { return lbTenMonAn.Text; }
            set { lbTenMonAn.Text = value; }
        }
        public string Gia
        {
            get { return lbGia.Text; }
            set { lbGia.Text = value; }
        }
        public string DiaChi
        {
            get { return lbDiaChi.Text; }
            set { lbDiaChi.Text = value; }
        }
        public string DongGop
        {
            get { return lbNguoiDongGop.Text; }
            set { lbNguoiDongGop.Text = value; }
        }

        public Image AnhMonAn
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }


    }

}
