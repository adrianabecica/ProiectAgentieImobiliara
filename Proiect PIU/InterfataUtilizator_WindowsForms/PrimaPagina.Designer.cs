
namespace InterfataUtilizator_WindowsForms
{
    partial class PrimaPagina
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
            this.butManager = new System.Windows.Forms.Button();
            this.butClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butManager
            // 
            this.butManager.BackColor = System.Drawing.Color.Transparent;
            this.butManager.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butManager.Location = new System.Drawing.Point(172, 69);
            this.butManager.Name = "butManager";
            this.butManager.Size = new System.Drawing.Size(163, 42);
            this.butManager.TabIndex = 0;
            this.butManager.Text = "Manager imobiliare";
            this.butManager.UseVisualStyleBackColor = false;
            this.butManager.Click += new System.EventHandler(this.butManager_Click);
            // 
            // butClient
            // 
            this.butClient.BackColor = System.Drawing.Color.Transparent;
            this.butClient.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butClient.Location = new System.Drawing.Point(415, 69);
            this.butClient.Name = "butClient";
            this.butClient.Size = new System.Drawing.Size(166, 42);
            this.butClient.TabIndex = 1;
            this.butClient.Text = "Client";
            this.butClient.UseVisualStyleBackColor = false;
            this.butClient.Click += new System.EventHandler(this.butClient_Click);
            // 
            // PrimaPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.oras;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.butClient);
            this.Controls.Add(this.butManager);
            this.MaximizeBox = false;
            this.Name = "PrimaPagina";
            this.Text = "PrimaPagina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butManager;
        private System.Windows.Forms.Button butClient;
    }
}