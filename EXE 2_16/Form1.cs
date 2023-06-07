using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE_2_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat instance form baru
            Form2 form2 = new Form2();

            // Menampilkan form baru
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance form baru
            Form3 form3 = new Form3();

            // Menampilkan form baru
            form3.Show();
        }
    }
}
