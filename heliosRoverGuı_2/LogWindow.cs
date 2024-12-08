using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Ports;
using System.CodeDom.Compiler;

namespace heliosRoverGuı_2
{
    public partial class LogWindow : Form
    {

        string path = Directory.GetCurrentDirectory() + @"\logs";
        //pathi canon hale getirmeliyim
        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("ads");

            //UpdateLog();
        }
        public LogWindow()
        {
            InitializeComponent();
            timer1.Start();
        }
        //sorunsuz çalışıyo
        private void UpdateLog(string selectedFile)
        {
            MessageBox.Show(path);
            //dataGridView1.Rows.Clear();
            table.Clear();
            //dataGridView1.DataBind();
            //dataGridView1.Refresh();

            Debug.WriteLine("B");
            string[] lines = File.ReadAllLines(selectedFile); // adres gircen
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                Debug.WriteLine("C");
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                //
                for(int j = 0; j < row.Length; j++)
                {
                    //List<string> newRow = new List<string>();
                    string[] temp = row[j].Split("|");

                    string[] arr = temp[1..];
                    table.Rows.Add(arr);
                }

                //her bir linedan verileri toplama
                //table.Rows.Add(row);
            }
        }

        DataTable table = new DataTable();
        private void LogWindow_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Speed", typeof(string));
            table.Columns.Add("a ", typeof(string));
            table.Columns.Add("Battery Percentage", typeof(string));
            table.Columns.Add("Gyro", typeof(string));
            table.Columns.Add("Date & Time", typeof(string));
            table.Columns.Add("Moisture", typeof(string));
            table.Columns.Add("Temperature", typeof(string));
            table.Columns.Add("Coordinates", typeof(string));
            table.Columns.Add("b ", typeof(string));
            table.Columns.Add("c ", typeof(string));
            table.Columns.Add("d ", typeof(string));
            
            comboBox1_DropDown(sender,e);

            dataGridView1.DataSource= table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFile = path +@"\"+ comboBox1.SelectedItem;
            UpdateLog(selectedFile);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //UpdateLog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            List<String> Configurations = Directory.EnumerateFiles(path)
                                                   .Select(p => Path.GetFileName(p))
                                                   .ToList();
            comboBox1.DataSource = Configurations;
        }
    }
}
