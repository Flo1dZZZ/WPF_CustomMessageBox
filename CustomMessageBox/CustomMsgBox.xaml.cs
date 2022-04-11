using System.Windows;

namespace CustomMessageBox
{
    /// <summary>
    /// Interaction logic for CustomMsgBox.xaml
    /// </summary>
    /// 
    public enum MsgBoxResult
    {
        None,
        OK,
        Yes,
        No,
        Cancel,
        CustomResult1,
        CustomResult2,
        CustomResult3
    }
    public enum MsgBoxButton
    {
        None,
        OK,
        OKCancel,
        YesNo,
        YesNoCancel
    }
    public enum MsgBoxImage
    {
        None,
        Information,
        Question,
        Warning,
        Error
    }
    

    public partial class CustomMsgBox : Window
    {
        public MsgBoxResult Result { get; set; }
        internal string Caption
        {
            get
            {
                return captionTxtBlock.Text;
            }
            set
            {
                captionTxtBlock.Text = value;
            }
        }
        internal string Message
        {
            get
            {
                return messageTxtBlock.Text;
            }
            set
            {
                messageTxtBlock.Text = value;
            }
        }

        internal string OkButtonText
        {
            get
            {
                return okBtn.Content.ToString();
            }
            set
            {
                okBtn.Content = value;
            }
        }
        internal string YesButtonText
        {
            get
            {
                return yesBtn.Content.ToString();
            }
            set
            {
                yesBtn.Content = value;
            }
        }
        internal string NoButtonText
        {
            get
            {
                return noBtn.Content.ToString();
            }
            set
            {
                noBtn.Content = value;
            }
        }
        internal string CancelButtonText
        {
            get
            {
                return cancelBtn.Content.ToString();
            }
            set
            {
                cancelBtn.Content = value;
            }
        }

        internal string CustomButton1Text
        {
            get
            {
                return custom1Btn.Content.ToString();
            }
            set
            {
                custom1Btn.Content = value;
            }
        }
        internal string CustomButton2Text
        {
            get
            {
                return custom2Btn.Content.ToString();
            }
            set
            {
                custom2Btn.Content = value;
            }
        }
        internal string CustomButton3Text
        {
            get
            {
                return custom3Btn.Content.ToString();
            }
            set
            {
                custom3Btn.Content = value;
            }
        }

        public CustomMsgBox(string message)
        {
            InitializeComponent();
            Message = message;
            messageTxtBlock.Visibility = Visibility.Visible;
            SetUpButtons(MsgBoxButton.OK);
        }
        public CustomMsgBox(string message, string caption)
        {
            InitializeComponent();
            Message = message;
            Caption = caption;
            captionTxtBlock.Visibility = Visibility.Visible;
            messageTxtBlock.Visibility = Visibility.Visible;
            SetUpButtons(MsgBoxButton.OK);
        }
        public CustomMsgBox(string message, string caption, MsgBoxButton buttons)
        {
            InitializeComponent();
            Message = message;
            Caption = caption;
            captionTxtBlock.Visibility = Visibility.Visible;
            messageTxtBlock.Visibility = Visibility.Visible;
            SetUpButtons(buttons);
        }
        public CustomMsgBox(string message, string caption, MsgBoxButton buttons, MsgBoxImage image)
        {
            InitializeComponent();
            Message = message;
            Caption = caption;
            captionTxtBlock.Visibility = Visibility.Visible;
            messageTxtBlock.Visibility = Visibility.Visible;
            SetUpButtons(buttons);
            SetUpImage(image);
        }
        
        private void SetUpButtons(MsgBoxButton buttons)
        {
            switch (buttons)
            {
                case MsgBoxButton.None:
                    break;
                case MsgBoxButton.OKCancel:
                    okBtn.Visibility = Visibility.Visible;
                    cancelBtn.Visibility = Visibility.Visible;
                    okBtn.Focus();
                    break;
                case MsgBoxButton.YesNoCancel:
                    yesBtn.Visibility = Visibility.Visible;
                    noBtn.Visibility = Visibility.Visible;
                    cancelBtn.Visibility = Visibility.Visible;
                    yesBtn.Focus();                  
                    break;
                case MsgBoxButton.YesNo:
                    yesBtn.Visibility = Visibility.Visible;
                    noBtn.Visibility = Visibility.Visible;
                    yesBtn.Focus();
                    break;
                default:
                    okBtn.Visibility = Visibility.Visible;
                    okBtn.Focus();
                    break;
            }
        }
        private void SetUpImage(MsgBoxImage image)
        {            
            switch (image)
            {
                case MsgBoxImage.None:
                    break;
                case MsgBoxImage.Question:
                    QuestionImage.Visibility = Visibility.Visible; 
                    break;
                case MsgBoxImage.Information:
                    InformationImage.Visibility = Visibility.Visible;
                    break;
                case MsgBoxImage.Warning:
                    WarningImage.Visibility = Visibility.Visible;
                    break;
                case MsgBoxImage.Error:
                    ErrorImage.Visibility = Visibility.Visible;
                    break;
                default:                    
                    break;
            }
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void custom1Btn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.CustomResult1;
            Close();
        }

        private void custom2Btn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.CustomResult2;
            Close();
        }

        private void custom3Btn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.CustomResult3;
            Close();
        }
        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.OK;
            Close();
        }
        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.Yes;
            Close();
        }
        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.No;
            Close();
        }
        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.Cancel;
            Close();
        }
        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Result = MsgBoxResult.None;
            Close();
        }
    }
}
