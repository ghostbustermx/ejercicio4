using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication1
{
	/// <summary>
	/// Descripci�n breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Variable del dise�ador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Necesario para admitir el Dise�ador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar c�digo de constructor despu�s de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region C�digo generado por el Dise�ador de Windows Forms
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicaci�n.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//crea el array de pilas
			pila []ap = new pila[2];
			//crea una pila
			pila p = new pila();
			p.push("pila");
			p.push("primera");
			//crea otra pila
			pila p2 = new pila();
			p2.push("pila");
			p2.push("segunda");
			//asigna las pilas a los campos del array
			ap[0] = p;
			ap[1] = p2;
			//recorre el array
			pila resul;//para almacenar el resultado
			for(int i=0; i<2; i++){//oara cada elemento del array
				resul = ap[i];
				MessageBox.Show("PILA NUMERO :" + i);
				while(!resul.pilaVacia()){//mientras esa pila no este vacia
					MessageBox.Show(resul.pop());
				}
			}
			
		}
	}
}
