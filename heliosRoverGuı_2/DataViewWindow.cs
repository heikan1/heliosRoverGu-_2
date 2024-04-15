using GMap.NET;
using Microsoft.VisualBasic.Logging;
using Plasmoid.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET.MapProviders;

namespace heliosRoverGuı_2
{
    public partial class DataViewWindow : Form
    {
        string currentFilePath;
        SerialPort serialPort1 = new SerialPort();
        bool baglantiKurulduMU = false;
        bool rawdataatandimi = false;
        Color clrActiveBorder = Color.FromArgb(255, 184, 180, 180);
        Color clrControlDarkDark = Color.FromArgb(255, 104, 105, 104);
        int radius = 25;
        string rawData;

        public void LoadDatasToDataViewWindow()
        {
            string[] values = null;
            bool sorunVarMi = false;
            string path = Environment.CurrentDirectory + "/" + "deneme.txt";
            string lastLine = File.ReadLines(path).Last();
            try
            {
                values = lastLine.Split(';');
            }
            catch (Exception e) { 
                exceptionLabel.Text = e.Message;
                sorunVarMi= true;
            }
            if (!sorunVarMi) { 
            //barların verilerini güncelliyo
            //speedPB.Value = int.Parse(values[0]);
            speedL.Text = values[0];
            moisturePb.Value = int.Parse(values[4]);
            moistureL.Text = values[4];
            temperaturePb.Value = int.Parse(values[5]);
            temperatureL.Text = values[5];
            batteryPb.Value = int.Parse(values[2]);
            batteryL.Text = values[2];
            //map
            rawData = values[6];  
            rawdataatandimi = true;
            }
        }
        private void mapUpdate(string rawData)
        {
            bool sorunvarmimap = false;
            string[] datas = null;
            try { 
                datas = rawData.Split(",");
            }
            catch (Exception e) { 
                sorunvarmimap = true;
                exceptionLabel.Text = e.Message;
            }

            if (!sorunvarmimap)
            {
            //Debug.WriteLine(double.Parse(datas[0], System.Globalization.CultureInfo.InvariantCulture));
            //datas[0] = "40.742271";
            //datas[1] = "30.332302";
            double lan = double.Parse(datas[0], System.Globalization.CultureInfo.InvariantCulture);
            double lot = double.Parse(datas[1], System.Globalization.CultureInfo.InvariantCulture);
            // gMapControl1.Position = new PointLatLng(double.Parse(datas[0]), double.Parse(datas[1]));
            gMapControl1.Position = new PointLatLng(lan, lot);

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Test_TxTWriter1();
            /* if (baglantiKurulduMU) {
                 ShowDatas();
             }*/
            SolveFormattedString(SomeFunctions.RandomDataGenerator());
            //timer1.Stop();
            //Test_TxTWriter2();
            //LoadDatasToDataViewWindow();
        }

        public DataViewWindow()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Start();
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel1, radius, clrActiveBorder);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel3, radius, clrActiveBorder);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel4, radius, clrActiveBorder);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel5, radius, clrActiveBorder);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel7, radius, clrActiveBorder);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel6, radius, clrActiveBorder);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel8, radius, clrActiveBorder);
        }

        private void semiCircleProgress1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel2, radius, clrActiveBorder);

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e,panel15,radius, clrControlDarkDark);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel19, radius, clrActiveBorder);

        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.None;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat, lon;
            lat = 41.20812085998769;
            lon = 32.62674684964999;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.Zoom = 18;
        }


        private void semiCircleProgress3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panel3, radius, clrActiveBorder);

        }

        private void speedPB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (baglantiKurulduMU)
            {
                mapUpdate(rawData);
            }
        }

        private void guncellemeTimeri_Tick(object sender, EventArgs e)
        {
            try
            {
                string sonuc = serialPort1.ReadExisting();
                string[] datas = sonuc.Split('\n');
                test.Text = datas[0];

                //veriDeneme.Text = datas.AsQueryable().Last();
                speedPB.Value = Int16.Parse(datas[0]);
                

            }
            catch (Exception ex)
            {
                exceptionLabel.Text = ex.Message;
                guncellemeTimeri.Stop();
            }
        }
        private void BaglantiKur()
        {
            guncellemeTimeri.Start();
            if (serialPort1.IsOpen)
            {
                veriDeneme.Text = "Bağlandı!";
                this.currentFilePath = SomeFunctions.TarihliLoguOlusturma();
                baglantiKurulduMU = true;
            }
            else
            {
                if (comboBoxPort.Text == "")
                {
                    return;
                }

                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Int32.Parse(comboBoxBaudRate.Text);
                try
                {
                    serialPort1.Open();
                }
                catch (Exception baglantiHata)
                {
                    //MessageBox.Show(baglantiHata.Message);
                    veriDeneme.Text = "Bağlanamadı!";
                    baglantiKurulduMU = false;
                }
            }
        }

        private void DataViewWindow_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
                comboBoxPort.SelectedIndex = 0;
            }
            comboBoxBaudRate.Items.Add("9600");
            comboBoxBaudRate.Items.Add("115200");
            comboBoxBaudRate.SelectedIndex = 0;
        }

        private void baglantibutonu_Click(object sender, EventArgs e)
        {
            BaglantiKur();
        }

        private void veriDeneme_Click(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent2()
        {
            this.SuspendLayout();
            // 
            // DataViewWindow
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "DataViewWindow";
            this.Load += new System.EventHandler(this.DataViewWindow_Load_1);
            this.ResumeLayout(false);

        }

        private void DataViewWindow_Load_1(object sender, EventArgs e)
        {

        }

        private void panelCompass_Paint(object sender, PaintEventArgs e)
        {
            SomeFunctions.RoundedLookingPanel(e, panelCompass, radius, clrActiveBorder);

        }
        

        private void SolveFormattedString(string sformat)
        {
            string[] values = null;
            bool sorunVarmi = false;
            try
            {
                values = sformat.Split('|'); 
            }
            catch(Exception ex)
            {
                exceptionLabel.Text= ex.Message;
                sorunVarmi = true;
            }
            if (!sorunVarmi)
            {
                ShowDatas(values);
            }
        }
        private void ShowDatas(string[] values)
        {
            bool sorunVarMi = false;
            double lan = 0;
            double lot = 0;
            //hız verilerinin gösterilmesi
            speedL.Text = values[1]; //anlık hız verisi
            try { speedPB.Value = int.Parse(values[1]); } catch { }
            //speedAverageLabel.Text = 
            //speedMaxLabel.Text =
            batteryL.Text = values[2];
            try { batteryPb.Value = int.Parse(values[2]); } catch { }
            leftMah.Text = values[3];
            //estMax.Text =
            temperatureL.Text = values[4];
            try { temperaturePb.Value = int.Parse(values[4]); } catch { }
            //temperatureMax =
            //temperatureAverage =
            moistureL.Text = values[5];
            try { moisturePb.Value = int.Parse(values[5]); } catch { }
            //moistureMax =
            //moistureAverage = 

            //direction gösten kod olacak

            //anlık konumu mapte gösteren kod, optimize etmek gerekebilir(yüksek ihtimal gerekecek)
            try
            {
                lan = double.Parse(values[7], System.Globalization.CultureInfo.InvariantCulture);
                lot = double.Parse(values[8], System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex) 
            {
                exceptionLabel.Text = ex.Message; // 2-3 farklı ex label yapmalıyım karışmasınlar
                sorunVarMi = true;
            }
            if(!sorunVarMi)
            {
                gMapControl1.Position = new PointLatLng(lan, lot);
            }

            //wildplant kodu
            if (!(values[9] == "0" && values[10] == "0")) // wildplant bulunamazsa koyulacak veri mi değil mi diye kontrol edicem, şimdilik 0 olarak kabul ediyorum
            {
                listBox2.Items.Add(values[9] + " , " + values[10]);
            }









        }
    }
}
