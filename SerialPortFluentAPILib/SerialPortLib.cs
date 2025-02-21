using System.IO.Ports;

namespace SerialPortFluentAPILib
{
    public class SerialPortLib
    {
        public static SerialPortLib serialPortLib = new SerialPortLib();
        public static SerialPortLib GetInstance
        {
            get
            {
                return serialPortLib;
            }        
        }
        SerialPort serialPort = new SerialPort();


        public SerialPortLib SetBaudRate(int baud)
        {

            this.serialPort.BaudRate = baud;
            return serialPortLib;
        }
        public SerialPortLib SetDataBits(int dataBits)
        {

            this.serialPort.DataBits = dataBits;
            return serialPortLib;
        }
        public SerialPortLib SetBytesToRead(Parity parity)
        {

            this.serialPort.Parity = parity;
            return serialPortLib;
        }
        public SerialPortLib SetPortName(String portName)
        {

            this.serialPort.PortName= portName;
            return serialPortLib;
        }
       



    }
}
