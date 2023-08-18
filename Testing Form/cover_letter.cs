using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Jobkar.DAL;

namespace Testing_form
{
    public partial class cover_letter : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public cover_letter()
        {
            InitializeComponent();
        }

        private void speakbtn_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(write.Text);

        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SpeechRecognitionEngine speech = new SpeechRecognitionEngine();
                Grammar words = new DictationGrammar();
                speech.LoadGrammar(words);


                speech.SetInputToDefaultAudioDevice();
                RecognitionResult result = speech.Recognize();


                if (result != null)
                {
                    write.Text = result.Text;
                }
                else
                {
                    write.Text = "No speech recognized.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & write.Text != " ")
            {

                if (DAL.insertcover_in_DB(name.Text, write.Text)){


                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                        Title = "Save Text File",
                        DefaultExt = "txt",
                        AddExtension = true
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        try
                        {
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                writer.Write(write.Text);
                            }
                            MessageBox.Show("File saved successfully!");
                            name.Clear();
                            write.Clear();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while saving the file: " + ex.Message);
                        }
                    }
                }
            }



            else
            {
                MessageBox.Show(text: "PLEASE FILL ALL THE BOXES");

            }

        }


        private void viewbtn_Click(object sender, EventArgs e)
        {
            BindView();
        }

        void BindView()
        {
            SqlConnection con = new SqlConnection(cs);
            string q = $"select name from cover_letter where user_id = {CurrentUser.userid}";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            data_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_view.DataSource = dataTable;
        }

        private string clickedName;

        public void data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedName = data_view.Rows[e.RowIndex].Cells["name"].Value.ToString();
            letter_display letter = new letter_display(clickedName);
            letter.BringToFront();
            letter.Show();




        }

    }
}
