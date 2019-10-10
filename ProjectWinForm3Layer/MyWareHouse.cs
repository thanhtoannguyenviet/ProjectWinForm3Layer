using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using ProjectWinForm3Layer.DTO;
using static ProjectWinForm3Layer.BUS.Repository;
namespace ProjectWinForm3Layer
{
    public partial class MyWareHouse : UserControl
    {
        public MyWareHouse()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataView dv = new DataView(bunifuDataGridView1.Tables[0]);
            //dv.RowFilter.
        }

        private void MyWareHouse_Load_1(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = GetAllKho();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bunifuDataGridView1.CurrentRow.Selected = true;
                    textBox2.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["MASP"].FormattedValue.ToString();
                    textBox3.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["TENSP"].FormattedValue.ToString();
                    textBox5.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["SL"].FormattedValue.ToString();
                    textBox4.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["GiaNhap"].FormattedValue.ToString();
                    textBox6.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["GiaXuat"].FormattedValue.ToString();
                    comboBox1.DataBindings.Add("text", bunifuDataGridView1.DataSource, "MATH");
                    comboBox2.DataBindings.Add("text", bunifuDataGridView1.DataSource, "MaLoai");

                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO{MaSP = textBox2.Text,TenSP = textBox3.Text,SL=int.Parse(textBox5.Text), GiaNhap =int.Parse( textBox4.Text), GiaXuat =int.Parse( textBox6.Text), MaTH = comboBox1.SelectedText,MaLoai =comboBox2.SelectedText };
            InsertUpdateKho(sp);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete this product", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                DeleteKho(textBox1.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
