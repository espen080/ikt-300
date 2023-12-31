﻿namespace UI
{
    partial class PowerSupplyUI
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
            this.gbx_com = new System.Windows.Forms.GroupBox();
            this.check_lock = new System.Windows.Forms.CheckBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_get_current = new System.Windows.Forms.Button();
            this.tbx_get_current = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_set_voltage = new System.Windows.Forms.TextBox();
            this.btn_get_voltage = new System.Windows.Forms.Button();
            this.tbx_get_voltage = new System.Windows.Forms.TextBox();
            this.btn_set_voltage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_psu_id = new System.Windows.Forms.ComboBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_frequency = new System.Windows.Forms.Button();
            this.tbx_frequency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tbx_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_com.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_com
            // 
            this.gbx_com.Controls.Add(this.check_lock);
            this.gbx_com.Controls.Add(this.btn_stop);
            this.gbx_com.Controls.Add(this.btn_get_current);
            this.gbx_com.Controls.Add(this.tbx_get_current);
            this.gbx_com.Controls.Add(this.label3);
            this.gbx_com.Controls.Add(this.tbx_set_voltage);
            this.gbx_com.Controls.Add(this.btn_get_voltage);
            this.gbx_com.Controls.Add(this.tbx_get_voltage);
            this.gbx_com.Controls.Add(this.btn_set_voltage);
            this.gbx_com.Controls.Add(this.label2);
            this.gbx_com.Controls.Add(this.cbx_psu_id);
            this.gbx_com.Controls.Add(this.lbl_port);
            this.gbx_com.Location = new System.Drawing.Point(12, 174);
            this.gbx_com.Name = "gbx_com";
            this.gbx_com.Size = new System.Drawing.Size(250, 259);
            this.gbx_com.TabIndex = 32;
            this.gbx_com.TabStop = false;
            this.gbx_com.Text = "Power supply";
            // 
            // check_lock
            // 
            this.check_lock.AutoSize = true;
            this.check_lock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_lock.Location = new System.Drawing.Point(33, 51);
            this.check_lock.Name = "check_lock";
            this.check_lock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_lock.Size = new System.Drawing.Size(64, 19);
            this.check_lock.TabIndex = 31;
            this.check_lock.Text = "Locked";
            this.check_lock.UseVisualStyleBackColor = true;
            this.check_lock.CheckedChanged += new System.EventHandler(this.check_lock_CheckedChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(139, 51);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 23);
            this.btn_stop.TabIndex = 30;
            this.btn_stop.Text = "Shut down";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_get_current
            // 
            this.btn_get_current.Location = new System.Drawing.Point(139, 204);
            this.btn_get_current.Name = "btn_get_current";
            this.btn_get_current.Size = new System.Drawing.Size(100, 23);
            this.btn_get_current.TabIndex = 29;
            this.btn_get_current.Text = "Get";
            this.btn_get_current.UseVisualStyleBackColor = true;
            this.btn_get_current.Click += new System.EventHandler(this.btn_get_current_Click);
            // 
            // tbx_get_current
            // 
            this.tbx_get_current.Location = new System.Drawing.Point(33, 205);
            this.tbx_get_current.Name = "tbx_get_current";
            this.tbx_get_current.ReadOnly = true;
            this.tbx_get_current.Size = new System.Drawing.Size(100, 23);
            this.tbx_get_current.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current:";
            // 
            // tbx_set_voltage
            // 
            this.tbx_set_voltage.Location = new System.Drawing.Point(33, 142);
            this.tbx_set_voltage.Name = "tbx_set_voltage";
            this.tbx_set_voltage.Size = new System.Drawing.Size(100, 23);
            this.tbx_set_voltage.TabIndex = 26;
            // 
            // btn_get_voltage
            // 
            this.btn_get_voltage.Location = new System.Drawing.Point(139, 111);
            this.btn_get_voltage.Name = "btn_get_voltage";
            this.btn_get_voltage.Size = new System.Drawing.Size(100, 23);
            this.btn_get_voltage.TabIndex = 25;
            this.btn_get_voltage.Text = "Get";
            this.btn_get_voltage.UseVisualStyleBackColor = true;
            this.btn_get_voltage.Click += new System.EventHandler(this.btn_get_voltage_Click);
            // 
            // tbx_get_voltage
            // 
            this.tbx_get_voltage.Location = new System.Drawing.Point(33, 112);
            this.tbx_get_voltage.Name = "tbx_get_voltage";
            this.tbx_get_voltage.ReadOnly = true;
            this.tbx_get_voltage.Size = new System.Drawing.Size(100, 23);
            this.tbx_get_voltage.TabIndex = 24;
            // 
            // btn_set_voltage
            // 
            this.btn_set_voltage.Location = new System.Drawing.Point(139, 141);
            this.btn_set_voltage.Name = "btn_set_voltage";
            this.btn_set_voltage.Size = new System.Drawing.Size(100, 23);
            this.btn_set_voltage.TabIndex = 23;
            this.btn_set_voltage.Text = "Set";
            this.btn_set_voltage.UseVisualStyleBackColor = true;
            this.btn_set_voltage.Click += new System.EventHandler(this.btn_set_voltage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Voltage:";
            // 
            // cbx_psu_id
            // 
            this.cbx_psu_id.FormattingEnabled = true;
            this.cbx_psu_id.Location = new System.Drawing.Point(33, 20);
            this.cbx_psu_id.Name = "cbx_psu_id";
            this.cbx_psu_id.Size = new System.Drawing.Size(206, 23);
            this.cbx_psu_id.TabIndex = 18;
            this.cbx_psu_id.SelectedIndexChanged += new System.EventHandler(this.cbx_psu_id_SelectedIndexChanged);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(6, 23);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(21, 15);
            this.lbl_port.TabIndex = 17;
            this.lbl_port.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_frequency);
            this.groupBox1.Controls.Add(this.tbx_frequency);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.tbx_host);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 156);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // btn_frequency
            // 
            this.btn_frequency.Enabled = false;
            this.btn_frequency.Location = new System.Drawing.Point(163, 118);
            this.btn_frequency.Name = "btn_frequency";
            this.btn_frequency.Size = new System.Drawing.Size(75, 23);
            this.btn_frequency.TabIndex = 5;
            this.btn_frequency.Text = "Apply";
            this.btn_frequency.UseVisualStyleBackColor = true;
            this.btn_frequency.Click += new System.EventHandler(this.btn_frequency_Click);
            // 
            // tbx_frequency
            // 
            this.tbx_frequency.Location = new System.Drawing.Point(6, 118);
            this.tbx_frequency.Name = "tbx_frequency";
            this.tbx_frequency.Size = new System.Drawing.Size(151, 23);
            this.tbx_frequency.TabIndex = 4;
            this.tbx_frequency.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Update fequency (seconds)";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(121, 66);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(118, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tbx_host
            // 
            this.tbx_host.Location = new System.Drawing.Point(6, 37);
            this.tbx_host.Name = "tbx_host";
            this.tbx_host.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_host.Size = new System.Drawing.Size(233, 23);
            this.tbx_host.TabIndex = 1;
            this.tbx_host.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_com);
            this.Name = "Form1";
            this.Text = "Power supply system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PowerSuplyUI_FormClosing);
            this.gbx_com.ResumeLayout(false);
            this.gbx_com.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbx_com;
        private Label lbl_port;
        private ComboBox cbx_psu_id;
        private GroupBox groupBox1;
        private TextBox tbx_host;
        private Label label1;
        private Button btn_connect;
        private Button btn_get_current;
        private TextBox tbx_get_current;
        private Label label3;
        private TextBox tbx_set_voltage;
        private Button btn_get_voltage;
        private TextBox tbx_get_voltage;
        private Button btn_set_voltage;
        private Label label2;
        private TextBox tbx_frequency;
        private Label label4;
        private Button btn_stop;
        private CheckBox check_lock;
        private Button btn_frequency;
    }
}