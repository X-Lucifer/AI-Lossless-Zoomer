using System.Diagnostics;
using System.Reflection;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom
{
    public partial class FormAbout : UIForm
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, System.EventArgs e)
        {
            lblxAuthor.Text = @"https://github.com/X-Lucifer";
            lblxDesc.Text = @"AI无损放大工具";
            lblxVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblxCopyright.Text  = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        }

        private void lblxAuthor_Click(object sender, System.EventArgs e)
        {
            Process.Start(lblxAuthor.Text);
        }
    }
}
