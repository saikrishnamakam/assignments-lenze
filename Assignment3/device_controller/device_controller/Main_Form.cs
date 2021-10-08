using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace device_controller
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Device1Details_Form device1DetailsForm = new Device1Details_Form();
            device1DetailsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Device2Details_Form device2DetailsForm = new Device2Details_Form();
            device2DetailsForm.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
