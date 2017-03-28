using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtSystolic_Enter(object sender, EventArgs e)
        {
            if (txtSystolic.Text == "Systolic")
            {
                txtSystolic.Text = "";
                txtSystolic.ForeColor = Color.LightSeaGreen;

            }
        }

        private void txtSystolic_Leave(object sender, EventArgs e)
        {
            if (txtSystolic.Text == "")
            {
                txtSystolic.Text = "Systolic";
                txtSystolic.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txtDiastolic_Enter(object sender, EventArgs e)
        {
            if (txtDiastolic.Text == "Diastolic")
            {
                txtDiastolic.Text = "";
                txtDiastolic.ForeColor = Color.LightSeaGreen;

            }
        }

        private void txtDiastolic_Leave(object sender, EventArgs e)
        {
            if (txtDiastolic.Text == "")
            {
                txtDiastolic.Text = "Diastolic";
                txtDiastolic.ForeColor = Color.LightSeaGreen;
            }
        }

        private void chkTest9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTest10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTest2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTest3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTest1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form2 NewForm = new Form2();
            NewForm.Show();
            this.Dispose(false);
        }

        private void radTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (radTrue.Checked == true)
            {
                lblbed.Visible = true;
                comboBed_No.Visible = true;
                lblcheckin.Visible = true;
                lblcheckout.Visible = true;
                datetimeIN.Visible = true;
                datetimeOUT.Visible = true;


            }

            else
            {
                lblbed.Visible = false;
                comboBed_No.Visible = false;
                lblcheckin.Visible = false;
                lblcheckout.Visible = false;
                datetimeIN.Visible = false;
                datetimeOUT.Visible = false;
            }
        }

        private void radFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (radFalse.Checked == true)
            {
                lblbed.Visible = false;
                comboBed_No.Visible = false;
                lblcheckin.Visible = false;
                lblcheckout.Visible = false;
                datetimeIN.Visible = false;
                datetimeOUT.Visible = false;

            }
            else
            {
                lblbed.Visible = true;
                comboBed_No.Visible = true;
                lblcheckin.Visible = true;
                lblcheckout.Visible = true;
                datetimeIN.Visible = true;
                datetimeOUT.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

            
            string connect = "datasource=127.0.0.1;port=3306;username=root;password=;database=darabase";
            string Query = " INSERT INTO diagnosis_details(patient_no, final_diagnosis, doctors_note, symptoms,Symptoms2, Symptoms3, Symptoms4, Symptoms5, checkin_date, checkout_date,Drugs_Administered1, Drugs_Administered2, Drugs_Administered3, Drugs_Administered4, Drugs_Administered5, Dosage1, Dosage2, Dosage3, Dosage4, Dosage5, bed_no) values('" + this.comboPatient_No.Text + "','" + this.txtpatientdiagnosis.Text + "','" + this.txtdoctorsnote.Text + "','" + this.comboBoxSymptoms1.Text + "','" + this.comboBoxSymptoms2.Text + "','" + this.comboBoxSymptoms3.Text + "', '" + this.comboBoxSymptoms4.Text + "','" + this.comboBoxSymptoms5.Text + "', '" + this.datetimeIN.Text + "', '" + this.datetimeOUT.Text + "','" + this.comboDrugs1.Text + "', '" + this.comboDrugs2.Text + "', '" + this.comboDrugs3.Text + "', '" + this.comboDrugs4.Text + "', '" + this.comboDrugs5.Text + "', '" + this.txtdosage1.Text + "', '" + this.txtdosage2.Text + "', '" + this.txtdosage3.Text + "', '" + this.txtdosage4.Text + "', '" + this.txtdosage5.Text + "', '" + this.comboBed_No.Text + "');";
            MySqlConnection connection = new MySqlConnection(connect);
            MySqlCommand Command = new MySqlCommand(Query, connection);
            MySqlDataReader Reader;
            connection.Open();
            Reader = Command.ExecuteReader();
            MessageBox.Show("Save Data to Database? This can not be undone","Save To Database", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            while (Reader.Read())  
            {      
               
            }  
            connection.Close(); 
 
            }  
        catch (Exception ex)  
        {   
            MessageBox.Show(ex.Message);  
      }  
}


        }

    }

