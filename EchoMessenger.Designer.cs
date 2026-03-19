namespace EchoMessenger
{
    partial class frmTitle
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
            lblTitle = new Label();
            txtInput = new TextBox();
            lstMessages = new ListBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(527, 89);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.GradientInactiveCaption;
            txtInput.Location = new Point(60, 714);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(823, 31);
            txtInput.TabIndex = 1;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // lstMessages
            // 
            lstMessages.BackColor = SystemColors.GradientInactiveCaption;
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(12, 143);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(1169, 504);
            lstMessages.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.GradientInactiveCaption;
            btnSend.BackgroundImageLayout = ImageLayout.None;
            btnSend.Location = new Point(953, 714);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(174, 31);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // frmTitle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1209, 887);
            Controls.Add(btnSend);
            Controls.Add(lstMessages);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Name = "frmTitle";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInput;
        private ListBox lstMessages;
        private Button btnSend;
    }
}
