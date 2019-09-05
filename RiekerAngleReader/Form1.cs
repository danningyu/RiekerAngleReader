using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;


namespace RiekerAngleReader{
    public partial class Form1 : Form{
        SerialPort angleReader = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One); //initialy COM1
        List<double> dataDouble = new List<double>(10000); //list to save values read in, initial size of 10000
        List<string> ports = new List<string>(); //list to save list of ports
        int errors = 0; //counter for errors
        string pathName = @"C:\Users\Public\RiekerAngle.txt";

        public Form1() { 
            InitializeComponent();
           // InitializeBackgroundWorker();
            dataReader.WorkerReportsProgress = true;
            dataReader.WorkerSupportsCancellation = true;
            ports = SerialPort.GetPortNames().Cast<string>().ToList(); //get current ports upon startup
            for (int i = 0; i < ports.Count; i++) {
                portOptionsBox.Items.Add(ports[i]);
            }
            saveFilePathText.Text = pathName;
            outputText.AppendText("Rieker angle reader application started, last revised 24 July 2019.\n");
        }

        //private void InitializeBackgroundWorker() { //alternate way of doing it
        //    dataReader.DoWork += new DoWorkEventHandler(dataReader_DoWork);
        //    dataReader.RunWorkerCompleted += new RunWorkerCompletedEventHandler( dataReader_RunWorkerCompleted);  
        //}

        private void connectButton_Click(object sender, EventArgs e) {
            angleReader.Close(); //close any existing port
            if (portOptionsBox.SelectedItem == null) {
                MessageBox.Show("Please select a port.");
                outputText.AppendText("Please select a port.\n");
                return;
            }        
            angleReader.PortName = ports[portOptionsBox.SelectedIndex];
            angleReader.Open();
            outputText.AppendText("Connected on port " + angleReader.PortName + ".\n");
        }

        private void portNumberText_TextChanged(object sender, EventArgs e) {

        }

        private void monitorCheck_CheckedChanged(object sender, EventArgs e) {
        }

        private void dataReader_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            errors = 0;
            angleReader.DiscardOutBuffer(); //don't know which one so do both
            angleReader.DiscardInBuffer();
            dataDouble.Clear(); //clear the array
            clearPlot_Click(sender, e); //clear the plot
            readData(worker, e); //time consuming part
        }

        private void readData(BackgroundWorker worker, DoWorkEventArgs e) {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (worker.CancellationPending == true) { //cancellation requested
                e.Cancel = true;
            }
            else {
                while (true) {
                    try {
                        if (worker.CancellationPending == true) { //cancellation requested
                            e.Cancel = true;
                            break;
                        }
                        if (watch.ElapsedMilliseconds % 10 == 0) { //H4S output data protocol: every 25 ms, mod10 to slow it down
                            string result = angleReader.ReadLine();
                            long time = watch.ElapsedMilliseconds;
                            double angleReading = double.Parse(result.Substring(1));
                            if (result[0] == '-') { //for negative values
                                angleReading = angleReading * -1;
                            }
                            // outputText.AppendText(" " + time + " " + result + "\n");
                            angleTextBox.Text = result;
                            elapsedTime.Text = time.ToString();
                            anglePlot.Series[0].Points.AddXY(time, angleReading);
                            dataDouble.Add(angleReading);
                        }
                    }
                    catch {
                        errors++;
                        continue;
                    }
                }
            }
            watch.Stop(); //reset stopwatch
        }

        private void dataReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            // First, handle the case where an exception was thrown.
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled) {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                outputText.AppendText("Data collection stopped.\n");
            }
            else {
                // Finally, handle the case where the operation 
                // succeeded.
                outputText.AppendText("Success.\n");
            }
            outputText.AppendText("Bad data points: " + errors + "\n");
            //outputText.AppendText("DONE\n");
            outputText.AppendText("Data points collected:  " + dataDouble.Count + "\n");
            // Enable the Start button.
            startAsyncButton.Enabled = true;
            // Disable the Cancel button.
            cancelAsync.Enabled = false;
        }     

        private void angleReadingText_Click(object sender, EventArgs e) {
        }

        private void startAsyncButton_Click(object sender, EventArgs e) {
            if (portOptionsBox.SelectedItem == null) {
                MessageBox.Show("Please select a port.");
                outputText.AppendText("Please select a port.\n");
                return;
            }
            outputText.AppendText("Data collection started.\n");
            // Disable the Start button until 
            // the asynchronous operation is done.
            this.startAsyncButton.Enabled = false;
            //enable cancel button
            this.cancelAsync.Enabled = true;
            // Start the asynchronous operation.
            dataReader.RunWorkerAsync();
        }

        private void cancelAsync_Click(object sender, EventArgs e) {
            this.dataReader.CancelAsync();
            cancelAsync.Enabled = false;
        }

        private void closePortButton_Click(object sender, EventArgs e) {
            angleReader.Dispose();
            angleReader.Close();
        }

        private void refreshPortsButton_Click(object sender, EventArgs e) {
            ports.Clear();
            portOptionsBox.Items.Clear();
            ports = SerialPort.GetPortNames().Cast<string>().ToList(); //get current ports
            for (int i = 0; i < ports.Count; i++) {
                portOptionsBox.Items.Add(ports[i]);
            }
        }

        private void angleTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void clearPlot_Click(object sender, EventArgs e) {
            //clear out plot and data in list too
            anglePlot.Series[0].Points.Clear();
            dataDouble.Clear();
        }

        private void label3_Click_1(object sender, EventArgs e) {

        }

        private void saveFilePath_Click(object sender, EventArgs e) {
            if (chooseFolderDialog1.ShowDialog() == DialogResult.OK) {
                pathName = chooseFolderDialog1.SelectedPath;      //get the chosen path  
            }
            string filename = "RiekerAngle.txt";
            pathName = System.IO.Path.Combine(pathName, filename);
            saveFilePathText.Text = pathName; // show the path in SavePathTextbox
        }

        private void button1_Click(object sender, EventArgs e) {
            //string folderName = saveFilePathText.Text.ToString();
            if(dataDouble.Count == 0) {
                MessageBox.Show("No data to save.");
                outputText.AppendText("No data to save.\n");
                return;
            }
            using (System.IO.StreamWriter fs = new System.IO.StreamWriter(pathName, true)) {
                foreach (double dataValue in dataDouble) {
                    if (dataValue >= 0) {
                        fs.WriteLine("+" + dataValue.ToString()); //for pos values, to work with TwoIntervalStatsCalculator
                    }
                    else {
                        fs.WriteLine(dataValue.ToString()); //negative sign included
                    }
                }
            }
        }

        private void appHelpButton_Click(object sender, EventArgs e) {
            string line2 = "This application is for reading in angle values (positive or negative) from a Rieker H4S1 inclinometer.\n";
            string line3 = "To use, first select the COM port to which the device is connected to. Then press \"Connect\".\n";
            string line4 = "Click the \"Start Async\" and \"Stop Async\" buttons to start and stop recording respectively.\n";
            string line5 = "After recording is finished, click the \"Save\" button to export the collected data as a .txt file to the specified folder.\n";
            string line6 = "Use the \"Disconnect\" button to close the serial port. The list of ports can also be refreshed if needed.\n";
            string message = line2 + line3 + line4 + line5 + line6;
            MessageBox.Show(message, "Application Help");
        }

        private void aboutApplicationButton_Click(object sender, EventArgs e) {
            string line0 = "Rieker Angle Reader, version 1.00 (24 July 2019).\n";
            string line1 = "About Application:\n";
            string line1AA = "Micro and Nano Manufacturing Lab.\n";
            string line1A = "Created by Danning Yu, Summer 2019.\n";
            string line3 = "v1.00: Initial code written.\n";
            string message = line1 + line0 + line1AA + line1A + line3;
            MessageBox.Show(message, "About Application");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}