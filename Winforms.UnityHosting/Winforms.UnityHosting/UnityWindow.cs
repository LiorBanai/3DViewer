using System.Windows.Forms;

namespace Winforms.UnityHosting
{
    public partial class UnityWindow : UserControl
    {
        private ServerNamePiped Pipe { get; }
        public UnityWindow()
        {
            InitializeComponent();
            Pipe = new ServerNamePiped();

        }
    }
}