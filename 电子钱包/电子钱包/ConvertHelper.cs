using System;
using System.Text;


namespace XieCanRFID
{
    /// <summary>
    /// 数据类型转换辅助类，使用前须先添加命名空间
    /// </summary>
    public class ConvertHelper
    {
        /// <summary>
        /// 将字节数组转化为整数
        /// </summary>
        /// <param name="datas">字节数组</param>
        /// <returns>转化失败返回0</returns>
        public static int BytesToInt(byte[] datas)
        {
            int i = 0;
            try
            {
                i = BitConverter.ToInt32(datas, 0);
            }
            catch
            {
            }
            return i;
        }

        /// <summary>
        /// 将字节数组转化为无符号整数
        /// </summary>
        /// <param name="datas">字节数组</param>
        /// <returns>转化失败返回0</returns>
        public static uint BytesToUInt32(byte[] datas)
        {
            uint i = 0;
            try
            {
                i = BitConverter.ToUInt32(datas, 0);
            }
            catch
            {
            }
            return i;
        }

        /// <summary>
        /// 将字节数组转化为字符串
        /// </summary>
        /// <param name="datas">字节数组</param>
        /// <returns>字符串</returns>
        public static string BytesToString(byte[] datas)
        {
            return Encoding.Default.GetString(datas);
        }

        /// <summary>
        /// 将整数转化为字节数组
        /// </summary>
        /// <param name="i">整数</param>
        /// <returns>字节数组</returns>
        public static byte[] IntToBytes(int i)
        {
            return BitConverter.GetBytes(i);
        }

        /// <summary>
        /// 将字符串转化为字节数组
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] StringToBytes(string str)
        {
            byte[] buf = new byte[0];
            if (!string.IsNullOrEmpty(str))
            {
                buf = Encoding.Default.GetBytes(str);
            }
            return buf;
        }

        /// <summary>
        /// 将无符号整数转化为字节数组
        /// </summary>
        /// <param name="i">无符号整数</param>
        /// <returns>字节数组</returns>
        public static byte[] UIntToBytes(uint i)
        {
            return BitConverter.GetBytes(i);
        }

        /// <summary>
        /// 将十六进制字符串转化为字节数组
        /// </summary>
        /// <param name="str">十六进制字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] HexStringToByteArray(string str)
        {
            str = str.Replace(" ", "");
            byte[] buffer = new byte[str.Length / 2];
            for (int i = 0; i < str.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(str.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary>
        /// 将字节数组转化为十六进制字符串
        /// </summary>
        /// <param name="datas">字节数组</param>
        /// <returns>十六进制字符串</returns>
        public static string ByteArrayToHexString(byte[] datas)
        {
            StringBuilder sb = new StringBuilder(datas.Length * 3);
            foreach (byte b in datas)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        /// <summary>
        /// 将字节转化为十六进制字符串
        /// </summary>
        /// <param name="datas">字节</param>
        /// <returns>十六进制字符串</returns>
        public static string ByteToHexString(byte data)
        {
            return Convert.ToString(data, 16).PadLeft(2, '0').ToUpper();
        }

        /// <summary>
        /// 将字节转化为字符串
        /// </summary>
        /// <param name="datas">字节</param>
        /// <returns>字符串</returns>
        public static string ByteToString(byte data)
        {
            return Convert.ToString(data, 2).PadLeft(8, '0');
        }
    }
}

