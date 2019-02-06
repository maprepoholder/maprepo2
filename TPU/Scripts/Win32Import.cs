using System;
using System.Runtime.InteropServices;




public enum SHOW_WINDOW
{
    /// <summary>
    /// Minimizes a window, even if the thread that owns the window is not responding. This flag should only be used when minimizing windows from a different thread.
    /// </summary>
    SW_FORCEMINIMIZE = 11,
    /// <summary>
    /// Hides the window and activates another window.
    /// </summary>
    SW_HIDE = 0,
    /// <summary>
    /// Maximizes the specified window.
    /// </summary>
    SW_MAXIMIZE = 3,

    /// <summary>
    /// Minimizes the specified window and activates the next top-level window in the Z order.
    /// </summary>
    SW_MINIMIZE = 6,

    /// <summary>
    /// Activates and displays the window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when restoring a minimized window.
    /// </summary>
    SW_RESTORE = 9,

    /// <summary>
    /// Activates the window and displays it in its current size and position.
    /// </summary>
    SW_SHOW = 5,

    /// <summary>
    /// Sets the show state based on the SW_ value specified in the STARTUPINFO structure passed to the CreateProcess function by the program that started the application.
    /// </summary>
    SW_SHOWDEFAULT = 10,

    /// <summary>
    /// Activates the window and displays it as a maximized window.
    /// </summary>
    SW_SHOWMAXIMIZED = 3,

    /// <summary>
    /// Activates the window and displays it as a minimized window.
    /// </summary>
    SW_SHOWMINIMIZED = 2,
    /// <summary>
    /// Displays the window as a minimized window. This value is similar to SW_SHOWMINIMIZED, except the window is not activated.
    /// </summary>
    SW_SHOWMINNOACTIVE = 7,

    /// <summary>
    /// Displays the window in its current size and position. This value is similar to SW_SHOW, except that the window is not activated.
    /// </summary>
    SW_SHOWNA = 8,

    /// <summary>
    /// Displays a window in its most recent size and position. This value is similar to SW_SHOWNORMAL, except that the window is not activated.
    /// </summary>
    SW_SHOWNOACTIVATE = 4,
    /// <summary>
    /// Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when displaying the window for the first time.
    /// </summary>
    SW_SHOWNORMAL = 1
    
}

public enum WINDOW_STYLES
{
    /// <summary>
    /// The window has a thin-line border.
    /// </summary>
    WS_BORDER = 0x00800000,

    /// <summary>
    /// The window has a title bar (includes the WS_BORDER style).
    /// </summary>
    WS_CAPTION = 0x00C00000,

    /// <summary>
    /// The window is initially disabled. A disabled window cannot receive input from the user. To change this after a window has been created, use the EnableWindow function.
    /// </summary>
    WS_DISABLED = 0x08000000,

    /// <summary>
    /// The window has a border of a style typically used with dialog boxes. A window with this style cannot have a title bar.
    /// </summary>
    WS_DLGFRAME =  0x00400000,

    /// <summary>
    /// The window is initially maximized.
    /// </summary>
    WS_MAXIMIZE = 0x01000000,

    /// <summary>
    /// The window has a maximize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.
    /// </summary>
    WS_MAXIMIZEBOX = 0x00010000,

    /// <summary>
    /// The window is initially minimized. Same as the WS_ICONIC style.
    /// </summary>
    WS_ICONIC  = 0x20000000,
    WS_MINIMIZE = 0x20000000,

    /// <summary>
    /// The window has a minimize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.
    /// </summary>
    WS_MINIMIZEBOX = 0x00020000,

    /// <summary>
    /// The window is an overlapped window. An overlapped window has a title bar and a border. Same as the WS_TILED style.
    /// </summary>
    WS_OVERLAPPED = 0x00000000,

    /// <summary>
    /// The window has a sizing border. Same as the WS_SIZEBOX style.
    /// </summary>
    WS_THICKFRAME = 0x00040000,

    /// <summary>
    /// The window has a window menu on its title bar. The WS_CAPTION style must also be specified.
    /// </summary>
    WS_SYSMENU = 0x00080000,

    /// <summary>
    /// The window is initially visible.
    ///This style can be turned on and off by using the ShowWindow or SetWindowPos function.
    /// </summary>
    WS_VISIBLE  =0x10000000,


    /// <summary>
    /// WS_OVERLAPPEDWINDOW
    ///(WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX)
    /// </summary>





    SW_HIDE = 0,
    SW_NORMAL = 1,
    SW_MINIMIZED = 2,
    SW_MAXIMIZED = 3,
    MAXIMIZE = 3,
    SW_NORMAL_NO_ACTIVATE = 4,
    SW_SHOW = 5,
    MINIMIZE = 6,
    SW_MIN_NO_ACTIVATE = 7,
    SW_NO_ACTIVATE = 8,
    SW_RESTORE = 9,
    SW_DEFAULT = 10,
    FORCE_MINIMIZED = 11
};

public enum WINDOWS_STYLE
{
    WS_BORDER         = 0x00800000,
    WS_CAPTION        = 0x00C00000,
    WS_CHILD          = 0x40000000,
    WS_CHILDWINDOW    = 0x40000000,
    WS_CLIPCHILDREN   = 0x02000000,
    WS_CLIPSIBLINGS   = 0x04000000,
    WS_DISABLED       = 0x08000000,
    WS_DLGFRAME       = 0x00400000,
    WS_MAXIMIZE       = 0x01000000,
    WS_MAXIMIZEBOX    = 0x00010000,
    WS_MINIMIZE       = 0x20000000,
    WS_MINIMIZEBOX    = 0x00020000,
    WS_OVERLAPPED     = 0x00000000,
    WS_SIZEBOX        = 0x00040000,
    WS_SYSMENU        = 0x00080000,
    WS_VISIBLE        = 0x10000000
}

public enum WINDOW_POS
{
    /// <summary>
    /// Places the window at the bottom of the Z order. If the hWnd parameter identifies a topmost window, the window loses its topmost status and is placed at the bottom of all other windows.
    /// </summary>
    HWND_BOTTOM = 1,
    /// <summary>
    /// Places the window above all non-topmost windows (that is, behind all topmost windows). This flag has no effect if the window is already a non-topmost window.
    /// </summary>
    HWND_NOTOPMOST = -2,
    /// <summary>
    /// Places the window at the top of the Z order.
    /// </summary>
    HWND_TOP = 0,
    /// <summary>
    /// Places the window above all non-topmost windows. The window maintains its topmost position even when it is deactivated.
    /// </summary>
    HWND_TOPMOST = -1,

    /// <summary>
    /// If the calling thread and the thread that owns the window are attached to different input queues, 
    /// the system posts the request to the thread that owns the window. \
    /// This prevents the calling thread from blocking its execution while other threads process the request.
    /// </summary>
    SWP_ASYNCWINDOWPOS = 0x4000,
    /// <summary>
    /// Retains the current Z order (ignores the hWndInsertAfter parameter).
    /// </summary>
    SWP_NOZORDER = 0x0004,
    /// <summary>
    /// Retains the current size (ignores the cx and cy parameters).
    /// </summary>
    SWP_NOSIZE = 0x0001,
    /// <summary>
    /// Displays the window.
    /// </summary>
    SWP_SHOWWINDOW = 0x0040,

    /// <summary>
    /// Retains the current position (ignores X and Y parameters).
    /// </summary>
    SWP_NOMOVE = 0x0002,

    /// <summary>
    /// Does not change the owner window's position in the Z order.
    /// </summary>
    SWP_NOREPOSITION = 0x0200,
    /// <summary>
    /// Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to the window, 
    /// even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
    /// </summary>
    SWP_FRAMECHANGED = 0x0020


}

public enum WINDOW_LONG
{
    /// <summary>
    /// Sets a new extended window style.
    /// </summary>
    GWL_EXSTYLE = -20,
    /// <summary>
    /// Sets a new application instance handle.
    /// </summary>
    GWL_HINSTANCE = -6,
    /// <summary>
    /// Sets a new identifier of the child window.The window cannot be a top-level window.
    /// </summary>
    GWL_ID = -12,
    /// <summary>
    /// Sets a new window style.
    /// </summary>
    GWL_STYLE = -16,
    /// <summary>
    /// Sets the user data associated with the window. This data is intended for use by the application that created the window. Its value is initially zero.
    /// </summary>
    GWL_USERDATA = -21,
    /// <summary>
    /// Sets a new address for the window procedure. You cannot change this attribute if the window does not belong to the same process as the calling thread.
    /// </summary>
    GWL_WNDPROC = -4,          
}

public enum EXTENDED_WINDOW
{
    /// <summary>
    /// The window is an overlapped window.
    /// </summary>
    WS_EX_WINDOWEDGE = 0x00000100,
    /// <summary>
    /// The window has a double border; the window can, optionally, be created with a title bar by specifying the WS_CAPTION style in the dwStyle parameter.
    /// </summary>
    WS_EX_DLGMODALFRAME = 0x00000001,
    /// <summary>
    /// The window should not be painted until siblings beneath the window (that were created by the same thread) have been painted. 
    /// </summary>
    WS_EX_TRANSPARENT = 0x20,
    /// <summary>
    /// The window is a layered window. This style cannot be used if the window has a class style of either CS_OWNDC or CS_CLASSDC.
    /// </summary>
    WS_EX_LAYERED = 0x80000      
}

public enum LAYERED_WINDOW_ATTRIBUTES
{
    /// <summary>
    /// Use bAlpha to determine the opacity of the layered window.
    /// </summary>
    LWA_ALPHA = 0x00000002,
    /// <summary>
    /// Use crKey as the transparency color.
    /// </summary>
    LWA_COLORKEY = 0x00000001
}

public class Win32Import
{
    /*
        public const int GWL_EXSTYLE = (-20);
        public const int GWL_STYLE = (-16);
        public const int WS_VISIBLE = 0x10000000;
        public const int WS_CHILD = 0x40000000;
        public const int WS_BORDER = 0x00800000;

        public const int LWA_ALPHA = 0x00000002;
        public const int WS_CAPTION = 0X00C0000;*/

    
    [DllImport("User32.dll", EntryPoint = "SendMessage")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", EntryPoint = "SetParent")]
    public static extern IntPtr SetParent(IntPtr child, IntPtr parent);

    [DllImport("user32.dll", EntryPoint = "GetParent")]
    public static extern IntPtr GetParent(IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
    public extern static int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
    [DllImport("user32.dll", EntryPoint = "SetWindowLongA")]
    public static extern int SetWindowLong(int hwnd, int nIndex, long dwNewLong);

    [DllImport("user32.dll", EntryPoint = "MoveWindow")]
    public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

    [DllImport("User32.dll", EntryPoint = "GetWindowLong")]
    public static extern long GetWindowLong(int hwnd, int nIndex);
    [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
    public static extern int GetWindowLong(IntPtr handle, int style);

    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    public static extern int SetWindowPos(int hwnd, int hwndInsertAfter, int x, int y, int cx, int cy, int uFlags);
    [DllImport("user32.dll")]
    public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);


    [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
    public static extern int SetLayeredWindowAttributes(int hwnd, int crKey, byte bAlpha, int dwFlags);

    

    [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
    public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

    [DllImport("User32.dll")]
    public static extern int SetLayeredWindowAttributes(IntPtr Handle, int crKey, byte bAlpha, int dwFlags);

    [DllImport("user32.dll", EntryPoint = "SetFocus")]
    public static extern IntPtr SetFocus(IntPtr hWnd);

    /*   [DllImport("user32.dll", EntryPoint = "GetActiveWindow")]
       public static extern int GetActiveWindow();*/

    [DllImport("user32.dll", EntryPoint = "GetActiveWindow")]
    public static extern System.IntPtr GetActiveWindow();


    [DllImport("user32.dll")]
    public static extern bool ShowWindowAsync(int hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string className, string windowTitle);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);






}