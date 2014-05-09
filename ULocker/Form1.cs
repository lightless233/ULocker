using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Threading;
using System.Security.Cryptography;
using System.Net;

namespace ULocker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Thread threadInitApp = new Thread(InitApp);
			threadInitApp.Start();
		}

		int gRemoveableDeviceCount = 0;

		// 初始化线程，用于初始化一些数据
		// 在Form1()中被调用
		// 状态：编写中
		// 完成日期：
		// 修改日期：2014.4.21
		private void InitApp()
		{
			this.comboBoxCryptoType.SelectedIndex = 0;
			this.comboBoxCryptoType.DropDownStyle = ComboBoxStyle.DropDownList;

			this.comboBoxRemoveableDevice.DropDownStyle = ComboBoxStyle.DropDownList;

			this.comboBox2.SelectedIndex = 0;
			this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

			// comboBox3: 解密用的U盘
			this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

			//获取驱动器信息
			gRemoveableDeviceCount = GetDriverType();
		}

		// 返回值
		// 0：未找到移动设备
		// 1：找到移动设备并且只有1个
		// 2及以上：找到多个存储设备
		// 状态：完成
		// 完成日期：2014.4.21
		// 最后修改日期：2014.4.21
		public int GetDriverType()
		{
			int RemoveableDeviceCount = 0;
			// 清空combox
			comboBoxRemoveableDevice.Items.Clear();
			comboBox3.Items.Clear();
			// 获取所有驱动器信息
			DriveInfo[] allDrivers = DriveInfo.GetDrives();
			foreach (DriveInfo d in allDrivers)
			{
				//MessageBox.Show(d.DriveType.ToString() + d.Name.ToString());
				// 判断是否为移动设备
				if (d.DriveType.ToString() == "Removable")
				{
					RemoveableDeviceCount += 1;
					//MessageBox.Show(d.VolumeLabel.ToString());
					comboBoxRemoveableDevice.Items.Add(d.Name.ToString() + 
						" " + d.VolumeLabel.ToString() + 
						" " + d.DriveFormat.ToString() +
						" " + d.TotalSize.ToString());

					comboBox3.Items.Add(d.Name.ToString() +
						" " + d.VolumeLabel.ToString() +
						" " + d.DriveFormat.ToString() +
						" " + d.TotalSize.ToString());
				}
			}
			return RemoveableDeviceCount;
		}

		// 在GetRemoveableDeviceSerialNumber中对searcher的值进行过滤
		// 状态：完成
		// 完成日期：2014.4.22
		// 最后修改日期：2014.4.22
		private string getValueInQuotes(string inValue)
		{
			string parsedValue = "";

			int posFoundStart = 0;
			int posFoundEnd = 0;

			posFoundStart = inValue.IndexOf("\"");
			posFoundEnd = inValue.IndexOf("\"", posFoundStart + 1);

			parsedValue = inValue.Substring(posFoundStart + 1, (posFoundEnd - posFoundStart) - 1);

			return parsedValue;
		}

		// 在GetRemoveableDeviceSerialNumber 中对serialnumber进行过滤
		// 状态：完成
		// 完成日期：2014.4.22
		// 最后修改日期：2014.4.22
		private string parseSerialFromDeviceID(string deviceId)
		{
			string[] splitDeviceId = deviceId.Split('\\');
			string[] serialArray;
			string serial;
			int arrayLen = splitDeviceId.Length - 1;

			serialArray = splitDeviceId[arrayLen].Split('&');
			serial = serialArray[0];

			return serial;
		}

		// 获取指定盘符的序列号
		// 参数DeviceName：指定盘符，例如C:\
		// 返回值为序列号
		// 状态：完成
		// 完成日期：2014-04-22
		// 最后修改日期：2014-04-22
		string GetRemoveableDeviceSerialNumber(string DeviceName)
		{
			string[] diskArray;
			string driveNumber;
			string driveLetter;

			string serialNumber = null;

			ManagementObjectSearcher searcher = 
				new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
			foreach (ManagementObject dm in searcher.Get())
			{
				diskArray = null;
				driveLetter = getValueInQuotes(dm["Dependent"].ToString());
				diskArray = getValueInQuotes(dm["Antecedent"].ToString()).Split(',');
				driveNumber = diskArray[0].Remove(0, 6).Trim();
				string[] t = DeviceName.Split('\\');
 				if (driveLetter == t[0])
 				{
// 					/* This is where we get the drive serial */
 					ManagementObjectSearcher disks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
 					foreach (ManagementObject disk in disks.Get())
 					{
 						if (disk["Name"].ToString() == ("\\\\.\\PHYSICALDRIVE" + driveNumber) & disk["InterfaceType"].ToString() == "USB")
 						{
 							//this._serialNumber = parseSerialFromDeviceID(disk["PNPDeviceID"].ToString());
							/*MessageBox.Show(disk["PNPDeviceID"].ToString());*/
							serialNumber = parseSerialFromDeviceID(disk["PNPDeviceID"].ToString());
/*							MessageBox.Show(serialNumber);*/
						}
					}
 				}
			}

			return serialNumber;
		}
		
		// 打开文件按钮
		// 状态：完成
		// 完成日期：2014.4.21
		// 最后修改日期：2014.4.21
		private void buttonSelectCryptionFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openDialog = new OpenFileDialog();
			//FolderBrowserDialog openDialog = new FolderBrowserDialog();
			openDialog.Title = "请选择需要加密的文件";
			if (openDialog.ShowDialog() == DialogResult.OK || 
				openDialog.ShowDialog() == DialogResult.Yes)
			{
				string filePath = openDialog.FileName;
				this.textBoxCryptionFilePath.Text = filePath;
			}
		}

		// 点击加密按钮时检测是否所有的编辑框都填写内容
		// 返回值：true，所有都填写完整
		// 返回值：false，有内容未填写
		// 状态：完成
		// 完成日期：2014-04-22
		// 最后修改时间：2014-04-22
		public bool CheckIsFillBlank()
		{
			bool res = true;


			// 先检查一下U盘数量，如果没有选中或者是U盘数量为0的话，就报错。
			if (gRemoveableDeviceCount == 0 /*|| RemoveableDeviceNumber == 0*/)
			{
				MessageBox.Show("U盘错误！");
				return false;
			}

			// 检查是否选中U盘
			string strSelectDevice;
			try
			{
				strSelectDevice = comboBoxRemoveableDevice.SelectedItem.ToString();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("请选择U盘！");
				return false;
			}

			// 检测是否选择文件
			//MessageBox.Show(textBoxCryptionFilePath.Text);
			if (textBoxCryptionFilePath.Text.Length == 0)
			{
				MessageBox.Show("请选择需要加密的文件!");
				return false;
			}
			return true;
		}


		// 加密按钮
		// 状态：编写中
		// 完成日期：
		// 最后修改日期：2014.4.21
		private void buttonCryptoFile_Click(object sender, EventArgs e)
		{

			if (CheckIsFillBlank() == false)
			{
				return; ;
			}

			string strSelectDevice = comboBoxRemoveableDevice.SelectedItem.ToString();

			// 将combox中获取的内容分割，得到U盘盘符
			// TargetDevice[0]就是盘符
			string[] TargetDevice = strSelectDevice.Split(' ');
			
			// 获取U盘序列号，存在serialNumber中
			string serialNumber = GetRemoveableDeviceSerialNumber(TargetDevice[0]);
			// 调试时使用
			// MessageBox.Show(serialNumber);

			// 将数据Post到服务端
			string postData = "uKeyu=" + serialNumber;
			string recvData = PostAndRecv(postData);
			MessageBox.Show(recvData);

		}

		// 向服务器POST数据并获得回显
		// 状态：完成
		// 完成日期：2014年5月9日 19:37:36
		// 最后修改日期：2014年5月9日 19:37:46
		// 参数：postData，待传递的参数，为a=1&b=2的形式
		// 返回值：post后的回显
		public string PostAndRecv(string postData)
		{
			byte[] byteArray = Encoding.UTF8.GetBytes(postData);

			Uri target = new Uri("http://127.0.0.1/gs/recvukey.php");
			WebRequest request = WebRequest.Create(target);

			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;

			using (var dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}

			string content;

			using (var response = (HttpWebResponse)request.GetResponse())
			{
				StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
				content = reader.ReadToEnd();
			}
			return content;
		}


		// 关闭按钮
		// 状态：完成
		// 完成日期：2014.4.21
		// 最后修改日期：2014.4.21
		private void buttonClose_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// 重写窗体的WndProc方法，截取消息
		// 状态：完成
		// 完成日期：2014.4.21
		// 最后修改日期：2014.4.21
		protected override void WndProc(ref Message m)
		{
			const int WM_DEVICECHANGE = 0x219;		//硬件设备状态改变
			const int DBT_DEVICEARRIVAL = 0x8000;	//U盘插入
			//const int DBT_CONFIGCHANGECANCELED = 0x0019;	//要求更改当前的配置已被取消
			const int DBT_DEVICEREMOVECOMPLETE = 0x8004;	//U盘拔出

			if (m.Msg == WM_DEVICECHANGE)
			{
				switch (m.WParam.ToInt32())
				{
					case WM_DEVICECHANGE:
						break;
					case DBT_DEVICEARRIVAL:
						//检测到U盘插入
						gRemoveableDeviceCount = GetDriverType();
						break;
					case DBT_DEVICEREMOVECOMPLETE:
						//检测到U盘拔出
						gRemoveableDeviceCount = GetDriverType();
						break;
					default:
						break;
				}
			}

			base.WndProc(ref m);
		}

	}
}
