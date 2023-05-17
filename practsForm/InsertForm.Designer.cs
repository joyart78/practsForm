namespace practsForm
{
    partial class InsertForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonInsrt = new System.Windows.Forms.Button();
            this.webName = new System.Windows.Forms.Label();
            this.loginFill = new System.Windows.Forms.Label();
            this.passFill = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 43);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "добавление сайта/приложения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(417, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(754, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // ButtonInsrt
            // 
            this.ButtonInsrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInsrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInsrt.Location = new System.Drawing.Point(134, 275);
            this.ButtonInsrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonInsrt.Name = "ButtonInsrt";
            this.ButtonInsrt.Size = new System.Drawing.Size(173, 54);
            this.ButtonInsrt.TabIndex = 16;
            this.ButtonInsrt.Text = "добавить";
            this.ButtonInsrt.UseVisualStyleBackColor = true;
            this.ButtonInsrt.Click += new System.EventHandler(this.ButtonInsrt_Click);
            // 
            // webName
            // 
            this.webName.AutoSize = true;
            this.webName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webName.Location = new System.Drawing.Point(39, 79);
            this.webName.Name = "webName";
            this.webName.Size = new System.Drawing.Size(88, 20);
            this.webName.TabIndex = 17;
            this.webName.Text = "название";
            // 
            // loginFill
            // 
            this.loginFill.AutoSize = true;
            this.loginFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginFill.Location = new System.Drawing.Point(39, 123);
            this.loginFill.Name = "loginFill";
            this.loginFill.Size = new System.Drawing.Size(57, 20);
            this.loginFill.TabIndex = 18;
            this.loginFill.Text = "логин";
            // 
            // passFill
            // 
            this.passFill.AutoSize = true;
            this.passFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passFill.Location = new System.Drawing.Point(39, 164);
            this.passFill.Name = "passFill";
            this.passFill.Size = new System.Drawing.Size(69, 20);
            this.passFill.TabIndex = 19;
            this.passFill.Text = "пароль";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(222, 77);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(176, 22);
            this.nameText.TabIndex = 20;
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(222, 121);
            this.loginText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(176, 22);
            this.loginText.TabIndex = 21;
            // 
            // passName
            // 
            this.passName.Location = new System.Drawing.Point(222, 162);
            this.passName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passName.Name = "passName";
            this.passName.Size = new System.Drawing.Size(176, 22);
            this.passName.TabIndex = 22;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.passName);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.passFill);
            this.Controls.Add(this.loginFill);
            this.Controls.Add(this.webName);
            this.Controls.Add(this.ButtonInsrt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonInsrt;
        private System.Windows.Forms.Label webName;
        private System.Windows.Forms.Label loginFill;
        private System.Windows.Forms.Label passFill;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passName;
        private System.Windows.Forms.Label label2;
    }
}