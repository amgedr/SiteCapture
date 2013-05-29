﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace SiteCapture
{
    class NativeMethods
    {
        [ComImport]
        [Guid("0000010D-0000-0000-C000-000000000046")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface IViewObject
        {
            void Draw([MarshalAs(UnmanagedType.U4)] uint dwAspect, int lindex, IntPtr pvAspect, [In] IntPtr ptd, IntPtr hdcTargetDev, IntPtr hdcDraw, [MarshalAs(UnmanagedType.Struct)] ref RECT lprcBounds, [In] IntPtr lprcWBounds, IntPtr pfnContinue, [MarshalAs(UnmanagedType.U4)] uint dwContinue);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static void GetImage(object obj, Image destination, Color backgroundColor)
        {
            using (Graphics graphics = Graphics.FromImage(destination))
            {
                IntPtr deviceContextHandle = IntPtr.Zero;
                RECT rectangle = new RECT();

                rectangle.Right = destination.Width;
                rectangle.Bottom = destination.Height;

                graphics.Clear(backgroundColor);

                try
                {
                    deviceContextHandle = graphics.GetHdc();

                    IViewObject viewObject = obj as IViewObject;
                    viewObject.Draw(1, -1, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, deviceContextHandle, ref rectangle, IntPtr.Zero, IntPtr.Zero, 0);
                }
                finally
                {
                    if (deviceContextHandle != IntPtr.Zero)
                    {
                        graphics.ReleaseHdc(deviceContextHandle);
                    }
                }
            }
        }
    }
}
