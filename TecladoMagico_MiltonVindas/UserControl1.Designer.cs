namespace TecladoMagico_MiltonVindas
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.boxSecuencia = new System.Windows.Forms.TextBox();
            this.boxTexto = new System.Windows.Forms.TextBox();
            this.boxResult = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxSecuencia
            // 
            this.boxSecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSecuencia.Location = new System.Drawing.Point(89, 211);
            this.boxSecuencia.MaximumSize = new System.Drawing.Size(400, 50);
            this.boxSecuencia.MinimumSize = new System.Drawing.Size(280, 32);
            this.boxSecuencia.Name = "boxSecuencia";
            this.boxSecuencia.Size = new System.Drawing.Size(280, 32);
            this.boxSecuencia.TabIndex = 0;
            this.boxSecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxTexto
            // 
            this.boxTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTexto.Location = new System.Drawing.Point(89, 321);
            this.boxTexto.MinimumSize = new System.Drawing.Size(280, 32);
            this.boxTexto.Name = "boxTexto";
            this.boxTexto.Size = new System.Drawing.Size(280, 32);
            this.boxTexto.TabIndex = 1;
            this.boxTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxResult
            // 
            this.boxResult.AutoSize = true;
            this.boxResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.boxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.boxResult.Location = new System.Drawing.Point(184, 511);
            this.boxResult.MaximumSize = new System.Drawing.Size(150, 150);
            this.boxResult.MinimumSize = new System.Drawing.Size(100, 35);
            this.boxResult.Name = "boxResult";
            this.boxResult.Size = new System.Drawing.Size(100, 35);
            this.boxResult.TabIndex = 4;
            this.boxResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTranslate.Location = new System.Drawing.Point(125, 439);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(221, 40);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.Text = "Calcular Movimientos";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.calculateMov);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.boxResult);
            this.Controls.Add(this.boxTexto);
            this.Controls.Add(this.boxSecuencia);
            this.MinimumSize = new System.Drawing.Size(460, 610);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(460, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxSecuencia;
        private System.Windows.Forms.TextBox boxTexto;
        private System.Windows.Forms.Label boxResult;
        private System.Windows.Forms.Button btnTranslate;
    }
}
