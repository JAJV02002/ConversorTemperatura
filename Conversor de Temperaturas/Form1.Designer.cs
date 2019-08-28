namespace Conversor_de_Temperaturas
{
    partial class Weather
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCentigrados = new System.Windows.Forms.TextBox();
            this.TxtFarenheit = new System.Windows.Forms.TextBox();
            this.LbCentigrados = new System.Windows.Forms.Label();
            this.LbFarenheit = new System.Windows.Forms.Label();
            this.BttnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCentigrados
            // 
            this.TxtCentigrados.Location = new System.Drawing.Point(87, 60);
            this.TxtCentigrados.Name = "TxtCentigrados";
            this.TxtCentigrados.Size = new System.Drawing.Size(380, 22);
            this.TxtCentigrados.TabIndex = 0;
            // 
            // TxtFarenheit
            // 
            this.TxtFarenheit.Location = new System.Drawing.Point(87, 163);
            this.TxtFarenheit.Name = "TxtFarenheit";
            this.TxtFarenheit.Size = new System.Drawing.Size(380, 22);
            this.TxtFarenheit.TabIndex = 1;
            // 
            // LbCentigrados
            // 
            this.LbCentigrados.AutoSize = true;
            this.LbCentigrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCentigrados.Location = new System.Drawing.Point(507, 60);
            this.LbCentigrados.Name = "LbCentigrados";
            this.LbCentigrados.Size = new System.Drawing.Size(187, 25);
            this.LbCentigrados.TabIndex = 2;
            this.LbCentigrados.Text = "Grados Centigrados";
            // 
            // LbFarenheit
            // 
            this.LbFarenheit.AutoSize = true;
            this.LbFarenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFarenheit.Location = new System.Drawing.Point(507, 160);
            this.LbFarenheit.Name = "LbFarenheit";
            this.LbFarenheit.Size = new System.Drawing.Size(163, 25);
            this.LbFarenheit.TabIndex = 3;
            this.LbFarenheit.Text = "Grados Farenheit";
            // 
            // BttnConvertir
            // 
            this.BttnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnConvertir.Location = new System.Drawing.Point(179, 208);
            this.BttnConvertir.Name = "BttnConvertir";
            this.BttnConvertir.Size = new System.Drawing.Size(176, 42);
            this.BttnConvertir.TabIndex = 4;
            this.BttnConvertir.Text = "Convertir";
            this.BttnConvertir.UseVisualStyleBackColor = true;
            this.BttnConvertir.Click += new System.EventHandler(this.BttnConvertir_Click);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.BttnConvertir);
            this.Controls.Add(this.LbFarenheit);
            this.Controls.Add(this.LbCentigrados);
            this.Controls.Add(this.TxtFarenheit);
            this.Controls.Add(this.TxtCentigrados);
            this.Name = "Weather";
            this.Text = "Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCentigrados;
        private System.Windows.Forms.TextBox TxtFarenheit;
        private System.Windows.Forms.Label LbCentigrados;
        private System.Windows.Forms.Label LbFarenheit;
        private System.Windows.Forms.Button BttnConvertir;
    }
}

