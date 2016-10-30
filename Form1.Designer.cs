namespace MwaChat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextLocalIP = new System.Windows.Forms.TextBox();
            this.textlocalPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.User_TwoIP = new System.Windows.Forms.TextBox();
            this.text_userTwoPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Startbutton1 = new System.Windows.Forms.Button();
            this.ListMassage = new System.Windows.Forms.ListBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.Sendbutton2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextLocalIP);
            this.groupBox1.Controls.Add(this.textlocalPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User_One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // TextLocalIP
            // 
            this.TextLocalIP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextLocalIP.Location = new System.Drawing.Point(74, 27);
            this.TextLocalIP.Name = "TextLocalIP";
            this.TextLocalIP.Size = new System.Drawing.Size(114, 20);
            this.TextLocalIP.TabIndex = 4;
            this.TextLocalIP.TextChanged += new System.EventHandler(this.TextLocalIP_TextChanged);
            // 
            // textlocalPort
            // 
            this.textlocalPort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textlocalPort.Location = new System.Drawing.Point(74, 65);
            this.textlocalPort.Name = "textlocalPort";
            this.textlocalPort.Size = new System.Drawing.Size(114, 20);
            this.textlocalPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.User_TwoIP);
            this.groupBox2.Controls.Add(this.text_userTwoPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(283, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User_Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // User_TwoIP
            // 
            this.User_TwoIP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.User_TwoIP.Location = new System.Drawing.Point(72, 27);
            this.User_TwoIP.Name = "User_TwoIP";
            this.User_TwoIP.Size = new System.Drawing.Size(111, 20);
            this.User_TwoIP.TabIndex = 6;
            // 
            // text_userTwoPort
            // 
            this.text_userTwoPort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_userTwoPort.Location = new System.Drawing.Point(72, 68);
            this.text_userTwoPort.Name = "text_userTwoPort";
            this.text_userTwoPort.Size = new System.Drawing.Size(111, 20);
            this.text_userTwoPort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // Startbutton1
            // 
            this.Startbutton1.Location = new System.Drawing.Point(506, 48);
            this.Startbutton1.Name = "Startbutton1";
            this.Startbutton1.Size = new System.Drawing.Size(75, 23);
            this.Startbutton1.TabIndex = 2;
            this.Startbutton1.Text = "START";
            this.Startbutton1.UseVisualStyleBackColor = true;
            this.Startbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListMassage
            // 
            this.ListMassage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListMassage.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMassage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ListMassage.FormattingEnabled = true;
            this.ListMassage.ItemHeight = 20;
            this.ListMassage.Location = new System.Drawing.Point(12, 138);
            this.ListMassage.Name = "ListMassage";
            this.ListMassage.Size = new System.Drawing.Size(488, 84);
            this.ListMassage.TabIndex = 3;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessagetextBox.Location = new System.Drawing.Point(12, 265);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(488, 20);
            this.MessagetextBox.TabIndex = 8;
            // 
            // Sendbutton2
            // 
            this.Sendbutton2.Location = new System.Drawing.Point(506, 262);
            this.Sendbutton2.Name = "Sendbutton2";
            this.Sendbutton2.Size = new System.Drawing.Size(75, 23);
            this.Sendbutton2.TabIndex = 9;
            this.Sendbutton2.Text = "SEND";
            this.Sendbutton2.UseVisualStyleBackColor = true;
            this.Sendbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 297);
            this.Controls.Add(this.Sendbutton2);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ListMassage);
            this.Controls.Add(this.Startbutton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "MwarukaSonChatApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextLocalIP;
        private System.Windows.Forms.TextBox textlocalPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox User_TwoIP;
        private System.Windows.Forms.TextBox text_userTwoPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Startbutton1;
        private System.Windows.Forms.ListBox ListMassage;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button Sendbutton2;
    }
}

