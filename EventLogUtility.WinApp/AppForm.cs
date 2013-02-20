using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EventLogUtility.WinApp
{
    public partial class AppForm : Form
    {

        private const string LocalMachineName = ".";

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
                    this.txtOutput.AppendText("Event Log Source [" + this.txtELS.Text + "] exists");
                    this.txtOutput.AppendText(Environment.NewLine);
                }
                else
                {
                    this.txtOutput.AppendText("Event Log Source [" + this.txtELS.Text + "] does not exist");
                    this.txtOutput.AppendText(Environment.NewLine);
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
                    this.txtOutput.AppendText("Event Log [" + this.txtELN.Text + "] exists");
                    this.txtOutput.AppendText(Environment.NewLine);
                }
                else
                {
                    this.txtOutput.AppendText("Event Log [" + this.txtELN.Text + "] does not exist");
                    this.txtOutput.AppendText(Environment.NewLine);
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

        private void btnELSGetLogName_Click(object sender, EventArgs e)
        {
            try
            {
                string eventLogName = EventLog.LogNameFromSourceName(this.txtELS.Text, AppForm.LocalMachineName);
                string outputMessage = "Event Log [{0}] corresponds to Event Log Source [{1}]";
                if (String.IsNullOrEmpty(eventLogName))
                {
                    outputMessage = "No Event Log found for Event Log Source [{1}]";
                }
                this.txtOutput.AppendText(string.Format(outputMessage, eventLogName, this.txtELS.Text));
                this.txtOutput.AppendText(Environment.NewLine);
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

    }
}
