using System;
using System.Windows.Forms;
using Sunny.UI;

namespace LosslessZoom.Core
{
    public partial class FormViewPic : UIForm
    {
        private readonly PictureBox _pic;
        public FormViewPic(PictureBox pic)
        {
            _pic = pic;
            InitializeComponent();
        }

        private void FormViewPic_Load(object sender, EventArgs e)
        {
            var pic = new PictureBox
            {
                Image = _pic.Image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            panelPic.Controls.Add(pic);
            lblPicname.Text = _pic.Text;
        }
    }
}
