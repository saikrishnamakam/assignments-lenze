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
    public partial class Device2Details_Form : Form, ILoadDeviceInfo
    {
        public Device2Details_Form()
        {
            InitializeComponent();
        }

        private void Device2Details_Form_Load(object sender, EventArgs e)
        {
            SetDeviceAttributes();
            SetErrorState();
        }

        public void SetDeviceAttributes()
        {
            this.device_name.Text = device_controller.Properties.Resources.device2_name;
            this.product_code.Text = device_controller.Properties.Resources.device2_productcode;
            this.firmware_ver.Text = device_controller.Properties.Resources.device2_firmwarever;
            this.actual_torque.Text = device_controller.Properties.Resources.device2_actualtorque;
            this.actual_speed.Text = device_controller.Properties.Resources.device2_actualspeed;
            this.actual_voltage.Text = device_controller.Properties.Resources.device2_actualvoltage;
        }

        public void SetErrorState()
        {
            int actualVoltage;
            int actualSpeed;

            Int32.TryParse(device_controller.Properties.Resources.device2_actualvoltage, out actualVoltage);
            Int32.TryParse(device_controller.Properties.Resources.device2_actualspeed, out actualSpeed);

            if(actualVoltage > 25 && (-5000 > actualSpeed || 5000 < actualSpeed))
            {
                this.errorstate_switch.BackColor = Color.Red;
            }
        }
    }
}
