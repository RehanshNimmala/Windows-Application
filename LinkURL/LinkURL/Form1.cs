using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LinkURL
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            Process.Start($@"https://www.google.com/search?q=cars+images&rlz=1C1FHFK_enUS985US985&oq=Cars
                                +images & aqs = chrome.0.0i131i433i512j0i512l6j69i65.4888j0j7 & sourceid = chrome & ie = U");
        }
    }
}
