namespace Testing_form
{
    partial class cover_letter
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
            this.speakbtn = new System.Windows.Forms.Button();
            this.recordbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.viewbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.write = new System.Windows.Forms.RichTextBox();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write your cover letter ";
            // 
            // speakbtn
            // 
            this.speakbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.speakbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.speakbtn.Location = new System.Drawing.Point(46, 186);
            this.speakbtn.Name = "speakbtn";
            this.speakbtn.Size = new System.Drawing.Size(64, 40);
            this.speakbtn.TabIndex = 2;
            this.speakbtn.Text = "Speak";
            this.speakbtn.UseVisualStyleBackColor = false;
            this.speakbtn.Click += new System.EventHandler(this.speakbtn_Click);
            // 
            // recordbtn
            // 
            this.recordbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.recordbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.recordbtn.Location = new System.Drawing.Point(46, 242);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(64, 45);
            this.recordbtn.TabIndex = 3;
            this.recordbtn.Text = "Record";
            this.recordbtn.UseVisualStyleBackColor = false;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saved Cover Letters";
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(517, 157);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(56, 23);
            this.viewbtn.TabIndex = 5;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(144, 96);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(274, 20);
            this.name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Letter";
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(144, 145);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(274, 204);
            this.write.TabIndex = 10;
            this.write.Text = "";
            // 
            // data_view
            // 
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Location = new System.Drawing.Point(453, 186);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(185, 163);
            this.data_view.TabIndex = 11;
            this.data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_CellContentClick);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savebtn.Location = new System.Drawing.Point(231, 367);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(99, 45);
            this.savebtn.TabIndex = 12;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cover_letter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.data_view);
            this.Controls.Add(this.write);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordbtn);
            this.Controls.Add(this.speakbtn);
            this.Controls.Add(this.label1);
            this.Name = "cover_letter";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button speakbtn;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox write;
        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.Button savebtn;
    }
}