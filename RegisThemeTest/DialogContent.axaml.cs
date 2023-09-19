using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using RegisThemeUI.Controls;

namespace RegisThemeTest
{
    public partial class DialogContent : UserControl
    {
        public DialogContent()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CloseDialog(object sender, RoutedEventArgs e)
        {
            InteractiveContainer.CloseDialog();
        }
    }
}
