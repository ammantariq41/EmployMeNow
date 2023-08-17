namespace Testing_form
{
    partial class emailForm
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
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.attach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.browsebtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            this.stmp = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(99, 13);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(267, 20);
            this.from.TabIndex = 1;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(99, 47);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(267, 20);
            this.to.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(99, 78);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(538, 20);
            this.subject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "SMTP";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(99, 155);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(538, 213);
            this.body.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Body";
            // 
            // attach
            // 
            this.attach.Location = new System.Drawing.Point(99, 114);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(458, 20);
            this.attach.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Attach";
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(562, 114);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(75, 23);
            this.browsebtn.TabIndex = 12;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.sendbtn.Location = new System.Drawing.Point(549, 376);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(88, 41);
            this.sendbtn.TabIndex = 13;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // stmp
            // 
            this.stmp.FormattingEnabled = true;
            this.stmp.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.yahoo.com",
            "smtp.outlook.com",
            "smtp.lums.edu.pk",
            "smtp.cam-systems.co.uk"});
            this.stmp.Location = new System.Drawing.Point(475, 44);
            this.stmp.Name = "stmp";
            this.stmp.Size = new System.Drawing.Size(162, 21);
            this.stmp.TabIndex = 14;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(475, 13);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 18;
            this.password.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(99, 385);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(188, 20);
            this.email.TabIndex = 16;
            // 
            // emailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(694, 430);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stmp);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.body);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label1);
            this.Name = "emailForm";
            this.Text = "emailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox attach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.ComboBox stmp;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
    }
}