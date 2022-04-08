
namespace TicketingSystem.ui
{
    partial class OperatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabelSpectacole = new System.Windows.Forms.DataGridView();
            this.tabelBilete = new System.Windows.Forms.DataGridView();
            this.showSpectacoleBtn = new System.Windows.Forms.Button();
            this.vizualizareBileteBtn = new System.Windows.Forms.Button();
            this.titluSpectacolLb = new System.Windows.Forms.Label();
            this.biletRandLb = new System.Windows.Forms.Label();
            this.numarBiletLb = new System.Windows.Forms.Label();
            this.titluSpectacolTxtB = new System.Windows.Forms.TextBox();
            this.randBiletTxtB = new System.Windows.Forms.TextBox();
            this.numarBiletTxtB = new System.Windows.Forms.TextBox();
            this.vizualizareBileteSpectacolBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.adaugareBiletBtn = new System.Windows.Forms.Button();
            this.schimbaStareBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelSpectacole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBilete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelSpectacole
            // 
            this.tabelSpectacole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelSpectacole.Location = new System.Drawing.Point(471, 12);
            this.tabelSpectacole.Name = "tabelSpectacole";
            this.tabelSpectacole.Size = new System.Drawing.Size(536, 178);
            this.tabelSpectacole.TabIndex = 11;
            this.tabelSpectacole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelSpectacole_CellContentClick);
            // 
            // tabelBilete
            // 
            this.tabelBilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelBilete.Location = new System.Drawing.Point(471, 221);
            this.tabelBilete.Name = "tabelBilete";
            this.tabelBilete.Size = new System.Drawing.Size(536, 195);
            this.tabelBilete.TabIndex = 12;
            this.tabelBilete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelBilete_CellContentClick);
            // 
            // showSpectacoleBtn
            // 
            this.showSpectacoleBtn.Location = new System.Drawing.Point(131, 12);
            this.showSpectacoleBtn.Name = "showSpectacoleBtn";
            this.showSpectacoleBtn.Size = new System.Drawing.Size(139, 23);
            this.showSpectacoleBtn.TabIndex = 19;
            this.showSpectacoleBtn.Text = "Vizualizare Spectacole";
            this.showSpectacoleBtn.UseVisualStyleBackColor = true;
            this.showSpectacoleBtn.Click += new System.EventHandler(this.showSpectacoleBtn_Click);
            // 
            // vizualizareBileteBtn
            // 
            this.vizualizareBileteBtn.Location = new System.Drawing.Point(15, 242);
            this.vizualizareBileteBtn.Name = "vizualizareBileteBtn";
            this.vizualizareBileteBtn.Size = new System.Drawing.Size(139, 23);
            this.vizualizareBileteBtn.TabIndex = 20;
            this.vizualizareBileteBtn.Text = "Vizualizare Bilete";
            this.vizualizareBileteBtn.UseVisualStyleBackColor = true;
            this.vizualizareBileteBtn.Click += new System.EventHandler(this.vizualizareBileteBtn_Click);
            // 
            // titluSpectacolLb
            // 
            this.titluSpectacolLb.AutoSize = true;
            this.titluSpectacolLb.Location = new System.Drawing.Point(12, 82);
            this.titluSpectacolLb.Name = "titluSpectacolLb";
            this.titluSpectacolLb.Size = new System.Drawing.Size(78, 13);
            this.titluSpectacolLb.TabIndex = 21;
            this.titluSpectacolLb.Text = "Titlu Spectacol";
            // 
            // biletRandLb
            // 
            this.biletRandLb.AutoSize = true;
            this.biletRandLb.Location = new System.Drawing.Point(12, 120);
            this.biletRandLb.Name = "biletRandLb";
            this.biletRandLb.Size = new System.Drawing.Size(56, 13);
            this.biletRandLb.TabIndex = 22;
            this.biletRandLb.Text = "Rand Bilet";
            // 
            // numarBiletLb
            // 
            this.numarBiletLb.AutoSize = true;
            this.numarBiletLb.Location = new System.Drawing.Point(12, 155);
            this.numarBiletLb.Name = "numarBiletLb";
            this.numarBiletLb.Size = new System.Drawing.Size(61, 13);
            this.numarBiletLb.TabIndex = 23;
            this.numarBiletLb.Text = "Numar Bilet";
            // 
            // titluSpectacolTxtB
            // 
            this.titluSpectacolTxtB.Location = new System.Drawing.Point(105, 82);
            this.titluSpectacolTxtB.Name = "titluSpectacolTxtB";
            this.titluSpectacolTxtB.Size = new System.Drawing.Size(178, 20);
            this.titluSpectacolTxtB.TabIndex = 24;
            // 
            // randBiletTxtB
            // 
            this.randBiletTxtB.Location = new System.Drawing.Point(105, 120);
            this.randBiletTxtB.Name = "randBiletTxtB";
            this.randBiletTxtB.Size = new System.Drawing.Size(178, 20);
            this.randBiletTxtB.TabIndex = 25;
            // 
            // numarBiletTxtB
            // 
            this.numarBiletTxtB.Location = new System.Drawing.Point(105, 152);
            this.numarBiletTxtB.Name = "numarBiletTxtB";
            this.numarBiletTxtB.Size = new System.Drawing.Size(178, 20);
            this.numarBiletTxtB.TabIndex = 26;
            // 
            // vizualizareBileteSpectacolBtn
            // 
            this.vizualizareBileteSpectacolBtn.Location = new System.Drawing.Point(224, 242);
            this.vizualizareBileteSpectacolBtn.Name = "vizualizareBileteSpectacolBtn";
            this.vizualizareBileteSpectacolBtn.Size = new System.Drawing.Size(164, 23);
            this.vizualizareBileteSpectacolBtn.TabIndex = 27;
            this.vizualizareBileteSpectacolBtn.Text = "Vizualizare Bilete Spectacol";
            this.vizualizareBileteSpectacolBtn.UseVisualStyleBackColor = true;
            this.vizualizareBileteSpectacolBtn.Click += new System.EventHandler(this.vizualizareBileteSpectacolBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(118, 393);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(139, 23);
            this.logOutBtn.TabIndex = 28;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // adaugareBiletBtn
            // 
            this.adaugareBiletBtn.Location = new System.Drawing.Point(45, 289);
            this.adaugareBiletBtn.Name = "adaugareBiletBtn";
            this.adaugareBiletBtn.Size = new System.Drawing.Size(75, 23);
            this.adaugareBiletBtn.TabIndex = 29;
            this.adaugareBiletBtn.Text = "AdaugaBilet";
            this.adaugareBiletBtn.UseVisualStyleBackColor = true;
            this.adaugareBiletBtn.Click += new System.EventHandler(this.adaugareBiletBtn_Click);
            // 
            // schimbaStareBtn
            // 
            this.schimbaStareBtn.Location = new System.Drawing.Point(262, 289);
            this.schimbaStareBtn.Name = "schimbaStareBtn";
            this.schimbaStareBtn.Size = new System.Drawing.Size(75, 23);
            this.schimbaStareBtn.TabIndex = 30;
            this.schimbaStareBtn.Text = "Vinde Bilet";
            this.schimbaStareBtn.UseVisualStyleBackColor = true;
            this.schimbaStareBtn.Click += new System.EventHandler(this.schimbaStareBtn_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 439);
            this.Controls.Add(this.schimbaStareBtn);
            this.Controls.Add(this.adaugareBiletBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.vizualizareBileteSpectacolBtn);
            this.Controls.Add(this.numarBiletTxtB);
            this.Controls.Add(this.randBiletTxtB);
            this.Controls.Add(this.titluSpectacolTxtB);
            this.Controls.Add(this.numarBiletLb);
            this.Controls.Add(this.biletRandLb);
            this.Controls.Add(this.titluSpectacolLb);
            this.Controls.Add(this.vizualizareBileteBtn);
            this.Controls.Add(this.showSpectacoleBtn);
            this.Controls.Add(this.tabelBilete);
            this.Controls.Add(this.tabelSpectacole);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabelSpectacole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBilete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelSpectacole;
        private System.Windows.Forms.DataGridView tabelBilete;
        private System.Windows.Forms.Button showSpectacoleBtn;
        private System.Windows.Forms.Button vizualizareBileteBtn;
        private System.Windows.Forms.Label titluSpectacolLb;
        private System.Windows.Forms.Label biletRandLb;
        private System.Windows.Forms.Label numarBiletLb;
        private System.Windows.Forms.TextBox titluSpectacolTxtB;
        private System.Windows.Forms.TextBox randBiletTxtB;
        private System.Windows.Forms.TextBox numarBiletTxtB;
        private System.Windows.Forms.Button vizualizareBileteSpectacolBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button adaugareBiletBtn;
        private System.Windows.Forms.Button schimbaStareBtn;
    }
}