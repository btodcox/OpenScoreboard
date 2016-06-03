// OpenScoreboard is an Eagle Scout project by David Cox
//
// (C) 2014-2016 B. Tod Cox & David Cox
// 
// http://www.codeproject.com/Articles/26528/C-Application-to-Watch-a-File-or-Directory-using-F 
//     by Prashat K. Singh was used as a starting point for the file watcher aspect
//     of this code.  
//  
// Scoreboard code does not flag or score ties between times.
//   

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace OpenScoreboard
{
    public partial class frmNotifier : Form
    {
        private StringBuilder m_Sb;
        private bool m_bDirty;
        private bool COMgood = false; // true if have successful connected to OpenScoreboard adapter
        private System.IO.FileSystemWatcher m_Watcher;
        private bool m_bIsWatching;   // true if Scoreboard enabled, false otherwise

        SerialPort ComPort = new SerialPort();
        internal delegate void SerialDataReceivedEventHandlerDelegate(
                 object sender, SerialDataReceivedEventArgs e);

        internal delegate void SerialPinChangedEventHandlerDelegate(
                 object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        delegate void SetTextCallback2(string text, string text2);
        string InputData = String.Empty;
        private int heat = 0;
        private int evnt = 1;

        public frmNotifier()
        {
            InitializeComponent();
            m_Sb = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;


            //         ComPort.DataReceived +=
            //           new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

        }

        private void btnWatchFile_Click(object sender, EventArgs e)
        {
            if (m_bIsWatching)
            {
                m_bIsWatching = false;
                m_Watcher.EnableRaisingEvents = false;
                m_Watcher.Dispose();
                btnStartScoreboard.BackColor = Color.LightSkyBlue;
                btnStartScoreboard.Text = "Start Scoreboard";

            }
            else if (COMgood) // make sure OpenScoreboard adapter is connected and has been successfully tested
            {
               
                m_bIsWatching = true;
                // start filesystemwatcher
                btnStartScoreboard.BackColor = Color.Red;
                btnStartScoreboard.Text = "Stop Scoreboard";

                m_Watcher = new System.IO.FileSystemWatcher();
                m_Watcher.Filter = "*.do3";  // only watch for Dolphin *.do3 files; note: no support for *.do4 files with splits
                m_Watcher.Path = txtFile.Text + "\\";
                m_Watcher.IncludeSubdirectories = true; // just in case


                m_Watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
                m_Watcher.Created += new FileSystemEventHandler(OnChanged);
                m_Watcher.EnableRaisingEvents = true;

                //open COM port to OpenScoreboard adapter
                ComPort.PortName = Convert.ToString(cboCOMPorts.Text);
                ComPort.BaudRate = 115200;
                ComPort.DataBits = 8;
                ComPort.StopBits = StopBits.One;
                ComPort.Parity = Parity.None;
                ComPort.ReadTimeout = 5000;
                ComPort.Open();
            }
            else
            {
                MessageBox.Show("\"Test COM Port\" button must be the color Green before Scoreboard will start.\n\n"+
                                "Press \"Test COM Port\" button to verify communication with \n" +
                                "OpenScoreboard adapter before pressing \"Start Scoreboard\" button.\n");
            }
        }
        public static bool IsFileReady(String sFilename)
        {
            // If the file can be opened for exclusive access it means that the file
            // is no longer locked by another process.
            try
            {
                using (FileStream inputStream = File.Open(sFilename, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    if (inputStream.Length > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string laneData;
            string laneTemp, timeTemp;
            string[] watchTimes;
            decimal w1, w2, w3;
            decimal laneTime;
            int intLaneTime;
            int oof;
            int minutes;
            int seconds;
            int hundredths;
            DataTable dt_times = new DataTable();
      //      DataTable dt_paneltimes = new DataTable();

            if (!m_bDirty)  
            {
                m_Sb.Remove(0, m_Sb.Length);
                m_Sb.Append(DateTime.Now.ToString());
                m_Sb.Append(" ");
                m_Sb.Append(e.FullPath);
                m_Sb.Append(" ");
                m_Sb.Append(e.ChangeType.ToString());
                m_bDirty = true;
            }
            while (!IsFileReady(e.FullPath)) 
            {
                //do nothing until file is until *.do3 file is completely written by Dolphin software and not locked by Meet Manager
            }
            System.IO.StreamReader file = new System.IO.StreamReader(e.FullPath);
            laneData = file.ReadLine(); //skip the first line of the *.do3 file
            laneTime = 0;
            dt_times.Columns.Add("Lane", typeof(string));
            dt_times.Columns.Add("Time", typeof(int));
         //   dt_times.Columns.Add("TimeSpan", typeof(string));
            for (int i=1; i <= 8; i++)  // only handles 8 lanes; easy to mod for more lanes.
            {
                laneData = file.ReadLine();
                Debug.WriteLine(laneData);
                watchTimes = laneData.Split(new char[]{ ';' }, StringSplitOptions.RemoveEmptyEntries);  // *.do3 file are semicolon delimited, parse and drop empty watch times
                switch (watchTimes.Length - 1) // number of available watch times as first element of array is lane number
                {
                    case 0: //no watch times for this lane
                        laneTime = 0;
                        break; 
                    case 1: //1 watch time, so it is the time
                        laneTime = decimal.Parse(watchTimes[1]);
                        break;
                    case 2: // 2 watch times, so average watches to get time
                        laneTime = decimal.Round((decimal.Parse(watchTimes[1]) + decimal.Parse(watchTimes[2]))/2,2,MidpointRounding.AwayFromZero);
                        break;
                    case 3: //3 watches times, so middle watch time is official time
                        w1 = decimal.Parse(watchTimes[1]);
                        w2 = decimal.Parse(watchTimes[2]);
                        w3 = decimal.Parse(watchTimes[3]);
                        if ((w1 >= w2) && (w2 >= w3)) laneTime = w2;
                        if ((w1 >= w3) && (w3 >= w2)) laneTime = w3;
                        if ((w2 >= w1) && (w1 >= w3)) laneTime = w1;
                        if ((w2 >= w3) && (w3 >= w1)) laneTime = w3;
                        if ((w3 >= w1) && (w1 >= w2)) laneTime = w1;
                        if ((w3 >= w2) && (w2 >= w1)) laneTime = w2;
                        break;
                }

                
                Debug.WriteLine(laneTime.ToString());
                intLaneTime = decimal.ToInt32(laneTime*100); // clear decimal; not needed for display
                if ( watchTimes.Length != 1) //check to see if lane had a time
                {
                    dt_times.Rows.Add(watchTimes[0], intLaneTime); //store lane and lane time in data table
                }
            }
            
            file.Close(); //done with parsing file, so close it as soon as possible

            //now we need to sort the valid times to get order of finish
            DataView dv_times = dt_times.DefaultView;
            dv_times.Sort = "Time ASC";
            dt_times = dv_times.ToTable();

             // record oof (order of finish) and format times for display on screen and on scoreboard
            dt_times.Columns.Add("Place", typeof(string)); // add order of finish to data table
            dt_times.Columns.Add("timeScreen", typeof(string)); //formatted for display on monitor
            dt_times.Columns.Add("timeBoard", typeof(string));  //formatted for display on scoreboard
            for (oof = 0; oof < dt_times.Rows.Count; oof++ )
            {
                dt_times.Rows[oof]["Place"] = (oof+1).ToString();
                intLaneTime = Convert.ToInt32(dt_times.Rows[oof]["Time"]);
                if (intLaneTime > 5999) //check to see if we need to format mm:ss.hh
                {
                    minutes = intLaneTime / 6000;
                    seconds = intLaneTime - minutes*6000;
                    hundredths = seconds - (seconds / 100) * 100;
                    dt_times.Rows[oof]["timeBoard"] = string.Format("{0}{1:D4}", minutes, seconds);
                    dt_times.Rows[oof]["timeScreen"] = string.Format("{0}:{1:D2}.{2:D2}", minutes, seconds/100, hundredths);
                }
                else
                {
                    seconds = intLaneTime;
                    hundredths = seconds - (seconds / 100) * 100;
                    dt_times.Rows[oof]["timeBoard"] =  intLaneTime.ToString();
                    dt_times.Rows[oof]["timeScreen"] = string.Format("{0}.{1:D2}", seconds/100, hundredths);
                }
                
            }


          //  //    oof = 1;
          //  foreach ( DataRow place in dt_times.Rows)
          //  {
          //      Debug.Write("Ln Tm Pl: ");
          //    //  Debug.Write(oof++);
          ////      Debug.Write(place.ToString());
          //      Debug.Write(" Ln ");
          //      foreach (var item in place.ItemArray)
          //      {
          //          Debug.Write(item);
          //          Debug.Write(" ");
          //      }
          //      Debug.WriteLine(" ");
          //  }

            heat += 1; // auto increment Heat number
            this.SetHeatText(heat.ToString());
            // output to serial port for broadcast to 
            Debug.WriteLine("Sending data to COM port:");
            ComPort.WriteLine("OSB 15");  //clear OpenScoreboard prior to sending times
            Thread.Sleep(250); //give the scoreboard time to clear
            laneData = string.Format("OSB 0 {0,2}{1,2}    ", eventTextBox.Text, heatTextBox.Text ); //update event and heat
            ComPort.WriteLine(laneData);
            
            Debug.WriteLine(laneData);
            for (oof = 0; oof < dt_times.Rows.Count; oof++)
            {
                laneData = string.Format("OSB {0} {1}{2,6}", dt_times.Rows[oof]["Lane"], oof+1, dt_times.Rows[oof]["timeBoard"]);
                ComPort.WriteLine(laneData);
                Debug.WriteLine(laneData);
                Thread.Sleep(100);
            }
            
            // finally, update scoreboard panel on windows form
            // clear out last heat, then update with new data, not pretty nor elegant, but it works
            this.SetLane1("-", "----");
            this.SetLane2("-", "----");
            this.SetLane3("-", "----");
            this.SetLane4("-", "----");
            this.SetLane5("-", "----");
            this.SetLane6("-", "----");
            this.SetLane7("-", "----");
            this.SetLane8("-", "----");
            for ( oof = 0; oof < dt_times.Rows.Count; oof++)
            {
                string txt = dt_times.Rows[oof]["Place"].ToString();
                string txt2 = dt_times.Rows[oof]["timeScreen"].ToString(); // need to format to mm:ss.hh

                switch ( Convert.ToInt32(dt_times.Rows[oof]["Lane"]) )
                {
                        
                    case 1:
                        this.SetLane1(txt, txt2);
                        break;
                    case 2:
                        this.SetLane2(txt, txt2);
                        break;
                    case 3:
                        this.SetLane3(txt, txt2);
                        break;
                    case 4:
                        this.SetLane4(txt, txt2);
                        break;
                    case 5:
                        this.SetLane5(txt, txt2);
                        break;
                    case 6:
                        this.SetLane6(txt, txt2);
                        break;
                    case 7:
                        this.SetLane7(txt, txt2);
                        break;
                    case 8:
                        this.SetLane8(txt, txt2);
                        break;
                    default:
                        break;
                }
            }
           // and we are done with the current heat!
            
        }


        private void SetLane1(string text, string text2)
        {
            if (this.plLane1.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane1);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane1.Text = text;
                this.timeLane1.Text = text2;
            }
        }

        private void SetLane2(string text, string text2)
        {
            if (this.plLane2.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane2);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane2.Text = text;
                this.timeLane2.Text = text2;
            }
        }

        private void SetLane3(string text, string text2)
        {
            if (this.plLane3.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane3);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane3.Text = text;
                this.timeLane3.Text = text2;
            }
        }

        private void SetLane4(string text, string text2)
        {
            if (this.plLane4.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane4);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane4.Text = text;
                this.timeLane4.Text = text2;
            }
        }
        private void SetLane5(string text, string text2)
        {
            if (this.plLane5.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane5);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane5.Text = text;
                this.timeLane5.Text = text2;
            }
        }
        private void SetLane6(string text, string text2)
        {
            if (this.plLane6.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane6);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane6.Text = text;
                this.timeLane6.Text = text2;
            }
        }
        private void SetLane7(string text, string text2)
        {
            if (this.plLane7.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane7);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane7.Text = text;
                this.timeLane7.Text = text2;
            }
        }
        private void SetLane8(string text, string text2)
        {
            if (this.plLane8.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetLane8);
                this.Invoke(d, new object[] { text, text2 });
            }
            else
            {
                this.plLane8.Text = text;
                this.timeLane8.Text = text2;
            }
        }

        private void SetHeatText(string text)
        {
            if (this.heatTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetHeatText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.heatTextBox.Text = text;
            }
        }

        private void tmrEditNotify_Tick(object sender, EventArgs e)
        {
            if (m_bDirty)
            {
                lstNotification.BeginUpdate();
                lstNotification.Items.Add(m_Sb.ToString());
                lstNotification.EndUpdate();
                lstNotification.SelectedIndex = lstNotification.Items.Count - 1;
                m_bDirty = false;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = dlgOpenDir.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                txtFile.Text = dlgOpenDir.SelectedPath;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = dlgSaveFile.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                FileInfo fi = new FileInfo(dlgSaveFile.FileName);
                StreamWriter sw = fi.CreateText();
                foreach (string sItem in lstNotification.Items)
                {
                    sw.WriteLine(sItem);
                }
                sw.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNotifier_Load(object sender, EventArgs e)
        {
            btnListCOMPorts.PerformClick();
        }

        private void cboCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTestCOM.BackColor = Color.LightSkyBlue;
            COMgood = false;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void HeatUp_Click(object sender, EventArgs e)
        {
            heat += 1;
            heatTextBox.Text = heat.ToString();
            updateEventHeat();
        }

        private void HeatDown_Click(object sender, EventArgs e)
        {
            heat -= 1;
            if (heat < 0)
            {
                heat = 0;
            }
            heatTextBox.Text = heat.ToString();
            updateEventHeat();
        }

        private void EventUp_Click(object sender, EventArgs e)
        {
            evnt += 1;
            eventTextBox.Text = evnt.ToString();
            heat = 1; // Event number has incremented, so heat should go back to 1
            heatTextBox.Text = heat.ToString();
            updateEventHeat();
        }

        private void EventDown_Click(object sender, EventArgs e)
        {
            evnt -= 1;
            if (evnt <= 0)
            {
                evnt = 1;
            }
            eventTextBox.Text = evnt.ToString();
            updateEventHeat();
        }

        private void updateEventHeat()
        {
            string eventHeat;
            if (COMgood && m_bIsWatching)
            {
                Debug.WriteLine("Sending data to COM port:");
                eventHeat = string.Format("OSB 0 {0,2}{1,2}    ", eventTextBox.Text, heatTextBox.Text); //update event and heat
                Debug.WriteLine(eventHeat);
                ComPort.WriteLine(eventHeat);
            }

        }

        private void chkSubFolder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTestCOMport(object sender, EventArgs e)
        {
            //  btnPortState.Text = "Open";
            if (COMgood) return;
            COMgood = false;
            btnTestCOM.BackColor = Color.LightSkyBlue;
            if (String.Compare(cboCOMPorts.Text, "No Ports") == 0)
            { //make sure there is a COM port selected
                MessageBox.Show("No COM port selected.  To correct this issue:\n"+
                                "1) Ensure OpenScoreboard adapter is plugged in.\n"+
                                "2) Press \"Query COM Ports\" button to update list of available COM ports.\n"+
                                "3) Select a COM port from dropdown list.\n"+
                                "4) Press \"Test COM Port\" button again.");
                return;
            }
            ComPort.PortName = Convert.ToString(cboCOMPorts.Text);
            ComPort.BaudRate = 115200;
            ComPort.DataBits = 8;
            ComPort.StopBits = StopBits.One;
            ComPort.Parity = Parity.None;
            ComPort.ReadTimeout = 5000;
            ComPort.Open();
            ComPort.DtrEnable = true;  //toggle DTR to reset Arduino; OpenScoreboardBaseWP will respone with "Starting OpenScoreboard gateway...\r" 
          //  Thread.Sleep(50);
            ComPort.DtrEnable = false;
            // Thread.Sleep(500);
            try
            {
                string s = ComPort.ReadLine();
                if (String.Compare(s, "Starting OpenScoreboard gateway...\r") == 0)  //Serial.println add '\r' to end of string...
                {
                    btnTestCOM.BackColor = Color.Green;
                    MessageBox.Show("Successful connection to OpenScoreboard Adapter!");
                    COMgood = true;
                }
                else
                {
                    MessageBox.Show("Failed to connect.\n\nVerify OpenScoreboard adapter is plugged in.");
                }
            }
            catch (TimeoutException)
            {
                btnTestCOM.BackColor = Color.Red;
                MessageBox.Show("No reponse from COM port.");
                COMgood = false;
            }
            ComPort.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                              OpenScoreboard\n"+
                            "An Eagle Scout Project for the Gleannloch Gators.\n\n"+
                            "                                    David Cox\n"+
                            "                                    Troop 626\n"+
                            "                                    Spring, TX\n"+
                            "                                    May 2014\n\n"+
                            "                                   Version 0.10");
        }

        private void btnQueryCOMPorts_click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            //       string debug = null;

            //Com Ports
            COMgood = false;
            cboCOMPorts.Items.Clear();
            ArrayComPortsNames = SerialPort.GetPortNames();
            //     debug = ArrayComPortsNames[0];
            if (ArrayComPortsNames.Length < 1) // make sure there is at least one serial port
            {
                cboCOMPorts.Items.Add("No Ports");
                cboCOMPorts.Text = "No Ports";
                MessageBox.Show("No COM ports found.\n\nPlease ensure OpenScoreboard adapter is plugged in.");
                return;
            }
            do
            {
                index += 1;
                cboCOMPorts.Items.Add(ArrayComPortsNames[index]);
            } while (!((ArrayComPortsNames[index] == ComPortName) ||
              (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }

            //get first item print in text
            cboCOMPorts.Text = ArrayComPortsNames[0];

        }
    }
}