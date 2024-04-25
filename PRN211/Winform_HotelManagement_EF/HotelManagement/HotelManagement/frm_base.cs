using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement
{
    public partial class frm_base : Form
    {
        public frm_base()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void CloseCurrentForm(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            bool isOpened = false;
            if (item.Text == "Exit")
            {
                Application.Exit();
                return;
            }

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                var frm = Application.OpenForms[i];
                if ($"frm_{item.Text}" != frm.Name)
                {
                    frm.Hide();
                }
                else
                {
                    isOpened = true;
                    frm.Show();
                }
            }

            if (!isOpened)
            {
                switch (item.Text)
                {
                    case "Room":
                        Program.ServiceProvider.GetRequiredService<frm_Room>().Show();
                        break;
                    case "Customer":
                        Program.ServiceProvider.GetRequiredService<frm_Customer>().Show();
                        break;
                    case "Booking":
                        Program.ServiceProvider.GetRequiredService<frm_Booking>().Show();
                        break;
                    case "Report":
                        Program.ServiceProvider.GetRequiredService<frm_Report>().Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm(sender, e);
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm(sender, e);
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm(sender, e);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm(sender, e);
        }
    }
}
