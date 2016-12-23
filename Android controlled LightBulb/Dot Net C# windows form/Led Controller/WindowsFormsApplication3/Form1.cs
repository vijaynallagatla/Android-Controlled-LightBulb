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
using Microsoft.VisualBasic;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        static SerialPort arduino = new SerialPort();
        String state="OFF";
        String comport;
        public Form1()
        {
            InitializeComponent();
            String port ="COM";
            port += Interaction.InputBox("Enter the COM PORT Number", "COM PORT", "Enter Numbers");
                arduino.PortName = port;
           
            arduino.BaudRate = 9600;
            arduino.Parity = Parity.None;
            arduino.DataBits = 8;
            arduino.ReadTimeout = 2000;
            arduino.WriteTimeout = 500;
            
            arduino.Handshake = Handshake.None;
           
        }

        private string InputBox(string p1, string p2, string p3, int p4, int p5)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                ledstate.Text = state;     
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Open();

                arduino.Write("1");
                state = "ON";
                ledstate.Text = state;
                arduino.Close();
            }
            catch (TimeoutException exception)
            {
                Console.WriteLine(exception);
            }
            catch (InvalidOperationException ex1)
            {
                Console.WriteLine(ex1);
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Open();
                arduino.Write("0");
                state = "OFF";
                ledstate.Text = state;
                arduino.Close();
            }
            catch (TimeoutException exception)
            {
                Console.WriteLine(exception);
            }
            catch (InvalidOperationException ex1)
            {
                Console.WriteLine(ex1);
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void ledstate_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
