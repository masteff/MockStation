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

namespace SerialClient
{
    public partial class Form1 : Form
    {
        SerialPort mySerialPort;
        private string[] Messages = { "Station ready!", "Starting test process", "Executing task ", "Stopping test process" };
        private int MessageIndex = 0;
        private int taskIndex = 1;
        private string recvString = "";
        private bool operatorConnected = false;
        private bool sendUpdates = false;

        public Form1()
        {
            InitializeComponent();

            lblOperator1.Text = "No";
            lblOperator2.Text = "Operator";
            lblOperator3.Text = "connected";

            mySerialPort = new SerialPort("COM3");
            mySerialPort.BaudRate = 115200;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += MySerialPort_DataReceived;

            try
            {
                mySerialPort.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            recvString = recvString + sp.ReadExisting();

            if (recvString.Contains(":::"))
            {
                Console.WriteLine(recvString);
                recvString = recvString.Remove(recvString.Length - 3);


                string[] command = recvString.Split(':');

                switch (command[0])
                {
                    case "Station":
                        if (command[1] == "Start")
                            btnStart.BeginInvoke(new Action(() => btnStart.PerformClick()));
                        else if (command[1] == "Stop")
                            btnStop.BeginInvoke(new Action(() => btnStop.PerformClick()));
                        else
                            Console.WriteLine("unknwon Station command");
                        break;

                    case "Operator":
                        pnlOperator.BeginInvoke(new Action(() =>
                        {
                            lblOperator1.Text = "Operator";
                            lblOperator2.Text = command[1];
                            lblOperator3.Text = "connected";
                        }));
                        operatorConnected = true;
                        break;

                    case "Updates":
                        if (command[1] == "Start")
                        {
                            mySerialPort.Write("UpdateStart:::");
                        }
                        else if (command[1] == "Stop")
                        {
                            mySerialPort.Write("UpdateStop:::");
                        }
                        else
                            Console.WriteLine("unknwon Updates command");
                        break;

                    default:
                        Console.WriteLine("Unknown command!");
                        break;
                }
                recvString = "";
            }


        }

        private void timUpdate_Tick_1(object sender, EventArgs e)
        {
            if (MessageIndex < 2)
            {
                lblUpdate.Text = Messages[MessageIndex] + "\n";
                if (operatorConnected)
                    mySerialPort.Write(Messages[MessageIndex] + ":::");
                MessageIndex++;
            }
            else
            {
                lblUpdate.Text = Messages[2] + taskIndex + "\n";
                if (operatorConnected)
                    mySerialPort.Write(Messages[2] + taskIndex + ":::");
                taskIndex++;
            } 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timUpdate.Stop();
            MessageIndex = 0;
            taskIndex = 1;
            btnStop.Visible = false;
            lblUpdate.Text = "Idle";
            btnStart.Text = "Start Test!";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timUpdate.Start();
            lblUpdate.Text = "Initalizing...";
            btnStop.Visible = true;
            btnStart.Text = "Test running!";
            btnStart.BackColor = Color.LightGreen;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timUpdate.Stop();   
            mySerialPort?.Close();
        }
    }
}
