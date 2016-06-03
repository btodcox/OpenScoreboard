namespace OpenScoreboard
{
    partial class frmNotifier
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
            this.components = new System.ComponentModel.Container();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnStartScoreboard = new System.Windows.Forms.Button();
            this.lstNotification = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.btnBrowseDir = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLog = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnTestCOM = new System.Windows.Forms.Button();
            this.cboCOMPorts = new System.Windows.Forms.ComboBox();
            this.btnListCOMPorts = new System.Windows.Forms.Button();
            this.TimeLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventUp = new System.Windows.Forms.Button();
            this.EventDown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HeatUp = new System.Windows.Forms.Button();
            this.HeatDown = new System.Windows.Forms.Button();
            this.heatTextBox = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.LaneNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.plLane1 = new System.Windows.Forms.Label();
            this.timeLane1 = new System.Windows.Forms.Label();
            this.plLane2 = new System.Windows.Forms.Label();
            this.plLane3 = new System.Windows.Forms.Label();
            this.plLane4 = new System.Windows.Forms.Label();
            this.plLane5 = new System.Windows.Forms.Label();
            this.plLane6 = new System.Windows.Forms.Label();
            this.plLane7 = new System.Windows.Forms.Label();
            this.plLane8 = new System.Windows.Forms.Label();
            this.timeLane2 = new System.Windows.Forms.Label();
            this.timeLane3 = new System.Windows.Forms.Label();
            this.timeLane4 = new System.Windows.Forms.Label();
            this.timeLane5 = new System.Windows.Forms.Label();
            this.timeLane6 = new System.Windows.Forms.Label();
            this.timeLane7 = new System.Windows.Forms.Label();
            this.timeLane8 = new System.Windows.Forms.Label();
            this.TimeLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(23, 27);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(268, 20);
            this.txtFile.TabIndex = 0;
            this.txtFile.Text = "C:\\CTSDolphin";
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(22, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(224, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Directory for CTS Dolphin Files (*.do3)";
            // 
            // btnStartScoreboard
            // 
            this.btnStartScoreboard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStartScoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartScoreboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartScoreboard.Location = new System.Drawing.Point(337, 566);
            this.btnStartScoreboard.Name = "btnStartScoreboard";
            this.btnStartScoreboard.Size = new System.Drawing.Size(119, 23);
            this.btnStartScoreboard.TabIndex = 4;
            this.btnStartScoreboard.Text = "Start Scoreboard";
            this.btnStartScoreboard.UseVisualStyleBackColor = false;
            this.btnStartScoreboard.Click += new System.EventHandler(this.btnWatchFile_Click);
            // 
            // lstNotification
            // 
            this.lstNotification.FormattingEnabled = true;
            this.lstNotification.Location = new System.Drawing.Point(25, 393);
            this.lstNotification.Name = "lstNotification";
            this.lstNotification.Size = new System.Drawing.Size(431, 160);
            this.lstNotification.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status Log";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
            this.tmrEditNotify.Tick += new System.EventHandler(this.tmrEditNotify_Tick);
            // 
            // btnBrowseDir
            // 
            this.btnBrowseDir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowseDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseDir.Location = new System.Drawing.Point(297, 24);
            this.btnBrowseDir.Name = "btnBrowseDir";
            this.btnBrowseDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDir.TabIndex = 8;
            this.btnBrowseDir.Text = "Browse";
            this.btnBrowseDir.UseVisualStyleBackColor = false;
            this.btnBrowseDir.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // dlgOpenDir
            // 
            this.dlgOpenDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Location = new System.Drawing.Point(14, 566);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(119, 23);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Save Log to File";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "log";
            this.dlgSaveFile.Filter = "LogFiles|*.log";
            // 
            // btnTestCOM
            // 
            this.btnTestCOM.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTestCOM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestCOM.Location = new System.Drawing.Point(302, 54);
            this.btnTestCOM.Name = "btnTestCOM";
            this.btnTestCOM.Size = new System.Drawing.Size(106, 23);
            this.btnTestCOM.TabIndex = 10;
            this.btnTestCOM.Text = "Test COM Port";
            this.btnTestCOM.UseVisualStyleBackColor = false;
            this.btnTestCOM.Click += new System.EventHandler(this.btnTestCOMport);
            // 
            // cboCOMPorts
            // 
            this.cboCOMPorts.FormattingEnabled = true;
            this.cboCOMPorts.Location = new System.Drawing.Point(163, 54);
            this.cboCOMPorts.Name = "cboCOMPorts";
            this.cboCOMPorts.Size = new System.Drawing.Size(133, 21);
            this.cboCOMPorts.TabIndex = 11;
            this.cboCOMPorts.Text = "No Ports";
            this.cboCOMPorts.SelectedIndexChanged += new System.EventHandler(this.cboCOMPorts_SelectedIndexChanged);
            // 
            // btnListCOMPorts
            // 
            this.btnListCOMPorts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListCOMPorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListCOMPorts.Location = new System.Drawing.Point(51, 53);
            this.btnListCOMPorts.Name = "btnListCOMPorts";
            this.btnListCOMPorts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListCOMPorts.Size = new System.Drawing.Size(106, 23);
            this.btnListCOMPorts.TabIndex = 12;
            this.btnListCOMPorts.Text = "Query COM Ports";
            this.btnListCOMPorts.UseVisualStyleBackColor = false;
            this.btnListCOMPorts.Click += new System.EventHandler(this.btnQueryCOMPorts_click);
            // 
            // TimeLayoutPanel1
            // 
            this.TimeLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TimeLayoutPanel1.ColumnCount = 3;
            this.TimeLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TimeLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TimeLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TimeLayoutPanel1.Controls.Add(this.timeLane8, 2, 8);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane7, 2, 7);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane6, 2, 6);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane5, 2, 5);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane4, 2, 4);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane3, 2, 3);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane2, 2, 2);
            this.TimeLayoutPanel1.Controls.Add(this.plLane8, 1, 8);
            this.TimeLayoutPanel1.Controls.Add(this.plLane7, 1, 7);
            this.TimeLayoutPanel1.Controls.Add(this.plLane6, 1, 6);
            this.TimeLayoutPanel1.Controls.Add(this.plLane5, 1, 5);
            this.TimeLayoutPanel1.Controls.Add(this.plLane4, 1, 4);
            this.TimeLayoutPanel1.Controls.Add(this.plLane3, 1, 3);
            this.TimeLayoutPanel1.Controls.Add(this.plLane2, 1, 2);
            this.TimeLayoutPanel1.Controls.Add(this.timeLane1, 2, 1);
            this.TimeLayoutPanel1.Controls.Add(this.plLane1, 1, 1);
            this.TimeLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.TimeLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.TimeLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.TimeLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.TimeLayoutPanel1.Controls.Add(this.LaneNum, 0, 0);
            this.TimeLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.TimeLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.TimeLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.TimeLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.TimeLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.TimeLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.TimeLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLayoutPanel1.Location = new System.Drawing.Point(70, 156);
            this.TimeLayoutPanel1.Name = "TimeLayoutPanel1";
            this.TimeLayoutPanel1.RowCount = 9;
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TimeLayoutPanel1.Size = new System.Drawing.Size(336, 204);
            this.TimeLayoutPanel1.TabIndex = 13;
            this.TimeLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(52, 23);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(35, 22);
            this.eventTextBox.TabIndex = 14;
            this.eventTextBox.Text = "1";
            this.eventTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EventUp);
            this.groupBox1.Controls.Add(this.EventDown);
            this.groupBox1.Controls.Add(this.eventTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // EventUp
            // 
            this.EventUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventUp.Location = new System.Drawing.Point(93, 16);
            this.EventUp.Name = "EventUp";
            this.EventUp.Size = new System.Drawing.Size(29, 31);
            this.EventUp.TabIndex = 17;
            this.EventUp.Text = "+";
            this.EventUp.UseVisualStyleBackColor = true;
            this.EventUp.Click += new System.EventHandler(this.EventUp_Click);
            // 
            // EventDown
            // 
            this.EventDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDown.Location = new System.Drawing.Point(17, 16);
            this.EventDown.Name = "EventDown";
            this.EventDown.Size = new System.Drawing.Size(29, 31);
            this.EventDown.TabIndex = 16;
            this.EventDown.Text = "-";
            this.EventDown.UseVisualStyleBackColor = true;
            this.EventDown.Click += new System.EventHandler(this.EventDown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HeatUp);
            this.groupBox2.Controls.Add(this.HeatDown);
            this.groupBox2.Controls.Add(this.heatTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(265, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 57);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heat";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // HeatUp
            // 
            this.HeatUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeatUp.Location = new System.Drawing.Point(93, 16);
            this.HeatUp.Name = "HeatUp";
            this.HeatUp.Size = new System.Drawing.Size(29, 31);
            this.HeatUp.TabIndex = 17;
            this.HeatUp.Text = "+";
            this.HeatUp.UseVisualStyleBackColor = true;
            this.HeatUp.Click += new System.EventHandler(this.HeatUp_Click);
            // 
            // HeatDown
            // 
            this.HeatDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeatDown.Location = new System.Drawing.Point(17, 16);
            this.HeatDown.Name = "HeatDown";
            this.HeatDown.Size = new System.Drawing.Size(29, 31);
            this.HeatDown.TabIndex = 16;
            this.HeatDown.Text = "-";
            this.HeatDown.UseVisualStyleBackColor = true;
            this.HeatDown.Click += new System.EventHandler(this.HeatDown_Click);
            // 
            // heatTextBox
            // 
            this.heatTextBox.Location = new System.Drawing.Point(52, 22);
            this.heatTextBox.Name = "heatTextBox";
            this.heatTextBox.Size = new System.Drawing.Size(35, 22);
            this.heatTextBox.TabIndex = 14;
            this.heatTextBox.Text = "1";
            this.heatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(399, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(57, 23);
            this.btnAbout.TabIndex = 19;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // LaneNum
            // 
            this.LaneNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LaneNum.AutoSize = true;
            this.LaneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaneNum.Location = new System.Drawing.Point(5, 2);
            this.LaneNum.Name = "LaneNum";
            this.LaneNum.Size = new System.Drawing.Size(76, 20);
            this.LaneNum.TabIndex = 0;
            this.LaneNum.Text = "Lane";
            this.LaneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "5";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "6";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "7";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "8";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane1
            // 
            this.plLane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane1.AutoSize = true;
            this.plLane1.Location = new System.Drawing.Point(89, 24);
            this.plLane1.Name = "plLane1";
            this.plLane1.Size = new System.Drawing.Size(76, 20);
            this.plLane1.TabIndex = 11;
            this.plLane1.Text = "-";
            this.plLane1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane1
            // 
            this.timeLane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane1.AutoSize = true;
            this.timeLane1.Location = new System.Drawing.Point(173, 24);
            this.timeLane1.Name = "timeLane1";
            this.timeLane1.Size = new System.Drawing.Size(158, 20);
            this.timeLane1.TabIndex = 12;
            this.timeLane1.Text = "----";
            this.timeLane1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane2
            // 
            this.plLane2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane2.AutoSize = true;
            this.plLane2.Location = new System.Drawing.Point(89, 46);
            this.plLane2.Name = "plLane2";
            this.plLane2.Size = new System.Drawing.Size(76, 20);
            this.plLane2.TabIndex = 13;
            this.plLane2.Text = "-";
            this.plLane2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane3
            // 
            this.plLane3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane3.AutoSize = true;
            this.plLane3.Location = new System.Drawing.Point(89, 68);
            this.plLane3.Name = "plLane3";
            this.plLane3.Size = new System.Drawing.Size(76, 20);
            this.plLane3.TabIndex = 15;
            this.plLane3.Text = "-";
            this.plLane3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane4
            // 
            this.plLane4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane4.AutoSize = true;
            this.plLane4.Location = new System.Drawing.Point(89, 90);
            this.plLane4.Name = "plLane4";
            this.plLane4.Size = new System.Drawing.Size(76, 20);
            this.plLane4.TabIndex = 17;
            this.plLane4.Text = "-";
            this.plLane4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane5
            // 
            this.plLane5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane5.AutoSize = true;
            this.plLane5.Location = new System.Drawing.Point(89, 112);
            this.plLane5.Name = "plLane5";
            this.plLane5.Size = new System.Drawing.Size(76, 20);
            this.plLane5.TabIndex = 19;
            this.plLane5.Text = "-";
            this.plLane5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane6
            // 
            this.plLane6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane6.AutoSize = true;
            this.plLane6.Location = new System.Drawing.Point(89, 134);
            this.plLane6.Name = "plLane6";
            this.plLane6.Size = new System.Drawing.Size(76, 20);
            this.plLane6.TabIndex = 21;
            this.plLane6.Text = "-";
            this.plLane6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane7
            // 
            this.plLane7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane7.AutoSize = true;
            this.plLane7.Location = new System.Drawing.Point(89, 156);
            this.plLane7.Name = "plLane7";
            this.plLane7.Size = new System.Drawing.Size(76, 20);
            this.plLane7.TabIndex = 23;
            this.plLane7.Text = "-";
            this.plLane7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plLane8
            // 
            this.plLane8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plLane8.AutoSize = true;
            this.plLane8.Location = new System.Drawing.Point(89, 178);
            this.plLane8.Name = "plLane8";
            this.plLane8.Size = new System.Drawing.Size(76, 24);
            this.plLane8.TabIndex = 25;
            this.plLane8.Text = "-";
            this.plLane8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane2
            // 
            this.timeLane2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane2.AutoSize = true;
            this.timeLane2.Location = new System.Drawing.Point(173, 46);
            this.timeLane2.Name = "timeLane2";
            this.timeLane2.Size = new System.Drawing.Size(158, 20);
            this.timeLane2.TabIndex = 26;
            this.timeLane2.Text = "----";
            this.timeLane2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane3
            // 
            this.timeLane3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane3.AutoSize = true;
            this.timeLane3.Location = new System.Drawing.Point(173, 68);
            this.timeLane3.Name = "timeLane3";
            this.timeLane3.Size = new System.Drawing.Size(158, 20);
            this.timeLane3.TabIndex = 27;
            this.timeLane3.Text = "----";
            this.timeLane3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane4
            // 
            this.timeLane4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane4.AutoSize = true;
            this.timeLane4.Location = new System.Drawing.Point(173, 90);
            this.timeLane4.Name = "timeLane4";
            this.timeLane4.Size = new System.Drawing.Size(158, 20);
            this.timeLane4.TabIndex = 28;
            this.timeLane4.Text = "----";
            this.timeLane4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane5
            // 
            this.timeLane5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane5.AutoSize = true;
            this.timeLane5.Location = new System.Drawing.Point(173, 112);
            this.timeLane5.Name = "timeLane5";
            this.timeLane5.Size = new System.Drawing.Size(158, 20);
            this.timeLane5.TabIndex = 29;
            this.timeLane5.Text = "----";
            this.timeLane5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane6
            // 
            this.timeLane6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane6.AutoSize = true;
            this.timeLane6.Location = new System.Drawing.Point(173, 134);
            this.timeLane6.Name = "timeLane6";
            this.timeLane6.Size = new System.Drawing.Size(158, 20);
            this.timeLane6.TabIndex = 30;
            this.timeLane6.Text = "----";
            this.timeLane6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane7
            // 
            this.timeLane7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane7.AutoSize = true;
            this.timeLane7.Location = new System.Drawing.Point(173, 156);
            this.timeLane7.Name = "timeLane7";
            this.timeLane7.Size = new System.Drawing.Size(158, 20);
            this.timeLane7.TabIndex = 31;
            this.timeLane7.Text = "----";
            this.timeLane7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLane8
            // 
            this.timeLane8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLane8.AutoSize = true;
            this.timeLane8.Location = new System.Drawing.Point(173, 178);
            this.timeLane8.Name = "timeLane8";
            this.timeLane8.Size = new System.Drawing.Size(158, 24);
            this.timeLane8.TabIndex = 32;
            this.timeLane8.Text = "----";
            this.timeLane8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNotifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 621);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeLayoutPanel1);
            this.Controls.Add(this.btnListCOMPorts);
            this.Controls.Add(this.cboCOMPorts);
            this.Controls.Add(this.btnTestCOM);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNotification);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnStartScoreboard);
            this.Controls.Add(this.btnBrowseDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNotifier";
            this.Text = "OpenScoreboard, an Eagle Scout Project by David Cox";
            this.Load += new System.EventHandler(this.frmNotifier_Load);
            this.TimeLayoutPanel1.ResumeLayout(false);
            this.TimeLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnStartScoreboard;
        private System.Windows.Forms.ListBox lstNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrEditNotify;
        private System.Windows.Forms.Button btnBrowseDir;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenDir;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.Button btnTestCOM;
        private System.Windows.Forms.ComboBox cboCOMPorts;
        private System.Windows.Forms.Button btnListCOMPorts;
        private System.Windows.Forms.TableLayoutPanel TimeLayoutPanel1;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EventUp;
        private System.Windows.Forms.Button EventDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button HeatUp;
        private System.Windows.Forms.Button HeatDown;
        private System.Windows.Forms.TextBox heatTextBox;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LaneNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timeLane8;
        private System.Windows.Forms.Label timeLane7;
        private System.Windows.Forms.Label timeLane6;
        private System.Windows.Forms.Label timeLane5;
        private System.Windows.Forms.Label timeLane4;
        private System.Windows.Forms.Label timeLane3;
        private System.Windows.Forms.Label timeLane2;
        private System.Windows.Forms.Label plLane8;
        private System.Windows.Forms.Label plLane7;
        private System.Windows.Forms.Label plLane6;
        private System.Windows.Forms.Label plLane5;
        private System.Windows.Forms.Label plLane4;
        private System.Windows.Forms.Label plLane3;
        private System.Windows.Forms.Label plLane2;
        private System.Windows.Forms.Label timeLane1;
        private System.Windows.Forms.Label plLane1;
    }
}

