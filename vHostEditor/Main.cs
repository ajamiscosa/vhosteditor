using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Ini.Net;

using System.Xml;
using System.Xml.Linq;

namespace vHostEditor
{
    public partial class Main : Form
    {
        private String XamppPath;
        private List<VirtualHostEntry> entries;


        public Main()
        {
            InitializeComponent();
            entries = new List<VirtualHostEntry>();
        }

        private void Load_Event(object sender, EventArgs e)
        {
            if (File.Exists("config.ini"))
            {
                IniFile ini = new IniFile("config.ini");
                if(ini.SectionExists("Config"))
                {
                    XamppPath = ini.ReadString("Config", "XAMPP");
                }
                else
                {
                    MessageBox.Show("Corrupted ini file. Paths will need to be reconfigured.");
                    FindXAMPP();
                }
            }
            else
            {
                FindXAMPP();
            }

            LoadvHostEntries();
        }

        private bool FindXAMPP()
        {
            try
            {
                RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
                string location = Util.FindByDisplayName(regKey, "xampp");
                MessageBox.Show(location);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to find XAMPP. Please locate folder instead.");
                exc:
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Locate XAMPP Installation Folder.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    XamppPath = fbd.SelectedPath;
                    if(File.Exists(String.Format(@"{0}\xampp-control.exe", XamppPath)))
                    {
                        IniFile ini = new IniFile("config.ini");
                        ini.WriteString("Config", "XAMPP", XamppPath);
                        
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Selected folder doesn't appear to be a valid XAMPP folder. Please try again.");
                        goto exc;
                    }
                }
            }

            MessageBox.Show("Unable to find valid XAMPP installation. Closing application.");
            Environment.Exit(-1);
            return false;
        }

        private void LoadvHostEntries()
        {
            try
            {
                String vHostPath = String.Format(@"{0}\apache\conf\extra\httpd-vhosts.conf", XamppPath);

                using (StreamReader reader = new StreamReader(vHostPath))
                {
                    VirtualHostEntry entry = null;
                    while(!reader.EndOfStream)
                    {
                        String line = reader.ReadLine();
                        line = line.Trim();
                        line = line.Trim(' ', '<', '>');
                        if (line.StartsWith("#") || line.StartsWith("\n")) continue;

                        if (!String.IsNullOrEmpty(line))
                        {
                            if (line.StartsWith("VirtualHost"))
                            {
                                entry = new VirtualHostEntry();
                            }
                            else if (line.StartsWith("DocumentRoot"))
                            {
                                entry.DocumentRoot = line.Remove("DocumentRoot").Replace('\\','/').Trim(' ', '"', '/');
                            }
                            else if (line.StartsWith("ServerName"))
                            {
                                entry.ServerName = line.Remove("ServerName").Trim();
                            }
                            else if (line.StartsWith("ServerAlias"))
                            {
                                entry.ServerAlias = line.Remove("ServerAlias").Trim();
                            }
                            else if (line.StartsWith("Directory"))
                            {
                                entry.BaseDirectory = line.Remove("Directory").Replace('\\', '/').Trim(' ', '"', '/');
                            }
                            else if (line.StartsWith("/VirtualHost"))
                            {
                                entries.Add(entry);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            foreach(var entry in entries)
            {
                listBox1.Items.Add(entry.ServerName);
            }
        }

        private void KeyPressedOnForm(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.F5)
            {
                listBox1.SelectedIndex = -1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FieldsAreEnabled(true);
            ClearFields();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                if (MessageBox.Show(this, "Remove entry from the list?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int idx = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(idx);
                    entries.RemoveAt(idx);
                    UpdateVHostEntries();
                    MessageBox.Show("vHost Entries Updated","Success");
                    ClearFields();
                    FieldsAreEnabled(false);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                FieldsAreEnabled(true);
            }
        }

        private void UpdateVHostEntries()
        {
            String vHostPath = String.Format(@"{0}\apache\conf\extra\httpd-vhosts.conf", XamppPath);

            using (TextWriter writer = new StreamWriter(vHostPath, false))
            {
                writer.WriteLine(Properties.Resources.Header);
                foreach (var entry in entries)
                {
                    writer.Write(entry);
                }
                writer.Flush();
            }

            String hostsPath = @"C:\Windows\System32\Drivers\etc\hosts";
            List<String> strLines = File.ReadAllLines(hostsPath).ToList();
            
            foreach(var entry in entries)
            {
                if(!strLines.Contains(String.Format("127.0.0.1\t{0}", entry.ServerAlias)))
                {
                    strLines.Add(String.Format("127.0.0.1\t{0}", entry.ServerAlias));
                }
            }


            using (TextWriter writer = new StreamWriter(hostsPath, false))
            {
                foreach (string line in strLines)
                {
                    writer.WriteLine(line);
                }
                writer.Flush();
            }

        }

        private void btnDocRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Document Root";
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                String selectedPath = fbd.SelectedPath;
                txtDocumentRoot.Text = selectedPath;
                if(selectedPath.EndsWith("public")) // laravel
                {
                    txtDirectory.Text = selectedPath.Remove("public").TrimEnd('/');
                }
                else
                {
                    txtDirectory.Text = selectedPath.TrimEnd('/');
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                VirtualHostEntry entry = entries[listBox1.SelectedIndex];
                txtDirectory.Text = entry.BaseDirectory;
                txtDocumentRoot.Text = entry.DocumentRoot;
                txtServerAlias.Text = entry.ServerAlias;
                txtServerName.Text = entry.ServerName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            VirtualHostEntry entry = new VirtualHostEntry();
            
            if (index != -1)
            {
                entry = entries[index];
            }

            entry.BaseDirectory = txtDirectory.Text.Replace('\\','/');
            entry.DocumentRoot = txtDocumentRoot.Text.Replace('\\', '/');
            entry.ServerAlias = txtServerAlias.Text;
            entry.ServerName = txtServerName.Text;


            if (index != -1)
            {
                entries.RemoveAt(index);
                entries.Insert(index, entry);
            }
            else
            {
                entries.Add(entry);
                listBox1.Items.Add(entry.ServerName);
            }



            FieldsAreEnabled(false);

            ClearFields();

            listBox1.SelectedIndex = -1;

            UpdateVHostEntries();
            MessageBox.Show("Host entries updated.", "Success");
        }

        private void FieldsAreEnabled(bool enabled)
        {
            listBox1.SelectedIndex = -1;

            btnDir.Enabled =
            btnDocRoot.Enabled =
            btnSave.Enabled =
            txtDirectory.Enabled =
            txtDocumentRoot.Enabled =
            txtServerAlias.Enabled =
            txtServerName.Enabled =
            btnCancel.Visible = enabled;

            btnNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = listBox1.Enabled = !enabled;

        }

        private void ClearFields()
        {
            txtDirectory.Text =
            txtDocumentRoot.Text =
            txtServerAlias.Text =
            txtServerName.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FieldsAreEnabled(false);
            ClearFields();
        }
    }
}
