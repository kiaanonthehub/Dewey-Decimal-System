namespace Dewey_Decimal_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSortCallNos_Click(object sender, EventArgs e)
        {
            frmSortingCallNumbers sortingCallNumbers = new frmSortingCallNumbers();
            this.Hide();
            sortingCallNumbers.ShowDialog();
        }
    }
}