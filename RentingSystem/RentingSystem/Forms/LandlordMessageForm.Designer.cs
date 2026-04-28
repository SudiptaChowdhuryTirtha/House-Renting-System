namespace RentingSystem.Forms
{
    partial class LandlordMessagesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.txtSenderID = new System.Windows.Forms.TextBox();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();

            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(20, 20);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.Size = new System.Drawing.Size(660, 200);
            this.dgvMessages.TabIndex = 0;
            this.dgvMessages.SelectionChanged += new System.EventHandler(this.dgvMessages_SelectionChanged);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 240);
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.Text = "Sender ID";

            this.txtSenderID.Location = new System.Drawing.Point(120, 237);
            this.txtSenderID.Name = "txtSenderID";
            this.txtSenderID.ReadOnly = true;
            this.txtSenderID.Size = new System.Drawing.Size(200, 20);
            this.txtSenderID.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 278);
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.Text = "Message";

            this.txtMessageText.Location = new System.Drawing.Point(120, 275);
            this.txtMessageText.Multiline = true;
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.ReadOnly = true;
            this.txtMessageText.Size = new System.Drawing.Size(560, 60);
            this.txtMessageText.TabIndex = 2;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 348);
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.Text = "Reply";

            this.txtReply.Location = new System.Drawing.Point(120, 345);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(560, 80);
            this.txtReply.TabIndex = 3;

            this.btnReply.Location = new System.Drawing.Point(120, 430);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(560, 30);
            this.btnReply.TabIndex = 4;
            this.btnReply.Text = "Send Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMessageText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMessages);
            this.Name = "LandlordMessagesForm";
            this.Text = "LandlordMessagesForm";
            this.Load += new System.EventHandler(this.LandlordMessagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.TextBox txtSenderID;
        private System.Windows.Forms.TextBox txtMessageText;
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}