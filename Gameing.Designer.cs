
namespace 五子棋
{
    partial class Gameing
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
            this.pad = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link_l = new System.Windows.Forms.Label();
            this.nowP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).BeginInit();
            this.SuspendLayout();
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(182)))), ((int)(((byte)(118)))));
            this.pad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pad.Location = new System.Drawing.Point(45, 45);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(809, 756);
            this.pad.TabIndex = 0;
            this.pad.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(908, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "绘制棋盘";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "无";
            // 
            // link_l
            // 
            this.link_l.AutoSize = true;
            this.link_l.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.link_l.Location = new System.Drawing.Point(904, 214);
            this.link_l.Name = "link_l";
            this.link_l.Size = new System.Drawing.Size(89, 19);
            this.link_l.TabIndex = 3;
            this.link_l.Text = "命令提示";
            // 
            // nowP
            // 
            this.nowP.AutoSize = true;
            this.nowP.Location = new System.Drawing.Point(908, 255);
            this.nowP.Name = "nowP";
            this.nowP.Size = new System.Drawing.Size(67, 15);
            this.nowP.TabIndex = 4;
            this.nowP.Text = "当前棋手";
            // 
            // Gameing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1203, 828);
            this.Controls.Add(this.nowP);
            this.Controls.Add(this.link_l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gameing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gameing";
            ((System.ComponentModel.ISupportInitialize)(this.pad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label link_l;
        private System.Windows.Forms.Label nowP;
    }
}