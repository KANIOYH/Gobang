
namespace 五子棋
{
    partial class Server
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skNum = new System.Windows.Forms.TextBox();
            this.link_msg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "创  建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(130, 108);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(259, 25);
            this.inputIP.TabIndex = 1;
            this.inputIP.Text = "192.168.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号";
            // 
            // skNum
            // 
            this.skNum.Location = new System.Drawing.Point(130, 163);
            this.skNum.Name = "skNum";
            this.skNum.Size = new System.Drawing.Size(259, 25);
            this.skNum.TabIndex = 3;
            this.skNum.Text = "50001";
            // 
            // link_msg
            // 
            this.link_msg.Location = new System.Drawing.Point(436, 34);
            this.link_msg.Name = "link_msg";
            this.link_msg.Size = new System.Drawing.Size(496, 266);
            this.link_msg.TabIndex = 6;
            this.link_msg.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 324);
            this.Controls.Add(this.link_msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.button1);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skNum;
        private System.Windows.Forms.RichTextBox link_msg;
    }
}