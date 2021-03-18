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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) 
        {
            this.Invoke(new EventHandler(MySerialReceived));  
        }

        public void MySerialReceived(object s, EventArgs e)
        {
            string ReceiveData = serialPort1.ReadLine();
            char sp = ' ';
            string[] Sp_Data = ReceiveData.Split(sp);
            if (Sp_Data.Length == 4)
            {
                if (ReceiveData[0] == 0x55)
                {
                    try
                    {
                        for (int i = 1; i < Sp_Data.Length; i++)
                        {
                            chart1.Series[0].Points.AddXY("", Sp_Data[i]);
                            chart1.Series[1].Points.AddXY("", Sp_Data[i]);
                            dataBaseBindingSource.Add(new DataBase()
                            {
                                DATETIME = DateTime.Now.ToString(@"hh\:mm\:ss"),
                                LENGTH = int.Parse(Sp_Data[i]),
                            });
                            if (chart1.Series[0].Points.Count > 50) chart1.Series[0].Points.RemoveAt(0);
                        }
                        chart1.ChartAreas[0].RecalculateAxesScale();
                    }
                    catch (FormatException ex)
                    {

                    }
                }
            }
        }
        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("포트가 열렸습니다.");
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                serialPort1.Open();
            }
            else if (serialPort1.IsOpen == true)
            {
                MessageBox.Show("포트가 닫혔습니다.");
                serialPort1.Close();
            }
        }
        private void Serial_Btn_Click(object sender, EventArgs e)
        {
            Serial_Con serial_ = new Serial_Con();
            if (serial_.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    serialPort1.BaudRate = Convert.ToInt32(serial_.BaudRate);
                    serialPort1.PortName = serial_.PortName;
                    serialPort1.DataBits = serial_.DataBits;
                    if (serial_.StopBit == "None") serialPort1.StopBits = StopBits.None;
                    else if (serial_.StopBit == "One") serialPort1.StopBits = StopBits.One;
                    else if (serial_.StopBit == "OnePointFive") serialPort1.StopBits = StopBits.OnePointFive;
                    else if (serial_.StopBit == "Two") serialPort1.StopBits = StopBits.Two;
                    if (serial_.Parity == "Even") serialPort1.Parity = Parity.Even;
                    else if (serial_.Parity == "Mark") serialPort1.Parity = Parity.Mark;
                    else if (serial_.Parity == "None") serialPort1.Parity = Parity.None;
                    else if (serial_.Parity == "Odd") serialPort1.Parity = Parity.Odd;
                    else if (serial_.Parity == "Space") serialPort1.Parity = Parity.Space;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Auto_Btn_Click(object sender, EventArgs e)
        {
            try { serialPort1.Write("AUTOOK"); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            try { serialPort1.Write("STOPOK"); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Left_Btn_Click(object sender, EventArgs e)
        {
            try { serialPort1.Write("LEFTOK"); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Right_Btn_Click(object sender, EventArgs e)
        {
            try { serialPort1.Write("RIGHTOK"); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
