namespace heliosRoverGuı_2
{
    partial class DataViewWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewWindow));
            speedPB = new SemiCircleProgress();
            batteryPb = new SemiCircleProgress();
            moisturePb = new SemiCircleProgress();
            temperaturePb = new SemiCircleProgress();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            speedL = new Label();
            panel9 = new Panel();
            speedAverageLabel = new Label();
            speedMaxLabel = new Label();
            panel11 = new Panel();
            label1 = new Label();
            panel10 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            panel15 = new Panel();
            label5 = new Label();
            panel7 = new Panel();
            listBox2 = new ListBox();
            panel8 = new Panel();
            panel16 = new Panel();
            label7 = new Label();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel2 = new Panel();
            batteryL = new Label();
            panel12 = new Panel();
            leftMah = new Label();
            estMax = new Label();
            panel13 = new Panel();
            label13 = new Label();
            panel14 = new Panel();
            label17 = new Label();
            label18 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            moistureL = new Label();
            panel4 = new Panel();
            moistureAverage = new Label();
            moistureMax = new Label();
            panel17 = new Panel();
            label4 = new Label();
            panel18 = new Panel();
            label8 = new Label();
            label11 = new Label();
            panel19 = new Panel();
            temperatureL = new Label();
            panel20 = new Panel();
            temperatureAverage = new Label();
            temperatureMax = new Label();
            panel21 = new Panel();
            label14 = new Label();
            panel22 = new Panel();
            label15 = new Label();
            label25 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            guncellemeTimeri = new System.Windows.Forms.Timer(components);
            comboBoxPort = new ComboBox();
            comboBoxBaudRate = new ComboBox();
            veriDeneme = new Label();
            baglantibutonu = new Button();
            test = new Label();
            exceptionLabel = new Label();
            panelCompass = new Panel();
            compassCustomControl1 = new compassdeneme.components.compassCustomControl();
            panel23 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            labelThingspeakDeneme = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel5.SuspendLayout();
            panel15.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel16.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel17.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panelCompass.SuspendLayout();
            panel23.SuspendLayout();
            SuspendLayout();
            // 
            // speedPB
            // 
            speedPB.BackColor = Color.FromArgb(184, 181, 181);
            speedPB.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            speedPB.Location = new Point(10, 19);
            speedPB.Name = "speedPB";
            speedPB.RightToLeft = RightToLeft.No;
            speedPB.Size = new Size(285, 175);
            speedPB.TabIndex = 11;
            speedPB.Text = "semiCircleProgress2";
            speedPB.TrackColor = Color.Olive;
            speedPB.TrackSize = 25;
            speedPB.UseMnemonic = false;
            speedPB.Value = 20;
            speedPB.ValueColor = Color.Yellow;
            speedPB.ValueChanged += speedPB_ValueChanged;
            // 
            // batteryPb
            // 
            batteryPb.BackColor = Color.FromArgb(184, 181, 181);
            batteryPb.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            batteryPb.Location = new Point(10, 19);
            batteryPb.Name = "batteryPb";
            batteryPb.RightToLeft = RightToLeft.No;
            batteryPb.Size = new Size(285, 175);
            batteryPb.TabIndex = 11;
            batteryPb.Text = "semiCircleProgress2";
            batteryPb.TrackColor = Color.DarkOliveGreen;
            batteryPb.TrackSize = 25;
            batteryPb.UseMnemonic = false;
            batteryPb.Value = 60;
            batteryPb.ValueColor = Color.Lime;
            // 
            // moisturePb
            // 
            moisturePb.BackColor = Color.FromArgb(184, 181, 181);
            moisturePb.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            moisturePb.Location = new Point(10, 19);
            moisturePb.Name = "moisturePb";
            moisturePb.RightToLeft = RightToLeft.No;
            moisturePb.Size = new Size(285, 175);
            moisturePb.TabIndex = 11;
            moisturePb.Text = "semiCircleProgress2";
            moisturePb.TrackColor = Color.MidnightBlue;
            moisturePb.TrackSize = 25;
            moisturePb.UseMnemonic = false;
            moisturePb.Value = 60;
            moisturePb.ValueColor = Color.DeepSkyBlue;
            moisturePb.ValueChanged += semiCircleProgress3_ValueChanged;
            // 
            // temperaturePb
            // 
            temperaturePb.BackColor = Color.FromArgb(184, 181, 181);
            temperaturePb.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            temperaturePb.Location = new Point(10, 19);
            temperaturePb.Name = "temperaturePb";
            temperaturePb.RightToLeft = RightToLeft.No;
            temperaturePb.Size = new Size(285, 175);
            temperaturePb.TabIndex = 11;
            temperaturePb.Text = "semiCircleProgress2";
            temperaturePb.TrackColor = Color.Maroon;
            temperaturePb.TrackSize = 25;
            temperaturePb.UseMnemonic = false;
            temperaturePb.Value = 20;
            temperaturePb.ValueColor = Color.Crimson;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(866, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(speedL);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(speedPB);
            panel1.Location = new Point(191, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 300);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // speedL
            // 
            speedL.AutoSize = true;
            speedL.BackColor = Color.Transparent;
            speedL.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            speedL.Location = new Point(125, 119);
            speedL.Name = "speedL";
            speedL.Size = new Size(58, 45);
            speedL.TabIndex = 16;
            speedL.Text = "20";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonShadow;
            panel9.Controls.Add(speedAverageLabel);
            panel9.Controls.Add(speedMaxLabel);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(0, 168);
            panel9.Name = "panel9";
            panel9.Size = new Size(300, 132);
            panel9.TabIndex = 15;
            // 
            // speedAverageLabel
            // 
            speedAverageLabel.AutoSize = true;
            speedAverageLabel.Location = new Point(137, 54);
            speedAverageLabel.Name = "speedAverageLabel";
            speedAverageLabel.Size = new Size(140, 20);
            speedAverageLabel.TabIndex = 17;
            speedAverageLabel.Text = "speedAverageLabel";
            // 
            // speedMaxLabel
            // 
            speedMaxLabel.AutoSize = true;
            speedMaxLabel.Location = new Point(116, 22);
            speedMaxLabel.Name = "speedMaxLabel";
            speedMaxLabel.Size = new Size(113, 20);
            speedMaxLabel.TabIndex = 16;
            speedMaxLabel.Text = "speedMaxLabel";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ControlDarkDark;
            panel11.Controls.Add(label1);
            panel11.Location = new Point(0, 89);
            panel11.Name = "panel11";
            panel11.Size = new Size(300, 43);
            panel11.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 5);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 8;
            label1.Text = "SPEED";
            // 
            // panel10
            // 
            panel10.Location = new Point(4, 181);
            panel10.Name = "panel10";
            panel10.Size = new Size(250, 51);
            panel10.TabIndex = 8;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(54, 54);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 13;
            label9.Text = "Average :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(54, 22);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 14;
            label10.Text = "Max :";
            // 
            // panel5
            // 
            panel5.Controls.Add(label24);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(panel15);
            panel5.Location = new Point(191, 742);
            panel5.Name = "panel5";
            panel5.Size = new Size(622, 120);
            panel5.TabIndex = 5;
            panel5.Paint += panel5_Paint;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(429, 37);
            label24.Name = "label24";
            label24.Size = new Size(104, 23);
            label24.TabIndex = 18;
            label24.Text = "5,324252352";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(239, 37);
            label23.Name = "label23";
            label23.Size = new Size(104, 23);
            label23.TabIndex = 17;
            label23.Text = "5,324252352";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(21, 37);
            label22.Name = "label22";
            label22.Size = new Size(104, 23);
            label22.TabIndex = 16;
            label22.Text = "5,324252352";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(429, 12);
            label21.Name = "label21";
            label21.Size = new Size(89, 25);
            label21.TabIndex = 15;
            label21.Text = "Direction";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(236, 12);
            label20.Name = "label20";
            label20.Size = new Size(98, 25);
            label20.TabIndex = 14;
            label20.Text = "Longitude";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(21, 12);
            label19.Name = "label19";
            label19.Size = new Size(81, 25);
            label19.TabIndex = 13;
            label19.Text = "Latitude";
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.ControlDarkDark;
            panel15.Controls.Add(label5);
            panel15.Location = new Point(0, 74);
            panel15.Name = "panel15";
            panel15.Size = new Size(622, 46);
            panel15.TabIndex = 12;
            panel15.Paint += panel15_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(239, 8);
            label5.Name = "label5";
            label5.Size = new Size(128, 30);
            label5.TabIndex = 11;
            label5.Text = "GPS DATAS";
            // 
            // panel7
            // 
            panel7.Controls.Add(listBox2);
            panel7.Location = new Point(1100, 93);
            panel7.Name = "panel7";
            panel7.Size = new Size(701, 300);
            panel7.TabIndex = 6;
            panel7.Paint += panel7_Paint;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(184, 181, 181);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.FormattingEnabled = true;
            listBox2.ImeMode = ImeMode.NoControl;
            listBox2.ItemHeight = 20;
            listBox2.Items.AddRange(new object[] { "36.93754140869017, 35.40220318016893", "37.39538055559732, 27.609098375455723", "39.66180972637755, 33.812465022816156", "39.94639122062479, 22.07252346062552", "37.116119736292895, 14.093922398942562" });
            listBox2.Location = new Point(34, 19);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(639, 220);
            listBox2.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel16);
            panel8.Controls.Add(gMapControl1);
            panel8.Location = new Point(1100, 416);
            panel8.Name = "panel8";
            panel8.Size = new Size(701, 446);
            panel8.TabIndex = 7;
            panel8.Paint += panel8_Paint;
            // 
            // panel16
            // 
            panel16.BackColor = SystemColors.ControlDarkDark;
            panel16.Controls.Add(label7);
            panel16.Location = new Point(0, 400);
            panel16.Name = "panel16";
            panel16.Size = new Size(701, 46);
            panel16.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(211, 8);
            label7.Name = "label7";
            label7.Size = new Size(300, 30);
            label7.TabIndex = 11;
            label7.Text = "Live Coordinate on the Map";
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(34, 26);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 100;
            gMapControl1.MinZoom = 0;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(639, 353);
            gMapControl1.TabIndex = 18;
            gMapControl1.Zoom = 2D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // panel2
            // 
            panel2.Controls.Add(batteryL);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(batteryPb);
            panel2.Location = new Point(513, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 300);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint_1;
            // 
            // batteryL
            // 
            batteryL.AutoSize = true;
            batteryL.BackColor = Color.Transparent;
            batteryL.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            batteryL.Location = new Point(125, 119);
            batteryL.Name = "batteryL";
            batteryL.Size = new Size(58, 45);
            batteryL.TabIndex = 16;
            batteryL.Text = "60";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ButtonShadow;
            panel12.Controls.Add(leftMah);
            panel12.Controls.Add(estMax);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(panel14);
            panel12.Controls.Add(label17);
            panel12.Controls.Add(label18);
            panel12.Location = new Point(0, 168);
            panel12.Name = "panel12";
            panel12.Size = new Size(300, 132);
            panel12.TabIndex = 15;
            // 
            // leftMah
            // 
            leftMah.AutoSize = true;
            leftMah.Location = new Point(151, 54);
            leftMah.Name = "leftMah";
            leftMah.Size = new Size(60, 20);
            leftMah.TabIndex = 17;
            leftMah.Text = "leftMah";
            // 
            // estMax
            // 
            estMax.AutoSize = true;
            estMax.Location = new Point(211, 22);
            estMax.Name = "estMax";
            estMax.Size = new Size(56, 20);
            estMax.TabIndex = 16;
            estMax.Text = "estMax";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ControlDarkDark;
            panel13.Controls.Add(label13);
            panel13.Location = new Point(0, 89);
            panel13.Name = "panel13";
            panel13.Size = new Size(300, 43);
            panel13.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(107, 5);
            label13.Name = "label13";
            label13.Size = new Size(91, 30);
            label13.TabIndex = 8;
            label13.Text = "Battery";
            // 
            // panel14
            // 
            panel14.Location = new Point(4, 181);
            panel14.Name = "panel14";
            panel14.Size = new Size(250, 51);
            panel14.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(54, 54);
            label17.Name = "label17";
            label17.Size = new Size(79, 20);
            label17.TabIndex = 13;
            label17.Text = "Left MAh :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(54, 22);
            label18.Name = "label18";
            label18.Size = new Size(151, 20);
            label18.TabIndex = 14;
            label18.Text = "Estimated Run Time :";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(1100, 350);
            panel6.Name = "panel6";
            panel6.Size = new Size(701, 43);
            panel6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(232, 3);
            label6.Name = "label6";
            label6.Size = new Size(252, 30);
            label6.TabIndex = 11;
            label6.Text = "Wild Plant Coordinates";
            // 
            // panel3
            // 
            panel3.Controls.Add(moistureL);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(moisturePb);
            panel3.Location = new Point(513, 416);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 300);
            panel3.TabIndex = 19;
            panel3.Paint += panel3_Paint_1;
            // 
            // moistureL
            // 
            moistureL.AutoSize = true;
            moistureL.BackColor = Color.Transparent;
            moistureL.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            moistureL.Location = new Point(125, 119);
            moistureL.Name = "moistureL";
            moistureL.Size = new Size(58, 45);
            moistureL.TabIndex = 16;
            moistureL.Text = "60";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(moistureAverage);
            panel4.Controls.Add(moistureMax);
            panel4.Controls.Add(panel17);
            panel4.Controls.Add(panel18);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(0, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 132);
            panel4.TabIndex = 15;
            panel4.Paint += panel4_Paint_1;
            // 
            // moistureAverage
            // 
            moistureAverage.AutoSize = true;
            moistureAverage.Location = new Point(147, 53);
            moistureAverage.Name = "moistureAverage";
            moistureAverage.Size = new Size(122, 20);
            moistureAverage.TabIndex = 17;
            moistureAverage.Text = "moistureAverage";
            // 
            // moistureMax
            // 
            moistureMax.AutoSize = true;
            moistureMax.Location = new Point(107, 22);
            moistureMax.Name = "moistureMax";
            moistureMax.Size = new Size(95, 20);
            moistureMax.TabIndex = 16;
            moistureMax.Text = "moistureMax";
            // 
            // panel17
            // 
            panel17.BackColor = SystemColors.ControlDarkDark;
            panel17.Controls.Add(label4);
            panel17.Location = new Point(0, 89);
            panel17.Name = "panel17";
            panel17.Size = new Size(300, 43);
            panel17.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(86, 5);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 8;
            label4.Text = "MOISTURE";
            // 
            // panel18
            // 
            panel18.Location = new Point(4, 181);
            panel18.Name = "panel18";
            panel18.Size = new Size(250, 51);
            panel18.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(54, 54);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 13;
            label8.Text = "Average:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(54, 22);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 14;
            label11.Text = "Max:";
            // 
            // panel19
            // 
            panel19.Controls.Add(temperatureL);
            panel19.Controls.Add(panel20);
            panel19.Controls.Add(temperaturePb);
            panel19.Location = new Point(191, 416);
            panel19.Name = "panel19";
            panel19.Size = new Size(300, 300);
            panel19.TabIndex = 18;
            panel19.Paint += panel19_Paint;
            // 
            // temperatureL
            // 
            temperatureL.AutoSize = true;
            temperatureL.BackColor = Color.Transparent;
            temperatureL.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            temperatureL.Location = new Point(125, 119);
            temperatureL.Name = "temperatureL";
            temperatureL.Size = new Size(58, 45);
            temperatureL.TabIndex = 16;
            temperatureL.Text = "20";
            // 
            // panel20
            // 
            panel20.BackColor = SystemColors.ButtonShadow;
            panel20.Controls.Add(temperatureAverage);
            panel20.Controls.Add(temperatureMax);
            panel20.Controls.Add(panel21);
            panel20.Controls.Add(panel22);
            panel20.Controls.Add(label15);
            panel20.Controls.Add(label25);
            panel20.Location = new Point(0, 168);
            panel20.Name = "panel20";
            panel20.Size = new Size(300, 132);
            panel20.TabIndex = 15;
            // 
            // temperatureAverage
            // 
            temperatureAverage.AutoSize = true;
            temperatureAverage.Location = new Point(146, 54);
            temperatureAverage.Name = "temperatureAverage";
            temperatureAverage.Size = new Size(146, 20);
            temperatureAverage.TabIndex = 17;
            temperatureAverage.Text = "temperatureAverage";
            // 
            // temperatureMax
            // 
            temperatureMax.AutoSize = true;
            temperatureMax.Location = new Point(125, 22);
            temperatureMax.Name = "temperatureMax";
            temperatureMax.Size = new Size(119, 20);
            temperatureMax.TabIndex = 16;
            temperatureMax.Text = "temperatureMax";
            // 
            // panel21
            // 
            panel21.BackColor = SystemColors.ControlDarkDark;
            panel21.Controls.Add(label14);
            panel21.Location = new Point(0, 89);
            panel21.Name = "panel21";
            panel21.Size = new Size(300, 43);
            panel21.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(71, 5);
            label14.Name = "label14";
            label14.Size = new Size(167, 30);
            label14.TabIndex = 8;
            label14.Text = "TEMPERATURE";
            // 
            // panel22
            // 
            panel22.Location = new Point(4, 181);
            panel22.Name = "panel22";
            panel22.Size = new Size(250, 51);
            panel22.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(54, 54);
            label15.Name = "label15";
            label15.Size = new Size(74, 20);
            label15.TabIndex = 13;
            label15.Text = "Average :";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(54, 22);
            label25.Name = "label25";
            label25.Size = new Size(47, 20);
            label25.TabIndex = 14;
            label25.Text = "Max :";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // guncellemeTimeri
            // 
            guncellemeTimeri.Interval = 300;
            guncellemeTimeri.Tick += guncellemeTimeri_Tick;
            // 
            // comboBoxPort
            // 
            comboBoxPort.FormattingEnabled = true;
            comboBoxPort.Location = new Point(866, 150);
            comboBoxPort.Name = "comboBoxPort";
            comboBoxPort.Size = new Size(187, 28);
            comboBoxPort.TabIndex = 20;
            // 
            // comboBoxBaudRate
            // 
            comboBoxBaudRate.FormattingEnabled = true;
            comboBoxBaudRate.Location = new Point(866, 198);
            comboBoxBaudRate.Name = "comboBoxBaudRate";
            comboBoxBaudRate.Size = new Size(187, 28);
            comboBoxBaudRate.TabIndex = 21;
            // 
            // veriDeneme
            // 
            veriDeneme.AutoSize = true;
            veriDeneme.Location = new Point(866, 273);
            veriDeneme.Name = "veriDeneme";
            veriDeneme.Size = new Size(50, 20);
            veriDeneme.TabIndex = 22;
            veriDeneme.Text = "label2";
            veriDeneme.Click += veriDeneme_Click;
            // 
            // baglantibutonu
            // 
            baglantibutonu.Location = new Point(935, 232);
            baglantibutonu.Name = "baglantibutonu";
            baglantibutonu.Size = new Size(118, 29);
            baglantibutonu.TabIndex = 23;
            baglantibutonu.Text = "baglantikurseri";
            baglantibutonu.UseVisualStyleBackColor = true;
            baglantibutonu.Click += baglantibutonu_Click;
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(1003, 273);
            test.Name = "test";
            test.Size = new Size(50, 20);
            test.TabIndex = 24;
            test.Text = "label2";
            test.Click += test_Click;
            // 
            // exceptionLabel
            // 
            exceptionLabel.AutoSize = true;
            exceptionLabel.Location = new Point(1100, 883);
            exceptionLabel.Name = "exceptionLabel";
            exceptionLabel.Size = new Size(81, 20);
            exceptionLabel.TabIndex = 25;
            exceptionLabel.Text = "exception?";
            // 
            // panelCompass
            // 
            panelCompass.Controls.Add(compassCustomControl1);
            panelCompass.Controls.Add(panel23);
            panelCompass.Location = new Point(832, 517);
            panelCompass.Name = "panelCompass";
            panelCompass.Size = new Size(250, 345);
            panelCompass.TabIndex = 26;
            panelCompass.Paint += panelCompass_Paint;
            // 
            // compassCustomControl1
            // 
            compassCustomControl1.BackColor = Color.FromArgb(184, 181, 181);
            compassCustomControl1.ForeColor = SystemColors.ActiveCaptionText;
            compassCustomControl1.Location = new Point(0, 49);
            compassCustomControl1.Name = "compassCustomControl1";
            compassCustomControl1.Size = new Size(250, 250);
            compassCustomControl1.TabIndex = 17;
            compassCustomControl1.Text = "compassCustomControl1";
            compassCustomControl1.Click += compassCustomControl1_Click;
            // 
            // panel23
            // 
            panel23.BackColor = SystemColors.ControlDarkDark;
            panel23.Controls.Add(label3);
            panel23.Controls.Add(label2);
            panel23.Location = new Point(0, 292);
            panel23.Name = "panel23";
            panel23.Size = new Size(250, 53);
            panel23.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 13);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 8;
            label3.Text = "DIRECTION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 13);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 8;
            label2.Text = "DIRECTION";
            // 
            // button1
            // 
            button1.Location = new Point(902, 366);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 27;
            button1.Text = "baglanti 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(902, 401);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 28;
            button2.Text = "baglanti 2 kes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelThingspeakDeneme
            // 
            labelThingspeakDeneme.AutoSize = true;
            labelThingspeakDeneme.Location = new Point(191, 883);
            labelThingspeakDeneme.Name = "labelThingspeakDeneme";
            labelThingspeakDeneme.Size = new Size(58, 20);
            labelThingspeakDeneme.TabIndex = 29;
            labelThingspeakDeneme.Text = "label12";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(196, 915);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 30;
            label12.Text = "label12";
            // 
            // DataViewWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1030);
            Controls.Add(label12);
            Controls.Add(labelThingspeakDeneme);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelCompass);
            Controls.Add(exceptionLabel);
            Controls.Add(test);
            Controls.Add(baglantibutonu);
            Controls.Add(veriDeneme);
            Controls.Add(comboBoxBaudRate);
            Controls.Add(comboBoxPort);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel19);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataViewWindow";
            Text = "DataViewWindow";
            Load += DataViewWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panelCompass.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Label label5;
        private Label label10;
        private Label label9;
        private Panel panel9;
        private Label speedL;
        private Panel panel10;
        private Panel panel11;
        private Panel panel2;
        private Label batteryL;
        private Panel panel12;
        private Panel panel13;
        private Label label13;
        private Panel panel14;
        private Label label17;
        private Label label18;
        private Panel panel15;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label24;
        private Label label23;
        private Label label22;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private ListBox listBox2;
        private Panel panel16;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private Panel panel3;
        private Label moistureL;
        private Panel panel4;
        private Panel panel17;
        private Label label4;
        private Panel panel18;
        private Label label8;
        private Label label11;
        private Panel panel19;
        private Label temperatureL;
        private Panel panel20;
        private Panel panel21;
        private Label label14;
        private Panel panel22;
        private Label label15;
        private Label label25;
        private SemiCircleProgress speedPB;
        private SemiCircleProgress batteryPb;
        private SemiCircleProgress moisturePb;
        private SemiCircleProgress temperaturePb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer guncellemeTimeri;
        private ComboBox comboBoxPort;
        private ComboBox comboBoxBaudRate;
        private Label veriDeneme;
        private Button baglantibutonu;
        private Label test;
        private Label exceptionLabel;
        private Panel panelCompass;
        private Panel panel23;
        private Label label2;
        private Label label3;
        private Label speedAverageLabel;
        private Label speedMaxLabel;
        private Label leftMah;
        private Label estMax;
        private Label moistureAverage;
        private Label moistureMax;
        private Label temperatureAverage;
        private Label temperatureMax;
        private compassdeneme.components.compassCustomControl compassCustomControl1;
        private Button button1;
        private Button button2;
        private Label labelThingspeakDeneme;
        private Label label12;
    }
}