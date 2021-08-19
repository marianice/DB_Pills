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
    public partial class FormPills : Form
    {
        public FormPills()
        {
            InitializeComponent();
        }

        private void FormPills_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PILLSDataSet.Pills_name". При необходимости она может быть перемещена или удалена.
            this.pills_nameTableAdapter.Fill(this.dB_PILLSDataSet.Pills_name);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Validate();
          this.pillsnameBindingSource.EndEdit();
          this.pills_nameTableAdapter.Update(this.dB_PILLSDataSet.Pills_name);


        }
    }
}
