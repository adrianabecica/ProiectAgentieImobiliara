
namespace InterfataUtilizator_WindowsForms
{
    partial class FormDestinatie
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
            this.lstImobiliare = new System.Windows.Forms.ListBox();
            this.butAfisareOferta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstImobiliare
            // 
            this.lstImobiliare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lstImobiliare.FormattingEnabled = true;
            this.lstImobiliare.ItemHeight = 16;
            this.lstImobiliare.Location = new System.Drawing.Point(314, 27);
            this.lstImobiliare.Name = "lstImobiliare";
            this.lstImobiliare.Size = new System.Drawing.Size(826, 292);
            this.lstImobiliare.TabIndex = 23;
            // 
            // butAfisareOferta
            // 
            this.butAfisareOferta.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butAfisareOferta.Location = new System.Drawing.Point(70, 83);
            this.butAfisareOferta.Name = "butAfisareOferta";
            this.butAfisareOferta.Size = new System.Drawing.Size(152, 42);
            this.butAfisareOferta.TabIndex = 24;
            this.butAfisareOferta.Text = "Afisare oferte";
            this.butAfisareOferta.UseVisualStyleBackColor = true;
            this.butAfisareOferta.Click += new System.EventHandler(this.butAfisareOferta_Click);
            // 
            // FormDestinatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.butAfisareOferta);
            this.Controls.Add(this.lstImobiliare);
            this.Name = "FormDestinatie";
            this.Text = "FormDestinatie";
            this.Load += new System.EventHandler(this.FormDestinatie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstImobiliare;
        private System.Windows.Forms.Button butAfisareOferta;
    }
}