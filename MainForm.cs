/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 09/08/2022
 * Hora: 21:59
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora_float.Parse_2._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Soma
			int x;
			x=int.Parse(textBox1.Text);
			int xx;
			xx=int.Parse(textBox2.Text);
			int s;
			s=x+xx;
			textBox3.Text=s.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			//Subtração
			int x;
			x=int.Parse(textBox1.Text);
			int xx;
			xx=int.Parse(textBox2.Text);
			int s;
			s=x-xx;
			textBox3.Text=s.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			//Multiplicação
			int x;
			x=int.Parse(textBox1.Text);
			int xx;
			xx=int.Parse(textBox2.Text);
			int s;
			s=x*xx;
			textBox3.Text=s.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
			//Float é para número fracionado. Divisão (até em frações.)
			float x;
			x=float.Parse(textBox1.Text);
			float xx;
			xx=float.Parse(textBox2.Text);
			float s;
			s=x/xx;
			textBox3.Text=s.ToString();
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
