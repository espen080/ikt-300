﻿namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_serialno = new System.Windows.Forms.Label();
            this.tbx_serialno = new System.Windows.Forms.TextBox();
            this.lbl_nom_volt = new System.Windows.Forms.Label();
            this.tbx_nom_volt = new System.Windows.Forms.TextBox();
            this.tbx_set_volt = new System.Windows.Forms.TextBox();
            this.btn_set_volt = new System.Windows.Forms.Button();
            this.tbx_get_volt = new System.Windows.Forms.TextBox();
            this.btn_get_volt = new System.Windows.Forms.Button();
            this.tbx_nom_watt = new System.Windows.Forms.TextBox();
            this.lbl_nom_watt = new System.Windows.Forms.Label();
            this.tbx_device_type = new System.Windows.Forms.TextBox();
            this.lbl_device_type = new System.Windows.Forms.Label();
            this.tbx_articleno = new System.Windows.Forms.TextBox();
            this.lbl_articleno = new System.Windows.Forms.Label();
            this.tbx_manufacturer = new System.Windows.Forms.TextBox();
            this.lbl_manufacturer = new System.Windows.Forms.Label();
            this.tbx_version = new System.Windows.Forms.TextBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.grp_device_info = new System.Windows.Forms.GroupBox();
            this.grp_remote = new System.Windows.Forms.GroupBox();
            this.cbx_remote_control = new System.Windows.Forms.CheckBox();
            this.grp_volt = new System.Windows.Forms.GroupBox();
            this.grp_watt = new System.Windows.Forms.GroupBox();
            this.btn_get_watt = new System.Windows.Forms.Button();
            this.tbx_set_watt = new System.Windows.Forms.TextBox();
            this.btn_set_watt = new System.Windows.Forms.Button();
            this.tbx_get_watt = new System.Windows.Forms.TextBox();
            this.gbx_power = new System.Windows.Forms.GroupBox();
            this.cbx_power_out = new System.Windows.Forms.CheckBox();
            this.gbx_com = new System.Windows.Forms.GroupBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.grp_device_info.SuspendLayout();
            this.grp_remote.SuspendLayout();
            this.grp_volt.SuspendLayout();
            this.grp_watt.SuspendLayout();
            this.gbx_power.SuspendLayout();
            this.gbx_com.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_serialno
            // 
            this.lbl_serialno.AutoSize = true;
            this.lbl_serialno.Location = new System.Drawing.Point(75, 61);
            this.lbl_serialno.Name = "lbl_serialno";
            this.lbl_serialno.Size = new System.Drawing.Size(54, 15);
            this.lbl_serialno.TabIndex = 0;
            this.lbl_serialno.Text = "SerialNo:";
            // 
            // tbx_serialno
            // 
            this.tbx_serialno.Enabled = false;
            this.tbx_serialno.Location = new System.Drawing.Point(135, 58);
            this.tbx_serialno.Name = "tbx_serialno";
            this.tbx_serialno.Size = new System.Drawing.Size(176, 23);
            this.tbx_serialno.TabIndex = 1;
            // 
            // lbl_nom_volt
            // 
            this.lbl_nom_volt.AutoSize = true;
            this.lbl_nom_volt.Location = new System.Drawing.Point(31, 90);
            this.lbl_nom_volt.Name = "lbl_nom_volt";
            this.lbl_nom_volt.Size = new System.Drawing.Size(98, 15);
            this.lbl_nom_volt.TabIndex = 2;
            this.lbl_nom_volt.Text = "Nominal voltage:";
            // 
            // tbx_nom_volt
            // 
            this.tbx_nom_volt.Enabled = false;
            this.tbx_nom_volt.Location = new System.Drawing.Point(135, 87);
            this.tbx_nom_volt.Name = "tbx_nom_volt";
            this.tbx_nom_volt.Size = new System.Drawing.Size(176, 23);
            this.tbx_nom_volt.TabIndex = 3;
            // 
            // tbx_set_volt
            // 
            this.tbx_set_volt.Location = new System.Drawing.Point(211, 51);
            this.tbx_set_volt.Name = "tbx_set_volt";
            this.tbx_set_volt.Size = new System.Drawing.Size(100, 23);
            this.tbx_set_volt.TabIndex = 4;
            // 
            // btn_set_volt
            // 
            this.btn_set_volt.Location = new System.Drawing.Point(119, 50);
            this.btn_set_volt.Name = "btn_set_volt";
            this.btn_set_volt.Size = new System.Drawing.Size(75, 23);
            this.btn_set_volt.TabIndex = 6;
            this.btn_set_volt.Text = "Apply";
            this.btn_set_volt.UseVisualStyleBackColor = true;
            this.btn_set_volt.Click += new System.EventHandler(this.btn_set_volt_Click);
            // 
            // tbx_get_volt
            // 
            this.tbx_get_volt.Enabled = false;
            this.tbx_get_volt.Location = new System.Drawing.Point(211, 22);
            this.tbx_get_volt.Name = "tbx_get_volt";
            this.tbx_get_volt.Size = new System.Drawing.Size(100, 23);
            this.tbx_get_volt.TabIndex = 7;
            // 
            // btn_get_volt
            // 
            this.btn_get_volt.Location = new System.Drawing.Point(119, 22);
            this.btn_get_volt.Name = "btn_get_volt";
            this.btn_get_volt.Size = new System.Drawing.Size(75, 23);
            this.btn_get_volt.TabIndex = 8;
            this.btn_get_volt.Text = "Refresh";
            this.btn_get_volt.UseVisualStyleBackColor = true;
            this.btn_get_volt.Click += new System.EventHandler(this.btn_get_volt_Click);
            // 
            // tbx_nom_watt
            // 
            this.tbx_nom_watt.Enabled = false;
            this.tbx_nom_watt.Location = new System.Drawing.Point(135, 116);
            this.tbx_nom_watt.Name = "tbx_nom_watt";
            this.tbx_nom_watt.Size = new System.Drawing.Size(176, 23);
            this.tbx_nom_watt.TabIndex = 12;
            // 
            // lbl_nom_watt
            // 
            this.lbl_nom_watt.AutoSize = true;
            this.lbl_nom_watt.Location = new System.Drawing.Point(47, 119);
            this.lbl_nom_watt.Name = "lbl_nom_watt";
            this.lbl_nom_watt.Size = new System.Drawing.Size(82, 15);
            this.lbl_nom_watt.TabIndex = 11;
            this.lbl_nom_watt.Text = "Nominal watt:";
            // 
            // tbx_device_type
            // 
            this.tbx_device_type.Enabled = false;
            this.tbx_device_type.Location = new System.Drawing.Point(135, 29);
            this.tbx_device_type.Name = "tbx_device_type";
            this.tbx_device_type.Size = new System.Drawing.Size(176, 23);
            this.tbx_device_type.TabIndex = 16;
            // 
            // lbl_device_type
            // 
            this.lbl_device_type.AutoSize = true;
            this.lbl_device_type.Location = new System.Drawing.Point(58, 32);
            this.lbl_device_type.Name = "lbl_device_type";
            this.lbl_device_type.Size = new System.Drawing.Size(71, 15);
            this.lbl_device_type.TabIndex = 15;
            this.lbl_device_type.Text = "Device type:";
            // 
            // tbx_articleno
            // 
            this.tbx_articleno.Enabled = false;
            this.tbx_articleno.Location = new System.Drawing.Point(135, 145);
            this.tbx_articleno.Name = "tbx_articleno";
            this.tbx_articleno.Size = new System.Drawing.Size(176, 23);
            this.tbx_articleno.TabIndex = 18;
            // 
            // lbl_articleno
            // 
            this.lbl_articleno.AutoSize = true;
            this.lbl_articleno.Location = new System.Drawing.Point(66, 148);
            this.lbl_articleno.Name = "lbl_articleno";
            this.lbl_articleno.Size = new System.Drawing.Size(63, 15);
            this.lbl_articleno.TabIndex = 17;
            this.lbl_articleno.Text = "Article No:";
            // 
            // tbx_manufacturer
            // 
            this.tbx_manufacturer.Enabled = false;
            this.tbx_manufacturer.Location = new System.Drawing.Point(135, 174);
            this.tbx_manufacturer.Name = "tbx_manufacturer";
            this.tbx_manufacturer.Size = new System.Drawing.Size(176, 23);
            this.tbx_manufacturer.TabIndex = 20;
            // 
            // lbl_manufacturer
            // 
            this.lbl_manufacturer.AutoSize = true;
            this.lbl_manufacturer.Location = new System.Drawing.Point(47, 177);
            this.lbl_manufacturer.Name = "lbl_manufacturer";
            this.lbl_manufacturer.Size = new System.Drawing.Size(82, 15);
            this.lbl_manufacturer.TabIndex = 19;
            this.lbl_manufacturer.Text = "Manufacturer:";
            // 
            // tbx_version
            // 
            this.tbx_version.Enabled = false;
            this.tbx_version.Location = new System.Drawing.Point(135, 203);
            this.tbx_version.Name = "tbx_version";
            this.tbx_version.Size = new System.Drawing.Size(176, 23);
            this.tbx_version.TabIndex = 22;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(32, 206);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(97, 15);
            this.lbl_version.TabIndex = 21;
            this.lbl_version.Text = "Software version:";
            // 
            // grp_device_info
            // 
            this.grp_device_info.Controls.Add(this.tbx_version);
            this.grp_device_info.Controls.Add(this.lbl_device_type);
            this.grp_device_info.Controls.Add(this.lbl_version);
            this.grp_device_info.Controls.Add(this.tbx_device_type);
            this.grp_device_info.Controls.Add(this.lbl_serialno);
            this.grp_device_info.Controls.Add(this.tbx_manufacturer);
            this.grp_device_info.Controls.Add(this.tbx_serialno);
            this.grp_device_info.Controls.Add(this.lbl_manufacturer);
            this.grp_device_info.Controls.Add(this.lbl_nom_volt);
            this.grp_device_info.Controls.Add(this.tbx_articleno);
            this.grp_device_info.Controls.Add(this.tbx_nom_volt);
            this.grp_device_info.Controls.Add(this.lbl_articleno);
            this.grp_device_info.Controls.Add(this.lbl_nom_watt);
            this.grp_device_info.Controls.Add(this.tbx_nom_watt);
            this.grp_device_info.Location = new System.Drawing.Point(12, 71);
            this.grp_device_info.Name = "grp_device_info";
            this.grp_device_info.Size = new System.Drawing.Size(335, 258);
            this.grp_device_info.TabIndex = 23;
            this.grp_device_info.TabStop = false;
            this.grp_device_info.Text = "Device information";
            // 
            // grp_remote
            // 
            this.grp_remote.Controls.Add(this.cbx_remote_control);
            this.grp_remote.Location = new System.Drawing.Point(12, 335);
            this.grp_remote.Name = "grp_remote";
            this.grp_remote.Size = new System.Drawing.Size(335, 65);
            this.grp_remote.TabIndex = 29;
            this.grp_remote.TabStop = false;
            this.grp_remote.Text = "Remote control";
            // 
            // cbx_remote_control
            // 
            this.cbx_remote_control.AutoSize = true;
            this.cbx_remote_control.Location = new System.Drawing.Point(228, 22);
            this.cbx_remote_control.Name = "cbx_remote_control";
            this.cbx_remote_control.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_remote_control.Size = new System.Drawing.Size(68, 19);
            this.cbx_remote_control.TabIndex = 0;
            this.cbx_remote_control.Text = "Enabled";
            this.cbx_remote_control.UseVisualStyleBackColor = true;
            this.cbx_remote_control.CheckedChanged += new System.EventHandler(this.remote_control_CheckedChanged);
            // 
            // grp_volt
            // 
            this.grp_volt.Controls.Add(this.btn_get_volt);
            this.grp_volt.Controls.Add(this.tbx_set_volt);
            this.grp_volt.Controls.Add(this.btn_set_volt);
            this.grp_volt.Controls.Add(this.tbx_get_volt);
            this.grp_volt.Location = new System.Drawing.Point(12, 477);
            this.grp_volt.Name = "grp_volt";
            this.grp_volt.Size = new System.Drawing.Size(335, 97);
            this.grp_volt.TabIndex = 30;
            this.grp_volt.TabStop = false;
            this.grp_volt.Text = "Voltage";
            // 
            // grp_watt
            // 
            this.grp_watt.Controls.Add(this.btn_get_watt);
            this.grp_watt.Controls.Add(this.tbx_set_watt);
            this.grp_watt.Controls.Add(this.btn_set_watt);
            this.grp_watt.Controls.Add(this.tbx_get_watt);
            this.grp_watt.Location = new System.Drawing.Point(12, 580);
            this.grp_watt.Name = "grp_watt";
            this.grp_watt.Size = new System.Drawing.Size(335, 97);
            this.grp_watt.TabIndex = 31;
            this.grp_watt.TabStop = false;
            this.grp_watt.Text = "Watt";
            // 
            // btn_get_watt
            // 
            this.btn_get_watt.Location = new System.Drawing.Point(119, 22);
            this.btn_get_watt.Name = "btn_get_watt";
            this.btn_get_watt.Size = new System.Drawing.Size(75, 23);
            this.btn_get_watt.TabIndex = 8;
            this.btn_get_watt.Text = "Refresh";
            this.btn_get_watt.UseVisualStyleBackColor = true;
            this.btn_get_watt.Click += new System.EventHandler(this.btn_get_watt_Click);
            // 
            // tbx_set_watt
            // 
            this.tbx_set_watt.Location = new System.Drawing.Point(211, 51);
            this.tbx_set_watt.Name = "tbx_set_watt";
            this.tbx_set_watt.Size = new System.Drawing.Size(100, 23);
            this.tbx_set_watt.TabIndex = 4;
            // 
            // btn_set_watt
            // 
            this.btn_set_watt.Location = new System.Drawing.Point(119, 50);
            this.btn_set_watt.Name = "btn_set_watt";
            this.btn_set_watt.Size = new System.Drawing.Size(75, 23);
            this.btn_set_watt.TabIndex = 6;
            this.btn_set_watt.Text = "Apply";
            this.btn_set_watt.UseVisualStyleBackColor = true;
            this.btn_set_watt.Click += new System.EventHandler(this.btn_set_watt_Click);
            // 
            // tbx_get_watt
            // 
            this.tbx_get_watt.Enabled = false;
            this.tbx_get_watt.Location = new System.Drawing.Point(211, 22);
            this.tbx_get_watt.Name = "tbx_get_watt";
            this.tbx_get_watt.Size = new System.Drawing.Size(100, 23);
            this.tbx_get_watt.TabIndex = 7;
            // 
            // gbx_power
            // 
            this.gbx_power.Controls.Add(this.cbx_power_out);
            this.gbx_power.Location = new System.Drawing.Point(12, 406);
            this.gbx_power.Name = "gbx_power";
            this.gbx_power.Size = new System.Drawing.Size(335, 65);
            this.gbx_power.TabIndex = 30;
            this.gbx_power.TabStop = false;
            this.gbx_power.Text = "Power output";
            // 
            // cbx_power_out
            // 
            this.cbx_power_out.AutoSize = true;
            this.cbx_power_out.Location = new System.Drawing.Point(228, 22);
            this.cbx_power_out.Name = "cbx_power_out";
            this.cbx_power_out.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_power_out.Size = new System.Drawing.Size(68, 19);
            this.cbx_power_out.TabIndex = 1;
            this.cbx_power_out.Text = "Enabled";
            this.cbx_power_out.UseVisualStyleBackColor = true;
            this.cbx_power_out.CheckedChanged += new System.EventHandler(this.rdi_power_enabled_CheckedChanged);
            // 
            // gbx_com
            // 
            this.gbx_com.Controls.Add(this.lbl_port);
            this.gbx_com.Controls.Add(this.tbx_port);
            this.gbx_com.Location = new System.Drawing.Point(12, 13);
            this.gbx_com.Name = "gbx_com";
            this.gbx_com.Size = new System.Drawing.Size(335, 49);
            this.gbx_com.TabIndex = 32;
            this.gbx_com.TabStop = false;
            this.gbx_com.Text = "COM Port";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(97, 23);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(32, 15);
            this.lbl_port.TabIndex = 17;
            this.lbl_port.Text = "Port:";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(135, 20);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(176, 23);
            this.tbx_port.TabIndex = 18;
            this.tbx_port.Text = "com6";
            this.tbx_port.TextChanged += new System.EventHandler(this.tbx_port_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 689);
            this.Controls.Add(this.gbx_com);
            this.Controls.Add(this.gbx_power);
            this.Controls.Add(this.grp_watt);
            this.Controls.Add(this.grp_volt);
            this.Controls.Add(this.grp_remote);
            this.Controls.Add(this.grp_device_info);
            this.Name = "Form1";
            this.Text = "PS2000b";
            this.grp_device_info.ResumeLayout(false);
            this.grp_device_info.PerformLayout();
            this.grp_remote.ResumeLayout(false);
            this.grp_remote.PerformLayout();
            this.grp_volt.ResumeLayout(false);
            this.grp_volt.PerformLayout();
            this.grp_watt.ResumeLayout(false);
            this.grp_watt.PerformLayout();
            this.gbx_power.ResumeLayout(false);
            this.gbx_power.PerformLayout();
            this.gbx_com.ResumeLayout(false);
            this.gbx_com.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_serialno;
        private TextBox tbx_serialno;
        private TextBox tbx_nom_volt;
        private TextBox tbx_set_volt;
        private Button btn_set_volt;
        private TextBox tbx_get_volt;
        private Button btn_get_volt;
        private TextBox tbx_nom_watt;
        private Label lbl_nom_watt;
        private Label lbl_nom_volt;
        private TextBox tbx_device_type;
        private Label lbl_device_type;
        private TextBox tbx_articleno;
        private Label lbl_articleno;
        private TextBox tbx_manufacturer;
        private Label lbl_manufacturer;
        private TextBox tbx_version;
        private Label lbl_version;
        private GroupBox grp_device_info;
        private GroupBox grp_remote;
        private GroupBox grp_volt;
        private GroupBox grp_watt;
        private Button btn_get_watt;
        private TextBox tbx_set_watt;
        private Button btn_set_watt;
        private TextBox tbx_get_watt;
        private GroupBox gbx_power;
        private CheckBox cbx_remote_control;
        private CheckBox cbx_power_out;
        private GroupBox gbx_com;
        private Label lbl_port;
        private TextBox tbx_port;
    }
}