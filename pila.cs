using System;

namespace WindowsApplication1
{
	/// <summary>
	///Implementa todos los metodos necesarios para el manejo de pilas
	/// </summary>
	public class pila
	{
		nodo cima;
		public pila()
		{
			cima = null;
		}

		public bool pilaVacia()
		{
			return (cima == null);
		}

		public void push(string dato)
		{
			nodo nuevo = new nodo(dato);
			if(!pilaVacia())
			{
				nuevo.anterior = cima;
				cima.siguiente = nuevo;
			}
			cima = nuevo;
		}//push insertar


		public string verCima()
		{
			string resultado = "";
			if(!pilaVacia())
				resultado = cima.dato;
		
			return resultado;
		}

		public string pop()
		{
			string d;
			if(cima.anterior == null)
			{
				d = cima.dato;
				cima = null;
			}
			else
			{
				d = cima.dato;
				cima = cima.anterior;
				cima.siguiente.anterior = null;
				cima.siguiente = null;
			}
			return d;
		}//pop eliminar

		public void eliminarPila()
		{
			string aux;
			while(!pilaVacia())
				aux = pop();
		}
	}
}
