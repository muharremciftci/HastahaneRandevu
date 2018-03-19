using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Appointment : Form
    {
      
        HospitalBusiness _hospitalBusiness;
        PoliclinicBusiness _policlinicBusiness;
        DoctorBusiness _doctorBusiness;
        AppointmentBusiness _appointmentBusiness;
        PatientBusiness _patientBusiness;
   
        private Patient _patient;
        public Appointment(Patient patient)
        {
            InitializeComponent();
        
            _hospitalBusiness = new HospitalBusiness();
            _policlinicBusiness = new PoliclinicBusiness();
            _doctorBusiness = new DoctorBusiness();
            _appointmentBusiness = new AppointmentBusiness();
            _patientBusiness = new PatientBusiness();
            _patient = patient;

            label9.Text = _patient.FirstName + " " + _patient.LastName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           //Burda GroupBox içindeki ComboBoxları gezerek itemlarını temizledim 
            foreach (Control item in groupBox1.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox yeni = (ComboBox)item;
                   
                    if (yeni.Name!="cmbCity")
                    {
                        yeni.Enabled = false;
                    }
                    yeni.DataSource=null;
                }
                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            

            dtpDate.MinDate = DateTime.Now.Date; //Burada geçmiş tarihleri seçmesini engelledim 
            dtpDate.MaxDate = DateTime.Now.AddDays(30);//En fazla 30 gün sonrasına randevu alabilmesini ayarladım
        }

        private void label12_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString() ;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            //cmbTown.DataSource = null;
   
        }

        private void cmbCity_Click(object sender, EventArgs e)
        {
            cmbCity.DataSource = _appointmentBusiness.GetAllCity();
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";
            cmbTown.Enabled = true;
        }

        private void cmbTown_Click(object sender, EventArgs e)
        {
            
            int secili = (int)cmbCity.SelectedValue;
            cmbTown.DataSource = _appointmentBusiness.GetAllTown(secili);
            cmbTown.DisplayMember = "Name";
            cmbTown.ValueMember = "Id";
            cmbClinic.Enabled = true;
        }

        private void cmbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHospital.DataSource = null;
        }

        private void cmbClinic_Click(object sender, EventArgs e)
        {
            cmbClinic.DataSource = _appointmentBusiness.GetAllClinic();
            cmbClinic.DisplayMember = "Name";
            cmbClinic.ValueMember = "Id";
            cmbHospital.Enabled = true;
        }

        private void cmbHospital_Click(object sender, EventArgs e)
        {
            int seciliClinic = (int)cmbClinic.SelectedValue;
            int SeciliTown = (int)cmbTown.SelectedValue;


            cmbHospital.DataSource = _hospitalBusiness.GetByClinic(seciliClinic,SeciliTown);
            cmbHospital.DisplayMember = "HospitalName";
            cmbHospital.ValueMember = "Id";
            cmbInspectionLocation.Enabled = true;
        }

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbInspectionLocation_Click(object sender, EventArgs e)
        {
            int seciliHospital=(int)cmbHospital.SelectedValue;

            cmbInspectionLocation.DataSource = _policlinicBusiness.GetAllPoliclinic(seciliHospital);
            cmbInspectionLocation.DisplayMember = "Name";
            cmbInspectionLocation.ValueMember = "Id";
            cmbDoctor.Enabled = true;
        }

        private void cmbDoctor_Click(object sender, EventArgs e)
        {
            int secili = (int)cmbInspectionLocation.SelectedValue;
            cmbDoctor.DataSource = _doctorBusiness.GetDoctor(secili);
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "Id";
        }

        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            List<Doctor> listDoctor=new List<Doctor>();
            int seciliDoctor= (int)cmbDoctor.SelectedValue;
            if (cmbDoctor.SelectedItem.ToString() == "Farketmez") 
            {

            }
            else
            {
                listDoctor.Add(_doctorBusiness.GetDoctorByID(seciliDoctor));
                gridDoctor.DataSource = listDoctor;
            }
        }

        private void gridDoctor_Click(object sender, EventArgs e)
        {
            Reservation();
            
        }

        public void Reservation()
        {
            flwSession.Controls.Clear();
            int seciliDoctor = (int)gridDoctor.CurrentRow.Cells["Id"].Value;
            List<TimeSpan> seans = _doctorBusiness.GetDurationDoctor(seciliDoctor);
            List<Apointment> listappointment = _appointmentBusiness.GetAllAppointment();
            Button btn;
            Doctor doctor = _doctorBusiness.GetDoctorByID(seciliDoctor);

            for (int i = 0; i < seans.Count; i++)
            {
                btn = new Button();

                btn.Text = seans[i].ToString();
                btn.Width = 43;

                btn.Height = 30;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Tag = seans[i];
                btn.Click += btn_Click;
                btn.BackColor = Color.Green;
                for (int k = 0; k < listappointment.Count; k++)
                {

                    if (listappointment[k].DoktorId == doctor.Id && listappointment[k].Date.Day == dtpDate.Value.Day && listappointment[k].Session.Hours == seans[i].Hours && listappointment[k].Session.Minutes == seans[i].Minutes)
                    {
                        btn.BackColor = Color.Red;
                    }

                }
                flwSession.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<Apointment> listApointment = _patientBusiness.AppointmentHistory(_patient);
            bool control = true;
             int seciliDoctor = (int)gridDoctor.CurrentRow.Cells["Id"].Value;
            Apointment appointment;
            Button secili = sender as Button;
            if (secili.BackColor==Color.Green)
            {
                DialogResult result = MessageBox.Show("Randevuyu gerçekleştirmek istiyor musunuz", "Randevu Alımı", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    foreach (Apointment item in listApointment)
                    {
                        if (item.DoktorId==seciliDoctor && item.Date==dtpDate.Value.Date)
                        {
                            control = false;
                            break;
                        }
                    }

                    if (control)
                    {
                        appointment = new Apointment();
                        appointment.PatientId = _patient.Id;
                        appointment.DoktorId = seciliDoctor;
                        appointment.Date = dtpDate.Value;
                        appointment.Session = (TimeSpan)secili.Tag;
                        appointment.Status = "Randevu Alındı";

                        bool resultappointment = _appointmentBusiness.InsertAppoinment(appointment);
                        if (resultappointment)
                        {
                            MessageBox.Show("Randevu Alındı");
                            Reservation();
                        }
                        else
                        {
                            MessageBox.Show("Randevu Alınamadı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aynı doktordan aynı gün içerisinde birden fazla randevu alamazsınız!");
                    }
                    
                }               
            }
        }

        private void gridDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAppointmentHistory_Click(object sender, EventArgs e)
        {
            AppointmentHistory frm = new AppointmentHistory(_patient);
            frm.Show();
        }

        private void btnENabız_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serverımızda oluşan sıkıntı gereği hizmet veremiyoruz.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
