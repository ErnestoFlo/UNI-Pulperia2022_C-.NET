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
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace PulperiaPY
{
    public partial class ReporteVentas : Form
    {
        Conexion conexion = new Conexion();
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlDataAdapter da = new SqlDataAdapter("consultaVentaPorRangoFecha", cn);
                DataTable dt = new DataTable();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@fechaInicial", SqlDbType.DateTime).Value = Convert.ToDateTime(dateTimePicker1.Text);
                da.SelectCommand.Parameters.Add("@fechaFinal", SqlDbType.DateTime).Value = Convert.ToDateTime(dateTimePicker2.Text);

                da.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("DataSet", dt);
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.LocalReport.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ----->", ex);
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
