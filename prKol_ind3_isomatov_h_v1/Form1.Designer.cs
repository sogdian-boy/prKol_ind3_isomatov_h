
namespace prKol_ind3_isomatov_h_v1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailsList = new System.Windows.Forms.ListBox();
            this.delete_email = new System.Windows.Forms.Button();
            this.change_email = new System.Windows.Forms.Button();
            this.new_email = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.domen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lasldlasd = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailsList
            // 
            this.emailsList.Dock = System.Windows.Forms.DockStyle.Right;
            this.emailsList.FormattingEnabled = true;
            this.emailsList.ItemHeight = 19;
            this.emailsList.Location = new System.Drawing.Point(412, 0);
            this.emailsList.Margin = new System.Windows.Forms.Padding(4);
            this.emailsList.Name = "emailsList";
            this.emailsList.Size = new System.Drawing.Size(617, 570);
            this.emailsList.TabIndex = 0;
            this.emailsList.SelectedIndexChanged += new System.EventHandler(this.emailsList_SelectedIndexChanged);
            this.emailsList.DoubleClick += new System.EventHandler(this.doubleclick);
            // 
            // delete_email
            // 
            this.delete_email.Location = new System.Drawing.Point(114, 206);
            this.delete_email.Margin = new System.Windows.Forms.Padding(4);
            this.delete_email.Name = "delete_email";
            this.delete_email.Size = new System.Drawing.Size(96, 29);
            this.delete_email.TabIndex = 1;
            this.delete_email.Text = "Удалить";
            this.delete_email.UseVisualStyleBackColor = true;
            this.delete_email.Click += new System.EventHandler(this.delete_email_Click);
            // 
            // change_email
            // 
            this.change_email.Location = new System.Drawing.Point(218, 206);
            this.change_email.Margin = new System.Windows.Forms.Padding(4);
            this.change_email.Name = "change_email";
            this.change_email.Size = new System.Drawing.Size(96, 29);
            this.change_email.TabIndex = 2;
            this.change_email.Text = "Изменить";
            this.change_email.UseVisualStyleBackColor = true;
            this.change_email.Click += new System.EventHandler(this.change_email_Click);
            // 
            // new_email
            // 
            this.new_email.Location = new System.Drawing.Point(9, 206);
            this.new_email.Margin = new System.Windows.Forms.Padding(4);
            this.new_email.Name = "new_email";
            this.new_email.Size = new System.Drawing.Size(96, 29);
            this.new_email.TabIndex = 3;
            this.new_email.Text = "Добавить";
            this.new_email.UseVisualStyleBackColor = true;
            this.new_email.Click += new System.EventHandler(this.new_email_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(11, 118);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.PlaceholderText = "ivanov";
            this.login.Size = new System.Drawing.Size(156, 26);
            this.login.TabIndex = 4;
            // 
            // domen
            // 
            this.domen.Location = new System.Drawing.Point(11, 170);
            this.domen.Margin = new System.Windows.Forms.Padding(4);
            this.domen.Name = "domen";
            this.domen.PlaceholderText = "yandex.ru";
            this.domen.Size = new System.Drawing.Size(156, 26);
            this.domen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин (до @)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Домен (после @)";
            // 
            // lasldlasd
            // 
            this.lasldlasd.AutoSize = true;
            this.lasldlasd.Location = new System.Drawing.Point(11, 10);
            this.lasldlasd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lasldlasd.Name = "lasldlasd";
            this.lasldlasd.Size = new System.Drawing.Size(110, 19);
            this.lasldlasd.TabIndex = 9;
            this.lasldlasd.Text = "Полная почта";
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(11, 37);
            this.adress.Margin = new System.Windows.Forms.Padding(4);
            this.adress.Name = "adress";
            this.adress.PlaceholderText = "ivanov@yandex.ru";
            this.adress.Size = new System.Drawing.Size(156, 26);
            this.adress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "или";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lasldlasd);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domen);
            this.Controls.Add(this.login);
            this.Controls.Add(this.new_email);
            this.Controls.Add(this.change_email);
            this.Controls.Add(this.delete_email);
            this.Controls.Add(this.emailsList);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Почтовый адрес организации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox emailsList;
        private System.Windows.Forms.Button delete_email;
        private System.Windows.Forms.Button change_email;
        private System.Windows.Forms.Button new_email;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox domen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lasldlasd;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label3;
    }
}

