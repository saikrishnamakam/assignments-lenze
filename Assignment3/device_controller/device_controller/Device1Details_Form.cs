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
    public partial class Device1Details_Form : Form, ILoadDeviceInfo
    {
        public Device1Details_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetDeviceAttributes()
        {
            this.device_name.Text = device_controller.Properties.Resources.device1_name;
            this.product_code.Text = device_controller.Properties.Resources.device1_productcode;
            this.firmware_ver.Text = device_controller.Properties.Resources.device1_firmwarever;
            this.switching_freq.Text = device_controller.Properties.Resources.device1_switchingfreq;
            this.start_freq.Text = device_controller.Properties.Resources.device1_startfreq;
            this.delay_time.Text = device_controller.Properties.Resources.device1_delaytime;
        }

        public void SetErrorState()
        {
            int startFrequency;
            int switchingFrequency;

            Int32.TryParse(device_controller.Properties.Resources.device1_startfreq, out startFrequency);
            Int32.TryParse(device_controller.Properties.Resources.device1_switchingfreq, out switchingFrequency);

            if (startFrequency > 250 && switchingFrequency > 500)
            {
                this.errorstate_switch.BackColor = Color.Red;
            }
        }

        private void Device1Details_Form_Load(object sender, EventArgs e)
        {
            SetDeviceAttributes();
            SetErrorState();
        }
    }
}
