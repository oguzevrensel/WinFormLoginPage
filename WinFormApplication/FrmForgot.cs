using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApplication
{
    public partial class FrmForgot : Form
    {
        public int userId;
        UserProcess userProcess;
        public FrmForgot()
        {
            InitializeComponent();
            userProcess = UserProcess.GetInstance();
        }

        private void FrmForgot_Load(object sender, EventArgs e)
        {
            grp.Visible = false;
            string question = userProcess.GetQuestionByUserId(userId);

            if(question != "")
            {
                lblQuestion.Text = question;
            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Bilgisi");
            }


            
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            string answer = TxtAnswer.Text.Trim();
            if(string.IsNullOrEmpty(TxtAnswer.Text.Trim()))
            {
                MessageBox.Show("Lütfen Soruyu Yanıtlayınız");
                return;
            }

            if (userProcess.IsAnswerTrue(userId, answer))
            {
                grp.Visible=true;
            }

            else
            {
                MessageBox.Show("Cevabınız Yanlış");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string repeatPassword = txtRepeatPassword.Text.Trim();

            if(string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
                return;

            }

            if(password != repeatPassword)
            {
                MessageBox.Show("Şifre ile Şifre tekrarı aynı olmalıdır");
                return;
            }

            else
            {
                MessageBox.Show(userProcess.UpdatePassword(userId, password));
                this.Close();
            }

        }
    }
}
