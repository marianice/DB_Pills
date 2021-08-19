using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Pills
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PILLSDataSet.Adress". При необходимости она может быть перемещена или удалена.
            this.adressTableAdapter.Fill(this.dB_PILLSDataSet.Adress);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PILLSDataSet.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.dB_PILLSDataSet.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PILLSDataSet.Pills_name". При необходимости она может быть перемещена или удалена.
            this.pills_nameTableAdapter.Fill(this.dB_PILLSDataSet.Pills_name);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void таблеткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPills myForm2 = new FormPills();
            myForm2.Show();

        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProviders myForm3 = new FormProviders();
            myForm3.Show();
        }

        private void адресаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddress myForm4 = new FormAddress();
            myForm4.Show();
        }
    }
}
