using System;
using Sunny.UI;

namespace LosslessZoom.Core
{
    public partial class FormError : UIForm
    {
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; set; }

        public FormError()
        {
            InitializeComponent();
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            txtError.Text = Message ?? "";
        }
    }
}
