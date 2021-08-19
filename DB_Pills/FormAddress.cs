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
    public partial class FormAddress : Form
    {
        public FormAddress()
        {
            InitializeComponent();
        }

        private void FormAddress_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PILLSDataSet.Adress". При необходимости она может быть перемещена или удалена.
            this.adressTableAdapter.Fill(this.dB_PILLSDataSet.Adress);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adressBindingSource.EndEdit();
            this.adressTableAdapter.Update(this.dB_PILLSDataSet.Adress);
        }
    }
}
