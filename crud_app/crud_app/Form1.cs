using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace crud_app
{
    public partial class Form1 : Form
    {

        class Patient
        {
            public int id;
            public string name, sex, birthday, allergies;
        }

        class MedicalRecord
        {
            public int id, patient_id;
            public string drugs, description, diagnosis;
        }

        Patient patient;
        MedicalRecord medicalRecord;

        public Form1()
        {
            InitializeComponent();
            patient = new Patient();
            medicalRecord = new MedicalRecord();
            DisplayMedicalRecord();
            DisplayPatient();
            UpdatePatientCB();
        }

        public static SqlConnection koneksi()
        {
            string conn_string = "Data Source=q8iqbal.database.windows.net;Initial Catalog=pemvis;Persist Security Info=True;User ID=iqbal;Password=secret";
            SqlConnection conn = new SqlConnection(conn_string);
            return conn;
        }

        public void GetPatientForm()
        {
            patient.id = int.Parse(tb_id.Text != null? tb_id.Text : "0" );
            patient.name = tb_name.Text;
            patient.sex = cb_sex.Text;
            patient.allergies = tb_allergies.Text;
            patient.birthday = dp_birthday.Text;
            Debug.WriteLine(medicalRecord.patient_id);
        }

        public void GetMedicalForm()
        {
            medicalRecord.id = int.Parse(tb_mr_id.Text != null ? tb_mr_id.Text : "0");
            medicalRecord.patient_id = int.Parse(Regex.Match(cb_mr_patient.Text, @"\d+").Value);
            medicalRecord.diagnosis = tb_mr_diagnosis.Text;
            medicalRecord.drugs = tb_mr_drugs.Text;
            medicalRecord.description = tb_mr_desc.Text;
        }

        /*
         * CRUD table patients
        */

        private void bt_create_Click(object sender, EventArgs e)
        {
            GetPatientForm();
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO pemvis.dbo.Patients (name,birthday,sex,allergies) VALUES('{patient.name}', '{patient.birthday}', '{patient.sex}', '{patient.allergies}') ";
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayPatient();
            UpdatePatientCB();
            DisplayMedicalRecord();
            MessageBox.Show("Data berhasil disimpan");
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            GetPatientForm();
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE patients SET name='{patient.name}' , birthday='{patient.birthday}', sex='{patient.sex}', allergies='{patient.allergies}' WHERE id={patient.id}";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            DisplayPatient();
            UpdatePatientCB();
            DisplayMedicalRecord();
            conn.Close();
            MessageBox.Show("Update data berhasil");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            GetPatientForm();
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM patients WHERE id={patient.id}";
            cmd.ExecuteNonQuery();
            DisplayPatient();
            UpdatePatientCB();
            DisplayMedicalRecord();
            conn.Close();
            MessageBox.Show("Hapus data berhasil");
        }

        private void DisplayPatient()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from Patients";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_table.DataSource = dt;
            conn.Close();
        }

        private void UpdatePatientCB()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT CONCAT(id,' ' ,name) list FROM Patients p ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cb_mr_patient.ValueMember = "list";
            cb_mr_patient.DataSource = dt;
            conn.Close();
        }

        private void dgv_table_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_table.Rows[e.RowIndex];
                tb_id.Text = row.Cells["id"].Value.ToString();
                tb_name.Text = row.Cells["name"].Value.ToString();
                tb_allergies.Text = row.Cells["allergies"].Value.ToString();
                cb_sex.Text = row.Cells["sex"].Value.ToString();
                dp_birthday.Value = DateTime.Parse(row.Cells["birthday"].Value.ToString());
            }
        }


        /*
         * CRUD table medical_records
         */

        private void bt_mr_create_Click(object sender, EventArgs e)
        {
            GetMedicalForm();
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO pemvis.dbo.medical_records (patient_id,drugs,description,diagnosis) VALUES({medicalRecord.patient_id}, '{medicalRecord.drugs}', '{medicalRecord.description}', '{medicalRecord.diagnosis}'); ";
            cmd.ExecuteNonQuery();
            DisplayMedicalRecord();
            conn.Close();
            MessageBox.Show("Data berhasil disimpan");
        }

        private void bt_mr_update_Click(object sender, EventArgs e)
        {
            GetMedicalForm();
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE pemvis.dbo.medical_records SET patient_id = {medicalRecord.patient_id}, drugs='{medicalRecord.drugs}', diagnosis='{medicalRecord.diagnosis}', description = '{medicalRecord.description}' WHERE id = {medicalRecord.id} ";
            cmd.ExecuteNonQuery();
            DisplayMedicalRecord();
            conn.Close();
            MessageBox.Show("Data berhasil disimpan");
        }

        private void bt_mr_delete_Click(object sender, EventArgs e)
        {
            GetMedicalForm();
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM medical_records WHERE id={medicalRecord.id}";
            cmd.ExecuteNonQuery();
            DisplayMedicalRecord();
            conn.Close();
            MessageBox.Show("Data berhasil disimpan");
        }

        private void DisplayMedicalRecord()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM medical_records";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_mr_table.DataSource = dt;
            conn.Close();
        }
        private void dgv_mr_table_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_mr_table.Rows[e.RowIndex];
                tb_mr_id.Text = row.Cells["id"].Value.ToString();
                tb_mr_diagnosis.Text = row.Cells["diagnosis"].Value.ToString();
                tb_mr_drugs.Text = row.Cells["drugs"].Value.ToString();
                tb_mr_desc.Text = row.Cells["description"].Value.ToString();
                cb_mr_patient.SelectedIndex = cb_mr_patient.FindString(row.Cells["patient_id"].Value.ToString());
            }
        }
    }
}
