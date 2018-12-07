using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace XieCanRFID
{
    /// <summary>
    /// EPC操作辅助类，使用前须先添加命名空间
    /// </summary>
    public class EPCSDKHelper
    {
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="portNo">串口号</param>
        /// <returns>成功时返回串口句柄，失败时返回-1</returns>
        [DllImport("EPCSDK.dll")]
        public static extern IntPtr OpenComm(int portNo);

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        [DllImport("EPCSDK.dll")]
        public static extern void CloseComm(IntPtr hCom);

        /// <summary>
        /// 读取Firmware版本(读头版本)
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="main">主版本号的变量地址(输出参数)</param>
        /// <param name="sub">子版本号的变量地址(输出参数)</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool ReadFirmwareVersion(IntPtr hCom, out int main, out int sub, byte ReaderAddr);

        /// <summary>
        /// 获取多个读写器参数
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="addr">要查询的读写器参数的起始地址(各地址参见高级附表)</param>
        /// <param name="paramNum">要查询的读写器参数的数量</param>
        /// <param name="parms">接收读写器参数的数组地址(输出参数)</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool GetReaderParameters(IntPtr hCom, int addr, int paramNum, byte[] parms, byte ReaderAddr);

        /// <summary>
        /// 设置多个读写器参数，通常在主从模式下使用该函数
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="addr">要查询的读写器参数的起始地址(各地址参见高级附表)</param>
        /// <param name="paramNum">要查询的读写器参数的数量</param>
        /// <param name="parms">设置读写器参数的数组地址</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool SetReaderParameters(IntPtr hCom, int addr, int paramNum, byte[] parms, byte ReaderAddr);

        /// <summary>
        /// 使读卡器停止读取标签。通常是在定时模式下，要临时停止读标签，使用该函数；如果要恢复到定时模式，此时要发送ResumeReading，即复位读头命令。
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool StopReading(IntPtr hCom, byte ReaderAddr);

        /// <summary>
        /// 复位读写器，相当于对读写器重新上电。用于定时模式下，临时停读标签之后，恢复到定时读取标签。 
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool ResumeReading(IntPtr hCom, byte ReaderAddr);

        /// <summary>
        /// 识别EPC区ID号，通常在主从模式使用
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="tagId">接收标签ID的数组地址(输出参数)，长度为12 </param>
        /// <param name="antennaNo">接收天线号的变量地址(输出参数)。不需要时置为null</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool IdentifySingleTag(IntPtr hCom, byte[] tagId, byte[] antennaNo, byte ReaderAddr);

        /// <summary>
        /// 识别读卡器上传的单个标签。在定时模式和单卡模式下获取识别到的标签时使用该函数
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="tagId">接收标签ID的数组地址(输出参数)，长度为12</param>
        /// <param name="devNos">接收设备号的变量地址(输出参数)。不需要时置为null</param>
        /// <param name="antennaNo">接收天线号的变量地址(输出参数)。不需要时置为null</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool IdentifyUploadedSingleTag(IntPtr hCom, byte[] tagId, byte[] devNos, byte[] antennaNo);

        /// <summary>
        /// 识别读卡器上传的多个标签。在定时模式和多卡模式下，获取读写器读到的多标签数据时使用该函数
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="tagNum">接收标签数的变量地址(输出参数)。一次可能读取的最大标签数是200</param>
        /// <param name="tagIds">接收标签ID的数组地址(输出参数)，长度为12 * tagNum</param>
        /// <param name="devNos">接收设备号的数组地址(输出参数)。长度为1 * tagNum， 不需要时置为null</param>
        /// <param name="antennaNos">接收天线号的数组地址(输出参数)。长度为1 * tagNum， 不需要时置为null</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool IdentifyUploadedMultiTags(IntPtr hCom, out byte tagNum, byte[] tagIds, byte[] devNos, byte[] antennaNos);

        /// <summary>
        /// 读标签内容，可以读取保留区、EPC区、TID区及用户区数据。最好在主从模式使用
        /// </summary>
        /// <remarks>
        /// 1. IdentifySingleTag 函数只能读取EPC 区的标签ID号。而本函数可以读4个区，范围更广。
        /// 2. IdentifySingleTag 标签识别的距离更远，效果更好，而本函数读取标签的距离要近些，效果不如IdentifySingleTag好。
        /// </remarks>
        /// <param name="hCom">串口句柄</param>
        /// <param name="memBank">要读的区域。各值的意义如下： 0x00 - 保留区；0x01 - EPC区；0x02 - TID区；0x03 - 用户区</param>
        /// <param name="address">要读区域中的地址，取值为范围0-7</param>
        /// <param name="length">要读取的长度，取值范围是1-8(单位是Word， 1Word = 2Byte)</param>
        /// <param name="data">接收数据的变量地址(输出参数)</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool ReadTag(IntPtr hCom, byte memBank, byte address, byte length, byte[] data, byte ReaderAddr);

        /// <summary>
        /// 向标签写入1个字(2字节)的内容。(注：EPC区的地址0、1不可写入)最好在主从模式下使用
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="memBank">要写的区域。各值的意义如下： 0x00 - 保留区；0x01 - EPC区；0x02 - TID区；0x03 - 用户区</param>
        /// <param name="address">要写区域中的地址，取值为范围0-7 (memBank为EPC区时， 0、 1不可取)。</param>
        /// <param name="data1">要写入内容的第1个字节</param>
        /// <param name="data2">要写入内容的第2个字节</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool WriteTagSingleWord(IntPtr hCom, byte memBank, byte address, byte data1, byte data2, byte ReaderAddr);

        /// <summary>
        /// 快写EPC区ID号，即通常所说的标签号码，最好在主从模式下使用
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="bytesNum">要写入内容的字节数，必须为2、4、6、8、10或12</param>
        /// <param name="bytes">要写入的内容</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool FastWriteTagID(IntPtr hCom, int bytesNum, byte[] bytes, byte ReaderAddr);

        /// <summary>
        /// 快写标签，包括EPC区、数据区和保留区，最好在主从模式下使用。一次性写入字节数越多，成功率越低，所以尽量只写必要数据
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="memBank">要写的区域。各值的意义如下： 0x00 - 保留区；0x01 - EPC区；0x02 - TID区；0x03 - 用户区</param>
        /// <param name="address">要写区域中的地址。EPC区地址范围为2-7，最大WordCount为6；保留区地址范围为0-3，最大WordCount为4； 数据区址址范围为0-31，最大WordCount为8</param>
        /// <param name="wordCount">要写入内容的长度，以字为单位，1个字为2个字节</param>
        /// <param name="data">要写入的内容</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool FastWriteTag(IntPtr hCom, byte memBank, byte address, byte wordCount, byte[] data, byte ReaderAddr); 

        /// <summary>
        /// 快写标签ID锁定
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="bytesNum">要写入内容的长度，以字为单位，1个字为2个字节</param>
        /// <param name="bytes">要写入的内容</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool FastWriteTagID_Lock(IntPtr hCom, int bytesNum, byte[] bytes, byte ReaderAddr);

        /// <summary>
        /// 初始化标签，初始化标签的协议控制字，通常不需使用该函数
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool InitializeTag(IntPtr hCom, byte ReaderAddr);

        /// <summary>
        /// 通过访问密码锁定标签，通常在主从模式下使用该函数
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="passwd1">访问密码1</param>
        /// <param name="passwd2">访问密码2</param>
        /// <param name="passwd3">访问密码3</param>
        /// <param name="passwd4">访问密码4 </param>
        /// <param name="lockType">锁定类型  取值范围：0 - LOCK USER; 1 - LOCK TID; 2 - LOCK EPC; 3 - LOCK ACCESS; 4 - LOCK KILL; 5 - LOCK ALL; 其他 - DO NOT LOCK</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool LockPassWordTag(IntPtr hCom, byte passwd1, byte passwd2, byte passwd3, byte passwd4, byte lockType, byte ReaderAddr);

        /// <summary>
        /// 通过访问密码解锁标签，通常在主从模式下使用该函数。
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="passwd1">访问密码1</param>
        /// <param name="passwd2">访问密码2</param>
        /// <param name="passwd3">访问密码3</param>
        /// <param name="passwd4">访问密码4 </param>
        /// <param name="lockType">解锁类型  取值范围：0 - UNLOCK USER; 1 - UNLOCK TID; 2 - UNLOCK EPC; 3 - UNLOCK ACCESS; 4 - UNLOCK KILL; 5 - UNLOCK ALL; 其他 - DO NOT UNLOCK</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool UnlockPassWordTag(IntPtr hCom, byte passwd1, byte passwd2, byte passwd3, byte passwd4, byte lockType, byte ReaderAddr);

        /// <summary>
        /// 销毁标签。通常在主从模式下使用该函数。一旦标签被销毁，就不能使用
        /// </summary>
        /// <param name="hCom">串口句柄</param>
        /// <param name="passwd1">密码1</param>
        /// <param name="passwd2">密码2</param>
        /// <param name="passwd3">密码3</param>
        /// <param name="passwd4">密码4</param>
        /// <param name="ReaderAddr">读头地址，一台主机接多台读头时使用，接单台读头时置为0</param>
        /// <returns>成功时返回true，失败时返回false</returns>
        [DllImport("EPCSDK.dll")]
        public static extern bool KillTag(IntPtr hCom, byte passwd1, byte passwd2, byte passwd3, byte passwd4, byte ReaderAddr);
    }
}
