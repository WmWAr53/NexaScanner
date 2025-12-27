namespace NexaScanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnScan = new Button();
            lblResult = new Label();
            progressBar1 = new ProgressBar();
            lstFindings = new ListBox();
            lblPercent = new Label();
            comboDrives = new ComboBox();
            SuspendLayout();
            // 
            // btnScan
            // 
            btnScan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnScan.Location = new Point(549, 12);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(175, 95);
            btnScan.TabIndex = 0;
            btnScan.Text = "TARA";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResult.Location = new Point(25, 368);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 50);
            lblResult.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(25, 269);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(538, 70);
            progressBar1.TabIndex = 2;
            // 
            // lstFindings
            // 
            lstFindings.FormattingEnabled = true;
            lstFindings.Location = new Point(25, 12);
            lstFindings.Name = "lstFindings";
            lstFindings.Size = new Size(456, 229);
            lstFindings.TabIndex = 3;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPercent.Location = new Point(596, 279);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(0, 50);
            lblPercent.TabIndex = 4;
            // 
            // comboDrives
            // 
            comboDrives.FormattingEnabled = true;
            comboDrives.Location = new Point(549, 130);
            comboDrives.Name = "comboDrives";
            comboDrives.Size = new Size(175, 23);
            comboDrives.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboDrives);
            Controls.Add(lblPercent);
            Controls.Add(lstFindings);
            Controls.Add(progressBar1);
            Controls.Add(lblResult);
            Controls.Add(btnScan);
            Name = "Form1";
            Text = "NexaScanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScan;
        private Label lblResult;
        private ProgressBar progressBar1;
        private ListBox lstFindings;
        private Label lblPercent;
        private ComboBox comboDrives;
    }
}
