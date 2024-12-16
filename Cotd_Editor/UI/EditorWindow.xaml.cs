using Cotd_Editor.Models.Cards;
using Cotd_Editor.VM;
using System.Windows;
using System.Windows.Controls;

namespace Cotd_Editor.UI
{
	/// <summary>
	/// Interaction logic for EditorWindow.xaml
	/// </summary>
	public partial class EditorWindow : Window
	{
        public CardEditorViewModel VM { get; set; }
        public EditorWindow()
		{
			VM = DataContext as CardEditorViewModel;
			InitializeComponent();
		}

		private void CardListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			VM.SelectedCard = (CardModel)CardListBox.SelectedItem;
		}
	}
}
