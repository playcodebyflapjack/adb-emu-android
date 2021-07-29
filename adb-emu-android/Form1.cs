using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace adb_emu_android
{
    public partial class Form1 : Form
    {

        private ShellADBCLI callAdb = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void  btnBrowseFileAdb_Click(object sender, EventArgs e)
        {

            if (findFileAdb.ShowDialog() == DialogResult.OK)
            {
                string fullFilePathADB = findFileAdb.FileName;

                this.txtBoxPathADB.Text = fullFilePathADB;

                callAdb = new ShellADBCLI(fullFilePathADB);
                string[] listOfDevices = await callAdb.GetListOfIp();

                this.comboBoxDevices.Items.Clear();

                foreach (string device in listOfDevices)
                {
                    this.comboBoxDevices.Items.Add(device);
                }

            }

        }

        private void BtnClickADB_Click(object sender, EventArgs e)
        {
           string device =  this.comboBoxDevices.SelectedItem != null ? comboBoxDevices.SelectedItem.ToString() : "";
            if (!String.IsNullOrEmpty(device))
            {
                callAdb.Click(device, 122, 168);
            }
        }
    }
}
