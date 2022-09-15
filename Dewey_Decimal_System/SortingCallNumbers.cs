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
    public partial class frmSortingCallNumbers : Form
    {
        public frmSortingCallNumbers()
        {
            InitializeComponent();
            lstboxRandom.AllowDrop = true;
            lstboxSorted.AllowDrop = true;

            lstboxRandom.Items.Add("Kiaan");
            lstboxRandom.Items.Add("Liam");
        }

        private void lstboxRandom_MouseDown(object sender, MouseEventArgs e)
        {
            lstboxSorted.DoDragDrop(lstboxRandom.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void lstboxSorted_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else 
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstboxSorted_DragDrop(object sender, DragEventArgs e)
        {
            lstboxSorted.Items.Add(e.Data.GetData(DataFormats.Text));
            lstboxRandom.Items.Remove(e.Data.GetData(DataFormats.Text));    
        }

  
    }
}
