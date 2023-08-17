namespace Testing_form
{
    partial class Applications_Portal
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
            this.contentpanel = new System.Windows.Forms.Panel();
            this.sidebarpnl = new System.Windows.Forms.Panel();
            this.coverbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emailbtn = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.sidebarpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentpanel
            // 
            this.contentpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentpanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(148, 0);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(652, 450);
            this.contentpanel.TabIndex = 1;
            // 
            // sidebarpnl
            // 
            this.sidebarpnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidebarpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebarpnl.Controls.Add(this.coverbtn);
            this.sidebarpnl.Controls.Add(this.button3);
            this.sidebarpnl.Controls.Add(this.button2);
            this.sidebarpnl.Controls.Add(this.emailbtn);
            this.sidebarpnl.Controls.Add(this.New);
            this.sidebarpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarpnl.Location = new System.Drawing.Point(0, 0);
            this.sidebarpnl.Name = "sidebarpnl";
            this.sidebarpnl.Size = new System.Drawing.Size(148, 450);
            this.sidebarpnl.TabIndex = 2;
            // 
            // coverbtn
            // 
            this.coverbtn.BackColor = System.Drawing.Color.SlateGray;
            this.coverbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coverbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coverbtn.Location = new System.Drawing.Point(2, 266);
            this.coverbtn.Name = "coverbtn";
            this.coverbtn.Size = new System.Drawing.Size(141, 45);
            this.coverbtn.TabIndex = 4;
            this.coverbtn.Text = "Write Cover Letter";
            this.coverbtn.UseVisualStyleBackColor = false;
            this.coverbtn.Click += new System.EventHandler(this.coverbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(21, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sign Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "In-Progress Applications";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emailbtn
            // 
            this.emailbtn.BackColor = System.Drawing.Color.SlateGray;
            this.emailbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailbtn.Location = new System.Drawing.Point(2, 188);
            this.emailbtn.Name = "emailbtn";
            this.emailbtn.Size = new System.Drawing.Size(141, 45);
            this.emailbtn.TabIndex = 1;
            this.emailbtn.Text = "Write Email";
            this.emailbtn.UseVisualStyleBackColor = false;
            this.emailbtn.Click += new System.EventHandler(this.emailbtn_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.SlateGray;
            this.New.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.New.Location = new System.Drawing.Point(3, 39);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(141, 45);
            this.New.TabIndex = 0;
            this.New.Text = "New Application";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Applications_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.sidebarpnl);
            this.Name = "Applications_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applications_Portal";
            this.sidebarpnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Panel sidebarpnl;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button emailbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button coverbtn;
    }
}