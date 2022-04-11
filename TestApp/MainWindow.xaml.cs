using System.Windows;
using System.Windows.Controls;
using CustomMessageBox;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            string caption = "";
            string okBtnText = "";
            string yesBtnText = "";
            string noBtnText = "";
            string cancelBtnText = "";
            string customButton1Text = "";
            string customButton2Text = "";
            string customButton3Text = "";
            MsgBoxButton msgBoxButton = new MsgBoxButton();
            MsgBoxImage msgBoxImage = new MsgBoxImage();
            ComboBoxItem msgBoxButtonCmbBoxItem = msgBoxButtonCmbBox.SelectedItem as ComboBoxItem;
            ComboBoxItem msgBoxImageCmbBoxItem = msgBoxImageCmbBox.SelectedItem as ComboBoxItem;
            
            message = messageTxtBox.Text;
            caption = captionTxtBox.Text;

            switch (msgBoxButtonCmbBoxItem.Content)
            {
                case "None":
                    msgBoxButton = MsgBoxButton.None;
                    break;
                case "OK":
                    msgBoxButton = MsgBoxButton.OK;
                    break;
                case "OKCancel":
                    msgBoxButton = MsgBoxButton.OKCancel;
                    break;
                case "YesNo":
                    msgBoxButton = MsgBoxButton.YesNo;
                    break;
                case "YesNoCancel":
                    msgBoxButton = MsgBoxButton.YesNoCancel;
                    break;
                default:
                    break;
            }

            switch (msgBoxImageCmbBoxItem.Content)
            {
                case "None":
                    msgBoxImage = MsgBoxImage.None;
                    break;
                case "Information":
                    msgBoxImage = MsgBoxImage.Information;
                    break;
                case "Question":
                    msgBoxImage = MsgBoxImage.Question;
                    break;
                case "Warning":
                    msgBoxImage = MsgBoxImage.Warning;
                    break;
                case "Error":
                    msgBoxImage = MsgBoxImage.Error;
                    break;
                default:
                    break;
            }

            if (okTxtTxtBox.Text != "") okBtnText = okTxtTxtBox.Text;
            if (yesTxtTxtBox.Text != "") yesBtnText = yesTxtTxtBox.Text;
            if (noTxtTxtBox.Text != "") noBtnText = noTxtTxtBox.Text;
            if (cancelTxtTxtBox.Text != "") cancelBtnText = cancelTxtTxtBox.Text;

            if (customBtn1TxtTxtBox.Text != "") customButton1Text = customBtn1TxtTxtBox.Text;
            if (customBtn2TxtTxtBox.Text != "") customButton2Text = customBtn2TxtTxtBox.Text;
            if (customBtn3TxtTxtBox.Text != "") customButton3Text = customBtn3TxtTxtBox.Text;


            if (okBtnText != "" && yesBtnText != "" && noBtnText != "" && cancelBtnText != "" && customButton1Text != "" && customButton2Text != "" && customButton3Text != "")
            {
                resultTxtBlock.Text = MsgBox.Show(this, message, caption, msgBoxButton, msgBoxImage, okBtnText, yesBtnText, noBtnText, cancelBtnText, customButton1Text, customButton2Text, customButton3Text).ToString();
                return;
            }
            else if(okBtnText != "" && yesBtnText != "" && noBtnText != "" && cancelBtnText != "" && customButton1Text != "" && customButton2Text != "")
            {
                resultTxtBlock.Text = MsgBox.Show(this, message, caption, msgBoxButton, msgBoxImage, okBtnText, yesBtnText, noBtnText, cancelBtnText, customButton1Text, customButton2Text).ToString();
                return;
            }
            else if(okBtnText != "" && yesBtnText != "" && noBtnText != "" && cancelBtnText != "" && customButton1Text != "")
            {
                resultTxtBlock.Text = MsgBox.Show(this, message, caption, msgBoxButton, msgBoxImage, okBtnText, yesBtnText, noBtnText, cancelBtnText, customButton1Text).ToString();
                return;
            }
            else if (okBtnText != "" && yesBtnText != "" && noBtnText != "" && cancelBtnText != "")
            {
                resultTxtBlock.Text = MsgBox.Show(this, message, caption, msgBoxButton, msgBoxImage, okBtnText, yesBtnText, noBtnText, cancelBtnText).ToString();
                return;
            }
            else
            {
                resultTxtBlock.Text = MsgBox.Show(this, message, caption, msgBoxButton, msgBoxImage).ToString();
                return;
            }
        }
    }
}
