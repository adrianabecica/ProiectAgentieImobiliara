
namespace InterfataUtilizator_WindowsForms
{
    partial class FormBeneficiar
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lstImobiliare = new System.Windows.Forms.ListBox();
            this.butAfisareOferta = new System.Windows.Forms.Button();
            this.butCumpara = new System.Windows.Forms.Button();
            this.butIntoarcere = new System.Windows.Forms.Button();
            this.lbleroareNume = new System.Windows.Forms.Label();
            this.lbleroarePrenume = new System.Windows.Forms.Label();
            this.lbleroareCNP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNume.Location = new System.Drawing.Point(109, 85);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 36);
            this.txtNume.TabIndex = 11;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(9, 88);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(50, 31);
            this.lblNume.TabIndex = 10;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrenume.Location = new System.Drawing.Point(102, 170);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 36);
            this.txtPrenume.TabIndex = 13;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrenume.Location = new System.Drawing.Point(9, 173);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(68, 31);
            this.lblPrenume.TabIndex = 12;
            this.lblPrenume.Text = "Prenume";
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCNP.Location = new System.Drawing.Point(109, 258);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(100, 36);
            this.txtCNP.TabIndex = 15;
            this.txtCNP.TextChanged += new System.EventHandler(this.txtCNP_TextChanged);
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCNP.Location = new System.Drawing.Point(17, 263);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(41, 31);
            this.lblCNP.TabIndex = 14;
            this.lblCNP.Text = "CNP";
            // 
            // lstImobiliare
            // 
            this.lstImobiliare.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstImobiliare.FormattingEnabled = true;
            this.lstImobiliare.ItemHeight = 31;
            this.lstImobiliare.Location = new System.Drawing.Point(215, 62);
            this.lstImobiliare.Name = "lstImobiliare";
            this.lstImobiliare.Size = new System.Drawing.Size(798, 283);
            this.lstImobiliare.TabIndex = 23;
            // 
            // butAfisareOferta
            // 
            this.butAfisareOferta.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butAfisareOferta.Location = new System.Drawing.Point(380, 351);
            this.butAfisareOferta.Name = "butAfisareOferta";
            this.butAfisareOferta.Size = new System.Drawing.Size(152, 42);
            this.butAfisareOferta.TabIndex = 24;
            this.butAfisareOferta.Text = "Afisare oferte";
            this.butAfisareOferta.UseVisualStyleBackColor = true;
            this.butAfisareOferta.Click += new System.EventHandler(this.butAfisareOferta_Click_1);
            // 
            // butCumpara
            // 
            this.butCumpara.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butCumpara.Location = new System.Drawing.Point(649, 351);
            this.butCumpara.Name = "butCumpara";
            this.butCumpara.Size = new System.Drawing.Size(152, 42);
            this.butCumpara.TabIndex = 25;
            this.butCumpara.Text = "Cumparare";
            this.butCumpara.UseVisualStyleBackColor = true;
            this.butCumpara.Click += new System.EventHandler(this.butCumpara_Click);
            // 
            // butIntoarcere
            // 
            this.butIntoarcere.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butIntoarcere.Location = new System.Drawing.Point(838, 456);
            this.butIntoarcere.Name = "butIntoarcere";
            this.butIntoarcere.Size = new System.Drawing.Size(142, 41);
            this.butIntoarcere.TabIndex = 42;
            this.butIntoarcere.Text = "Pagina Principala";
            this.butIntoarcere.UseVisualStyleBackColor = true;
            this.butIntoarcere.Click += new System.EventHandler(this.butIntoarcere_Click);
            // 
            // lbleroareNume
            // 
            this.lbleroareNume.AutoSize = true;
            this.lbleroareNume.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbleroareNume.ForeColor = System.Drawing.Color.Red;
            this.lbleroareNume.Location = new System.Drawing.Point(21, 128);
            this.lbleroareNume.Name = "lbleroareNume";
            this.lbleroareNume.Size = new System.Drawing.Size(188, 31);
            this.lbleroareNume.TabIndex = 43;
            this.lbleroareNume.Text = "SE INTODUC DOAR LITERE";
            this.lbleroareNume.Visible = false;
            // 
            // lbleroarePrenume
            // 
            this.lbleroarePrenume.AutoSize = true;
            this.lbleroarePrenume.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbleroarePrenume.ForeColor = System.Drawing.Color.Red;
            this.lbleroarePrenume.Location = new System.Drawing.Point(21, 229);
            this.lbleroarePrenume.Name = "lbleroarePrenume";
            this.lbleroarePrenume.Size = new System.Drawing.Size(188, 31);
            this.lbleroarePrenume.TabIndex = 44;
            this.lbleroarePrenume.Text = "SE INTODUC DOAR LITERE";
            this.lbleroarePrenume.Visible = false;
            // 
            // lbleroareCNP
            // 
            this.lbleroareCNP.AutoSize = true;
            this.lbleroareCNP.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbleroareCNP.ForeColor = System.Drawing.Color.Red;
            this.lbleroareCNP.Location = new System.Drawing.Point(21, 314);
            this.lbleroareCNP.Name = "lbleroareCNP";
            this.lbleroareCNP.Size = new System.Drawing.Size(181, 31);
            this.lbleroareCNP.TabIndex = 45;
            this.lbleroareCNP.Text = "SE INTODUC DOAR CIFRE";
            this.lbleroareCNP.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cumparare imobiliare";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormBeneficiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.orasb;
            this.ClientSize = new System.Drawing.Size(1040, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbleroareCNP);
            this.Controls.Add(this.lbleroarePrenume);
            this.Controls.Add(this.lbleroareNume);
            this.Controls.Add(this.butIntoarcere);
            this.Controls.Add(this.butCumpara);
            this.Controls.Add(this.butAfisareOferta);
            this.Controls.Add(this.lstImobiliare);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.MaximizeBox = false;
            this.Name = "FormBeneficiar";
            this.Text = "FormBeneficiar";
            this.Load += new System.EventHandler(this.FormBeneficiar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.ListBox lstImobiliare;
        private System.Windows.Forms.Button butAfisareOferta;
        private System.Windows.Forms.Button butCumpara;
        private System.Windows.Forms.Button butIntoarcere;
        private System.Windows.Forms.Label lbleroareNume;
        private System.Windows.Forms.Label lbleroarePrenume;
        private System.Windows.Forms.Label lbleroareCNP;
        private System.Windows.Forms.Label label1;
    }
}