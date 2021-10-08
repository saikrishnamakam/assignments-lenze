using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace device_controller
{
    interface ILoadDeviceInfo
    {
        void SetDeviceAttributes();

        void SetErrorState();
    }
}
