namespace wwwHome
{
    public partial class LoginF : Form
    {
        int number = 0;
        public LoginF()
        {
            InitializeComponent();
            Text = MF.Ver + @" Вход {wwwHome}";
        }

        private void buttonESC_Click(object sender, EventArgs e)
        {
            Program.result = DialogResult.Cancel;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Не введен пароль...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Не введен пароль...", "Предупреждение");
                textBoxPassword.Focus();
                return;
            }
            number++;
            labelNumber.Text = @"Количество попыток: " + number;
            Application.DoEvents();
            if (textBoxPassword.Text == "1221")
            {
                Program.result = DialogResult.OK;
                Close();
            }
            if (number == 3)
            {
                if (textBoxPassword.Text != "1221")
                {
                    MessageBox.Show("Пароль введен неправильно..." + Environment.NewLine + "Ваши попытки закончились...",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
            textBoxPassword.Text = string.Empty;
            Application.DoEvents();
            textBoxPassword.Focus();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOK_Click(sender, null);
        }
    }
}