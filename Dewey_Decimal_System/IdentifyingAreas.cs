using DeweyDecimalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewey_Decimal_System
{
    public partial class IdentifyingAreas : Form
    {
        // declare generic collections
        public static List<ModelIdentifyingCallNos> lstDescription = new List<ModelIdentifyingCallNos>();
        public static List<string> lstCallNos = new List<string>();
        public static Dictionary<string, string> dictCallNoDescription = new Dictionary<string, string>();

        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
