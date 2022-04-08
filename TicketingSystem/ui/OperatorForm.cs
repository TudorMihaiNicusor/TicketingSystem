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
    public partial class OperatorForm : Form
    {
        private SpectacoleService spectacoleService = new SpectacoleService();
        private BileteService bileteService = new BileteService();
        private LoginForm loginForm;
        public OperatorForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
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

        private void vizualizareBileteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tabelBilete.DataSource = bileteService.getTabelBilete();
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la afisarea biletelor");
            }

        }

        private void vizualizareBileteSpectacolBtn_Click(object sender, EventArgs e)
        {
            if (titluSpectacolTxtB.Text.Equals(""))
            {
                MessageBox.Show("Introduceti titlul spectacolului la care doriti sa vedeti biletele");
            }
            else{
                try
                {
                    String titlu = spectacoleService.getSpectacol(titluSpectacolTxtB.Text).Titlu;
                    tabelBilete.DataSource = bileteService.getTableBileteSpectacol(titlu);
                }
                catch
                {
                    MessageBox.Show("A aparut o eroare la afisarea biletelor");
                }
             }
        }

        private void adaugareBiletBtn_Click(object sender, EventArgs e)
        {
            if (titluSpectacolTxtB.Text.Equals("") || numarBiletTxtB.Text.Equals("") || randBiletTxtB.Text.Equals(""))
            {
                MessageBox.Show("Introduceti titlul spectacolului, randul si numarul biletului pe care doriti sa il introduceti");
            }
            else
            {
                try
                {
                    bileteService.addBilet(int.Parse(randBiletTxtB.Text), int.Parse(numarBiletTxtB.Text), titluSpectacolTxtB.Text);
                    String titlu = spectacoleService.getSpectacol(titluSpectacolTxtB.Text).Titlu;
                    tabelBilete.DataSource = bileteService.getTableBileteSpectacol(titlu);
                    MessageBox.Show("Bilet adaugat cu succes");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void schimbaStareBtn_Click(object sender, EventArgs e)
        {
            if (titluSpectacolTxtB.Text.Equals("") || numarBiletTxtB.Text.Equals("") || randBiletTxtB.Text.Equals(""))
            {
                MessageBox.Show("Introduceti titlul spectacolului, randul si numarul biletului pe care doriti sa il vindeti");
            }
            else
            {
                try
                {
                    bileteService.sellBilet(titluSpectacolTxtB.Text, int.Parse(randBiletTxtB.Text), int.Parse(numarBiletTxtB.Text));
                    String titlu = spectacoleService.getSpectacol(titluSpectacolTxtB.Text).Titlu;
                    tabelBilete.DataSource = bileteService.getTableBileteSpectacol(titlu);
                    MessageBox.Show("Bilet vandut cu succes");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void tabelBilete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.tabelBilete.Rows[e.RowIndex];
                    String spectacolId = row.Cells["spectacolid"].Value.ToString();

                    titluSpectacolTxtB.Text = spectacoleService.getSpectacol(int.Parse(spectacolId)).Titlu;
                    randBiletTxtB.Text = row.Cells["rand"].Value.ToString();
                    numarBiletTxtB.Text = row.Cells["numar"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la extragerea datelor din tabel");
            }
            
        }

        private void tabelSpectacole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.tabelSpectacole.Rows[e.RowIndex];
                    titluSpectacolTxtB.Text = row.Cells["titlu"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la extragerea datelor din tabel");
            }
            
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.Show();
        }
    }
}
