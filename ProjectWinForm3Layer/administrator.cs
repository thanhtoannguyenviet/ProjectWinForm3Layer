using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForm3Layer
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }
        private void btnmcus_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sslide1.Location = new Point(sslide1.Location.X, btn.Location.Y);
            sslide2.Location = new Point(sslide2.Location.X, btn.Location.Y);
            switch (btn.Name)
            {
                case "btndashboard":
                    myDashBoard1.BringToFront();
                    break;
                case "btnEmploy":
                    myUserControl1.BringToFront();
                    break;
                case "btnproducts":
                    myWareHouse1.BringToFront();
                    break;
                case "btnbuylogs":
                    Form cashierForm = new Cashier();
                    cashierForm.Show();
                    break;
            }
        }
    }

}
