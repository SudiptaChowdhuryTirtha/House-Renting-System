namespace RentingSystem.Forms
{
    partial class CustomerChatForm
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
            this.dgvLandlords = new System.Windows.Forms.DataGridView();
            this.dgvConversation = new System.Windows.Forms.DataGridView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLandlords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversation)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.Text = "Your Conversations";

            this.dgvLandlords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLandlords.Location = new System.Drawing.Point(20, 40);
            this.dgvLandlords.Name = "dgvLandlords";
            this.dgvLandlords.ReadOnly = true;
            this.dgvLandlords.Size = new System.Drawing.Size(760, 100);
            this.dgvLandlords.TabIndex = 1;
            this.dgvLandlords.SelectionChanged += new System.EventHandler(this.dgvLandlords_SelectionChanged);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.Text = "Chat History";

            this.dgvConversation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConversation.Location = new System.Drawing.Point(20, 180);
            this.dgvConversation.Name = "dgvConversation";
            this.dgvConversation.ReadOnly = true;
            this.dgvConversation.Size = new System.Drawing.Size(760, 200);
            this.dgvConversation.TabIndex = 3;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 400);
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.Text = "Message";

            this.txtMessage.Location = new System.Drawing.Point(20, 420);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(760, 100);
            this.txtMessage.TabIndex = 5;

            this.btnSendMessage.Location = new System.Drawing.Point(20, 530);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(760, 30);
            this.btnSendMessage.TabIndex = 6;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvConversation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLandlords);
            this.Controls.Add(this.label1);
            this.Name = "CustomerChatForm";
            this.Text = "CustomerChatForm";
            this.Load += new System.EventHandler(this.CustomerChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLandlords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvLandlords;
        private System.Windows.Forms.DataGridView dgvConversation;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}