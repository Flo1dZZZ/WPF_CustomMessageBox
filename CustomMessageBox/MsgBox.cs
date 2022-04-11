using System.Windows;

namespace CustomMessageBox
{
    /// <summary>
    /// Displays a message box.
    /// </summary>

    public static class MsgBox
    {
        /// <summary>
        /// Displays a message box that has a message and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message);
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption; and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption);
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption, MsgBoxButton buttons)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons);
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons, an image and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption, MsgBoxButton buttons, MsgBoxImage image)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, an image and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, a custom buttons, an image and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <param name="CustomButton1Text">A System.String that specifies the 1st custom button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText, string CustomButton1Text)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.CustomButton1Text = CustomButton1Text;
            msgBox.custom1Btn.Visibility = Visibility.Visible;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, a custom buttons, an image and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <param name="CustomButton1Text">A System.String that specifies the 1st custom button text.</param>
        /// <param name="CustomButton2Text">A System.String that specifies the 2nd custom button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText, string CustomButton1Text, string CustomButton2Text)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.CustomButton1Text = CustomButton1Text;
            msgBox.custom1Btn.Visibility = Visibility.Visible;
            msgBox.CustomButton2Text = CustomButton2Text;
            msgBox.custom2Btn.Visibility = Visibility.Visible;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, a custom buttons, an image and that returns a result.
        /// </summary>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <param name="CustomButton1Text">A System.String that specifies the 1st custom button text.</param>
        /// <param name="CustomButton2Text">A System.String that specifies the 2nd custom button text.</param>
        /// <param name="CustomButton3Text">A System.String that specifies the 3rd custom button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText, string CustomButton1Text, string CustomButton2Text, string CustomButton3Text)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.CustomButton1Text = CustomButton1Text;
            msgBox.custom1Btn.Visibility = Visibility.Visible;
            msgBox.CustomButton2Text = CustomButton2Text;
            msgBox.custom2Btn.Visibility = Visibility.Visible;
            msgBox.CustomButton3Text = CustomButton3Text;
            msgBox.custom3Btn.Visibility = Visibility.Visible;
            msgBox.ShowDialog();
            return msgBox.Result;
        }





        /// <summary>
        /// Displays a message box that has a message and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message);
            msgBox.Owner = owner;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption);
            msgBox.Owner = owner;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption, MsgBoxButton buttons)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons);
            msgBox.Owner = owner;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons, an image and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption, MsgBoxButton buttons, MsgBoxImage image)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.Owner = owner;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, an image and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.Owner = owner;
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, a custom buttons, an image and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <param name="CustomButton1Text">A System.String that specifies the 1st custom button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText, string CustomButton1Text)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.Owner = owner;
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.CustomButton1Text = CustomButton1Text;
            msgBox.custom1Btn.Visibility = Visibility.Visible;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, a custom buttons, an image and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <param name="CustomButton1Text">A System.String that specifies the 1st custom button text.</param>
        /// <param name="CustomButton2Text">A System.String that specifies the 2nd custom button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText, string CustomButton1Text, string CustomButton2Text)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.Owner = owner;
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.CustomButton1Text = CustomButton1Text;
            msgBox.custom1Btn.Visibility = Visibility.Visible;
            msgBox.CustomButton2Text = CustomButton2Text;
            msgBox.custom2Btn.Visibility = Visibility.Visible;
            msgBox.ShowDialog();
            return msgBox.Result;
        }

        /// <summary>
        /// Displays a message box that has a message, a caption, a buttons with custom text, a custom buttons, an image and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <param name="message">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the text over the message to display.</param>
        /// <param name="buttons">A CustomMsgBox.MsgBoxButton that specifies buttons to display.</param>
        /// <param name="image">A CustomMsgBox.MsgBoxImage that specifies image to display.</param>
        /// <param name="OkButtonText">A System.String that specifies the 'OK' button text.</param>
        /// <param name="YesButtonText">A System.String that specifies the 'Yes' button text.</param>
        /// <param name="NoButtonText">A System.String that specifies the 'No' button text.</param>
        /// <param name="CancelButtonText">A System.String that specifies the 'Cancel' button text.</param>
        /// <param name="CustomButton1Text">A System.String that specifies the 1st custom button text.</param>
        /// <param name="CustomButton2Text">A System.String that specifies the 2nd custom button text.</param>
        /// <param name="CustomButton3Text">A System.String that specifies the 3rd custom button text.</param>
        /// <returns>A CustomMsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MsgBoxResult Show(Window owner, string message, string caption, MsgBoxButton buttons, MsgBoxImage image, string OkButtonText, string YesButtonText, string NoButtonText, string CancelButtonText, string CustomButton1Text, string CustomButton2Text, string CustomButton3Text)
        {
            CustomMsgBox msgBox = new CustomMsgBox(message, caption, buttons, image);
            msgBox.Owner = owner;
            msgBox.OkButtonText = OkButtonText;
            msgBox.YesButtonText = YesButtonText;
            msgBox.NoButtonText = NoButtonText;
            msgBox.CancelButtonText = CancelButtonText;
            msgBox.CustomButton1Text = CustomButton1Text;
            msgBox.custom1Btn.Visibility = Visibility.Visible;
            msgBox.CustomButton2Text = CustomButton2Text;
            msgBox.custom2Btn.Visibility = Visibility.Visible;
            msgBox.CustomButton3Text = CustomButton3Text;
            msgBox.custom3Btn.Visibility = Visibility.Visible;
            msgBox.ShowDialog();
            return msgBox.Result;
        }
    }
}
