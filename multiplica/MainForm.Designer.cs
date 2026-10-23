/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC07
 * Fecha: 23/10/2026
 * Hora: 07:35 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace multiplica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(37, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa el segundo  numero:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(37, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingresa el primer  numero:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(126, 105);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(101, 47);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(221, 34);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 3;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(221, 63);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 4;
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(62, 174);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(215, 23);
			this.lblResultado.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 261);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "multiplica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
