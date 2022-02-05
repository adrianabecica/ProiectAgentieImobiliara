
namespace InterfataUtilizator_WindowsForms
{
    partial class PaginaLogare
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.butIntoarcere = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.butLogin);
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.lblParola);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.lblNume);
            this.groupBox1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(68, 151);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 41);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(79, 97);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 41);
            this.txtParola.TabIndex = 3;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(16, 100);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(61, 37);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(79, 36);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 41);
            this.txtNume.TabIndex = 1;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(16, 39);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(58, 37);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // butIntoarcere
            // 
            this.butIntoarcere.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butIntoarcere.Location = new System.Drawing.Point(32, 278);
            this.butIntoarcere.Name = "butIntoarcere";
            this.butIntoarcere.Size = new System.Drawing.Size(221, 41);
            this.butIntoarcere.TabIndex = 5;
            this.butIntoarcere.Text = "Pagina Principala";
            this.butIntoarcere.UseVisualStyleBackColor = true;
            this.butIntoarcere.Click += new System.EventHandler(this.butIntoarcere_Click);
            // 
            // PaginaLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.logare;
            this.ClientSize = new System.Drawing.Size(279, 368);
            this.Controls.Add(this.butIntoarcere);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "PaginaLogare";
            this.Text = "PaginaLogare";
            this.Load += new System.EventHandler(this.PaginaLogare_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox txtParola;
        internal System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtNume;
        internal System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button butIntoarcere;
    }
}