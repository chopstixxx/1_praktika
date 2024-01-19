using System.Text;


namespace goofyahh
{
    public partial class Form1 : Form
    {
        
        string user_text;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            user_text = textBox1.Text;
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Выберите формат!");
                return;
            }

            if(string.IsNullOrEmpty(user_text))
                {
                MessageBox.Show("Поле пустое!");
                return;
            }
            if(radioButton1.Checked)
            {
                saveFileDialog1.Filter = "Text files(*.txt) |*.txt|All files(*.*) |*.*";
            }
            if (radioButton2.Checked)
            {
                saveFileDialog1.Filter = "Text files(*.csv) |*.csv|All files(*.*) |*.*";
            }
            if(saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, user_text, Encoding.GetEncoding(1251));
            MessageBox.Show("Файл сохранён!");
            filename = "";

           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}