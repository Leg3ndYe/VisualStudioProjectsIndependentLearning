using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Figuring_Out
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite izaći?", "Izlaz", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
