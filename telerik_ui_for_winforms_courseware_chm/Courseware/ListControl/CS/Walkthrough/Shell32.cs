using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

// Declares types and methods that can be called from the DLL
public class Shell32
{
    public static Bitmap GetFileBitmap(string fileName)
    {
        Bitmap result = null;
        SHFILEINFO shFileInfo = new SHFILEINFO();
        IntPtr returnCode = SHGetFileInfo(fileName, 0, ref shFileInfo,
          (uint)Marshal.SizeOf(shFileInfo), SHGFI_ICON);

        if (shFileInfo.hIcon != IntPtr.Zero)
        {
            System.Drawing.Icon icon = System.Drawing.Icon.FromHandle(shFileInfo.hIcon);
            result = icon.ToBitmap();
            DestroyIcon(shFileInfo.hIcon);
            icon.Dispose();
        }

        return result;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public IntPtr hIcon;
        public IntPtr iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };

    public const uint SHGFI_ICON = 0x100;
    public const uint SHGFI_LARGEICON = 0x0;

    [DllImport("shell32.dll")]
    public static extern IntPtr SHGetFileInfo(string path,
                                uint dwFileAttributes,
                                ref SHFILEINFO shfi,
                                uint cbSizeFileInfo,
                                uint uFlags);
    [DllImport("user32.dll")]
    public static extern Int32 DestroyIcon(IntPtr hIcon);
}

