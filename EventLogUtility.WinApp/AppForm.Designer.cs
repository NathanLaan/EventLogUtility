namespace EventLogUtility.WinApp
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnELSGetLogName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnELNDelete = new System.Windows.Forms.Button();
            this.btnELNExists = new System.Windows.Forms.Button();
            this.txtELN = new System.Windows.Forms.TextBox();
            this.lblELN = new System.Windows.Forms.Label();
            this.btnELSDelete = new System.Windows.Forms.Button();
            this.btnELSExists = new System.Windows.Forms.Button();
            this.txtELS = new System.Windows.Forms.TextBox();
            this.lblELS = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnELSGetLogName);
            this.splitContainer.Panel1.Controls.Add(this.btnClear);
            this.splitContainer.Panel1.Controls.Add(this.btnCreate);
            this.splitContainer.Panel1.Controls.Add(this.btnELNDelete);
            this.splitContainer.Panel1.Controls.Add(this.btnELNExists);
            this.splitContainer.Panel1.Controls.Add(this.txtELN);
            this.splitContainer.Panel1.Controls.Add(this.lblELN);
            this.splitContainer.Panel1.Controls.Add(this.btnELSDelete);
            this.splitContainer.Panel1.Controls.Add(this.btnELSExists);
            this.splitContainer.Panel1.Controls.Add(this.txtELS);
            this.splitContainer.Panel1.Controls.Add(this.lblELS);
            this.splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer.Size = new System.Drawing.Size(632, 453);
            this.splitContainer.SplitterDistance = 100;
            this.splitContainer.TabIndex = 0;
            // 
            // btnELSGetLogName
            // 
            this.btnELSGetLogName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnELSGetLogName.Location = new System.Drawing.Point(383, 8);
            this.btnELSGetLogName.Name = "btnELSGetLogName";
            this.btnELSGetLogName.Size = new System.Drawing.Size(75, 23);
            this.btnELSGetLogName.TabIndex = 10;
            this.btnELSGetLogName.Text = "Get Log";
            this.btnELSGetLogName.UseVisualStyleBackColor = true;
            this.btnELSGetLogName.Click += new System.EventHandler(this.btnELSGetLogName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(545, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(464, 63);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnELNDelete
            // 
            this.btnELNDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnELNDelete.Location = new System.Drawing.Point(545, 34);
            this.btnELNDelete.Name = "btnELNDelete";
            this.btnELNDelete.Size = new System.Drawing.Size(75, 23);
            this.btnELNDelete.TabIndex = 7;
            this.btnELNDelete.Text = "Delete";
            this.btnELNDelete.UseVisualStyleBackColor = true;
            this.btnELNDelete.Click += new System.EventHandler(this.btnELNDelete_Click);
            // 
            // btnELNExists
            // 
            this.btnELNExists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnELNExists.Location = new System.Drawing.Point(464, 34);
            this.btnELNExists.Name = "btnELNExists";
            this.btnELNExists.Size = new System.Drawing.Size(75, 23);
            this.btnELNExists.TabIndex = 6;
            this.btnELNExists.Text = "Exists";
            this.btnELNExists.UseVisualStyleBackColor = true;
            this.btnELNExists.Click += new System.EventHandler(this.btnELNExists_Click);
            // 
            // txtELN
            // 
            this.txtELN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtELN.Location = new System.Drawing.Point(115, 36);
            this.txtELN.Name = "txtELN";
            this.txtELN.Size = new System.Drawing.Size(343, 20);
            this.txtELN.TabIndex = 5;
            // 
            // lblELN
            // 
            this.lblELN.AutoSize = true;
            this.lblELN.Location = new System.Drawing.Point(13, 39);
            this.lblELN.Name = "lblELN";
            this.lblELN.Size = new System.Drawing.Size(90, 13);
            this.lblELN.TabIndex = 4;
            this.lblELN.Text = "Event Log Name:";
            // 
            // btnELSDelete
            // 
            this.btnELSDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnELSDelete.Location = new System.Drawing.Point(545, 8);
            this.btnELSDelete.Name = "btnELSDelete";
            this.btnELSDelete.Size = new System.Drawing.Size(75, 23);
            this.btnELSDelete.TabIndex = 3;
            this.btnELSDelete.Text = "Delete";
            this.btnELSDelete.UseVisualStyleBackColor = true;
            this.btnELSDelete.Click += new System.EventHandler(this.btnELSDelete_Click);
            // 
            // btnELSExists
            // 
            this.btnELSExists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnELSExists.Location = new System.Drawing.Point(464, 8);
            this.btnELSExists.Name = "btnELSExists";
            this.btnELSExists.Size = new System.Drawing.Size(75, 23);
            this.btnELSExists.TabIndex = 2;
            this.btnELSExists.Text = "Exists";
            this.btnELSExists.UseVisualStyleBackColor = true;
            this.btnELSExists.Click += new System.EventHandler(this.btnELSExists_Click);
            // 
            // txtELS
            // 
            this.txtELS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtELS.Location = new System.Drawing.Point(115, 10);
            this.txtELS.Name = "txtELS";
            this.txtELS.Size = new System.Drawing.Size(262, 20);
            this.txtELS.TabIndex = 1;
            // 
            // lblELS
            // 
            this.lblELS.AutoSize = true;
            this.lblELS.Location = new System.Drawing.Point(13, 13);
            this.lblELS.Name = "lblELS";
            this.lblELS.Size = new System.Drawing.Size(96, 13);
            this.lblELS.TabIndex = 0;
            this.lblELS.Text = "Event Log Source:";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(632, 349);
            this.txtOutput.TabIndex = 0;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventLog Utility";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox txtELS;
        private System.Windows.Forms.Label lblELS;
        private System.Windows.Forms.Button btnELSExists;
        private System.Windows.Forms.Button btnELSDelete;
        private System.Windows.Forms.Button btnELNDelete;
        private System.Windows.Forms.Button btnELNExists;
        private System.Windows.Forms.TextBox txtELN;
        private System.Windows.Forms.Label lblELN;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnELSGetLogName;
    }
}

