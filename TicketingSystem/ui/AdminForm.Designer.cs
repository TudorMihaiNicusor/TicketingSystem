
namespace TicketingSystem.ui
{
    partial class AdminForm
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
            this.task1Lb = new System.Windows.Forms.Label();
            this.usernameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.usernameTxtB = new System.Windows.Forms.TextBox();
            this.passwordTxtB = new System.Windows.Forms.TextBox();
            this.nameTxtB = new System.Windows.Forms.TextBox();
            this.AddOperator = new System.Windows.Forms.Button();
            this.tabelSpectacole = new System.Windows.Forms.DataGridView();
            this.task2Lb = new System.Windows.Forms.Label();
            this.showSpectacoleBtn = new System.Windows.Forms.Button();
            this.dataPremieraTxtB = new System.Windows.Forms.TextBox();
            this.regizorTxtB = new System.Windows.Forms.TextBox();
            this.titluTxtB = new System.Windows.Forms.TextBox();
            this.dataPremieraLb = new System.Windows.Forms.Label();
            this.regizorLb = new System.Windows.Forms.Label();
            this.titluLb = new System.Windows.Forms.Label();
            this.actoriLb = new System.Windows.Forms.Label();
            this.actoriTxtB = new System.Windows.Forms.TextBox();
            this.nrBileteLb = new System.Windows.Forms.Label();
            this.nrBileteTxtB = new System.Windows.Forms.TextBox();
            this.addSpectacolBtn = new System.Windows.Forms.Button();
            this.updateSpectacolBtn = new System.Windows.Forms.Button();
            this.deleteSpectacolBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelSpectacole)).BeginInit();
            this.SuspendLayout();
            // 
            // task1Lb
            // 
            this.task1Lb.AutoSize = true;
            this.task1Lb.Location = new System.Drawing.Point(127, 9);
            this.task1Lb.Name = "task1Lb";
            this.task1Lb.Size = new System.Drawing.Size(94, 13);
            this.task1Lb.TabIndex = 0;
            this.task1Lb.Text = "AdaugareOperator";
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Location = new System.Drawing.Point(12, 51);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(55, 13);
            this.usernameLb.TabIndex = 1;
            this.usernameLb.Text = "Username";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(14, 84);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(53, 13);
            this.passwordLb.TabIndex = 2;
            this.passwordLb.Text = "Password";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(14, 115);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(35, 13);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "Name";
            // 
            // usernameTxtB
            // 
            this.usernameTxtB.Location = new System.Drawing.Point(91, 48);
            this.usernameTxtB.Name = "usernameTxtB";
            this.usernameTxtB.Size = new System.Drawing.Size(173, 20);
            this.usernameTxtB.TabIndex = 5;
            // 
            // passwordTxtB
            // 
            this.passwordTxtB.Location = new System.Drawing.Point(91, 84);
            this.passwordTxtB.Name = "passwordTxtB";
            this.passwordTxtB.Size = new System.Drawing.Size(173, 20);
            this.passwordTxtB.TabIndex = 6;
            // 
            // nameTxtB
            // 
            this.nameTxtB.Location = new System.Drawing.Point(91, 115);
            this.nameTxtB.Name = "nameTxtB";
            this.nameTxtB.Size = new System.Drawing.Size(173, 20);
            this.nameTxtB.TabIndex = 7;
            // 
            // AddOperator
            // 
            this.AddOperator.Location = new System.Drawing.Point(323, 82);
            this.AddOperator.Name = "AddOperator";
            this.AddOperator.Size = new System.Drawing.Size(72, 23);
            this.AddOperator.TabIndex = 9;
            this.AddOperator.Text = "Add";
            this.AddOperator.UseVisualStyleBackColor = true;
            this.AddOperator.Click += new System.EventHandler(this.AddOperator_Click);
            // 
            // tabelSpectacole
            // 
            this.tabelSpectacole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelSpectacole.Location = new System.Drawing.Point(450, 12);
            this.tabelSpectacole.Name = "tabelSpectacole";
            this.tabelSpectacole.Size = new System.Drawing.Size(589, 375);
            this.tabelSpectacole.TabIndex = 10;
            this.tabelSpectacole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelSpectacole_CellContentClick);
            // 
            // task2Lb
            // 
            this.task2Lb.AutoSize = true;
            this.task2Lb.Location = new System.Drawing.Point(117, 204);
            this.task2Lb.Name = "task2Lb";
            this.task2Lb.Size = new System.Drawing.Size(115, 13);
            this.task2Lb.TabIndex = 11;
            this.task2Lb.Text = "Gestionare Spectacole";
            // 
            // showSpectacoleBtn
            // 
            this.showSpectacoleBtn.Location = new System.Drawing.Point(291, 241);
            this.showSpectacoleBtn.Name = "showSpectacoleBtn";
            this.showSpectacoleBtn.Size = new System.Drawing.Size(139, 23);
            this.showSpectacoleBtn.TabIndex = 18;
            this.showSpectacoleBtn.Text = "Vizualizare Spectacole";
            this.showSpectacoleBtn.UseVisualStyleBackColor = true;
            this.showSpectacoleBtn.Click += new System.EventHandler(this.showSpectacoleBtn_Click);
            // 
            // dataPremieraTxtB
            // 
            this.dataPremieraTxtB.Location = new System.Drawing.Point(91, 311);
            this.dataPremieraTxtB.Name = "dataPremieraTxtB";
            this.dataPremieraTxtB.Size = new System.Drawing.Size(173, 20);
            this.dataPremieraTxtB.TabIndex = 17;
            // 
            // regizorTxtB
            // 
            this.regizorTxtB.Location = new System.Drawing.Point(91, 280);
            this.regizorTxtB.Name = "regizorTxtB";
            this.regizorTxtB.Size = new System.Drawing.Size(173, 20);
            this.regizorTxtB.TabIndex = 16;
            // 
            // titluTxtB
            // 
            this.titluTxtB.Location = new System.Drawing.Point(91, 244);
            this.titluTxtB.Name = "titluTxtB";
            this.titluTxtB.Size = new System.Drawing.Size(173, 20);
            this.titluTxtB.TabIndex = 15;
            // 
            // dataPremieraLb
            // 
            this.dataPremieraLb.AutoSize = true;
            this.dataPremieraLb.Location = new System.Drawing.Point(11, 314);
            this.dataPremieraLb.Name = "dataPremieraLb";
            this.dataPremieraLb.Size = new System.Drawing.Size(74, 13);
            this.dataPremieraLb.TabIndex = 14;
            this.dataPremieraLb.Text = "Data Premiera";
            // 
            // regizorLb
            // 
            this.regizorLb.AutoSize = true;
            this.regizorLb.Location = new System.Drawing.Point(14, 280);
            this.regizorLb.Name = "regizorLb";
            this.regizorLb.Size = new System.Drawing.Size(43, 13);
            this.regizorLb.TabIndex = 13;
            this.regizorLb.Text = "Regizor";
            // 
            // titluLb
            // 
            this.titluLb.AutoSize = true;
            this.titluLb.Location = new System.Drawing.Point(12, 247);
            this.titluLb.Name = "titluLb";
            this.titluLb.Size = new System.Drawing.Size(27, 13);
            this.titluLb.TabIndex = 12;
            this.titluLb.Text = "Titlu";
            // 
            // actoriLb
            // 
            this.actoriLb.AutoSize = true;
            this.actoriLb.Location = new System.Drawing.Point(23, 362);
            this.actoriLb.Name = "actoriLb";
            this.actoriLb.Size = new System.Drawing.Size(34, 13);
            this.actoriLb.TabIndex = 19;
            this.actoriLb.Text = "Actori";
            // 
            // actoriTxtB
            // 
            this.actoriTxtB.Location = new System.Drawing.Point(91, 347);
            this.actoriTxtB.Multiline = true;
            this.actoriTxtB.Name = "actoriTxtB";
            this.actoriTxtB.Size = new System.Drawing.Size(173, 40);
            this.actoriTxtB.TabIndex = 20;
            // 
            // nrBileteLb
            // 
            this.nrBileteLb.AutoSize = true;
            this.nrBileteLb.Location = new System.Drawing.Point(14, 412);
            this.nrBileteLb.Name = "nrBileteLb";
            this.nrBileteLb.Size = new System.Drawing.Size(66, 13);
            this.nrBileteLb.TabIndex = 21;
            this.nrBileteLb.Text = "Numar bilete";
            // 
            // nrBileteTxtB
            // 
            this.nrBileteTxtB.Location = new System.Drawing.Point(91, 409);
            this.nrBileteTxtB.Name = "nrBileteTxtB";
            this.nrBileteTxtB.Size = new System.Drawing.Size(173, 20);
            this.nrBileteTxtB.TabIndex = 22;
            // 
            // addSpectacolBtn
            // 
            this.addSpectacolBtn.Location = new System.Drawing.Point(291, 275);
            this.addSpectacolBtn.Name = "addSpectacolBtn";
            this.addSpectacolBtn.Size = new System.Drawing.Size(139, 23);
            this.addSpectacolBtn.TabIndex = 23;
            this.addSpectacolBtn.Text = "Adaugare";
            this.addSpectacolBtn.UseVisualStyleBackColor = true;
            this.addSpectacolBtn.Click += new System.EventHandler(this.addSpectacolBtn_Click);
            // 
            // updateSpectacolBtn
            // 
            this.updateSpectacolBtn.Location = new System.Drawing.Point(291, 309);
            this.updateSpectacolBtn.Name = "updateSpectacolBtn";
            this.updateSpectacolBtn.Size = new System.Drawing.Size(139, 23);
            this.updateSpectacolBtn.TabIndex = 24;
            this.updateSpectacolBtn.Text = "Update";
            this.updateSpectacolBtn.UseVisualStyleBackColor = true;
            this.updateSpectacolBtn.Click += new System.EventHandler(this.updateSpectacolBtn_Click);
            // 
            // deleteSpectacolBtn
            // 
            this.deleteSpectacolBtn.Location = new System.Drawing.Point(291, 347);
            this.deleteSpectacolBtn.Name = "deleteSpectacolBtn";
            this.deleteSpectacolBtn.Size = new System.Drawing.Size(139, 23);
            this.deleteSpectacolBtn.TabIndex = 25;
            this.deleteSpectacolBtn.Text = "Delete";
            this.deleteSpectacolBtn.UseVisualStyleBackColor = true;
            this.deleteSpectacolBtn.Click += new System.EventHandler(this.deleteSpectacolBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(678, 402);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(139, 23);
            this.logOutBtn.TabIndex = 26;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 445);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.deleteSpectacolBtn);
            this.Controls.Add(this.updateSpectacolBtn);
            this.Controls.Add(this.addSpectacolBtn);
            this.Controls.Add(this.nrBileteTxtB);
            this.Controls.Add(this.nrBileteLb);
            this.Controls.Add(this.actoriTxtB);
            this.Controls.Add(this.actoriLb);
            this.Controls.Add(this.showSpectacoleBtn);
            this.Controls.Add(this.dataPremieraTxtB);
            this.Controls.Add(this.regizorTxtB);
            this.Controls.Add(this.titluTxtB);
            this.Controls.Add(this.dataPremieraLb);
            this.Controls.Add(this.regizorLb);
            this.Controls.Add(this.titluLb);
            this.Controls.Add(this.task2Lb);
            this.Controls.Add(this.tabelSpectacole);
            this.Controls.Add(this.AddOperator);
            this.Controls.Add(this.nameTxtB);
            this.Controls.Add(this.passwordTxtB);
            this.Controls.Add(this.usernameTxtB);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.task1Lb);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabelSpectacole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task1Lb;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.TextBox usernameTxtB;
        private System.Windows.Forms.TextBox passwordTxtB;
        private System.Windows.Forms.TextBox nameTxtB;
        private System.Windows.Forms.Button AddOperator;
        private System.Windows.Forms.DataGridView tabelSpectacole;
        private System.Windows.Forms.Label task2Lb;
        private System.Windows.Forms.Button showSpectacoleBtn;
        private System.Windows.Forms.TextBox dataPremieraTxtB;
        private System.Windows.Forms.TextBox regizorTxtB;
        private System.Windows.Forms.TextBox titluTxtB;
        private System.Windows.Forms.Label dataPremieraLb;
        private System.Windows.Forms.Label regizorLb;
        private System.Windows.Forms.Label titluLb;
        private System.Windows.Forms.Label actoriLb;
        private System.Windows.Forms.TextBox actoriTxtB;
        private System.Windows.Forms.Label nrBileteLb;
        private System.Windows.Forms.TextBox nrBileteTxtB;
        private System.Windows.Forms.Button addSpectacolBtn;
        private System.Windows.Forms.Button updateSpectacolBtn;
        private System.Windows.Forms.Button deleteSpectacolBtn;
        private System.Windows.Forms.Button logOutBtn;
    }
}