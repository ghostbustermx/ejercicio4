using System;

namespace WindowsApplication1
{
	/// <summary>
	/// Descripci�n breve de nodo.
	/// </summary>
	public class nodo
	{
		//clase que contiene el dato y los enlaces de la pila
		public string dato;
        public nodo anterior, siguiente;
		public nodo(string sDato)
        {
		dato = sDato;
		}
	}
}
