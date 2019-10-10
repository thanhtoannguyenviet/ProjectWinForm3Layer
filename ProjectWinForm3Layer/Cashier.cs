using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWinForm3Layer.DTO;
using static ProjectWinForm3Layer.BUS.Repository;
namespace ProjectWinForm3Layer
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
           
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
        List<SanPhamDTO> ls = new List<SanPhamDTO>();

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string txt = dataGridView1.Rows[e.RowIndex].Cells["MASP"].Value.ToString();
            var data = AddProduct(txt);
            ls.Add(data);
            if (ls.Where(t => t.MaSP == data.MaSP).FirstOrDefault()==null) { 
                if (data != null) { 
                    int n = dataGridView1.Rows.Add()-1;
                    dataGridView1.Rows[n].Cells[0].Value = data.MaSP;
                    dataGridView1.Rows[n].Cells[1].Value = data.TenSP;
                    dataGridView1.Rows[n].Cells[2].Value = data.SL;
                dataGridView1.Rows[n].Cells[3].Value = data.GiaXuat;
                }
            }
            txttongtien.Text =(int.Parse(txttongtien.Text)+ (data.SL * data.GiaXuat)).ToString();

        }

        private void txttienkhach_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char) Keys.Enter)
            {
                txttienthoi.Text = (int.Parse(txttienkhach.Text) - int.Parse(txttongtien.Text)).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = Int32.Parse(DateTime.Now.ToLongDateString());
            hd.MaKH = 01;
            hd.MaNV = 01;
            hd.ThanhTien = int.Parse(txttongtien.Text);
            CreateHoaDon(hd);
        }
    }
}
