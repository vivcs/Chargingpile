using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Reflection;
using System.Net.Sockets;

public enum PackageType
{
    CMD_ROLL = 0,
    CMD_HEARTBEAT = 0x21,
    CMD_REGISTER = 0x20,
    CMD_GET_TIME = 0x22,    // Server sends
    CMD_SYNC_TIME = 0x12,
    CMD_SYNC_HOST_INFOR = 0x13, // Host status report
    CMD_CHARGE_DATA = 0x06,
    CMD_DEV_WARN = 0x42,
    CMD_ON_OFF_CHARGE = 0x82,
    CMD_SETTLEMENT = 0x03,
    CMD_IP_ADDRESS = 0x34, // LBY: Modify IP address
    CMD_UPDATE_VER = 0x35,
    CMD_CTRL_JI = 0x36, // Relay control
    CMD_DOOR_CONTROL = 0x37, // Door control
    CMD_CTRL_SMOKE = 0x38, // Smoke control
    CMD_CTRL_SOLENOID = 0x39, // Sprinkler solenoid control
    CMD_DEV_CALL_POLICE = 0x43, // Smoke alarm
    CMD_DEV_VOICE = 0x44, // Voice broadcast
    CMD_DEV_SET_A = 0x83, // Set device port parameters A
    CMD_DEV_SET_B = 0x84, // Set device port parameters B
    CMD_DEV_SET_MAX = 0x85, // Set max charging duration, overload power
    CMD_DEV_LOCK = 0x89, // Lock
    CMD_DEV_SET_ID = 0xFF, // Modify ID
    CMD_OTA_START = 0xF9,
    CMD_OTA_PACKAGE = 0xFA
}




namespace SerialPortForm
{

    public partial class Form1 : Form
    {
        //定义端口类
        private SerialPort ComDevice = new SerialPort();

        // 创建 DataReceiver 实例
        DataReceiver receiver = new DataReceiver();

        //private static byte[] dataID = new byte[4]; // ID
        //private static ushort messagID = 0; // 消息ID

        private static ushort unlock_flag = 1; // 解锁标志位

        int device_ID = 0;//设备ID

        bool CorrectIsToggled_1 = false; // 按钮1的状态
        bool CorrectIsToggled_2 = false; // 按钮2的状态

        public class ONOFF_COMD_TYPE
        {
            //public byte u8Cmd { get; set; }
            public byte u8ChargeRate { get; set; } // 费率模式
            public byte[] u8Balance { get; set; } = new byte[4]; // 余额/有效期
            public byte u8ChargePort { get; set; } // 端口号
            public byte u8ChargeCmd { get; set; } // 充电命令
            public byte[] u8TimeOrQuantity { get; set; } = new byte[2]; // 充电时常
            public byte[] u8OrderNo { get; set; } = new byte[16]; // 订单编号
            public byte[] u8MaxChargeTime { get; set; } = new byte[2]; // 最大充电时常
            public byte[] u8MaxPower { get; set; } = new byte[2]; // 过载功率
            public byte u8LedStatus { get; set; } // 二维码灯
            public byte u8ChargeMod { get; set; }
            public byte[] u8FloatingTime { get; set; } = new byte[2]; // un_floatingTime unFloatingTime
            public byte u8IgnoreCheckShort { get; set; }
            public byte u8Ignoreextract { get; set; }
            public byte u8MustCheckFull { get; set; }
            public byte u8FullPower { get; set; }
            public byte u8CheckFullMaxTime { get; set; }
        }


        public Form1()
        {
            InitializeComponent();
            button_Switch.Click += button_Switch_Click;
            button_Set_ID.Click += button_Send_Click;
            button_Set_ID.Enabled = false;
            button_get_ID.Enabled = false;
            InitralConfig();
        }

        /// <summary>
        /// 配置初始化
        /// </summary>
        private void InitralConfig()
        {
            //查询主机上存在的串口
            comboBox_Port.Items.AddRange(SerialPort.GetPortNames());

            if (comboBox_Port.Items.Count > 0)
            {
                comboBox_Port.SelectedIndex = 0;
            }
            else
            {
                comboBox_Port.Text = "未检测到串口";
            }
            string[] listBaudRate = new string[]
            {
                "9600",
                "14400",
                "19200",
                "38400",
                "56000",
                "115200"
            };
            comboBox_BaudRate.Items.AddRange(listBaudRate);
            comboBox_BaudRate.SelectedIndex = 0;

            string[] listDataBits = new string[]
            {
                "5",
                "6",
                "7",
                "8"
            };
            comboBox_DataBits.Items.AddRange(listDataBits);
            comboBox_DataBits.SelectedIndex = 3;


            string[] listStopBits = new string[]
            {
                "1",
                "1.5",
                "2",
                "8"
            };
            comboBox_StopBits.Items.AddRange(listStopBits);
            comboBox_StopBits.SelectedIndex = 0;

            string[] listCheckBits = new string[]
            {
                "None"
            };
            comboBox_CheckBits.Items.AddRange(listCheckBits);
            comboBox_CheckBits.SelectedIndex = 0;
            pictureBox_Status.BackColor = Color.Red;

            ComDevice.ReceivedBytesThreshold = 1;

            //向ComDevice.DataReceived（是一个事件）注册一个方法Com_DataReceived，当端口类接收到信息时时会自动调用Com_DataReceived方法
            ComDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
        }


        private StringBuilder builder = new StringBuilder();

        /// <summary>
        /// 一旦ComDevice.DataReceived事件发生，就将从串口接收到的数据显示到接收端对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(50);
            builder.Clear();//清除字符串构造器的内容
            string str = "";
            int n = ComDevice.BytesToRead;//先记录下来，避免丢失
                                          //label3.Text = n.ToString();

            byte[] buf = new byte[n];
            ComDevice.Read(buf, 0, n);//读取缓冲区数据

            this.Invoke((EventHandler)(delegate
            {

                foreach (byte b in buf)
                {
                    builder.Append(b.ToString("X2") + " ");
                }

                //DataUnpack(buf, buf.Length);

                ////追加文本
                //this.textBox1_ReciMes.AppendText(builder.ToString());
                ////create a new thread
                ////;
                // 创建线程时使用 DataParams 包装 buf 和 buf.Length
                DataParams dataParams = new DataParams { Buffer = buf, Length = buf.Length };
                Thread unpack_task = new Thread(new ParameterizedThreadStart(Options));
                unpack_task.Start(dataParams);
            }));


        }

        private void UpdateUI(float power, float energy, float voltage, float current)
        {
            if (textBox_power1.InvokeRequired)
            {
                textBox_power1.Invoke(new Action(() => UpdateUI(power, energy, voltage, current)));
            }
            else
            {
                textBox_power1.Clear(); // 清空旧数据
                textBox_voltage1.Clear(); // 清空旧数据
                textBox_voltage1.Clear(); // 清空旧数据
                textBox_current1.Clear(); // 清空旧数据

                textBox_power1.AppendText(power.ToString());
                textBox_energy1.AppendText(energy.ToString());
                textBox_voltage1.AppendText(voltage.ToString());
                textBox_current1.AppendText(current.ToString());
            }
        }

        public byte[] DataPack(byte cmd, int device_ID, byte device_type, int messagID, byte[] data, int dat_len)
        {
            byte[] data_sendt = new byte[200]; // 数据发送缓冲区
            int len = 0; // 长度

            len = dat_len + 9;//帧长度 = 数据长度 + 9
            ushort datsum = 0;//累加和

            data_sendt[0] = 0x44;
            data_sendt[1] = 0x4e;
            data_sendt[2] = 0x59;

            data_sendt[3] = (byte)(len & 0xff);
            data_sendt[4] = (byte)(len >> 8);

            data_sendt[5] = (byte)(device_ID & 0xff);
            data_sendt[6] = (byte)(device_ID >> 8);
            data_sendt[7] = (byte)(device_ID >> 16);
            data_sendt[8] = device_type;

            data_sendt[9] = (byte)(messagID & 0xff);
            data_sendt[10] = (byte)(messagID >> 8);

            data_sendt[11] = cmd;

            Array.Copy(data, 0, data_sendt, 12, dat_len);

            datsum = Checksum16(data_sendt, len + 3);//校验长度 = len + 3字节帧头头

            data_sendt[dat_len + 12] = (byte)(datsum & 0xff);
            data_sendt[dat_len + 13] = (byte)(datsum >> 8);

            MySendData(data_sendt, len + 5);//总数据长度 = len + 3字节帧头头 + 2字节长度

            return data_sendt; // 返回数据包
        }

        public class DataParams
        {
            public byte[] Buffer { get; set; }
            public int Length { get; set; }
        }

        private void Options(object obj)
        {
            DataParams dataParams = (DataParams)obj; // 转换为 DataParams 类型
            DataUnpack(dataParams.Buffer, dataParams.Length); // 调用 DataUnpack 方法
        }

        //public void DataUnpack(byte[] data, int dat_len)
        //{
        //    if (data[0] == 0x41 && data[1] == 0x54 && data[2] == 0x2b && data[3] == 0x43 && data[4] == 0x49 && data[5] == 0x50 && data[6] == 0x4f && data[7] == 0x50)
        //    {
        //        string command = "AT+CIPOPEN=1,\"TCP\",\"211.151.2.247\",60010\r\n";
        //        byte[] data_ip = System.Text.Encoding.ASCII.GetBytes(command);
        //        MySendData(data_ip, data_ip.Length);
        //        Console.WriteLine(System.Text.Encoding.ASCII.GetString(data_ip));
        //    }
        //    else 
        //        MySendData(data, dat_len);

        //    Console.WriteLine(System.Text.Encoding.ASCII.GetString(data));
        //}
        public void DataUnpack(byte[] data, int dat_len)
        {
            ushort len = 0; // 长度
            byte[] dataID = new byte[4]; // ID
            ushort messagID = 0; // 消息ID
                                 //int device_ID = 0;//设备ID
            ushort device_type = 0; // 设备类型
            ushort datsum = 0;//累加和
            byte cmd = 0;//命令
            byte[] data_get = new byte[50]; // ID

            Console.WriteLine("长度：" + dat_len);
            if (data[0] == 0x44 && data[1] == 0x4e && data[2] == 0x59)//检查帧头是否正确
            {
                len = (ushort)((data[4] << 8) | data[3]);//获取帧数据长度
                datsum = (ushort)((data[len + 4] << 8) | data[len + 3]);//获取帧校验

                Console.WriteLine("长度：" + len);
                Console.WriteLine("校验：" + datsum);

                if (datsum == Checksum16(data, dat_len - 2))
                {
                    Console.WriteLine("解析成功");

                    device_ID = (int)((data[7] << 16) | (data[6] << 8) | data[5]);
                    device_type = data[8];
                    messagID = (ushort)((data[4] << 8) | data[3]);
                    cmd = data[11];

                    Console.WriteLine("设备编号：" + device_ID);
                    Console.WriteLine("设备类型：" + device_type);
                    Console.WriteLine("消息ID：" + messagID);

                    Show_ID(device_ID.ToString());//显示ID

                    Array.Copy(data, 12, data_get, 0, len - 9);
                    // data_get
                    cmdUnpack((PackageType)cmd, data_get, len - 9);


                }
                else
                {

                    Console.WriteLine("累加校验错误");
                }
            }
            else
            {
                Console.WriteLine("解析错误");
            }
        }

        public void cmdUnpack(PackageType command, byte[] data, int dat_len)
        {
            int firmware_version = 0;
            float com_voltage = 0;
            byte com_num = 0;
            byte type_d = 0;
            byte temp = 0;

            int power = 0;//功率
            int energy = 0;//电能
            int voltage = 0;//电压
            int current = 0;//电流
            byte com_temp = 0;//端口温度



            Console.WriteLine("命令：" + command);

            Console.WriteLine("数据长度：" + dat_len);

            switch (command)
            {
                case PackageType.CMD_HEARTBEAT:
                    com_voltage = (ushort)((data[1] << 8) | data[0]);
                    com_num = data[2];
                    temp = data[3];
                    Console.WriteLine("心跳......................................." + "电压：" + com_voltage / 10 + "端口：" + com_num + "温度：" + temp);
                    break;

                case PackageType.CMD_REGISTER:
                    firmware_version = (ushort)((data[1] << 8) | data[0]);
                    com_num = data[2];
                    type_d = data[4];
                    Console.WriteLine("......................................固件版本：V" + dat_len + com_num + type_d);
                    break;

                case PackageType.CMD_DEV_SET_ID:
                    Console.WriteLine("设置ID");
                    break;

                case PackageType.CMD_DEV_LOCK:
                    if (data[0] == 0)
                    {
                        Console.WriteLine("解锁flash");
                        unlock_flag = 0;
                    }
                    else
                    {
                        Console.WriteLine("上锁flash");
                        unlock_flag = 1;
                    }
                    break;

                case PackageType.CMD_CHARGE_DATA:
                    Console.WriteLine("充电心跳包");
                    if (0 == data[0])
                    {
                        energy = (ushort)((data[5] << 8) | data[4]);
                        power = (ushort)((data[8] << 8) | data[7]);
                        voltage = (ushort)((data[34] << 8) | data[35]);
                        current = (ushort)((data[38] << 8) | data[37]);
                        temp = data[39];
                        com_temp = data[40];
                        Console.WriteLine("voltage：" + voltage + "  current：" + current + "  power：" + power + "  energy：" + energy);
                        // textBox_power1.Clear(); // 清空旧数据

                        // 更新UI
                        UpdateUI((float)power / 10, (float)energy / 10, (float)voltage / 10, (float)current / 10);
                    }
                    break;
      
                default:
                    break;
            }
        }

        private ushort Checksum16(byte[] data, int length)
        {
            ushort sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += data[i];
            }

            return sum;
        }
        /// <summary>
        /// 解码过程
        /// </summary>
        /// <param name="data">串口通信的数据编码方式因串口而异，需要查询串口相关信息以获取</param>
        public void AddData(byte[] data)
        {
            if (radioButton_Hex.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                AddContent(sb.ToString().ToUpper());
            }
            else if (radioButton_ASCII.Checked)
            {
                AddContent(new ASCIIEncoding().GetString(data));
            }
            else if (radioButton_UTF8.Checked)
            {
                AddContent(new UTF8Encoding().GetString(data));
            }
            else if (radioButton_Unicode.Checked)
            {
                AddContent(new UnicodeEncoding().GetString(data));
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                AddContent(sb.ToString().ToUpper());
            }
        }

        /// <summary>
        /// 接收端对话框显示消息
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                textBox_Receive.AppendText(content);
            }));
        }
        /// <summary>
        /// 显示设备ID
        /// </summary>
        /// <param name="content"></param>
        private void Show_ID(string content)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                textBox_ID.Clear(); // 清空旧数据
                textBox_ID.AppendText(content);
            }));
        }

        //接收数据
        public class DataReceiver
        {
            private static int step = 0; // 状态变量
            private static int cnt = 0; // 计数器
            private static byte[] Buf = new byte[300]; // 数据缓存
            private static ushort len; // 数据长度
            private static byte cmd; // 命令字
            private static byte[] dataPtr; // 数据指针
            private static ushort crc16; // CRC16 校验值
            private static byte[] dataID = new byte[4]; // ID
            private static ushort messagID = 0; // 消息ID

            public void Receive(byte bytedata)
            {
                // 状态机进行数据解析
                switch (step)
                {
                    case 0: // 接收帧头44状态
                        if (bytedata == 0x44)
                        {
                            step++;
                            cnt = 0;
                            Buf[cnt++] = bytedata;
                        }
                        break;

                    case 1: // 接收帧头4e状态
                        if (bytedata == 0x4e)
                        {
                            step++;
                            Buf[cnt++] = bytedata;
                        }
                        break;
                    case 2: // 接收帧头59状态
                        if (bytedata == 0x59)
                        {
                            step++;
                            Buf[cnt++] = bytedata;
                        }
                        else if (bytedata == 0x44)
                        {
                            step = 1; // 重复帧头1
                        }
                        else
                        {
                            step = 0; // 重置状态
                        }
                        break;
                    case 3: // 接收数据长度字节状态

                        Buf[cnt++] = bytedata;
                        if (cnt >= 4)
                        {
                            len = (ushort)((Buf[4] << 8) | Buf[3]); // 修正为位移组合
                            step++;
                        }
                        else step = 3;
                        break;

                    case 4: //  接收物理ID

                        Buf[cnt++] = bytedata;
                        if (cnt >= 9)
                        {
                            Array.Copy(Buf, 5, dataID, 0, 4); // 拷贝数据到指针
                            step++;
                        }
                        else step = 4;
                        break;

                    case 5: // 消息ID

                        Buf[cnt++] = bytedata;
                        if (cnt >= 11)
                        {
                            messagID = (ushort)((Buf[11] << 8) | Buf[10]);
                            step++;
                        }
                        else step = 5;
                        break;

                    case 6: // 接收 命令
                        step++;
                        Buf[cnt++] = bytedata;
                        cmd = bytedata;
                        dataPtr = new byte[len]; // 为数据分配数组
                        Array.Copy(Buf, cnt, dataPtr, 0, cnt); // 拷贝数据到指针
                        if (len == 9) step++; // 数据长度为0则跳过接收状态
                        break;

                    case 7: // 接收 len 字节数据状态
                        Buf[cnt++] = bytedata;
                        if ((cnt - 10) == (len - 9)) // 根据长度判断数据是否接收完
                        {
                            step++;
                        }
                        break;

                    case 8: // 接收 累加 低字节
                        step++;
                        crc16 = bytedata;
                        crc16 <<= 8;
                        break;

                    case 9: // 接收 累加 高字节          
                        crc16 += bytedata;
                        if (crc16 == Checksum(Buf, cnt)) // 校验正确
                        {
                            Data_Analysis(cmd, dataPtr, len); // 数据解析
                            step = 0; // 重置状态
                        }
                        else if (bytedata == 0xA5)
                        {
                            step = 1; // 重复帧头1
                        }
                        else
                        {
                            step = 0; // 重置状态
                        }
                        break;

                    default:
                        step = 0; // 不可达状态
                        break;
                }
            }

            private ushort Checksum(byte[] data, int length)
            {
                ushort sum = 0;

                for (int i = 0; i < length; i++)
                {
                    sum += data[i];
                }

                return sum;
            }

            private void Data_Analysis(byte command, byte[] data, ushort length)
            {
                // 实现数据分析逻辑
            }
        }


        /// <summary>
        /// 串口开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Switch_Click(object sender, EventArgs e)
        {
            if (comboBox_Port.Items.Count <= 0)
            {
                MessageBox.Show("未发现可用串口，请检查硬件设备");
                return;
            }

            if (ComDevice.IsOpen == false)
            {
                //设置串口相关属性
                ComDevice.PortName = comboBox_Port.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(comboBox_BaudRate.SelectedItem.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(comboBox_CheckBits.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(comboBox_DataBits.SelectedItem.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(comboBox_StopBits.SelectedItem.ToString());
                try
                {
                    //开启串口
                    ComDevice.Open();
                    button_Set_ID.Enabled = true;
                    button_get_ID.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "未能成功开启串口", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                button_Switch.Text = "关闭";
                pictureBox_Status.BackColor = Color.Green;
            }
            else
            {
                try
                {
                    //关闭串口
                    ComDevice.Close();
                    button_Set_ID.Enabled = false;
                    button_get_ID.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "串口关闭错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                button_Switch.Text = "开启";
                pictureBox_Status.BackColor = Color.Red;
            }

            comboBox_Port.Enabled = !ComDevice.IsOpen;
            comboBox_BaudRate.Enabled = !ComDevice.IsOpen;
            comboBox_DataBits.Enabled = !ComDevice.IsOpen;
            comboBox_StopBits.Enabled = !ComDevice.IsOpen;
            comboBox_CheckBits.Enabled = !ComDevice.IsOpen;
        }


        /// <summary>
        /// 将消息编码并发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Receive.Text.Length > 0)
            {
                textBox_Receive.AppendText("\n");
            }

            byte[] sendData = null;

            if (radioButton_Hex.Checked)
            {
                sendData = strToHexByte(textBox_Send.Text.Trim());
            }
            else if (radioButton_ASCII.Checked)
            {
                sendData = Encoding.ASCII.GetBytes(textBox_Send.Text.Trim());
            }
            else if (radioButton_UTF8.Checked)
            {
                sendData = Encoding.UTF8.GetBytes(textBox_Send.Text.Trim());
            }
            else if (radioButton_Unicode.Checked)
            {
                sendData = Encoding.Unicode.GetBytes(textBox_Send.Text.Trim());
            }
            else
            {
                sendData = strToHexByte(textBox_Send.Text.Trim());
            }

            SendData(sendData);
        }

        /// <summary>
        /// 此函数将编码后的消息传递给串口
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    //将消息传递给串口
                    ComDevice.Write(data, 0, data.Length);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool MySendData(byte[] data, int len)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    //将消息传递给串口
                    ComDevice.Write(data, 0, len);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// 16进制编码
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }


        private void button_Send_Click_1(object sender, EventArgs e)
        {
            byte[] data_buff = new byte[4];
            string textValue = textBox_ID_set.Text; // 获取 TextBox 的文本值
            int device_ID_set = 0;



            data_buff[0] = 0;
            DataPack((byte)PackageType.CMD_DEV_LOCK, device_ID, 4, 0, data_buff, 1);

            if (int.TryParse(textValue, out device_ID_set))
            {
                // 转换成功，number 现在是 int 类型
                Console.WriteLine("转换成功: " + device_ID_set);
                if (unlock_flag == 0)
                {
                    Console.WriteLine("设置id" + device_ID_set);
                    DataPack((byte)PackageType.CMD_DEV_SET_ID, device_ID_set, 4, 0, data_buff, 1);
                    pictureBox_IDset.BackColor = Color.Green;
                    label_id_flag.Text = "烧录成功";
                    label_id_flag.ForeColor = Color.Green;
                }
                else
                {
                    Console.WriteLine("flash未解锁");
                    pictureBox_IDset.BackColor = Color.Red;
                    label_id_flag.Text = "烧录失败";
                    label_id_flag.ForeColor = Color.Red;
                }
            }
            else
            {
                // 转换失败，处理错误
                Console.WriteLine("无效的整数输入");
                label_id_flag.Text = "ID无效";
                //label_id_flag.Text = "烧录失败";
                label_id_flag.ForeColor = Color.Red; // 将 Label 文字颜色设置为蓝色
                pictureBox_IDset.BackColor = Color.Red;
            }

        }

        private void textBox_ID_set_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 检查输入是否为数字或控制字符（如退格）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 取消输入
            }
        }

        private void button_get_ID_Click(object sender, EventArgs e)
        {
            byte[] data_buff = new byte[4];
            data_buff[0] = 0x00;
            data_buff[1] = 0x01;
            DataPack((byte)PackageType.CMD_ROLL, 0, 0, 01, data_buff, 2);

        }
        public byte[] CommandToByteArray(ONOFF_COMD_TYPE command)
        {
            byte[] data = new byte[sizeof(byte) + sizeof(byte) + 4 + sizeof(byte) + sizeof(byte) + 2 + 16 + 2 + 2 + sizeof(byte) + sizeof(byte) + 2 + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte)];

            int index = 0;

            //data[index++] = command.u8Cmd;
            data[index++] = command.u8ChargeRate;
            Array.Copy(command.u8Balance, 0, data, index, command.u8Balance.Length);
            index += command.u8Balance.Length;

            data[index++] = command.u8ChargePort;
            data[index++] = command.u8ChargeCmd;
            Array.Copy(command.u8TimeOrQuantity, 0, data, index, command.u8TimeOrQuantity.Length);
            index += command.u8TimeOrQuantity.Length;

            Array.Copy(command.u8OrderNo, 0, data, index, command.u8OrderNo.Length);
            index += command.u8OrderNo.Length;

            Array.Copy(command.u8MaxChargeTime, 0, data, index, command.u8MaxChargeTime.Length);
            index += command.u8MaxChargeTime.Length;

            Array.Copy(command.u8MaxPower, 0, data, index, command.u8MaxPower.Length);
            index += command.u8MaxPower.Length;

            data[index++] = command.u8LedStatus;
            data[index++] = command.u8ChargeMod;
            Array.Copy(command.u8FloatingTime, 0, data, index, command.u8FloatingTime.Length);
            index += command.u8FloatingTime.Length;

            data[index++] = command.u8IgnoreCheckShort;
            data[index++] = command.u8Ignoreextract;
            data[index++] = command.u8MustCheckFull;
            data[index++] = command.u8FullPower;
            data[index++] = command.u8CheckFullMaxTime;

            return data;
        }

        // 声明为全局变量
        private static ONOFF_COMD_TYPE command = new ONOFF_COMD_TYPE
        {
            // u8Cmd = 1, // (如果需要使用的话，取消注释)
            u8ChargeRate = 0,
            u8Balance = new byte[] { 0x3f, 0x02, 0x00, 0x00 },
            u8ChargePort = 0,
            u8ChargeCmd = 1,
            u8TimeOrQuantity = new byte[] { 0x20, 0x1c },
            u8OrderNo = new byte[16]
            {
            0x71, 0x97, 0x98, 0x26, 0x67, 0x19, 0x15, 0x42,
            0x22, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            },
            u8MaxChargeTime = new byte[] { 0, 0 },
            u8MaxPower = new byte[] { 0, 0 },
            u8LedStatus = 0,
            u8ChargeMod = 0,
            u8FloatingTime = new byte[] { 0, 0 },
            u8IgnoreCheckShort = 2, // 2=正常检测短路
            u8Ignoreextract = 0,
            u8MustCheckFull = 0,
            u8FullPower = 0,
            u8CheckFullMaxTime = 0
        };

        private void button_start_com1_Click(object sender, EventArgs e)
        {

            // 切换按钮状态
            CorrectIsToggled_1 = !CorrectIsToggled_1;

            if (CorrectIsToggled_1)
            {
                command.u8ChargePort = 0;
                command.u8ChargeCmd = 1;
                button_start_com1.Text = "开始充电";
                button_start_com1.BackColor = Color.LightGray;
            }
            else
            {
                command.u8ChargePort = 0;
                command.u8ChargeCmd = 0;
                button_start_com1.Text = "结束充电";
                button_start_com1.BackColor = Color.LightGreen;
            }
            byte[] commandData = CommandToByteArray(command);

            DataPack((byte)PackageType.CMD_ON_OFF_CHARGE, device_ID, 4, 0, commandData, 38);

        }

        private void button_start_com2_Click(object sender, EventArgs e)
        {
            // 切换按钮状态
            CorrectIsToggled_2 = !CorrectIsToggled_2;

            if (CorrectIsToggled_2)
            {
                command.u8ChargePort = 1;
                command.u8ChargeCmd = 1;
                button_start_com2.Text = "开始充电";
                button_start_com2.BackColor = Color.LightGray;
            }
            else
            {
                command.u8ChargePort = 1;
                command.u8ChargeCmd = 0;
                button_start_com2.Text = "结束充电";
                button_start_com2.BackColor = Color.LightGreen;
            }
            byte[] commandData = CommandToByteArray(command);

            DataPack((byte)PackageType.CMD_ON_OFF_CHARGE, device_ID, 4, 0, commandData, 38);
        }
    }

    public class Info
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
