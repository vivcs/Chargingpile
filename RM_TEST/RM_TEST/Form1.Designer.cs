
namespace SerialPortForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_CheckBits = new System.Windows.Forms.ComboBox();
            this.button_Set_ID = new System.Windows.Forms.Button();
            this.radioButton_Hex = new System.Windows.Forms.RadioButton();
            this.radioButton_ASCII = new System.Windows.Forms.RadioButton();
            this.radioButton_UTF8 = new System.Windows.Forms.RadioButton();
            this.radioButton_Unicode = new System.Windows.Forms.RadioButton();
            this.pictureBox_Status = new System.Windows.Forms.PictureBox();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            this.button_Switch = new System.Windows.Forms.Button();
            this.button_On = new System.Windows.Forms.Button();
            this.button_Off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_start_com2 = new System.Windows.Forms.Button();
            this.button_start_com1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_current2 = new System.Windows.Forms.TextBox();
            this.textBox_voltage2 = new System.Windows.Forms.TextBox();
            this.textBox_energy2 = new System.Windows.Forms.TextBox();
            this.textBox_power2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_current1 = new System.Windows.Forms.TextBox();
            this.textBox_voltage1 = new System.Windows.Forms.TextBox();
            this.textBox_energy1 = new System.Windows.Forms.TextBox();
            this.textBox_power1 = new System.Windows.Forms.TextBox();
            this.label_id_flag = new System.Windows.Forms.Label();
            this.textBox_ID_set = new System.Windows.Forms.TextBox();
            this.pictureBox_IDset = new System.Windows.Forms.PictureBox();
            this.button_get_ID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IDset)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(82, 25);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(160, 23);
            this.comboBox_Port.TabIndex = 0;
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(356, 25);
            this.comboBox_BaudRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(160, 23);
            this.comboBox_BaudRate.TabIndex = 1;
            this.comboBox_BaudRate.Text = "115200";
            // 
            // comboBox_DataBits
            // 
            this.comboBox_DataBits.FormattingEnabled = true;
            this.comboBox_DataBits.Location = new System.Drawing.Point(611, 25);
            this.comboBox_DataBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_DataBits.Name = "comboBox_DataBits";
            this.comboBox_DataBits.Size = new System.Drawing.Size(160, 23);
            this.comboBox_DataBits.TabIndex = 2;
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Location = new System.Drawing.Point(82, 68);
            this.comboBox_StopBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(160, 23);
            this.comboBox_StopBits.TabIndex = 3;
            // 
            // comboBox_CheckBits
            // 
            this.comboBox_CheckBits.FormattingEnabled = true;
            this.comboBox_CheckBits.Location = new System.Drawing.Point(356, 68);
            this.comboBox_CheckBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_CheckBits.Name = "comboBox_CheckBits";
            this.comboBox_CheckBits.Size = new System.Drawing.Size(160, 23);
            this.comboBox_CheckBits.TabIndex = 4;
            // 
            // button_Set_ID
            // 
            this.button_Set_ID.Location = new System.Drawing.Point(329, 161);
            this.button_Set_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Set_ID.Name = "button_Set_ID";
            this.button_Set_ID.Size = new System.Drawing.Size(100, 80);
            this.button_Set_ID.TabIndex = 5;
            this.button_Set_ID.Text = "烧写编号";
            this.button_Set_ID.UseVisualStyleBackColor = true;
            this.button_Set_ID.Click += new System.EventHandler(this.button_Send_Click_1);
            // 
            // radioButton_Hex
            // 
            this.radioButton_Hex.AutoSize = true;
            this.radioButton_Hex.Location = new System.Drawing.Point(82, 25);
            this.radioButton_Hex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_Hex.Name = "radioButton_Hex";
            this.radioButton_Hex.Size = new System.Drawing.Size(74, 19);
            this.radioButton_Hex.TabIndex = 6;
            this.radioButton_Hex.Text = "16进制";
            this.radioButton_Hex.UseVisualStyleBackColor = true;
            // 
            // radioButton_ASCII
            // 
            this.radioButton_ASCII.AutoSize = true;
            this.radioButton_ASCII.Location = new System.Drawing.Point(254, 25);
            this.radioButton_ASCII.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_ASCII.Name = "radioButton_ASCII";
            this.radioButton_ASCII.Size = new System.Drawing.Size(68, 19);
            this.radioButton_ASCII.TabIndex = 7;
            this.radioButton_ASCII.Text = "ASCII";
            this.radioButton_ASCII.UseVisualStyleBackColor = true;
            // 
            // radioButton_UTF8
            // 
            this.radioButton_UTF8.AutoSize = true;
            this.radioButton_UTF8.Checked = true;
            this.radioButton_UTF8.Location = new System.Drawing.Point(420, 25);
            this.radioButton_UTF8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_UTF8.Name = "radioButton_UTF8";
            this.radioButton_UTF8.Size = new System.Drawing.Size(68, 19);
            this.radioButton_UTF8.TabIndex = 8;
            this.radioButton_UTF8.TabStop = true;
            this.radioButton_UTF8.Text = "UTF-8";
            this.radioButton_UTF8.UseVisualStyleBackColor = true;
            // 
            // radioButton_Unicode
            // 
            this.radioButton_Unicode.AutoSize = true;
            this.radioButton_Unicode.Location = new System.Drawing.Point(585, 25);
            this.radioButton_Unicode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_Unicode.Name = "radioButton_Unicode";
            this.radioButton_Unicode.Size = new System.Drawing.Size(84, 19);
            this.radioButton_Unicode.TabIndex = 9;
            this.radioButton_Unicode.Text = "Unicode";
            this.radioButton_Unicode.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Status
            // 
            this.pictureBox_Status.Location = new System.Drawing.Point(733, 62);
            this.pictureBox_Status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_Status.Name = "pictureBox_Status";
            this.pictureBox_Status.Size = new System.Drawing.Size(39, 37);
            this.pictureBox_Status.TabIndex = 11;
            this.pictureBox_Status.TabStop = false;
            // 
            // textBox_Receive
            // 
            this.textBox_Receive.Location = new System.Drawing.Point(21, 22);
            this.textBox_Receive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Receive.Multiline = true;
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.Size = new System.Drawing.Size(368, 116);
            this.textBox_Receive.TabIndex = 12;
            // 
            // button_Switch
            // 
            this.button_Switch.Location = new System.Drawing.Point(611, 67);
            this.button_Switch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Switch.Name = "button_Switch";
            this.button_Switch.Size = new System.Drawing.Size(100, 28);
            this.button_Switch.TabIndex = 14;
            this.button_Switch.Text = "开启";
            this.button_Switch.UseVisualStyleBackColor = true;
            // 
            // button_On
            // 
            this.button_On.Location = new System.Drawing.Point(35, 538);
            this.button_On.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_On.Name = "button_On";
            this.button_On.Size = new System.Drawing.Size(100, 28);
            this.button_On.TabIndex = 15;
            this.button_On.Text = "继电器开";
            this.button_On.UseVisualStyleBackColor = true;
            // 
            // button_Off
            // 
            this.button_Off.Location = new System.Drawing.Point(167, 538);
            this.button_Off.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Off.Name = "button_Off";
            this.button_Off.Size = new System.Drawing.Size(100, 28);
            this.button_Off.TabIndex = 16;
            this.button_Off.Text = "继电器关";
            this.button_Off.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "波特率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "校验方式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "数据位";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_UTF8);
            this.groupBox1.Controls.Add(this.radioButton_Hex);
            this.groupBox1.Controls.Add(this.radioButton_ASCII);
            this.groupBox1.Controls.Add(this.radioButton_Unicode);
            this.groupBox1.Location = new System.Drawing.Point(24, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(805, 65);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编码方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Port);
            this.groupBox2.Controls.Add(this.comboBox_BaudRate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_DataBits);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_StopBits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_CheckBits);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox_Status);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_Switch);
            this.groupBox2.Location = new System.Drawing.Point(24, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(805, 108);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "端口属性设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Receive);
            this.groupBox3.Location = new System.Drawing.Point(24, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(401, 148);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收端";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_Send);
            this.groupBox4.Location = new System.Drawing.Point(24, 358);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(401, 148);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送端";
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(21, 22);
            this.textBox_Send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Send.Multiline = true;
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(368, 116);
            this.textBox_Send.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "获取设备ID";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ID.ForeColor = System.Drawing.Color.Red;
            this.textBox_ID.Location = new System.Drawing.Point(21, 53);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(272, 81);
            this.textBox_ID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "当前设备编号";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_start_com2);
            this.groupBox5.Controls.Add(this.button_start_com1);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox_current2);
            this.groupBox5.Controls.Add(this.textBox_voltage2);
            this.groupBox5.Controls.Add(this.textBox_energy2);
            this.groupBox5.Controls.Add(this.textBox_power2);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox_current1);
            this.groupBox5.Controls.Add(this.textBox_voltage1);
            this.groupBox5.Controls.Add(this.textBox_energy1);
            this.groupBox5.Controls.Add(this.textBox_power1);
            this.groupBox5.Controls.Add(this.label_id_flag);
            this.groupBox5.Controls.Add(this.textBox_ID_set);
            this.groupBox5.Controls.Add(this.pictureBox_IDset);
            this.groupBox5.Controls.Add(this.button_Set_ID);
            this.groupBox5.Controls.Add(this.textBox_ID);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.button_get_ID);
            this.groupBox5.Location = new System.Drawing.Point(24, 117);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(805, 457);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // button_start_com2
            // 
            this.button_start_com2.Location = new System.Drawing.Point(654, 350);
            this.button_start_com2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_start_com2.Name = "button_start_com2";
            this.button_start_com2.Size = new System.Drawing.Size(100, 44);
            this.button_start_com2.TabIndex = 42;
            this.button_start_com2.Text = "计量采集";
            this.button_start_com2.UseVisualStyleBackColor = true;
            this.button_start_com2.Click += new System.EventHandler(this.button_start_com2_Click);
            // 
            // button_start_com1
            // 
            this.button_start_com1.Location = new System.Drawing.Point(654, 295);
            this.button_start_com1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_start_com1.Name = "button_start_com1";
            this.button_start_com1.Size = new System.Drawing.Size(100, 44);
            this.button_start_com1.TabIndex = 41;
            this.button_start_com1.Text = "计量采集";
            this.button_start_com1.UseVisualStyleBackColor = true;
            this.button_start_com1.Click += new System.EventHandler(this.button_start_com1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(7, 360);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "②";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(8, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "①";
            // 
            // textBox_current2
            // 
            this.textBox_current2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_current2.ForeColor = System.Drawing.Color.Red;
            this.textBox_current2.Location = new System.Drawing.Point(479, 354);
            this.textBox_current2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_current2.Multiline = true;
            this.textBox_current2.Name = "textBox_current2";
            this.textBox_current2.Size = new System.Drawing.Size(145, 41);
            this.textBox_current2.TabIndex = 38;
            // 
            // textBox_voltage2
            // 
            this.textBox_voltage2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_voltage2.ForeColor = System.Drawing.Color.Red;
            this.textBox_voltage2.Location = new System.Drawing.Point(324, 353);
            this.textBox_voltage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_voltage2.Multiline = true;
            this.textBox_voltage2.Name = "textBox_voltage2";
            this.textBox_voltage2.Size = new System.Drawing.Size(154, 41);
            this.textBox_voltage2.TabIndex = 37;
            // 
            // textBox_energy2
            // 
            this.textBox_energy2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_energy2.ForeColor = System.Drawing.Color.Red;
            this.textBox_energy2.Location = new System.Drawing.Point(192, 353);
            this.textBox_energy2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_energy2.Multiline = true;
            this.textBox_energy2.Name = "textBox_energy2";
            this.textBox_energy2.Size = new System.Drawing.Size(131, 41);
            this.textBox_energy2.TabIndex = 36;
            // 
            // textBox_power2
            // 
            this.textBox_power2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_power2.ForeColor = System.Drawing.Color.Red;
            this.textBox_power2.Location = new System.Drawing.Point(52, 353);
            this.textBox_power2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_power2.Multiline = true;
            this.textBox_power2.Name = "textBox_power2";
            this.textBox_power2.Size = new System.Drawing.Size(137, 41);
            this.textBox_power2.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(458, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "电流(A)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(320, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "电压(V)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(193, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "电能(度)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(81, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "功率(W)";
            // 
            // textBox_current1
            // 
            this.textBox_current1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_current1.ForeColor = System.Drawing.Color.Red;
            this.textBox_current1.Location = new System.Drawing.Point(479, 298);
            this.textBox_current1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_current1.Multiline = true;
            this.textBox_current1.Name = "textBox_current1";
            this.textBox_current1.Size = new System.Drawing.Size(145, 41);
            this.textBox_current1.TabIndex = 30;
            // 
            // textBox_voltage1
            // 
            this.textBox_voltage1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_voltage1.ForeColor = System.Drawing.Color.Red;
            this.textBox_voltage1.Location = new System.Drawing.Point(324, 297);
            this.textBox_voltage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_voltage1.Multiline = true;
            this.textBox_voltage1.Name = "textBox_voltage1";
            this.textBox_voltage1.Size = new System.Drawing.Size(154, 41);
            this.textBox_voltage1.TabIndex = 29;
            // 
            // textBox_energy1
            // 
            this.textBox_energy1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_energy1.ForeColor = System.Drawing.Color.Red;
            this.textBox_energy1.Location = new System.Drawing.Point(192, 297);
            this.textBox_energy1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_energy1.Multiline = true;
            this.textBox_energy1.Name = "textBox_energy1";
            this.textBox_energy1.Size = new System.Drawing.Size(131, 41);
            this.textBox_energy1.TabIndex = 28;
            // 
            // textBox_power1
            // 
            this.textBox_power1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_power1.ForeColor = System.Drawing.Color.Red;
            this.textBox_power1.Location = new System.Drawing.Point(52, 297);
            this.textBox_power1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_power1.Multiline = true;
            this.textBox_power1.Name = "textBox_power1";
            this.textBox_power1.Size = new System.Drawing.Size(137, 41);
            this.textBox_power1.TabIndex = 27;
            // 
            // label_id_flag
            // 
            this.label_id_flag.AutoSize = true;
            this.label_id_flag.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id_flag.ForeColor = System.Drawing.Color.Black;
            this.label_id_flag.Location = new System.Drawing.Point(456, 178);
            this.label_id_flag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_flag.Name = "label_id_flag";
            this.label_id_flag.Size = new System.Drawing.Size(151, 44);
            this.label_id_flag.TabIndex = 26;
            this.label_id_flag.Text = "烧录ID";
            // 
            // textBox_ID_set
            // 
            this.textBox_ID_set.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ID_set.ForeColor = System.Drawing.Color.Red;
            this.textBox_ID_set.Location = new System.Drawing.Point(21, 161);
            this.textBox_ID_set.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_ID_set.MaxLength = 8;
            this.textBox_ID_set.Multiline = true;
            this.textBox_ID_set.Name = "textBox_ID_set";
            this.textBox_ID_set.Size = new System.Drawing.Size(272, 81);
            this.textBox_ID_set.TabIndex = 25;
            this.textBox_ID_set.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_set_KeyPress);
            // 
            // pictureBox_IDset
            // 
            this.pictureBox_IDset.Location = new System.Drawing.Point(683, 161);
            this.pictureBox_IDset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_IDset.Name = "pictureBox_IDset";
            this.pictureBox_IDset.Size = new System.Drawing.Size(88, 80);
            this.pictureBox_IDset.TabIndex = 23;
            this.pictureBox_IDset.TabStop = false;
            // 
            // button_get_ID
            // 
            this.button_get_ID.Location = new System.Drawing.Point(329, 50);
            this.button_get_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_get_ID.Name = "button_get_ID";
            this.button_get_ID.Size = new System.Drawing.Size(100, 80);
            this.button_get_ID.TabIndex = 24;
            this.button_get_ID.Text = "获取设备ID";
            this.button_get_ID.UseVisualStyleBackColor = true;
            this.button_get_ID.Click += new System.EventHandler(this.button_get_ID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 602);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Off);
            this.Controls.Add(this.button_On);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "串口控制";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IDset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_DataBits;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.ComboBox comboBox_CheckBits;
        private System.Windows.Forms.Button button_Set_ID;
        private System.Windows.Forms.RadioButton radioButton_Hex;
        private System.Windows.Forms.RadioButton radioButton_ASCII;
        private System.Windows.Forms.RadioButton radioButton_UTF8;
        private System.Windows.Forms.RadioButton radioButton_Unicode;
        private System.Windows.Forms.PictureBox pictureBox_Status;
        private System.Windows.Forms.TextBox textBox_Receive;
        private System.Windows.Forms.Button button_Switch;
        private System.Windows.Forms.Button button_On;
        private System.Windows.Forms.Button button_Off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox_IDset;
        private System.Windows.Forms.Button button_get_ID;
        private System.Windows.Forms.TextBox textBox_ID_set;
        private System.Windows.Forms.Label label_id_flag;
        private System.Windows.Forms.TextBox textBox_current1;
        private System.Windows.Forms.TextBox textBox_voltage1;
        private System.Windows.Forms.TextBox textBox_energy1;
        private System.Windows.Forms.TextBox textBox_power1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_current2;
        private System.Windows.Forms.TextBox textBox_voltage2;
        private System.Windows.Forms.TextBox textBox_energy2;
        private System.Windows.Forms.TextBox textBox_power2;
        private System.Windows.Forms.Button button_start_com1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_start_com2;
    }
}

