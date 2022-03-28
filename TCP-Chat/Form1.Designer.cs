
namespace TCP_Chat
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình chat Client/Server sử dụng TCP";
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(128, 150);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(210, 129);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(447, 150);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(210, 129);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
    }
}

