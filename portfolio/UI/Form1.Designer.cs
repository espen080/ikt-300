namespace UI
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
            this.tbx_set_volt = new System.Windows.Forms.TextBox();
            this.btn_set_volt = new System.Windows.Forms.Button();
            this.tbx_get_volt = new System.Windows.Forms.TextBox();
            this.btn_get_volt = new System.Windows.Forms.Button();
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
            this.cbx_psu_id = new System.Windows.Forms.ComboBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.grp_remote.SuspendLayout();
            this.grp_volt.SuspendLayout();
            this.grp_watt.SuspendLayout();
            this.gbx_power.SuspendLayout();
            this.gbx_com.SuspendLayout();
            this.SuspendLayout();
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
            this.gbx_com.Controls.Add(this.cbx_psu_id);
            this.gbx_com.Controls.Add(this.lbl_port);
            this.gbx_com.Location = new System.Drawing.Point(12, 129);
            this.gbx_com.Name = "gbx_com";
            this.gbx_com.Size = new System.Drawing.Size(335, 59);
            this.gbx_com.TabIndex = 32;
            this.gbx_com.TabStop = false;
            this.gbx_com.Text = "Power supply";
            // 
            // cbx_psu_id
            // 
            this.cbx_psu_id.FormattingEnabled = true;
            this.cbx_psu_id.Location = new System.Drawing.Point(33, 20);
            this.cbx_psu_id.Name = "cbx_psu_id";
            this.cbx_psu_id.Size = new System.Drawing.Size(278, 23);
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
            this.Name = "Form1";
            this.Text = "Power supply system";
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
        private TextBox tbx_set_volt;
        private Button btn_set_volt;
        private TextBox tbx_get_volt;
        private Button btn_get_volt;
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
        private ComboBox cbx_psu_id;
    }
}