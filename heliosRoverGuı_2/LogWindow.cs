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

namespace heliosRoverGuı_2
{
    public partial class LogWindow : Form
    {
        //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("ads");

            UpdateLog();
        }
        public LogWindow()
        {
            InitializeComponent();
            timer1.Start();
        }
        //sorunsuz çalışıyo
        private void UpdateLog()
        {
            //dataGridView1.Rows.Clear();
            table.Clear();
            //dataGridView1.DataBind();
            //dataGridView1.Refresh();

            Debug.WriteLine("B");
            string[] lines = File.ReadAllLines(@"C:\Users\metin\OneDrive - ogr.sakarya.edu.tr\Masaüstü\IEEE TARIMSAL IKA\Arayuz veri deneme\deneme.txt"); // adres gircen
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
                table.Rows.Add(row);
            }
        }

        DataTable table = new DataTable();
        private void LogWindow_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Speed", typeof(int));
            table.Columns.Add("Coordinate", typeof(string));
            table.Columns.Add("Battery Percentage", typeof(int));
            table.Columns.Add("Date & Time", typeof(string));

            dataGridView1.DataSource= table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            UpdateLog();
        }
    }
}
