using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocThongTinOCung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btODia_Click(object sender, EventArgs e)
        {
            ODia oDia = new ODia();
            this.Hide();
            if (oDia.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }

        }

        private void btOCung_Click(object sender, EventArgs e)
        {
            OCung oCung = new OCung();
            this.Hide();
            if (oCung.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
