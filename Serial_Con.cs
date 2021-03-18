using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp_SerialUart_Sonic
{
    public partial class Serial_Con : Form
    {
        SerialPort serial;
        public Serial_Con( )
        {
            InitializeComponent();
        }

        private void Serial_Con_Load(object sender, EventArgs e)
        {
            Port_ComboBox.DataSource = SerialPort.GetPortNames();
            Port_ComboBox.SelectedIndex = 2;
            BoudRate_ComboBox.SelectedIndex = 11;
            DataBit_ComboBox.SelectedIndex = 1;
            StopBit_ComboBox.SelectedIndex = 1;
            Parity_ComboBox.SelectedIndex = 0;
        }

        private void PortSearch_Btn_Click(object sender, EventArgs e)
        {
            Port_ComboBox.DataSource = SerialPort.GetPortNames();
            Port_ComboBox.SelectedIndex = 2;
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        public string BaudRate
        {
            get { return this.BoudRate_ComboBox.Text; }
        }
        public string PortName
        {
            get { return this.Port_ComboBox.Text; }
        }
        public int DataBits
        {
            get { return Convert.ToInt32(this.DataBit_ComboBox.Text); }
        }
        public string StopBit
        {
            get { return this.StopBit_ComboBox.Text; }
        }
        public string Parity
        {
            get { return this.Parity_ComboBox.Text; }
        }
    }
}
