using System;
//Estucttas de datos: Arreglos, Listas, Diccionarios...
using System.Collections.Generic;  
using System.Windows.Forms;
using System.Drawing;

namespace ED_Diccionarios_
{
    public partial class Form1 : Form
    {
        //Declaracion global del diccionario
        //Intrfaz - Interface
        IDictionary<string, string> diccionarioAlumnos = new Dictionary<string, string>();       
        
        public Form1()
        {
            InitializeComponent();        
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string value;
            try
            {
                if (diccionarioAlumnos.ContainsKey(txtKey.Text) == true)//true | false
                {
                    diccionarioAlumnos.TryGetValue(txtKey.Text, out value);
                    MessageBox.Show(" Datos encontrado" , "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    txtValue.Text = value;                  
                }
                else
                {
                    MessageBox.Show(" Dato no encontrado, revisa la matricula ingresada", "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKey.Text = string.Empty;
                    txtValue.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar elementos al diccionario
            //DAr un aviso cuando se cargó el Key
            try
            {
                diccionarioAlumnos.Add(txtKey.Text, txtValue.Text);
                MessageBox.Show(" Datos guardados con exito.", "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                         
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Modificar un elemento del diccionario
            try
            {
                diccionarioAlumnos[txtKey.Text] = txtValue.Text;
                MessageBox.Show(" Datos actualizados con exito.", "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Diccionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        private void btnMostrarContenidop_Click(object sender, EventArgs e)
        {
            //Mostrar los elementos del Dictionary
            //For, While - Foreach
            listBox1.Items.Clear();
            foreach (KeyValuePair<string,string> resultadosDiccionario in diccionarioAlumnos)
            {
                string resultadoPorVuelta = string.Format("Resultado encontrado: \n Key: {0}. \n Value: {1}", resultadosDiccionario.Key, resultadosDiccionario.Value);
                //MessageBox.Show(resultadoPorVuelta);
                listBox1.Items.Add(resultadoPorVuelta);
            }
           
        }
    }
}
