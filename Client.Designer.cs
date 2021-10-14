
namespace 五子棋
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
            this.label2 = new System.Windows.Forms.Label();
            this.skNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cli_msg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "端口号";
            // 
            // skNum
            // 
            this.skNum.Location = new System.Drawing.Point(125, 127);
            this.skNum.Name = "skNum";
            this.skNum.Size = new System.Drawing.Size(259, 25);
            this.skNum.TabIndex = 8;
            this.skNum.Text = "50001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP地址";
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(125, 72);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(259, 25);
            this.inputIP.TabIndex = 6;
            this.inputIP.Text = "192.168.1.101";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "加 入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cli_msg
            // 
            this.cli_msg.Location = new System.Drawing.Point(467, 48);
            this.cli_msg.Name = "cli_msg";
            this.cli_msg.Size = new System.Drawing.Size(589, 237);
            this.cli_msg.TabIndex = 11;
            this.cli_msg.Text = "";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 315);
            this.Controls.Add(this.cli_msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.button1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox cli_msg;
    }
}