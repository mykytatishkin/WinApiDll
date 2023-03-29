

using SpDll_P05;

using System.Text;



Console.WriteLine("Hello, World!");

const int MB_RETRYCANCEL = 0x00000005;

const int MB_ICONINFORMATION = 0x00000040;

const int WM_SETTEXT = 0x000C;

const int WM_CLOSE = 0x0010;





//var res = WinApiFunctions.MessageBox(IntPtr.Zero, "Some message", "Header", MB_ICONINFORMATION|MB_RETRYCANCEL);

//Console.WriteLine(res);

//var hWnd = WinApiFunctions.FindWindow("WindowsForms10.Window.8.app.0.378734a_r3_ad1", null);

//var hWnd = WinApiFunctions.FindWindow("TTOTAL_CMD", null);



//WinApiFunctions.SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);



//StringBuilder sb = new StringBuilder(300);

//WinApiFunctions.GetWindowText(hWnd,sb,300);

//Console.WriteLine(sb.ToString());

////WinApiFunctions.SetWindowText(hWnd, "Another text");

//WinApiFunctions.SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, "Sended message");

//WinApiFunctions.GetWindowText(hWnd, sb, 300);

//Console.WriteLine(sb.ToString());



WinApiFunctions.Beep(2000, 1000);