using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_5_1_ui
{
    interface IPaper
    {
        int Format { get; set; }
        void roll_up();
        void cut();
        string get_string();
    }
}