using System;
using System.Windows.Forms;

namespace prKol_ind3_isomatov_h_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void new_email_Click(object sender, EventArgs e)
        {
            if (adress.Text != "")
            {
                if (adress.Text.Contains('@') && adress.Text.IndexOf('@') < adress.Text.IndexOf('.') - 1 && adress.Text.IndexOf('.') != -1)
                {
                    if (emailAdress.emails.Contains(adress.Text) == false)
                    {
                        emailAdress n = new emailAdress(adress.Text);
                    }
                    else
                    {
                        MessageBox.Show("Такая почта уже существует!");
                    }
                }
                else if (login.Text != "" && domen.Text != "" && domen.Text.Contains('.'))
                {
                    emailAdress n = new emailAdress(login.Text, domen.Text);
                }
                else
                {
                    MessageBox.Show("Неверный формат почты!");

                }
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Все поля пусты!");
            }


        }

        public void UpdateListBox()
        {
            emailsList.Items.Clear();
            foreach (var item in emailAdress.emails)
            {
                emailsList.Items.Add(item);
            }
        }

        private void delete_email_Click(object sender, EventArgs e)
        {
            emailAdress.emails.RemoveAt(emailsList.SelectedIndex);
            UpdateListBox();
        }

        private void change_email_Click(object sender, EventArgs e)
        {
            if (adress.Text != "")
            {
                if (login.Text != "" && domen.Text != "" && domen.Text.Contains('.'))
                {
                    emailAdress.emails.RemoveAt(lastselected);
                    emailAdress n = new emailAdress(login.Text, domen.Text);
                }
                else
                {
                    MessageBox.Show("Неверный формат почты!");

                }
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Все поля пусты!");
            }
        }
        public static int lastselected;
        public void doubleclick(object sender, EventArgs e)
        {
            
            string adress = emailAdress.emails[emailsList.SelectedIndex].ToString();
            string[] loginDomen = adress.Split('@');
            login.Text = loginDomen[0];
            domen.Text = loginDomen[1];
            lastselected = emailsList.SelectedIndex;
            this.adress.Text = "";
            
        }
        private void emailsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
