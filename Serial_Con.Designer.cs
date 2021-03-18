namespace WindowsFormsApp_SerialUart_Sonic
{
    partial class Serial_Con
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Port_ComboBox = new System.Windows.Forms.ComboBox();
            this.BoudRate_ComboBox = new System.Windows.Forms.ComboBox();
            this.DataBit_ComboBox = new System.Windows.Forms.ComboBox();
            this.StopBit_ComboBox = new System.Windows.Forms.ComboBox();
            this.Parity_ComboBox = new System.Windows.Forms.ComboBox();
            this.PortSearch_Btn = new System.Windows.Forms.Button();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "BoudRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "DataBit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "StopBit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(38, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Parity";
            // 
            // Port_ComboBox
            // 
            this.Port_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port_ComboBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Port_ComboBox.FormattingEnabled = true;
            this.Port_ComboBox.Location = new System.Drawing.Point(127, 16);
            this.Port_ComboBox.Name = "Port_ComboBox";
            this.Port_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Port_ComboBox.TabIndex = 1;
            // 
            // BoudRate_ComboBox
            // 
            this.BoudRate_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoudRate_ComboBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BoudRate_ComboBox.FormattingEnabled = true;
            this.BoudRate_ComboBox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.BoudRate_ComboBox.Location = new System.Drawing.Point(127, 52);
            this.BoudRate_ComboBox.Name = "BoudRate_ComboBox";
            this.BoudRate_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.BoudRate_ComboBox.TabIndex = 2;
            // 
            // DataBit_ComboBox
            // 
            this.DataBit_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBit_ComboBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DataBit_ComboBox.FormattingEnabled = true;
            this.DataBit_ComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBit_ComboBox.Location = new System.Drawing.Point(127, 87);
            this.DataBit_ComboBox.Name = "DataBit_ComboBox";
            this.DataBit_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.DataBit_ComboBox.TabIndex = 3;
            // 
            // StopBit_ComboBox
            // 
            this.StopBit_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBit_ComboBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopBit_ComboBox.FormattingEnabled = true;
            this.StopBit_ComboBox.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.StopBit_ComboBox.Location = new System.Drawing.Point(127, 119);
            this.StopBit_ComboBox.Name = "StopBit_ComboBox";
            this.StopBit_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.StopBit_ComboBox.TabIndex = 4;
            // 
            // Parity_ComboBox
            // 
            this.Parity_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity_ComboBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Parity_ComboBox.FormattingEnabled = true;
            this.Parity_ComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Parity_ComboBox.Location = new System.Drawing.Point(127, 152);
            this.Parity_ComboBox.Name = "Parity_ComboBox";
            this.Parity_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Parity_ComboBox.TabIndex = 5;
            // 
            // PortSearch_Btn
            // 
            this.PortSearch_Btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PortSearch_Btn.Location = new System.Drawing.Point(12, 198);
            this.PortSearch_Btn.Name = "PortSearch_Btn";
            this.PortSearch_Btn.Size = new System.Drawing.Size(109, 46);
            this.PortSearch_Btn.TabIndex = 6;
            this.PortSearch_Btn.Text = "포트 조회";
            this.PortSearch_Btn.UseVisualStyleBackColor = true;
            this.PortSearch_Btn.Click += new System.EventHandler(this.PortSearch_Btn_Click);
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Connect_Btn.Location = new System.Drawing.Point(127, 198);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(121, 46);
            this.Connect_Btn.TabIndex = 7;
            this.Connect_Btn.Text = "포트 적용";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // Serial_Con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 260);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.PortSearch_Btn);
            this.Controls.Add(this.Parity_ComboBox);
            this.Controls.Add(this.StopBit_ComboBox);
            this.Controls.Add(this.DataBit_ComboBox);
            this.Controls.Add(this.BoudRate_ComboBox);
            this.Controls.Add(this.Port_ComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Serial_Con";
            this.Text = "Serial_Con";
            this.Load += new System.EventHandler(this.Serial_Con_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Port_ComboBox;
        private System.Windows.Forms.ComboBox BoudRate_ComboBox;
        private System.Windows.Forms.ComboBox DataBit_ComboBox;
        private System.Windows.Forms.ComboBox StopBit_ComboBox;
        private System.Windows.Forms.ComboBox Parity_ComboBox;
        private System.Windows.Forms.Button PortSearch_Btn;
        private System.Windows.Forms.Button Connect_Btn;
    }
}