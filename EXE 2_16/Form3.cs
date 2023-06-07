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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTI_dataDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTI_dataDataSet.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat instance form baru
            Form1 form1 = new Form1();

            // Menampilkan form baru
            form1.Show();
        }
    }
}
