# CustomMessageBox for WPF
### Better alternative to default MessageBox

Advantages:
> Nice UI design
>
> Fully customizable form. You can change everything by using XAML
>
> Many overloads. Your can hide MsgBoxImage, rename all buttons or add 3 custom buttons with their own MsgBoxResults
>
> Ability to change MsgBoxImage to your own (.png), by replacing files in project folder
>
> Ability to change any piece code of MsgBox

Known issues:
> Need to add 3 new files to your project (MsgBox form, MsgBox.cs class and Icons folder)

# Usage
Add files from the CustomMsgBox project to your project and add using directive to the CustomMessageBox namespace

![alt text](https://github.com/Flo1dZZZ/CustomMessageBox/blob/master/Screenshot_1.png)

```
using CustomMessageBox;
```

Call msgBox show method as just as the default's one
```
MsgBox.Show("Hello World!");
MsgBox.Show(this, "Text", "Caption", MsgBoxButton.YesNoCancel, MsgBoxImage.Question, "Okey", "Yeah", "Nope", "Close");
```
## Handling the msgBox result
```
MsgBoxResult msgBoxResult = MsgBox.Show(this, "Message", "Caption", MsgBoxButton.OKCancel, MsgBoxImage.Information);

switch (msgBoxResult)
{
    case MsgBoxResult.None:
        break;
    case MsgBoxResult.OK:
        break;
    case MsgBoxResult.Yes:
        break;
    case MsgBoxResult.No:
        break;
    case MsgBoxResult.Cancel:
        break;
    case MsgBoxResult.CustomResult1:
        break;
    case MsgBoxResult.CustomResult2:
        break;
    case MsgBoxResult.CustomResult3:
        break;
    default:
        break;
}
```

# Demo
![alt text](https://github.com/Flo1dZZZ/CustomMessageBox/blob/master/Demo.gif)
