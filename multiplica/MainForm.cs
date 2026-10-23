/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC07
 * Fecha: 23/10/2026
 * Hora: 07:35 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace multiplica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double num1, num2, multi;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			multi=num1*num2;
			lblResultado.Text=txtNum1.Text+"*"+txtNum2.Text+"= "+Convert.ToString(multi);
		}
	}
}
