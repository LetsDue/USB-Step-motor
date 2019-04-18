using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;
using System.Threading;
namespace silnik_krokowy_RB
{
    public partial class Form1 : Form
    {

        FTDI device;
        FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
        FTDI.FT232B_EEPROM_STRUCTURE data = new FTDI.FT232B_EEPROM_STRUCTURE();
        int steps = 0;
        int sleep = 0;
        int index = 0;
        byte[] fullstepBytes = {  0x09, 0x05, 0x06, 0x0A };
        byte[] halfstepBytes = { 0x01, 0x05, 0x04, 0x06, 0x02, 0x0A, 0x08, 0x09 };
        byte[] wavestepBytes = { 0x01, 0x04, 0x02, 0x08 };

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                uint devices = 0;                                               //liczba urzadzen
                device = new FTDI();											//nowy obiekt typu FIDI 
                device.GetNumberOfDevices(ref devices);
                FTDI.FT_DEVICE_INFO_NODE[] ftdi_devices = new FTDI.FT_DEVICE_INFO_NODE[devices];
                device.GetDeviceList(ftdi_devices);
                device.OpenBySerialNumber(ftdi_devices[0].SerialNumber);
                device.SetBitMode(0xff, 1);
                console.AppendText("Connection successful\n");
                n_steps_left.Enabled = true;
                n_steps_right.Enabled = true;
                eeprom_btn.Enabled = true;
            }catch{
                console.AppendText("Connection failure!\n");
            }        
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] end = { 0x00 };
                uint bytesToWrite = 1;
                uint bytesWritten = 0;
                device.Write(end, bytesToWrite, ref bytesWritten);
                console.AppendText("Disconnect success!\n");
                device = null;
                n_steps_left.Enabled = false;
                n_steps_right.Enabled = false;
                eeprom_btn.Enabled = false;
            }
            catch
            {
                console.AppendText("Disconnect failed!\n");
            }   
        }

        private void n_steps_left_Click(object sender, EventArgs e)
        {
            steps = Int32.Parse(stepCount.Text);
            sleep = Int32.Parse(Interval.Text);
            if (sleep > 1000) sleep = 1000;
            uint bytesWritten = 0;
            byte[] controlByte = {0x00};
            if (modes.Text == "Fullstep")
            {
                for(int i = 0; i < steps; i++){
                    index++;
                    if(index > 3){
                        index %= 4;
                    }
                    
                    controlByte[0] = fullstepBytes[index];
                    
                    device.Write(controlByte, 1, ref bytesWritten);          
                    Thread.Sleep(sleep);       
                }
                device.Write(new byte[] { 0x00 }, 1, ref bytesWritten);
            }else
            if (modes.Text == "Halfstep")
            {
                for (int i = 0; i < steps; i++)
                {
                    index++;
                    if (index > 7)
                    {
                        index %= 8;
                    }

                    controlByte[0] = halfstepBytes[index];

                    device.Write(controlByte, 1, ref bytesWritten);
                    Thread.Sleep(sleep);
                }
                device.Write(new byte[] { 0x00 }, 1, ref bytesWritten);
            }else
            if (modes.Text == "Wavestep")
            {
                for (int i = 0; i < steps; i++)
                {
                    index++;
                    if (index > 3)
                    {
                        index %= 4;
                    }

                    controlByte[0] = wavestepBytes[index];

                    device.Write(controlByte, 1, ref bytesWritten);
                    Thread.Sleep(sleep);
                }
                device.Write(new byte[] { 0x00 }, 1, ref bytesWritten);
            }
        }

        private void n_steps_right_Click(object sender, EventArgs e)
        {
            steps = Int32.Parse(stepCount.Text);
            sleep = Int32.Parse(Interval.Text);
            if (sleep > 1000) sleep = 1000;
            uint bytesWritten = 0;
            byte[] controlByte = { 0x00 };
            if (modes.Text == "Fullstep")
            {
                for (int i = 0; i < steps; i++)
                {
                    index--;
                    if (index > 3)
                    {
                        index %= 4;
                    }
                    if (index < 0)
                    {
                        index = 3;
                    }
                    
                    controlByte[0] = fullstepBytes[index];
                    
                    device.Write(controlByte, 1, ref bytesWritten);
                    Thread.Sleep(sleep);
                }
                device.Write(new byte[] { 0x00 }, 1, ref bytesWritten);
            }else
            if (modes.Text == "Halfstep")
            {
                for (int i = 0; i < steps; i++)
                {
                    index--;
                    if (index < 0)
                    {
                        index = 7;
                    }

                    controlByte[0] = halfstepBytes[index];

                    device.Write(controlByte, 1, ref bytesWritten);
                    Thread.Sleep(sleep);
                }
                device.Write(new byte[] { 0x00 }, 1, ref bytesWritten);
            }
            else
            if (modes.Text == "Wavestep")
            {
                for (int i = 0; i < steps; i++)
                {
                    index--;
                    if (index > 3)
                    {
                        index %= 4;
                    }
                    if (index < 0)
                    {
                        index = 3;
                    }

                    controlByte[0] = wavestepBytes[index];

                    device.Write(controlByte, 1, ref bytesWritten);
                    Thread.Sleep(sleep);
                }
                device.Write(new byte[] { 0x00 }, 1, ref bytesWritten);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                byte[] end = { 0x00 };
                uint bytesToWrite = 1;
                uint bytesWritten = 0;
                if (device != null)
                {
                    device.Write(end, bytesToWrite, ref bytesWritten);
                }
                device = null;
            }
            catch
            {
                console.AppendText("Disconnect failed!\n");
            }
        }

        private void eeprom_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ftStatus = device.ReadFT232BEEPROM(data);
            }
            catch (FTDI.FT_EXCEPTION)
            {
                console.AppendText("Unable to get eeprom data\n");
            }
            if(ftStatus == FTDI.FT_STATUS.FT_OK){
                console.AppendText("------------------\n");
                console.AppendText("Vendor id: " + String.Format("{0:x}", data.VendorID) + "\n");
                console.AppendText("Product id: " + String.Format("{0:x}", data.ProductID) + "\n");
                console.AppendText("Manufacturer: " + data.Manufacturer.ToString() +  "\n");
                console.AppendText("Manufacturer id: " + data.ManufacturerID.ToString() + "\n");
                console.AppendText("Description: " + data.Description.ToString() + "\n");
                console.AppendText("Serial Number: " + data.SerialNumber.ToString() + "\n");
                console.AppendText("Max Power: " + data.MaxPower.ToString() + "\n");
                console.AppendText("Self powered: " + data.SelfPowered.ToString() + "\n");
                console.AppendText("Remote wakeup enabled: " + data.RemoteWakeup.ToString() + "\n");
                console.AppendText("------------------\n");
                console.ScrollToCaret();
                change_desc.Enabled = true;
                default_btn.Enabled = true;
            }
            
        }

        private void change_desc_Click(object sender, EventArgs e)
        {
            String desc = description_textbox.Text;
            data.Description = desc;
            try{
                ftStatus = device.WriteFT232BEEPROM(data);
            }catch(FTDI.FT_EXCEPTION){
                console.AppendText("Exception thrown when calling write function");
            }
        }

        private void default_btn_Click(object sender, EventArgs e)
        {
            data.Description = "usb step motor";
            try
            {
                ftStatus = device.WriteFT232BEEPROM(data);
            }
            catch (FTDI.FT_EXCEPTION)
            {
                console.AppendText("Exception thrown when calling write function");
            }
        }
    }
}
