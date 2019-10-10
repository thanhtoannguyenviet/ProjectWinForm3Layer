using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWinForm3Layer.DTO;
using static ProjectWinForm3Layer.BUS.Repository;
namespace ProjectWinForm3Layer
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
            comboBox1.DataSource= Const.cvList;
            comboBox3.DataSource =new BindingSource( Const.GioiTinh,null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";
        }

        private void MyUserControl_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = GetAllNhanVien();
            
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
                if (bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bunifuDataGridView1.CurrentRow.Selected = true;
                    textBox1.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["MaNV"].FormattedValue.ToString();
                    maskedTextBox1.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["TenNV"].FormattedValue.ToString();
                    comboBox1.Text =bunifuDataGridView1.Rows[e.RowIndex].Cells["ChucVu"].FormattedValue.ToString();
                    maskedTextBox4.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["TK_NhanVien"].FormattedValue.ToString();
                    maskedTextBox5.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells["MK_NhanVien"].FormattedValue.ToString();
                    comboBox2.SelectedText = bunifuDataGridView1.Rows[e.RowIndex].Cells["BiXoa"].FormattedValue.ToString();
                    comboBox3.SelectedText = bunifuDataGridView1.Rows[e.RowIndex].Cells["GioiTinhNV"].FormattedValue.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BindingNhanVien(int.Parse(textBox1.Text)) == null)
            {
                try
                {
                    InsertNhanVien(new NhanVienDTO
                    {
                        MaNV = int.Parse(textBox1.Text),
                        TenNV = maskedTextBox1.Text,
                        ChucVu = comboBox1.SelectedText,
                        GioiTinhNV = comboBox3.SelectedText,
                        TK_NhanVien = maskedTextBox4.Text,
                        MK_NhanVien = maskedTextBox5.Text
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                UpdateNhanVien(new NhanVienDTO
                {
                    MaNV = int.Parse(textBox1.Text),
                    TenNV = maskedTextBox1.Text,
                    ChucVu = comboBox1.SelectedText,
                    GioiTinhNV = comboBox3.SelectedText,
                    TK_NhanVien = maskedTextBox4.Text,
                    MK_NhanVien = maskedTextBox5.Text
                }); ;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete this member account", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
                DeleteNhanVien(int.Parse(textBox1.Text));
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
