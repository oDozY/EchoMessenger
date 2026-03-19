namespace EchoMessenger
{
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                return;
            }

            string typed_msg = txtInput.Text;
            lstMessages.Items.Add(typed_msg);
            txtInput.Clear();

            txtInput.Focus();

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
    }
}
