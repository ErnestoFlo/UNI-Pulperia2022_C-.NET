using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PulperiaPY.bitacoraController;

namespace PulperiaPY
{
    public partial class Bitacora : Form
    {
        bitacoraController bitacoraController;
        int userId;
        string actionType;
        DataTable srcDGV;
        public Bitacora()
        {
            InitializeComponent();
            this.bitacoraController = new bitacoraController();
            this.userId = 0;
            this.actionType = "None";
            this.srcDGV = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.actionType = "Update";
            Bitacora_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.actionType = "Delete";
            Bitacora_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.actionType = "Insert";
            Bitacora_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.actionType = "None";
            cmbUser.SelectedIndex = -1;
            Bitacora_Load(sender, e);
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {

            DataTable srcDGV = bitacoraController.getBitacora(this.userId, this.actionType);
            if (cmbUser.Items.Count <= 1)
            {

                DataTable srcCmb = bitacoraController.getUsers();
                cmbUser.DisplayMember = "username";
                cmbUser.ValueMember = "idUsuario";
                cmbUser.DataSource = srcCmb;
                cmbUser.SelectedIndex = -1;

            }
            dgvBitacora.DataSource = null;
            dgvBitacora.Refresh();

            dgvBitacora.DataSource = srcDGV;
            this.srcDGV = srcDGV;
            dgvBitacora.Refresh();



        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == -1)
                this.userId = 0;
            else
                this.userId = (int)cmbUser.SelectedValue;
            Bitacora_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dvLog = this.srcDGV.DefaultView;
            try { 
            
                dvLog.RowFilter = "name like '%" + txtSearch.Text + "%'";
                if (dvLog.Count <= 0)
                    dvLog.RowFilter = "accionRealizada like '%" + txtSearch.Text + "%'";
                if (dvLog.Count <= 0)
                    dvLog.RowFilter = "fechaYHora = " + Convert.ToDateTime(txtSearch.Text);
             
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
                dvLog.RowFilter = "";
            }


        }
    }
}
