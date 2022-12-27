namespace WinFormApplication
{
    public partial class Login : Form
    {
        UserProcess userProcess;
        public Login()
        {
            InitializeComponent();
            userProcess = UserProcess.GetInstance();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userProcess.LoginControl(txtUserName.Text.Trim(),
                txtPassword.Text.Trim()))
            {
                MessageBox.Show("Hoþgeldiniz");
            }

            else
            {
                MessageBox.Show("Geçersiz Kullanýcý veya þifre",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lnkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Lütfen Kullanýcý adýný girin");
                return;
            }

            int userId = userProcess.GetUserIdByUserName
                (txtUserName.Text.Trim());

            if(userId != -1)
            {
                FrmForgot frm = new FrmForgot();
                frm.userId = userId;
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Bu isimde bir kullanýcý adý bulunamadý");
            }

        }
    }
}