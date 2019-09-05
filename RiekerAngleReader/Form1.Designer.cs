namespace RiekerAngleReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.dataReader = new System.ComponentModel.BackgroundWorker();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.angleReadingText = new System.Windows.Forms.Label();
            this.anglePlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startAsyncButton = new System.Windows.Forms.Button();
            this.cancelAsync = new System.Windows.Forms.Button();
            this.closePortButton = new System.Windows.Forms.Button();
            this.portOptionsBox = new System.Windows.Forms.ComboBox();
            this.refreshPortsButton = new System.Windows.Forms.Button();
            this.clearPlot = new System.Windows.Forms.Button();
            this.saveFilePathText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.TextBox();
            this.saveFilePath = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.chooseFolderDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.appHelpButton = new System.Windows.Forms.Button();
            this.aboutApplicationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anglePlot)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(152, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Port:";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(424, -1);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(283, 144);
            this.outputText.TabIndex = 3;
            // 
            // dataReader
            // 
            this.dataReader.WorkerReportsProgress = true;
            this.dataReader.WorkerSupportsCancellation = true;
            this.dataReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dataReader_DoWork);
            this.dataReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dataReader_RunWorkerCompleted);
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(328, 37);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.ReadOnly = true;
            this.angleTextBox.Size = new System.Drawing.Size(84, 20);
            this.angleTextBox.TabIndex = 5;
            this.angleTextBox.TextChanged += new System.EventHandler(this.angleTextBox_TextChanged);
            // 
            // angleReadingText
            // 
            this.angleReadingText.AutoSize = true;
            this.angleReadingText.Location = new System.Drawing.Point(229, 40);
            this.angleReadingText.Name = "angleReadingText";
            this.angleReadingText.Size = new System.Drawing.Size(90, 13);
            this.angleReadingText.TabIndex = 6;
            this.angleReadingText.Text = "Angle Reading (°)";
            this.angleReadingText.Click += new System.EventHandler(this.angleReadingText_Click);
            // 
            // anglePlot
            // 
            chartArea1.AxisX.Title = "Time (ms)";
            chartArea1.AxisY.Title = "Angle (°)";
            chartArea1.Name = "ChartArea1";
            this.anglePlot.ChartAreas.Add(chartArea1);
            this.anglePlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.anglePlot.Legends.Add(legend1);
            this.anglePlot.Location = new System.Drawing.Point(0, 149);
            this.anglePlot.Name = "anglePlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Angle";
            this.anglePlot.Series.Add(series1);
            this.anglePlot.Size = new System.Drawing.Size(707, 321);
            this.anglePlot.TabIndex = 8;
            this.anglePlot.Text = "chart1";
            // 
            // startAsyncButton
            // 
            this.startAsyncButton.BackColor = System.Drawing.Color.Lime;
            this.startAsyncButton.Location = new System.Drawing.Point(12, 34);
            this.startAsyncButton.Name = "startAsyncButton";
            this.startAsyncButton.Size = new System.Drawing.Size(105, 52);
            this.startAsyncButton.TabIndex = 9;
            this.startAsyncButton.Text = "Start Async\r\n(Start Recording)";
            this.startAsyncButton.UseVisualStyleBackColor = false;
            this.startAsyncButton.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // cancelAsync
            // 
            this.cancelAsync.BackColor = System.Drawing.Color.Red;
            this.cancelAsync.Location = new System.Drawing.Point(123, 34);
            this.cancelAsync.Name = "cancelAsync";
            this.cancelAsync.Size = new System.Drawing.Size(100, 52);
            this.cancelAsync.TabIndex = 10;
            this.cancelAsync.Text = "Cancel Async\r\n(Stop Recording)";
            this.cancelAsync.UseVisualStyleBackColor = false;
            this.cancelAsync.Click += new System.EventHandler(this.cancelAsync_Click);
            // 
            // closePortButton
            // 
            this.closePortButton.Location = new System.Drawing.Point(232, 5);
            this.closePortButton.Name = "closePortButton";
            this.closePortButton.Size = new System.Drawing.Size(75, 23);
            this.closePortButton.TabIndex = 11;
            this.closePortButton.Text = "Disconnect";
            this.closePortButton.UseVisualStyleBackColor = true;
            this.closePortButton.Click += new System.EventHandler(this.closePortButton_Click);
            // 
            // portOptionsBox
            // 
            this.portOptionsBox.FormattingEnabled = true;
            this.portOptionsBox.Location = new System.Drawing.Point(76, 7);
            this.portOptionsBox.Name = "portOptionsBox";
            this.portOptionsBox.Size = new System.Drawing.Size(70, 21);
            this.portOptionsBox.TabIndex = 12;
            // 
            // refreshPortsButton
            // 
            this.refreshPortsButton.Location = new System.Drawing.Point(312, 5);
            this.refreshPortsButton.Name = "refreshPortsButton";
            this.refreshPortsButton.Size = new System.Drawing.Size(99, 23);
            this.refreshPortsButton.TabIndex = 13;
            this.refreshPortsButton.Text = "Refresh Ports List";
            this.refreshPortsButton.UseVisualStyleBackColor = true;
            this.refreshPortsButton.Click += new System.EventHandler(this.refreshPortsButton_Click);
            // 
            // clearPlot
            // 
            this.clearPlot.Location = new System.Drawing.Point(12, 118);
            this.clearPlot.Name = "clearPlot";
            this.clearPlot.Size = new System.Drawing.Size(75, 23);
            this.clearPlot.TabIndex = 14;
            this.clearPlot.Text = "Clear Plot";
            this.clearPlot.UseVisualStyleBackColor = true;
            this.clearPlot.Click += new System.EventHandler(this.clearPlot_Click);
            // 
            // saveFilePathText
            // 
            this.saveFilePathText.Location = new System.Drawing.Point(88, 92);
            this.saveFilePathText.Name = "saveFilePathText";
            this.saveFilePathText.Size = new System.Drawing.Size(215, 20);
            this.saveFilePathText.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Save data to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Elapsed Time (ms)";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // elapsedTime
            // 
            this.elapsedTime.Location = new System.Drawing.Point(328, 62);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.ReadOnly = true;
            this.elapsedTime.Size = new System.Drawing.Size(83, 20);
            this.elapsedTime.TabIndex = 27;
            // 
            // saveFilePath
            // 
            this.saveFilePath.Location = new System.Drawing.Point(309, 90);
            this.saveFilePath.Name = "saveFilePath";
            this.saveFilePath.Size = new System.Drawing.Size(26, 23);
            this.saveFilePath.TabIndex = 28;
            this.saveFilePath.Text = "...";
            this.saveFilePath.UseVisualStyleBackColor = true;
            this.saveFilePath.Click += new System.EventHandler(this.saveFilePath_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(341, 90);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 23);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save Data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // appHelpButton
            // 
            this.appHelpButton.Location = new System.Drawing.Point(205, 120);
            this.appHelpButton.Name = "appHelpButton";
            this.appHelpButton.Size = new System.Drawing.Size(75, 23);
            this.appHelpButton.TabIndex = 30;
            this.appHelpButton.Text = "Help";
            this.appHelpButton.UseVisualStyleBackColor = true;
            this.appHelpButton.Click += new System.EventHandler(this.appHelpButton_Click);
            // 
            // aboutApplicationButton
            // 
            this.aboutApplicationButton.Location = new System.Drawing.Point(286, 120);
            this.aboutApplicationButton.Name = "aboutApplicationButton";
            this.aboutApplicationButton.Size = new System.Drawing.Size(126, 23);
            this.aboutApplicationButton.TabIndex = 31;
            this.aboutApplicationButton.Text = "About Application";
            this.aboutApplicationButton.UseVisualStyleBackColor = true;
            this.aboutApplicationButton.Click += new System.EventHandler(this.aboutApplicationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 470);
            this.Controls.Add(this.aboutApplicationButton);
            this.Controls.Add(this.appHelpButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveFilePath);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveFilePathText);
            this.Controls.Add(this.clearPlot);
            this.Controls.Add(this.refreshPortsButton);
            this.Controls.Add(this.portOptionsBox);
            this.Controls.Add(this.closePortButton);
            this.Controls.Add(this.cancelAsync);
            this.Controls.Add(this.startAsyncButton);
            this.Controls.Add(this.anglePlot);
            this.Controls.Add(this.angleReadingText);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Rieker Angle Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anglePlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputText;
        private System.ComponentModel.BackgroundWorker dataReader;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label angleReadingText;
        private System.Windows.Forms.DataVisualization.Charting.Chart anglePlot;
        private System.Windows.Forms.Button startAsyncButton;
        private System.Windows.Forms.Button cancelAsync;
        private System.Windows.Forms.Button closePortButton;
        private System.Windows.Forms.ComboBox portOptionsBox;
        private System.Windows.Forms.Button refreshPortsButton;
        private System.Windows.Forms.Button clearPlot;
        private System.Windows.Forms.TextBox saveFilePathText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox elapsedTime;
        private System.Windows.Forms.Button saveFilePath;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog chooseFolderDialog1;
        private System.Windows.Forms.Button appHelpButton;
        private System.Windows.Forms.Button aboutApplicationButton;
    }
}

