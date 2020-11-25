using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Moreno_Jose
{
    public partial class Form1 : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = SegundoParcial; integrated security= SSPI";
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
                string patente = txt_patente.Text;
                int tipo = cbo_tipo.SelectedIndex;
            if (!campos_vacios(gbo_ingreso))
            {

                
                string horas = txt_horas.Text;
                tipo++;


                string consulta = "INSERT INTO Estacionamiento (Patente,Tipo,horas) values (@patente,@tipo,@horas)";
                int rta;
                SqlCommand comando;
                comando = new SqlCommand(consulta, cn);
                comando.Parameters.AddWithValue("@patente", patente);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@horas", horas);

                cn.Open();
                rta = comando.ExecuteNonQuery();
                cn.Close();
                respuesta_comando(rta, "Vehiculo");
                limpiar_textos(gbo_ingreso);
                carga_grilla();


            }
            else
            {
                mostrar_mensaje("Por favor completar todos los campos");
            }

         
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string consulta = "select count (Tipo) As Tipo from Estacionamiento group by Tipo";


            SqlDataAdapter da;
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            dg_informacion.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                int total = 0;

                for(int i=0; i < dt.Rows.Count; i++)
                {
                    total += Convert.ToInt32(dt.Rows[i][0]);
                }

                lbl_total.Text = Convert.ToString(total);
                lbl_autos.Text = Convert.ToString(dt.Rows[0][0]);
                lbl_motos.Text = Convert.ToString(dt.Rows[1][0]);
                lbl_camionetas.Text = Convert.ToString(dt.Rows[2][0]);
            }
            mayor_patente();
            monto_total();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            cargar_combo();
            carga_grilla();
            int val;
            int tipo1 = cbo_tipo.SelectedIndex;
            val =validar_cantidad(tipo1);
            if(val == 1)
            {
                this.Close();
            }
        }

        // --------------------------Funciones------------------------------//
        private void cargar_combo()
        {
            cbo_tipo.Items.Insert(0, "AUTO");
            cbo_tipo.Items.Insert(1, "MOTO");
            cbo_tipo.Items.Insert(2, "CAMIONETA");

        }
        private void carga_grilla()
        {
            string consulta = "select * from Estacionamiento";
        

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            dg_informacion.DataSource = dt;
        }
        private void mayor_patente()
        {
            string consulta = "select * from Estacionamiento";


            SqlDataAdapter da;
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            int hora,horasdt,posicion;
            hora = 0;
            posicion = 0;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    horasdt = Convert.ToInt32(dt.Rows[i][2]);

                    if (horasdt > hora)
                    {
                        hora = horasdt;
                        posicion = i;
                    }
                }
                lbl_mayor_horas.Text = Convert.ToString(dt.Rows[posicion][0]);
            }
        }
        private int validar_cantidad(int tipo)
        {
            int TIPO = tipo;
            int t1,t2,t3,t4,v;
            v = 0;
            string consulta = "select count(Tipo) from Estacionamiento group by Tipo";


            SqlDataAdapter da;
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            t1 = Convert.ToInt32(dt.Rows[0][0]);
            t2 = Convert.ToInt32(dt.Rows[1][0]);
            t3 = Convert.ToInt32(dt.Rows[2][0]);
            t4 = t1 + t2 + t3;
            if (t4> 10)
            {
                mostrar_mensaje("No se pueden Estacionar Mas Vehiculos");
                v = 1;
            }
            return v;
     

            


        }
        private void monto_total()
        {
            string consulta = "select sum(horas) As Total from Estacionamiento";


            SqlDataAdapter da;
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            int Total;
            Total = 0;
          
            Total = Convert.ToInt32(dt.Rows[0][0]);
            Total = Total * 150;                
            
            lbl_ingresos.Text = Convert.ToString(Total);
        }
        private bool campos_vacios(GroupBox gb)
        {
            bool rta = false;
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if (c.Text == "")
                    {
                        rta = true;
                    }
                }

            }
            return rta;
        }
        private void respuesta_comando(int resultado, string accion)
        {
            if (resultado >= 1)
            {
                mostrar_mensaje(accion + " Ingresado");
            }
            else
            {
                mostrar_mensaje("No se pudo establecer el " + accion);
            }
        }
        private void limpiar_textos(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }
        private void mostrar_mensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
