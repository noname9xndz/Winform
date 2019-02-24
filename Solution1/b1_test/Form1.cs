using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // add event động
            this.Click += new System.EventHandler(this.doitenform);
            this.txtNhapChuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.testskTextChanged);
        }
        // this để gọi form cần xử lý
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // event tự định nghĩa
        private void doitenform(object sender, EventArgs e)
        {
            this.Text = "noname";
        }
        // kéo thả event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("bạn có muốn đóng?");
        }

        #region test event

        private void btnXuatChuoi_Click(object sender, EventArgs e)
        {
            lblXuatChuoi.Text = txtNhapChuoi.Text;
        }

        private void testskTextChanged(object sender, EventArgs e)
        {
            //lblXuatChuoi.Text = txtNhapChuoi.Text;
        }

        private void txtNhapChuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblXuatChuoi.Text = txtNhapChuoi.Text;
        }


        #endregion

        private void txtNhapChuoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public partial class Form2 : Form
    {
        // adđ form động
    }
}
