namespace WindowsFormsApp_SerialUart_Sonic
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Auto_Btn = new System.Windows.Forms.Button();
            this.Left_Btn = new System.Windows.Forms.Button();
            this.Right_Btn = new System.Windows.Forms.Button();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Serial_Btn = new System.Windows.Forms.Button();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.dATETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM9";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea2";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(836, 649);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Auto_Btn
            // 
            this.Auto_Btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Auto_Btn.Location = new System.Drawing.Point(724, 13);
            this.Auto_Btn.Name = "Auto_Btn";
            this.Auto_Btn.Size = new System.Drawing.Size(70, 50);
            this.Auto_Btn.TabIndex = 1;
            this.Auto_Btn.Text = "자동";
            this.Auto_Btn.UseVisualStyleBackColor = true;
            this.Auto_Btn.Click += new System.EventHandler(this.Auto_Btn_Click);
            // 
            // Left_Btn
            // 
            this.Left_Btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Left_Btn.Location = new System.Drawing.Point(800, 12);
            this.Left_Btn.Name = "Left_Btn";
            this.Left_Btn.Size = new System.Drawing.Size(70, 50);
            this.Left_Btn.TabIndex = 2;
            this.Left_Btn.Text = "왼쪽";
            this.Left_Btn.UseVisualStyleBackColor = true;
            this.Left_Btn.Click += new System.EventHandler(this.Left_Btn_Click);
            // 
            // Right_Btn
            // 
            this.Right_Btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Right_Btn.Location = new System.Drawing.Point(876, 13);
            this.Right_Btn.Name = "Right_Btn";
            this.Right_Btn.Size = new System.Drawing.Size(70, 50);
            this.Right_Btn.TabIndex = 3;
            this.Right_Btn.Text = "오른쪽";
            this.Right_Btn.UseVisualStyleBackColor = true;
            this.Right_Btn.Click += new System.EventHandler(this.Right_Btn_Click);
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stop_Btn.Location = new System.Drawing.Point(952, 13);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(70, 50);
            this.Stop_Btn.TabIndex = 4;
            this.Stop_Btn.Text = "정지";
            this.Stop_Btn.UseVisualStyleBackColor = true;
            this.Stop_Btn.Click += new System.EventHandler(this.Stop_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATETIMEDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataBaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(724, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(480, 593);
            this.dataGridView1.TabIndex = 5;
            // 
            // Serial_Btn
            // 
            this.Serial_Btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Serial_Btn.Location = new System.Drawing.Point(1028, 13);
            this.Serial_Btn.Name = "Serial_Btn";
            this.Serial_Btn.Size = new System.Drawing.Size(85, 50);
            this.Serial_Btn.TabIndex = 6;
            this.Serial_Btn.Text = "포트설정";
            this.Serial_Btn.UseVisualStyleBackColor = true;
            this.Serial_Btn.Click += new System.EventHandler(this.Serial_Btn_Click);
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Connect_Btn.Location = new System.Drawing.Point(1119, 13);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(85, 50);
            this.Connect_Btn.TabIndex = 6;
            this.Connect_Btn.Text = "On/Off";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // dATETIMEDataGridViewTextBoxColumn
            // 
            this.dATETIMEDataGridViewTextBoxColumn.DataPropertyName = "DATETIME";
            this.dATETIMEDataGridViewTextBoxColumn.HeaderText = "DATETIME";
            this.dATETIMEDataGridViewTextBoxColumn.Name = "dATETIMEDataGridViewTextBoxColumn";
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataSource = typeof(WindowsFormsApp_SerialUart_Sonic.DataBase);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 674);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.Serial_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Stop_Btn);
            this.Controls.Add(this.Right_Btn);
            this.Controls.Add(this.Left_Btn);
            this.Controls.Add(this.Auto_Btn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Auto_Btn;
        private System.Windows.Forms.Button Left_Btn;
        private System.Windows.Forms.Button Right_Btn;
        private System.Windows.Forms.Button Stop_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Serial_Btn;
        private System.Windows.Forms.Button Connect_Btn;
        public System.Windows.Forms.BindingSource dataBaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
    }
}

