namespace silnik_krokowy_RB
{
    partial class Form1
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.stepCount = new System.Windows.Forms.TextBox();
            this.Interval = new System.Windows.Forms.TextBox();
            this.Steps = new System.Windows.Forms.Label();
            this.sleepTime = new System.Windows.Forms.Label();
            this.n_steps_left = new System.Windows.Forms.Button();
            this.n_steps_right = new System.Windows.Forms.Button();
            this.modes = new System.Windows.Forms.ComboBox();
            this.eeprom_btn = new System.Windows.Forms.Button();
            this.change_desc = new System.Windows.Forms.Button();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.default_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(12, 12);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(93, 12);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.disconnect_btn.TabIndex = 1;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(12, 41);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(260, 96);
            this.console.TabIndex = 2;
            this.console.Text = "";
            // 
            // stepCount
            // 
            this.stepCount.Location = new System.Drawing.Point(52, 143);
            this.stepCount.Name = "stepCount";
            this.stepCount.Size = new System.Drawing.Size(100, 20);
            this.stepCount.TabIndex = 3;
            this.stepCount.Text = "1";
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(52, 169);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(100, 20);
            this.Interval.TabIndex = 4;
            this.Interval.Text = "100";
            // 
            // Steps
            // 
            this.Steps.AutoSize = true;
            this.Steps.Location = new System.Drawing.Point(12, 146);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(34, 13);
            this.Steps.TabIndex = 5;
            this.Steps.Text = "Steps";
            // 
            // sleepTime
            // 
            this.sleepTime.AutoSize = true;
            this.sleepTime.Location = new System.Drawing.Point(12, 172);
            this.sleepTime.Name = "sleepTime";
            this.sleepTime.Size = new System.Drawing.Size(42, 13);
            this.sleepTime.TabIndex = 6;
            this.sleepTime.Text = "Interval";
            // 
            // n_steps_left
            // 
            this.n_steps_left.Enabled = false;
            this.n_steps_left.Location = new System.Drawing.Point(12, 206);
            this.n_steps_left.Name = "n_steps_left";
            this.n_steps_left.Size = new System.Drawing.Size(115, 23);
            this.n_steps_left.TabIndex = 7;
            this.n_steps_left.Text = "n steps left";
            this.n_steps_left.UseVisualStyleBackColor = true;
            this.n_steps_left.Click += new System.EventHandler(this.n_steps_left_Click);
            // 
            // n_steps_right
            // 
            this.n_steps_right.Enabled = false;
            this.n_steps_right.Location = new System.Drawing.Point(157, 206);
            this.n_steps_right.Name = "n_steps_right";
            this.n_steps_right.Size = new System.Drawing.Size(115, 23);
            this.n_steps_right.TabIndex = 8;
            this.n_steps_right.Text = "n steps right";
            this.n_steps_right.UseVisualStyleBackColor = true;
            this.n_steps_right.Click += new System.EventHandler(this.n_steps_right_Click);
            // 
            // modes
            // 
            this.modes.FormattingEnabled = true;
            this.modes.Items.AddRange(new object[] {
            "Fullstep",
            "Halfstep",
            "Wavestep"});
            this.modes.Location = new System.Drawing.Point(158, 143);
            this.modes.Name = "modes";
            this.modes.Size = new System.Drawing.Size(114, 21);
            this.modes.TabIndex = 9;
            // 
            // eeprom_btn
            // 
            this.eeprom_btn.Enabled = false;
            this.eeprom_btn.Location = new System.Drawing.Point(158, 167);
            this.eeprom_btn.Name = "eeprom_btn";
            this.eeprom_btn.Size = new System.Drawing.Size(114, 23);
            this.eeprom_btn.TabIndex = 10;
            this.eeprom_btn.Text = "Read EEPROM";
            this.eeprom_btn.UseVisualStyleBackColor = true;
            this.eeprom_btn.Click += new System.EventHandler(this.eeprom_btn_Click);
            // 
            // change_desc
            // 
            this.change_desc.Location = new System.Drawing.Point(12, 240);
            this.change_desc.Name = "change_desc";
            this.change_desc.Size = new System.Drawing.Size(75, 23);
            this.change_desc.TabIndex = 11;
            this.change_desc.Text = "program";
            this.change_desc.UseVisualStyleBackColor = true;
            this.change_desc.Click += new System.EventHandler(this.change_desc_Click);
            this.change_desc.Enabled = false;
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(93, 243);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(100, 20);
            this.description_textbox.TabIndex = 12;
            this.description_textbox.Text = "usb step motor";
            // 
            // default_btn
            // 
            this.default_btn.Location = new System.Drawing.Point(199, 240);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(75, 23);
            this.default_btn.TabIndex = 13;
            this.default_btn.Text = "default";
            this.default_btn.UseVisualStyleBackColor = true;
            this.default_btn.Click += new System.EventHandler(this.default_btn_Click);
            this.default_btn.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.Controls.Add(this.default_btn);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.change_desc);
            this.Controls.Add(this.eeprom_btn);
            this.Controls.Add(this.modes);
            this.Controls.Add(this.n_steps_right);
            this.Controls.Add(this.n_steps_left);
            this.Controls.Add(this.sleepTime);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.stepCount);
            this.Controls.Add(this.console);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.connect_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.TextBox stepCount;
        private System.Windows.Forms.TextBox Interval;
        private System.Windows.Forms.Label Steps;
        private System.Windows.Forms.Label sleepTime;
        private System.Windows.Forms.Button n_steps_left;
        private System.Windows.Forms.Button n_steps_right;
        private System.Windows.Forms.ComboBox modes;
        private System.Windows.Forms.Button eeprom_btn;
        private System.Windows.Forms.Button change_desc;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.Button default_btn;
    }
}

