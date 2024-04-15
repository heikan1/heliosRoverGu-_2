using System.Diagnostics;

namespace heliosRoverGuı_2
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            SomeFunctions.LogDosyasıYoksaOlusturma();
        }
        public void loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //uygulamanın büyük ekran olarak başlatılmasını sağlıyor
            FormBorderStyle= FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;

            //ana sayfaya data view windowu yüklüyor
            loadform(new DataViewWindow());

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 1920, 50));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new LogWindow());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new DataViewWindow());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}