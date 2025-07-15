using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTrackSystem
{
    public partial class DevForms : Form
    {
        public DevForms()
        {
            InitializeComponent();
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void AdjustLayoutDatabaseForm()
        {
            int spacing = 10;

            if (groupBox4.Visible)
            {
                label4.Location = new Point(19, groupBox4.Bottom + spacing);
            }
            else
            {
                label4.Location = new Point(19, textBox1.Bottom + spacing);
            }

            textBox2.Location = new Point(label4.Left, label4.Bottom + spacing);
            btnsimpanDB.Location = new Point(textBox2.Left, textBox2.Bottom + spacing);

            int bottomMost = btnsimpanDB.Bottom + spacing;
            groupBox2.Height = bottomMost;
        }
        private void ResizeAndRepositionForm()
        {
            this.PerformLayout();
            this.Update();

            var screen = Screen.PrimaryScreen.WorkingArea;

            int paddingBottom = 60;
            int paddingRight = 20;

            int newHeight = groupBox2.Bottom + paddingBottom;
            int newWidth = this.Width;

            int posX = screen.Right - newWidth - paddingRight;
            int posY = screen.Bottom - newHeight;

            if (posY < screen.Top)
            {
                posY = screen.Top;
            }
            this.Size = new Size(newWidth, newHeight);
            this.Location = new Point(posX, posY);
        }
        private void LoadProjectList()
        {
            string filePath = Path.Combine(Application.StartupPath, "project-list.txt");

            comboBox1.Items.Clear(); 

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                string defaultItem = null;

                foreach (var line in lines)
                {
                    string item = line.Trim();
                    if (string.IsNullOrEmpty(item)) continue;

                    if (item.StartsWith("*"))
                    {
                        item = item.Substring(1);
                        defaultItem = item;
                    }

                    comboBox1.Items.Add(item);
                }

                if (!string.IsNullOrEmpty(defaultItem))
                {
                    comboBox1.SelectedItem = defaultItem;
                }
                else if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("File project-list.txt tidak ditemukan di folder aplikasi.", "Error");
            }
        }
        private void SetAutoStart(bool enable)
        {
            string appName = "DevTrackSystem";
            string exePath = Application.ExecutablePath;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enable)
            {
                rk.SetValue(appName, $"\"{exePath}\"");
            }
            else
            {
                rk.DeleteValue(appName, false);
            }
        }
        private void DevForms_Load(object sender, EventArgs e)
        {
            this.Text = "Catatan Developer";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            SetAutoStart(true);
            ShowFormInBottomRight();
            LoadProjectList();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void SubmitLog()
        {
            string folderPath = Path.Combine(Application.StartupPath, "Catatan");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string selectedProject = comboBox1.SelectedItem?.ToString() ?? "default";
            string filePath = Path.Combine(folderPath, $"{selectedProject}.json");

            var logEntry = new DevLogEntry
            {
                created_at = DateTime.Now,
                type = radioCode.Checked ? "code" : "db",
                file = textBox1.Text.Trim(),
                note = textBox2.Text.Trim(),
                author =  Environment.MachineName,
                project = selectedProject,
                subtype = radioCode.Checked ? null
                            : radioTable.Checked ? "table"
                            : RadioSP.Checked ? "sp"
                            : radioQuery.Checked ? "query"
                            : null

            };

            List<DevLogEntry> logs = new List<DevLogEntry>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                logs = JsonSerializer.Deserialize<List<DevLogEntry>>(json) ?? new List<DevLogEntry>();
            }

            logs.Add(logEntry);

            string updatedJson = JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);

            MessageBox.Show("Log berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
            radioCode.Checked = false;
            radioDB.Checked = false;
            radioQuery.Checked = false;
            RadioSP.Checked = false;
            groupBox2.Visible = false;
            if (this.Visible == false || this.WindowState == FormWindowState.Minimized)
            {
                ResizeAndRepositionForm();
                ShowFormInBottomRight();
                LoadProjectList();
                this.Show();
                this.BringToFront();
                this.Activate();
            }
            else
            {
                this.Hide();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioDB_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = radioDB.Checked;
            groupBox4.Visible = radioDB.Checked;
            LoadProjectList();
            AdjustLayoutDatabaseForm();
            ResizeAndRepositionForm();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Show();
            ShowFormInBottomRight();
            LoadProjectList();
            this.BringToFront();
            this.Activate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void panelCode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioCode_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = radioCode.Checked;
            groupBox2.Text = "Source Code";
            groupBox4.Visible = !radioCode.Checked;
            LoadProjectList();
            AdjustLayoutDatabaseForm();
            ResizeAndRepositionForm();

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false || this.WindowState == FormWindowState.Minimized)
            {
                ResizeAndRepositionForm();
                ShowFormInBottomRight();
                LoadProjectList();
                this.Show();
                this.BringToFront();
                this.Activate();
            }
            else
            {
                this.Hide();
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }

            base.OnFormClosing(e);
        }
        private void ShowFormInBottomRight()
        {
            this.PerformLayout();
            this.Update();
            var screen = Screen.PrimaryScreen.WorkingArea;
            int formWidth = 400;
            int formHeight = 300;

            int posX = screen.Right - formWidth;
            int posY = screen.Bottom - formHeight;

            this.Size = new Size(formWidth, formHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(posX, posY);

            this.Show();
            this.BringToFront();
            this.Activate();
        }

        private void radioTable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioSP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpanDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SubmitLog();
        }
    }
}
