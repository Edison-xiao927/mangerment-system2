using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Twain
{
    internal sealed class DibToImage
    {

        public static Stream WithStream(IntPtr dibPtr)
        {
            MemoryStream _stream = new MemoryStream();
            BinaryWriter _writer = new BinaryWriter(_stream);

            BITMAPINFOHEADER _bmi = (BITMAPINFOHEADER)Marshal.PtrToStructure(dibPtr, typeof(BITMAPINFOHEADER));

            int _extra = 0;
            if (_bmi.biCompression == 0)
            {
                int _bytesPerRow = ((_bmi.biWidth * _bmi.biBitCount) >> 3);
                _extra = Math.Max(_bmi.biHeight * (_bytesPerRow + ((_bytesPerRow & 0x3) != 0 ? 4 - _bytesPerRow & 0x3 : 0)) - _bmi.biSizeImage, 0);
            }

            int _dibSize = _bmi.biSize + _bmi.biSizeImage + _extra + (_bmi.ClrUsed << 2);

            #region BITMAPFILEHEADER

            _writer.Write((ushort)0x4d42);
            _writer.Write(14 + _dibSize);
            _writer.Write(0);
            _writer.Write(14 + _bmi.biSize + (_bmi.ClrUsed << 2));

            #endregion

            #region BITMAPINFO and pixel data

            byte[] _data = new byte[_dibSize];
            Marshal.Copy(dibPtr, _data, 0, _data.Length);
            _writer.Write(_data);

            #endregion

            return _stream;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        private class BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;

            public int ClrUsed
            {
                get
                {
                    return this.IsRequiredCreateColorTable ? 1 << this.biBitCount : this.biClrUsed;
                }
            }

            public bool IsRequiredCreateColorTable
            {
                get
                {
                    return this.biClrUsed == 0 && this.biBitCount <= 8;
                }
            }
        }
    }
}
