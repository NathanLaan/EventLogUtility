using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventLogUtility.WinApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void btnELSExists_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventLog.SourceExists(this.txtELS.Text))
                {
                    MessageBox.Show("Event Log Source [" + this.txtELS.Text + "] exists");
                }
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

        private void btnELSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                EventLog.DeleteEventSource(this.txtELS.Text);
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

        private void btnELNExists_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventLog.Exists(this.txtELN.Text))
                {
                    MessageBox.Show("Event Log [" + this.txtELN.Text + "] exists");
                }
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

        private void btnELNDelete_Click(object sender, EventArgs e)
        {
            try
            {
                EventLog.Delete(this.txtELN.Text);
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(this,
                    "Create Event Log [" + this.txtELN.Text + "] with Source [" + this.txtELS.Text + "] ?",
                    "Create Event Log",
                    MessageBoxButtons.YesNo))
                {
                    EventLog.CreateEventSource(this.txtELS.Text, this.txtELN.Text);
                }
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

        private void HandleException(Exception exception)
        {
            this.txtOutput.AppendText(exception.ToString());
            this.txtOutput.AppendText(Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtOutput.Clear();
        }

    }
}
