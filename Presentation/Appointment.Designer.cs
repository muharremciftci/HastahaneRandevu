namespace Presentation
{
    partial class Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.gridDoctor = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.cmbClinic = new System.Windows.Forms.ComboBox();
            this.cmbSemtPoliclinic = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbInspectionLocation = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbTown = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearchAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnENabız = new System.Windows.Forms.Button();
            this.btnAppointmentHistory = new System.Windows.Forms.Button();
            this.flwSession = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDoctor
            // 
            this.gridDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoctor.Location = new System.Drawing.Point(7, 538);
            this.gridDoctor.MultiSelect = false;
            this.gridDoctor.Name = "gridDoctor";
            this.gridDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDoctor.Size = new System.Drawing.Size(823, 229);
            this.gridDoctor.TabIndex = 3;
            this.gridDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDoctor_CellContentClick);
            this.gridDoctor.Click += new System.EventHandler(this.gridDoctor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Merkezi Hekim Randevu Sistemi";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(11, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 26);
            this.label9.TabIndex = 7;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbHospital
            // 
            this.cmbHospital.Enabled = false;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(128, 146);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(223, 21);
            this.cmbHospital.TabIndex = 0;
            this.cmbHospital.SelectedIndexChanged += new System.EventHandler(this.cmbHospital_SelectedIndexChanged);
            this.cmbHospital.Click += new System.EventHandler(this.cmbHospital_Click);
            // 
            // cmbClinic
            // 
            this.cmbClinic.Enabled = false;
            this.cmbClinic.FormattingEnabled = true;
            this.cmbClinic.Location = new System.Drawing.Point(128, 119);
            this.cmbClinic.Name = "cmbClinic";
            this.cmbClinic.Size = new System.Drawing.Size(223, 21);
            this.cmbClinic.TabIndex = 0;
            this.cmbClinic.SelectedIndexChanged += new System.EventHandler(this.cmbClinic_SelectedIndexChanged);
            this.cmbClinic.Click += new System.EventHandler(this.cmbClinic_Click);
            // 
            // cmbSemtPoliclinic
            // 
            this.cmbSemtPoliclinic.Enabled = false;
            this.cmbSemtPoliclinic.FormattingEnabled = true;
            this.cmbSemtPoliclinic.Location = new System.Drawing.Point(128, 174);
            this.cmbSemtPoliclinic.Name = "cmbSemtPoliclinic";
            this.cmbSemtPoliclinic.Size = new System.Drawing.Size(223, 21);
            this.cmbSemtPoliclinic.TabIndex = 0;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(128, 64);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(223, 21);
            this.cmbCity.TabIndex = 0;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            this.cmbCity.Click += new System.EventHandler(this.cmbCity_Click);
            // 
            // cmbInspectionLocation
            // 
            this.cmbInspectionLocation.Enabled = false;
            this.cmbInspectionLocation.FormattingEnabled = true;
            this.cmbInspectionLocation.Location = new System.Drawing.Point(128, 201);
            this.cmbInspectionLocation.Name = "cmbInspectionLocation";
            this.cmbInspectionLocation.Size = new System.Drawing.Size(223, 21);
            this.cmbInspectionLocation.TabIndex = 0;
            this.cmbInspectionLocation.Click += new System.EventHandler(this.cmbInspectionLocation_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Enabled = false;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(128, 228);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(223, 21);
            this.cmbDoctor.TabIndex = 0;
            this.cmbDoctor.Click += new System.EventHandler(this.cmbDoctor_Click);
            // 
            // cmbTown
            // 
            this.cmbTown.Enabled = false;
            this.cmbTown.FormattingEnabled = true;
            this.cmbTown.Location = new System.Drawing.Point(128, 92);
            this.cmbTown.Name = "cmbTown";
            this.cmbTown.Size = new System.Drawing.Size(223, 21);
            this.cmbTown.TabIndex = 0;
            this.cmbTown.Click += new System.EventHandler(this.cmbTown_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 28);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchAppointment
            // 
            this.btnSearchAppointment.Location = new System.Drawing.Point(223, 268);
            this.btnSearchAppointment.Name = "btnSearchAppointment";
            this.btnSearchAppointment.Size = new System.Drawing.Size(127, 28);
            this.btnSearchAppointment.TabIndex = 2;
            this.btnSearchAppointment.Text = "Randevu Ara";
            this.btnSearchAppointment.UseVisualStyleBackColor = true;
            this.btnSearchAppointment.Click += new System.EventHandler(this.btnSearchAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İl Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İlçe Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Klinik Seçiniz :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hastahane Seçiniz : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Semt Poliklinik Seçiniz :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Muayene yeri Seçiniz :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hekim Seçiniz :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(128, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(223, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "HASTANE RANDEVU ARAMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchAppointment);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbTown);
            this.groupBox1.Controls.Add(this.cmbDoctor);
            this.groupBox1.Controls.Add(this.cmbInspectionLocation);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.cmbSemtPoliclinic);
            this.groupBox1.Controls.Add(this.cmbClinic);
            this.groupBox1.Controls.Add(this.cmbHospital);
            this.groupBox1.Location = new System.Drawing.Point(7, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(726, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 102);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(752, 138);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Click += new System.EventHandler(this.label12_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(434, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Soru ve sorunlarınız için yardimmasasi@mhrs.gov.tr adresimizi kullanarak bize ula" +
    "şabilirsiniz.";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(723, 181);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(0, 13);
            this.lblTimeNow.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnENabız);
            this.groupBox2.Controls.Add(this.btnAppointmentHistory);
            this.groupBox2.Location = new System.Drawing.Point(7, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 67);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(693, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 33);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnENabız
            // 
            this.btnENabız.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnENabız.BackgroundImage")));
            this.btnENabız.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnENabız.Location = new System.Drawing.Point(147, 19);
            this.btnENabız.Name = "btnENabız";
            this.btnENabız.Size = new System.Drawing.Size(97, 33);
            this.btnENabız.TabIndex = 19;
            this.btnENabız.UseVisualStyleBackColor = true;
            this.btnENabız.Click += new System.EventHandler(this.btnENabız_Click);
            // 
            // btnAppointmentHistory
            // 
            this.btnAppointmentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppointmentHistory.Location = new System.Drawing.Point(19, 19);
            this.btnAppointmentHistory.Name = "btnAppointmentHistory";
            this.btnAppointmentHistory.Size = new System.Drawing.Size(122, 33);
            this.btnAppointmentHistory.TabIndex = 17;
            this.btnAppointmentHistory.Text = "Randevu Geçmişi";
            this.btnAppointmentHistory.UseVisualStyleBackColor = true;
            this.btnAppointmentHistory.Click += new System.EventHandler(this.btnAppointmentHistory_Click);
            // 
            // flwSession
            // 
            this.flwSession.Location = new System.Drawing.Point(382, 226);
            this.flwSession.Name = "flwSession";
            this.flwSession.Size = new System.Drawing.Size(448, 267);
            this.flwSession.TabIndex = 20;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 741);
            this.Controls.Add(this.flwSession);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridDoctor);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridDoctor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.ComboBox cmbClinic;
        private System.Windows.Forms.ComboBox cmbSemtPoliclinic;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbInspectionLocation;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbTown;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearchAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnENabız;
        private System.Windows.Forms.Button btnAppointmentHistory;
        private System.Windows.Forms.FlowLayoutPanel flwSession;
    }
}