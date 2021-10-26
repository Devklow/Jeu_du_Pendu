
namespace TestGraphique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxEntry = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblWTF = new System.Windows.Forms.Label();
            this.lblWordToFind = new System.Windows.Forms.Label();
            this.lblAlreadyGivenLetters = new System.Windows.Forms.Label();
            this.lblAGL = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pbxPendu = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGG = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(295, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Jeu du Pendu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxEntry
            // 
            this.tbxEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxEntry.BackColor = System.Drawing.SystemColors.Window;
            this.tbxEntry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEntry.ForeColor = System.Drawing.Color.Black;
            this.tbxEntry.HideSelection = false;
            this.tbxEntry.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbxEntry.Location = new System.Drawing.Point(527, 263);
            this.tbxEntry.MaxLength = 15;
            this.tbxEntry.Name = "tbxEntry";
            this.tbxEntry.ShortcutsEnabled = false;
            this.tbxEntry.Size = new System.Drawing.Size(300, 38);
            this.tbxEntry.TabIndex = 2;
            this.tbxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(521, 219);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(191, 32);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Entrez le mot :";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWTF
            // 
            this.lblWTF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWTF.AutoSize = true;
            this.lblWTF.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWTF.Location = new System.Drawing.Point(476, 123);
            this.lblWTF.Name = "lblWTF";
            this.lblWTF.Size = new System.Drawing.Size(411, 36);
            this.lblWTF.TabIndex = 4;
            this.lblWTF.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            this.lblWTF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblWTF.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWordToFind
            // 
            this.lblWordToFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWordToFind.AutoSize = true;
            this.lblWordToFind.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToFind.Location = new System.Drawing.Point(477, 83);
            this.lblWordToFind.Name = "lblWordToFind";
            this.lblWordToFind.Size = new System.Drawing.Size(173, 27);
            this.lblWordToFind.TabIndex = 5;
            this.lblWordToFind.Text = "Mot à trouver : ";
            this.lblWordToFind.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAlreadyGivenLetters
            // 
            this.lblAlreadyGivenLetters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlreadyGivenLetters.AutoSize = true;
            this.lblAlreadyGivenLetters.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyGivenLetters.Location = new System.Drawing.Point(476, 387);
            this.lblAlreadyGivenLetters.Name = "lblAlreadyGivenLetters";
            this.lblAlreadyGivenLetters.Size = new System.Drawing.Size(286, 32);
            this.lblAlreadyGivenLetters.TabIndex = 6;
            this.lblAlreadyGivenLetters.Text = "Lettres déjà données :";
            // 
            // lblAGL
            // 
            this.lblAGL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAGL.AutoSize = true;
            this.lblAGL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGL.Location = new System.Drawing.Point(478, 425);
            this.lblAGL.Name = "lblAGL";
            this.lblAGL.Size = new System.Drawing.Size(23, 24);
            this.lblAGL.TabIndex = 7;
            this.lblAGL.Text = "A";
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(610, 316);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(136, 38);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // pbxPendu
            // 
            this.pbxPendu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxPendu.Image = global::TestGraphique.Properties.Resources.dpendu0;
            this.pbxPendu.Location = new System.Drawing.Point(-2, -1);
            this.pbxPendu.Name = "pbxPendu";
            this.pbxPendu.Size = new System.Drawing.Size(465, 513);
            this.pbxPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPendu.TabIndex = 0;
            this.pbxPendu.TabStop = false;
            this.pbxPendu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Image = global::TestGraphique.Properties.Resources.dreset;
            this.btnReset.Location = new System.Drawing.Point(801, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblGG
            // 
            this.lblGG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGG.AutoSize = true;
            this.lblGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGG.Location = new System.Drawing.Point(528, 240);
            this.lblGG.Name = "lblGG";
            this.lblGG.Size = new System.Drawing.Size(299, 73);
            this.lblGG.TabIndex = 10;
            this.lblGG.Text = "GAGNÉ !";
            // 
            // btnMode
            // 
            this.btnMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMode.Image = global::TestGraphique.Properties.Resources.lightmode;
            this.btnMode.Location = new System.Drawing.Point(847, 12);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(40, 40);
            this.btnMode.TabIndex = 11;
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(905, 515);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblGG);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblAGL);
            this.Controls.Add(this.lblAlreadyGivenLetters);
            this.Controls.Add(this.lblWordToFind);
            this.Controls.Add(this.lblWTF);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbxEntry);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxPendu);
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.Name = "Form1";
            this.Text = "Jeu du Pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxEntry;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblWordToFind;
        private System.Windows.Forms.Label lblAlreadyGivenLetters;
        private System.Windows.Forms.Label lblAGL;
        private System.Windows.Forms.Label lblWTF;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGG;
        private System.Windows.Forms.PictureBox pbxPendu;
        private System.Windows.Forms.Button btnMode;
    }
}

