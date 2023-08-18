using Jobkar.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Testing_form
{
    public partial class AddApplication : Form
    {
        string company = " ";
       
        public AddApplication()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            if (company != "" && position.Text != "")
            {

                var appInserted = DAL.InsertApplication(company, position.Text, CurrentUser.userid);
               
                if (!appInserted)
                {
                    System.Windows.Forms.MessageBox.Show(text: "PLEASE FILL ALL THE BOXES");
                    return;
                }

                System.Windows.Forms.MessageBox.Show(text: $"You Applied at {company} \n" +
                      $"At the designation of {this.position.Text}");

                UcSubmit Formm = new UcSubmit();
                Formm.ShowDialog(this);
                string from = CurrentUser.email;
                string to = DAL.GetCompanyEmail(company);

                string subject = position.Text;
                string smtp = "smtp.gmail.com";

                string email = from;
                string password = CurrentUser.password;

                string filePath = cover_textbox.Text;
                string body = Helper.ReadTextFile(filePath);
                string cv_attach = attach.Text;

                Helper.send_email(from, to, subject, smtp, email, password, body, cv_attach);
                
                comboBox1.Items.Clear();
                position.Clear();
                attach.Clear();
                cover_textbox.Clear();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocumentClass printDocumentClass = new PrintDocumentClass();
            printDocumentClass.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                attach.Text = path;
            }
        }

        private void coverbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                cover_textbox.Text = path;
            }

        }

        private void AddApplication_Load(object sender, EventArgs e)
        {
            var companyNames = DAL.GetCompanyNames();
            foreach (string companyName in companyNames)
            { comboBox1.Items.Add(companyName); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = comboBox1.SelectedItem.ToString();
        }
    }
}
