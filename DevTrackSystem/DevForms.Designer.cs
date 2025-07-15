namespace DevTrackSystem
{
    partial class DevForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevForms));
            label1 = new Label();
            radioDB = new RadioButton();
            radioCode = new RadioButton();
            comboBox1 = new ComboBox();
            label2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnsimpanDB = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            groupBox4 = new GroupBox();
            radioTable = new RadioButton();
            RadioSP = new RadioButton();
            radioQuery = new RadioButton();
            label3 = new Label();
            textBox1 = new TextBox();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 0;
            label1.Text = "Pilih Kategori Perubahan";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // radioDB
            // 
            radioDB.AutoSize = true;
            radioDB.Location = new Point(16, 30);
            radioDB.Name = "radioDB";
            radioDB.Size = new Size(111, 29);
            radioDB.TabIndex = 1;
            radioDB.TabStop = true;
            radioDB.Text = "Database";
            radioDB.UseVisualStyleBackColor = true;
            radioDB.CheckedChanged += radioDB_CheckedChanged;
            // 
            // radioCode
            // 
            radioCode.AutoSize = true;
            radioCode.Location = new Point(187, 30);
            radioCode.Name = "radioCode";
            radioCode.Size = new Size(138, 29);
            radioCode.TabIndex = 2;
            radioCode.TabStop = true;
            radioCode.Text = "Source Code";
            radioCode.UseVisualStyleBackColor = true;
            radioCode.CheckedChanged += radioCode_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 36);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(268, 28);
            label2.TabIndex = 4;
            label2.Text = "Pilih Project (Setup by .txt)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "DevTrackMACF";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 68);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 32);
            toolStripMenuItem1.Text = "Open";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(128, 32);
            toolStripMenuItem2.Text = "Exit";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioCode);
            groupBox1.Controls.Add(radioDB);
            groupBox1.Location = new Point(15, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 71);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnsimpanDB);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(15, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 437);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database";
            groupBox2.UseCompatibleTextRendering = true;
            groupBox2.Visible = false;
            // 
            // btnsimpanDB
            // 
            btnsimpanDB.BackColor = Color.FromArgb(0, 192, 0);
            btnsimpanDB.ForeColor = SystemColors.Control;
            btnsimpanDB.Location = new Point(19, 375);
            btnsimpanDB.Name = "btnsimpanDB";
            btnsimpanDB.Size = new Size(322, 49);
            btnsimpanDB.TabIndex = 8;
            btnsimpanDB.Text = "Simpan";
            btnsimpanDB.UseVisualStyleBackColor = false;
            btnsimpanDB.Click += btnsimpanDB_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 186);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 4;
            label4.Text = "Catatan";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 132);
            textBox2.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioTable);
            groupBox4.Controls.Add(RadioSP);
            groupBox4.Controls.Add(radioQuery);
            groupBox4.Location = new Point(19, 102);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(322, 81);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipe ";
            // 
            // radioTable
            // 
            radioTable.AutoSize = true;
            radioTable.Location = new Point(124, 34);
            radioTable.Name = "radioTable";
            radioTable.Size = new Size(77, 29);
            radioTable.TabIndex = 2;
            radioTable.TabStop = true;
            radioTable.Text = "Table";
            radioTable.UseVisualStyleBackColor = true;
            // 
            // RadioSP
            // 
            RadioSP.AutoSize = true;
            RadioSP.Location = new Point(249, 34);
            RadioSP.Name = "RadioSP";
            RadioSP.Size = new Size(57, 29);
            RadioSP.TabIndex = 1;
            RadioSP.TabStop = true;
            RadioSP.Text = "SP";
            RadioSP.UseVisualStyleBackColor = true;
            RadioSP.CheckedChanged += RadioSP_CheckedChanged;
            // 
            // radioQuery
            // 
            radioQuery.AutoSize = true;
            radioQuery.Location = new Point(16, 35);
            radioQuery.Name = "radioQuery";
            radioQuery.Size = new Size(85, 29);
            radioQuery.TabIndex = 0;
            radioQuery.TabStop = true;
            radioQuery.Text = "Query";
            radioQuery.UseVisualStyleBackColor = true;
            radioQuery.CheckedChanged += radioTable_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 37);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 1;
            label3.Text = "Nama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 31);
            textBox1.TabIndex = 0;
            // 
            // DevForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 619);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "DevForms";
            Text = "DevForms";
            Load += DevForms_Load;
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioDB;
        private RadioButton radioCode;
        private ComboBox comboBox1;
        private Label label2;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private Label label3;
        private RadioButton RadioSP;
        private RadioButton radioQuery;
        private Label label4;
        private TextBox textBox2;
        private Button btnsimpanDB;
        private RadioButton radioTable;
    }
}