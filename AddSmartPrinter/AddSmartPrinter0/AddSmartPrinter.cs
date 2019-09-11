using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AddSmartPrinter0
{
    public partial class AddSmartPrinter : Form
    {

        string jsonFilePath = @"<location path>\Offices.json";


        List<JSONOffices> offices;

        Process process = new Process();


        public AddSmartPrinter()
        {
            InitializeComponent();

            loadJson();

            fillLocations();

            location_box.Sorted = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = setCommandArguments(location_box.Text),
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = false


            };

            process.StartInfo = processStartInfo;

            process.Start();
        }

        private void loadJson()
        {
            using (StreamReader jsonreader = new StreamReader(jsonFilePath))
            {
                string json = jsonreader.ReadToEnd();
                offices = JsonConvert.DeserializeObject<List<JSONOffices>>(json);
            };

        }

        private void fillLocations()
        { 
            foreach (JSONOffices office in offices)
            {
                location_box.Items.Add(office.OFFICE.ToString());
            }

        }

        private string setCommandArguments(string location)
        {
            string commandstring = null;

            foreach (JSONOffices office in offices)
            {
                if (office.OFFICE.ToString() == location)
                {
                    commandstring = @"/c rundll32 printui.dll,PrintUIEntry /in /n \\" + office.PRSERVER.ToString() + "\\" + office.PRNAME.ToString();
                }
            }

            return commandstring;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptrNotFound_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start Chrome <link to knowledge site where printer info is located>",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = false


            };

            process.StartInfo = processStartInfo;

            process.Start();
        }
    }
}
