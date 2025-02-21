using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortFluentAPILib;
using Superpower;

namespace SerialPortDeneme
{
    public partial class Form1: Form
    {
        SerialPortLib serialPortLib;
        public Form1()
        {
            InitializeComponent();
            serialPortLib = SerialPortLib.GetInstance;
        }
        private Parity parity;
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPortLib.SetPortName(textBox1.Text).SetDataBits(Int32.Parse(textBox2.Text)).SetDataBits(Int32.Parse(textBox3.Text)).SetBaudRate(Int32.Parse(textBox4.Text)).SetBytesToRead(parity);
        }
    }
}
