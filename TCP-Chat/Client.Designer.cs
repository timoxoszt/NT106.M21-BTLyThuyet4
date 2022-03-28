
namespace TCP_Chat
{
    partial class Client
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
            this.tbClient = new System.Windows.Forms.TextBox();
            this.lbClient = new System.Windows.Forms.Label();
            this.tbInputClient = new System.Windows.Forms.TextBox();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(60, 51);
            this.tbClient.Multiline = true;
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(675, 316);
            this.tbClient.TabIndex = 0;
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.Location = new System.Drawing.Point(361, 19);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(81, 29);
            this.lbClient.TabIndex = 1;
            this.lbClient.Text = "Client";
            // 
            // tbInputClient
            // 
            this.tbInputClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputClient.Location = new System.Drawing.Point(60, 390);
            this.tbInputClient.Name = "tbInputClient";
            this.tbInputClient.Size = new System.Drawing.Size(585, 30);
            this.tbInputClient.TabIndex = 2;
            // 
            // btnClientSend
            // 
            this.btnClientSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSend.Location = new System.Drawing.Point(660, 389);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(75, 31);
            this.btnClientSend.TabIndex = 3;
            this.btnClientSend.Text = "Send";
            this.btnClientSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientSend.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClientSend);
            this.Controls.Add(this.tbInputClient);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.tbClient);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.TextBox tbInputClient;
        private System.Windows.Forms.Button btnClientSend;
    }
}