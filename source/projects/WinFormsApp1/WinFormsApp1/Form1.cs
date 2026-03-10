namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public bool IsValid()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(this.textBox_Name.Text))
            {
                isValid = false;
                this.errorProvider1.SetError(this.textBox_Name, "name is empty");
            }
            if (string.IsNullOrEmpty(this.textBox_Surname.Text))
            {
                isValid = false;
                this.errorProvider1.SetError(this.textBox_Surname, "surname is empty");

            }
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsValid();
        }


        private void Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(sender as TextBox, null);
        }

        private void textBox_Name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(this.textBox_Name.Text))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(sender as TextBox, "pole je povinne");
            }

        }
    }


}
