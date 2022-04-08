using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketingSystem.bussiness_logic;

namespace TicketingSystem.ui
{
    public partial class LoginForm : Form
    {
        UsersService usersService;

        public LoginForm()
        {
            InitializeComponent();
            passwordTBox.PasswordChar = '*';
            usersService = new UsersService();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTBox.Text;
            String password = passwordTBox.Text;

            try
            {
                if(usersService.login(username, password).Equals("administrator"))
                {
                    
                    AdminForm adminFornm = new AdminForm(this);
                    adminFornm.Show();
                    this.Hide();
                }
                else
                {
                    OperatorForm operatorForm = new OperatorForm(this);
                    operatorForm.Show();
                    this.Hide();
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Userul introdus nu exista");
            }
        }
    }
}
