using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Diccionarios_
{
    public partial class ContadorElementos : Form
    {
        public ContadorElementos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listaNumeros = new List<int>();
            //listaNumeros.Add(3);
            //listaNumeros.Add(13);
            //listaNumeros.Add(37);
            //listaNumeros.Add(123);
            listaNumeros.AddRange(new int[] { 1,11,2,3,3,4,5,8,8,9,7,11});
            //int[] arreglo = new int[] { 2,2,2,2,2,2,22};

            //Implemnetnat metodo
            ImprimirLista<int>(listaNumeros);

            ICollection<int> datosUnicos = EnviarGrupos<int>(listaNumeros);
            ImprimirLista<int>(datosUnicos);

            //contar grupos

        }

        /// <summary>
        /// Metodo para agrupar los valores contenidos en  la lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <returns></returns>
        static ICollection<T> EnviarGrupos<T>(ICollection<T> lista) {

            Dictionary<T, bool> buscarElemento = new Dictionary<T, bool>();
            List<T> unicos = new List<T>();
            //leer la lista en el orden original de los datos crgados
            foreach (T valorRetorno in lista)
            {
                if (!buscarElemento.ContainsKey(valorRetorno))
                {
                    buscarElemento[valorRetorno] = true;
                    unicos.Add(valorRetorno);
                }
            }
            return unicos;
        }
        
        /// <summary>
        /// Método para impirimir una lista que contiene un arreglo desparametrizado. UMR
        /// </summary>
        /// <typeparam name="T">t. tipo de dato de retorno de la lista</typeparam>
        /// <param name="lista">list: lista en la que se leeran los elementos.</param>
        static void ImprimirLista<T>(ICollection<T> lista) {
            foreach (T valorREtornoLista in lista)
            {
                string msg = string.Format("Resultado: {0} ", valorREtornoLista.ToString());
                MessageBox.Show(msg);
            }
        }
    }
}
