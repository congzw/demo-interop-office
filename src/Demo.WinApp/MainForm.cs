using System.Windows.Forms;
using AxDSOFramer;

namespace Demo.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }
        
        private AxFramerControl _axFramerControl;
        private void MyInitializeComponent()
        {
            //this.axFramerControl1.Dock = DockStyle.Fill;
            _axFramerControl = new AxFramerControl { Dock = DockStyle.Fill };
            this.splitContainer1.Panel1.Controls.Add(_axFramerControl);
            this.splitContainer1.FixedPanel = FixedPanel.Panel2;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            openFileDialog.Filter = @"Microsoft PPT Files|*.ppt|All Files|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this._axFramerControl.Open(openFileDialog.FileName);
            }
        }

    }
}
