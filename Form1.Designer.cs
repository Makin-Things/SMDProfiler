namespace SMDProfiler
{
    partial class SMDReflowProfiler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMDReflowProfiler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGetOven = new System.Windows.Forms.Button();
            this.btnBootldr = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lblPreheatRate = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.lblCoolingRate = new System.Windows.Forms.Label();
            this.lblTimeAbove = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblSoakRate = new System.Windows.Forms.Label();
            this.lblSoakTime = new System.Windows.Forms.Label();
            this.lblPreheatEndTemp = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.lblReflowCutoff = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblPreheatCutoff = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblReflowTemp = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblReflowTime = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblSoakTemp = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblSoakDutycycle = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblPreheatTemp = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDataReceived = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbbCOMPorts = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblPower = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbResults.SuspendLayout();
            this.gbProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label21);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.lblD);
            this.splitContainer1.Panel2.Controls.Add(this.lblI);
            this.splitContainer1.Panel2.Controls.Add(this.lblP);
            this.splitContainer1.Panel2.Controls.Add(this.lblPower);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetOven);
            this.splitContainer1.Panel2.Controls.Add(this.btnBootldr);
            this.splitContainer1.Panel2.Controls.Add(this.btnProgram);
            this.splitContainer1.Panel2.Controls.Add(this.gbResults);
            this.splitContainer1.Panel2.Controls.Add(this.lblTemp);
            this.splitContainer1.Panel2.Controls.Add(this.gbProfile);
            this.splitContainer1.Panel2.Controls.Add(this.lblProcess);
            this.splitContainer1.Panel2.Controls.Add(this.Label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDataReceived);
            this.splitContainer1.Panel2.Controls.Add(this.lblMessage);
            this.splitContainer1.Panel2.Controls.Add(this.btnDisconnect);
            this.splitContainer1.Panel2.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel2.Controls.Add(this.cbbCOMPorts);
            this.splitContainer1.Panel2.Controls.Add(this.Label1);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.splitContainer1.SplitterDistance = 798;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Interval = 60D;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.Interval = 60D;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Maximum = 360D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 15D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Title = "Time (Seconds)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Interval = 50D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Interval = 50D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.Interval = 50D;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Maximum = 250D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Title = "Temperature (°C)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Chart1Legend";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8F;
            legend1.Position.Width = 10F;
            legend1.Position.X = 11F;
            legend1.Position.Y = 5F;
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.Size = new System.Drawing.Size(1904, 798);
            this.chart1.TabIndex = 0;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // btnGetOven
            // 
            this.btnGetOven.Location = new System.Drawing.Point(416, 2);
            this.btnGetOven.Name = "btnGetOven";
            this.btnGetOven.Size = new System.Drawing.Size(75, 23);
            this.btnGetOven.TabIndex = 18;
            this.btnGetOven.Text = "Get Oven";
            this.btnGetOven.UseVisualStyleBackColor = true;
            this.btnGetOven.Click += new System.EventHandler(this.btnGetOven_Click);
            // 
            // btnBootldr
            // 
            this.btnBootldr.Location = new System.Drawing.Point(330, 35);
            this.btnBootldr.Name = "btnBootldr";
            this.btnBootldr.Size = new System.Drawing.Size(75, 23);
            this.btnBootldr.TabIndex = 17;
            this.btnBootldr.Text = "Bootloader";
            this.btnBootldr.UseVisualStyleBackColor = true;
            this.btnBootldr.Click += new System.EventHandler(this.btnBootldr_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.Location = new System.Drawing.Point(251, 35);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(75, 23);
            this.btnProgram.TabIndex = 16;
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lblPreheatRate);
            this.gbResults.Controls.Add(this.Label17);
            this.gbResults.Controls.Add(this.lblCoolingRate);
            this.gbResults.Controls.Add(this.lblTimeAbove);
            this.gbResults.Controls.Add(this.lblMaxTemp);
            this.gbResults.Controls.Add(this.lblSoakRate);
            this.gbResults.Controls.Add(this.lblSoakTime);
            this.gbResults.Controls.Add(this.lblPreheatEndTemp);
            this.gbResults.Controls.Add(this.Label16);
            this.gbResults.Controls.Add(this.Label15);
            this.gbResults.Controls.Add(this.Label14);
            this.gbResults.Controls.Add(this.Label13);
            this.gbResults.Controls.Add(this.Label12);
            this.gbResults.Controls.Add(this.Label11);
            this.gbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(416, 38);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(309, 189);
            this.gbResults.TabIndex = 15;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Performance Results";
            // 
            // lblPreheatRate
            // 
            this.lblPreheatRate.AutoSize = true;
            this.lblPreheatRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreheatRate.Location = new System.Drawing.Point(109, 25);
            this.lblPreheatRate.Name = "lblPreheatRate";
            this.lblPreheatRate.Size = new System.Drawing.Size(45, 13);
            this.lblPreheatRate.TabIndex = 13;
            this.lblPreheatRate.Text = "Label18";
            this.lblPreheatRate.Visible = false;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(6, 25);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(108, 13);
            this.Label17.TabIndex = 12;
            this.Label17.Text = "Preheat Rate °C/Sec";
            // 
            // lblCoolingRate
            // 
            this.lblCoolingRate.AutoSize = true;
            this.lblCoolingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoolingRate.Location = new System.Drawing.Point(109, 165);
            this.lblCoolingRate.Name = "lblCoolingRate";
            this.lblCoolingRate.Size = new System.Drawing.Size(45, 13);
            this.lblCoolingRate.TabIndex = 11;
            this.lblCoolingRate.Text = "Label14";
            this.lblCoolingRate.Visible = false;
            // 
            // lblTimeAbove
            // 
            this.lblTimeAbove.AutoSize = true;
            this.lblTimeAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAbove.Location = new System.Drawing.Point(109, 141);
            this.lblTimeAbove.Name = "lblTimeAbove";
            this.lblTimeAbove.Size = new System.Drawing.Size(45, 13);
            this.lblTimeAbove.TabIndex = 10;
            this.lblTimeAbove.Text = "Label13";
            this.lblTimeAbove.Visible = false;
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(109, 117);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(13, 13);
            this.lblMaxTemp.TabIndex = 9;
            this.lblMaxTemp.Text = "0";
            this.lblMaxTemp.Visible = false;
            // 
            // lblSoakRate
            // 
            this.lblSoakRate.AutoSize = true;
            this.lblSoakRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoakRate.Location = new System.Drawing.Point(109, 93);
            this.lblSoakRate.Name = "lblSoakRate";
            this.lblSoakRate.Size = new System.Drawing.Size(45, 13);
            this.lblSoakRate.TabIndex = 8;
            this.lblSoakRate.Text = "Label11";
            this.lblSoakRate.Visible = false;
            // 
            // lblSoakTime
            // 
            this.lblSoakTime.AutoSize = true;
            this.lblSoakTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoakTime.Location = new System.Drawing.Point(109, 69);
            this.lblSoakTime.Name = "lblSoakTime";
            this.lblSoakTime.Size = new System.Drawing.Size(45, 13);
            this.lblSoakTime.TabIndex = 7;
            this.lblSoakTime.Text = "Label10";
            this.lblSoakTime.Visible = false;
            // 
            // lblPreheatEndTemp
            // 
            this.lblPreheatEndTemp.AutoSize = true;
            this.lblPreheatEndTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreheatEndTemp.Location = new System.Drawing.Point(109, 45);
            this.lblPreheatEndTemp.Name = "lblPreheatEndTemp";
            this.lblPreheatEndTemp.Size = new System.Drawing.Size(39, 13);
            this.lblPreheatEndTemp.TabIndex = 6;
            this.lblPreheatEndTemp.Text = "Label9";
            this.lblPreheatEndTemp.Visible = false;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(6, 165);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(106, 13);
            this.Label16.TabIndex = 5;
            this.Label16.Text = "Cooling Rate °C/Sec";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(6, 141);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(85, 13);
            this.Label15.TabIndex = 4;
            this.Label15.Text = "Time Above X°C";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(6, 117);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(104, 13);
            this.Label14.TabIndex = 3;
            this.Label14.Text = "Max Temp Reached";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(6, 93);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(96, 13);
            this.Label13.TabIndex = 2;
            this.Label13.Text = "Soak Rate °C/Sec";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(6, 69);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(58, 13);
            this.Label12.TabIndex = 1;
            this.Label12.Text = "Soak Time";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(6, 45);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(96, 13);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Preheat End Temp";
            // 
            // lblTemp
            // 
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTemp.Location = new System.Drawing.Point(557, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(160, 40);
            this.lblTemp.TabIndex = 14;
            this.lblTemp.Text = "    ";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.lblReflowCutoff);
            this.gbProfile.Controls.Add(this.Label10);
            this.gbProfile.Controls.Add(this.lblPreheatCutoff);
            this.gbProfile.Controls.Add(this.Label9);
            this.gbProfile.Controls.Add(this.lblReflowTemp);
            this.gbProfile.Controls.Add(this.Label8);
            this.gbProfile.Controls.Add(this.lblReflowTime);
            this.gbProfile.Controls.Add(this.Label7);
            this.gbProfile.Controls.Add(this.lblSoakTemp);
            this.gbProfile.Controls.Add(this.Label6);
            this.gbProfile.Controls.Add(this.lblSoakDutycycle);
            this.gbProfile.Controls.Add(this.Label5);
            this.gbProfile.Controls.Add(this.lblPreheatTemp);
            this.gbProfile.Controls.Add(this.Label4);
            this.gbProfile.Controls.Add(this.lblPName);
            this.gbProfile.Controls.Add(this.Label3);
            this.gbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProfile.Location = new System.Drawing.Point(10, 63);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(400, 165);
            this.gbProfile.TabIndex = 13;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profile";
            this.gbProfile.Visible = false;
            // 
            // lblReflowCutoff
            // 
            this.lblReflowCutoff.AutoSize = true;
            this.lblReflowCutoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflowCutoff.Location = new System.Drawing.Point(309, 86);
            this.lblReflowCutoff.Name = "lblReflowCutoff";
            this.lblReflowCutoff.Size = new System.Drawing.Size(39, 13);
            this.lblReflowCutoff.TabIndex = 15;
            this.lblReflowCutoff.Text = "Label8";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(206, 86);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(71, 13);
            this.Label10.TabIndex = 14;
            this.Label10.Text = "Reflow Cutoff";
            // 
            // lblPreheatCutoff
            // 
            this.lblPreheatCutoff.AutoSize = true;
            this.lblPreheatCutoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreheatCutoff.Location = new System.Drawing.Point(309, 42);
            this.lblPreheatCutoff.Name = "lblPreheatCutoff";
            this.lblPreheatCutoff.Size = new System.Drawing.Size(39, 13);
            this.lblPreheatCutoff.TabIndex = 13;
            this.lblPreheatCutoff.Text = "Label4";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(206, 42);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(75, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Preheat Cutoff";
            // 
            // lblReflowTemp
            // 
            this.lblReflowTemp.AutoSize = true;
            this.lblReflowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflowTemp.Location = new System.Drawing.Point(109, 86);
            this.lblReflowTemp.Name = "lblReflowTemp";
            this.lblReflowTemp.Size = new System.Drawing.Size(39, 13);
            this.lblReflowTemp.TabIndex = 11;
            this.lblReflowTemp.Text = "Label7";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(6, 86);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(70, 13);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "Reflow Temp";
            // 
            // lblReflowTime
            // 
            this.lblReflowTime.AutoSize = true;
            this.lblReflowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflowTime.Location = new System.Drawing.Point(109, 108);
            this.lblReflowTime.Name = "lblReflowTime";
            this.lblReflowTime.Size = new System.Drawing.Size(39, 13);
            this.lblReflowTime.TabIndex = 9;
            this.lblReflowTime.Text = "Label9";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(6, 108);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(66, 13);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Reflow Time";
            // 
            // lblSoakTemp
            // 
            this.lblSoakTemp.AutoSize = true;
            this.lblSoakTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoakTemp.Location = new System.Drawing.Point(109, 64);
            this.lblSoakTemp.Name = "lblSoakTemp";
            this.lblSoakTemp.Size = new System.Drawing.Size(39, 13);
            this.lblSoakTemp.TabIndex = 7;
            this.lblSoakTemp.Text = "Label5";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(6, 64);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(62, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Soak Temp";
            // 
            // lblSoakDutycycle
            // 
            this.lblSoakDutycycle.AutoSize = true;
            this.lblSoakDutycycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoakDutycycle.Location = new System.Drawing.Point(309, 64);
            this.lblSoakDutycycle.Name = "lblSoakDutycycle";
            this.lblSoakDutycycle.Size = new System.Drawing.Size(39, 13);
            this.lblSoakDutycycle.TabIndex = 5;
            this.lblSoakDutycycle.Text = "Label6";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(206, 64);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Soak Dutycycle";
            // 
            // lblPreheatTemp
            // 
            this.lblPreheatTemp.AutoSize = true;
            this.lblPreheatTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreheatTemp.Location = new System.Drawing.Point(109, 42);
            this.lblPreheatTemp.Name = "lblPreheatTemp";
            this.lblPreheatTemp.Size = new System.Drawing.Size(39, 13);
            this.lblPreheatTemp.TabIndex = 3;
            this.lblPreheatTemp.Text = "Label3";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(6, 42);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(74, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Preheat Temp";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(109, 20);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(39, 13);
            this.lblPName.TabIndex = 1;
            this.lblPName.Text = "Label2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(6, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Name";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(119, 38);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(43, 13);
            this.lblProcess.TabIndex = 12;
            this.lblProcess.Text = "Ready";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Process";
            // 
            // txtDataReceived
            // 
            this.txtDataReceived.Location = new System.Drawing.Point(739, 2);
            this.txtDataReceived.Name = "txtDataReceived";
            this.txtDataReceived.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDataReceived.Size = new System.Drawing.Size(525, 237);
            this.txtDataReceived.TabIndex = 7;
            this.txtDataReceived.TabStop = false;
            this.txtDataReceived.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(413, 7);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(19, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "    ";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(332, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(251, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbbCOMPorts
            // 
            this.cbbCOMPorts.FormattingEnabled = true;
            this.cbbCOMPorts.Location = new System.Drawing.Point(124, 2);
            this.cbbCOMPorts.Name = "cbbCOMPorts";
            this.cbbCOMPorts.Size = new System.Drawing.Size(121, 21);
            this.cbbCOMPorts.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(106, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Available Serial Ports";
            // 
            // lblPower
            // 
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPower.Location = new System.Drawing.Point(1334, 14);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(160, 40);
            this.lblPower.TabIndex = 19;
            this.lblPower.Text = "    ";
            this.lblPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblP
            // 
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblP.Location = new System.Drawing.Point(1334, 68);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(160, 40);
            this.lblP.TabIndex = 20;
            this.lblP.Text = "    ";
            this.lblP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblI
            // 
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblI.Location = new System.Drawing.Point(1334, 122);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(160, 40);
            this.lblI.TabIndex = 21;
            this.lblI.Text = "    ";
            this.lblI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblD
            // 
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblD.Location = new System.Drawing.Point(1334, 176);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(160, 40);
            this.lblD.TabIndex = 22;
            this.lblD.Text = "    ";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1296, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Power";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1296, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "P";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1296, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "I";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1296, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "D";
            // 
            // SMDReflowProfiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMDReflowProfiler";
            this.Text = "SMD Reflow Profiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        internal System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.ComboBox cbbCOMPorts;
        internal System.Windows.Forms.Label Label1;
        private System.IO.Ports.SerialPort serialPort1;
				internal System.Windows.Forms.Label lblMessage;
				internal System.Windows.Forms.RichTextBox txtDataReceived;
				internal System.Windows.Forms.GroupBox gbResults;
				internal System.Windows.Forms.Label lblPreheatRate;
				internal System.Windows.Forms.Label Label17;
				internal System.Windows.Forms.Label lblCoolingRate;
				internal System.Windows.Forms.Label lblTimeAbove;
				internal System.Windows.Forms.Label lblMaxTemp;
				internal System.Windows.Forms.Label lblSoakRate;
				internal System.Windows.Forms.Label lblSoakTime;
				internal System.Windows.Forms.Label lblPreheatEndTemp;
				internal System.Windows.Forms.Label Label16;
				internal System.Windows.Forms.Label Label15;
				internal System.Windows.Forms.Label Label14;
				internal System.Windows.Forms.Label Label13;
				internal System.Windows.Forms.Label Label12;
				internal System.Windows.Forms.Label Label11;
				internal System.Windows.Forms.Label lblTemp;
				internal System.Windows.Forms.GroupBox gbProfile;
				internal System.Windows.Forms.Label lblReflowCutoff;
				internal System.Windows.Forms.Label Label10;
				internal System.Windows.Forms.Label lblPreheatCutoff;
				internal System.Windows.Forms.Label Label9;
				internal System.Windows.Forms.Label lblReflowTemp;
				internal System.Windows.Forms.Label Label8;
				internal System.Windows.Forms.Label lblReflowTime;
				internal System.Windows.Forms.Label Label7;
				internal System.Windows.Forms.Label lblSoakTemp;
				internal System.Windows.Forms.Label Label6;
				internal System.Windows.Forms.Label lblSoakDutycycle;
				internal System.Windows.Forms.Label Label5;
				internal System.Windows.Forms.Label lblPreheatTemp;
				internal System.Windows.Forms.Label Label4;
				internal System.Windows.Forms.Label lblPName;
				internal System.Windows.Forms.Label Label3;
				internal System.Windows.Forms.Label lblProcess;
				internal System.Windows.Forms.Label Label2;
				private System.Windows.Forms.Button btnProgram;
				private System.Windows.Forms.Button btnBootldr;
				private System.Windows.Forms.Button btnGetOven;
        internal System.Windows.Forms.Label lblD;
        internal System.Windows.Forms.Label lblI;
        internal System.Windows.Forms.Label lblP;
        internal System.Windows.Forms.Label lblPower;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label18;
    }
}

