namespace ProyectoPruebas
{
    partial class Form1
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
            this.btn_GenReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenReporte
            // 
            this.btn_GenReporte.Location = new System.Drawing.Point(311, 45);
            this.btn_GenReporte.Name = "btn_GenReporte";
            this.btn_GenReporte.Size = new System.Drawing.Size(153, 42);
            this.btn_GenReporte.TabIndex = 0;
            this.btn_GenReporte.Text = "Generar Reporte";
            this.btn_GenReporte.UseVisualStyleBackColor = true;
            this.btn_GenReporte.Click += new System.EventHandler(this.btn_GenReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 127);
            this.Controls.Add(this.btn_GenReporte);
            this.Name = "Form1";
            this.Text = "EjemploImplementacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenReporte;
    }
}

