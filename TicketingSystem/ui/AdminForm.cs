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
    public partial class AdminForm : Form
    {
        private SpectacoleService spectacoleService = new SpectacoleService();
        private UsersService usersService = new UsersService();
        private LoginForm loginForm;
        public AdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void AddOperator_Click(object sender, EventArgs e)
        {
            try
            {
                usersService.addUser(usernameTxtB.Text, passwordTxtB.Text, "operator", nameTxtB.Text);
                usernameTxtB.Text = "";
                passwordTxtB.Text = "";
                nameTxtB.Text = "";
                MessageBox.Show("Operator introdus cu succes");
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la introducerea operatorului");
            }
        }

        private void showSpectacoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tabelSpectacole.DataSource = spectacoleService.getTabelSpectacole();
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la afisarea spectacolelor");
            }
        }

        private void addSpectacolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                spectacoleService.addSpectacol(titluTxtB.Text, regizorTxtB.Text, actoriTxtB.Text, dataPremieraTxtB.Text, int.Parse(nrBileteTxtB.Text));
                tabelSpectacole.DataSource = spectacoleService.getTabelSpectacole();
                MessageBox.Show("Spectacol introdus cu succes");
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la introducerea spectacolului");
            }
        }

        private void updateSpectacolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String data = dataPremieraTxtB.Text;
                String theCorrectData = data.Substring(6, 4) + "." + data.Substring(3, 3) + data.Substring(0,2) + data.Substring(10);
                spectacoleService.updateSpectacol(titluTxtB.Text, regizorTxtB.Text, actoriTxtB.Text, theCorrectData, int.Parse(nrBileteTxtB.Text));
                tabelSpectacole.DataSource = spectacoleService.getTabelSpectacole();
                MessageBox.Show("Spectacol modificat cu succes");
            }
            catch
            {
                MessageBox.Show("Spectacolul introdus nu exista in baza de date");
            }
        }

        private void deleteSpectacolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                spectacoleService.deleteSpectacol(titluTxtB.Text);
                tabelSpectacole.DataSource = spectacoleService.getTabelSpectacole();
                MessageBox.Show("Spectacol sters cu succes");
            }
            catch
            {
                MessageBox.Show("Spectacolul introdus nu exista in baza de date");
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.Show();
        }

        private void tabelSpectacole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.tabelSpectacole.Rows[e.RowIndex];
                    titluTxtB.Text = row.Cells["titlu"].Value.ToString();
                    regizorTxtB.Text = row.Cells["regizor"].Value.ToString();
                    actoriTxtB.Text = row.Cells["actori"].Value.ToString();
                    dataPremieraTxtB.Text = row.Cells["data"].Value.ToString();
                    nrBileteTxtB.Text = row.Cells["nrbilete"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la extragerea datelor din tabel tabel");
            }
        }
    }
}
