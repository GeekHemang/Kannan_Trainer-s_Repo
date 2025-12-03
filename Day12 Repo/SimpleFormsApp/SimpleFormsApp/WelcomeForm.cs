using SimpleFormsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFormsApp
{
    class WelcomeForm : Form
    {
        private Button button1;
        private TextBox txtUserName;
        private Button button2;
        public WelcomeForm()
        {

            this.Text = "Welcome Form Title";
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(149, 141);
            button1.Name = "button1";
            button1.Size = new Size(182, 106);
            button1.TabIndex = 0;
            button1.Text = "Hello";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(374, 91);
            button2.Name = "button2";
            button2.Size = new Size(184, 129);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += (s,e)=> {
            //    this.Close();
            
            //};
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(129, 39);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 31);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Sarvesh";
            // 
            // WelcomeForm
            // 
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(622, 378);
            Controls.Add(txtUserName);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "WelcomeForm";
            Text = "MyTitle";
            ResumeLayout(false);
            PerformLayout();

        }


        //event handler
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            DataService dataService = new DataService();
            int data = dataService.GetData();
            MessageBox.Show($"you clicked me  {userName} , data is {data}");
        }

       
    }
}
