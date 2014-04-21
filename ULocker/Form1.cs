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
				}
			}
			return RemoveableDeviceCount;
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


		// 加密按钮
		// 状态：编写中
		// 完成日期：
		// 最后修改日期：2014.4.21
		private void buttonCryptoFile_Click(object sender, EventArgs e)
		{
			// 先检查一下U盘数量，如果没有选中或者是U盘数量为0的话，就报错。
			if (gRemoveableDeviceCount == 0 /*|| RemoveableDeviceNumber == 0*/)
			{
				MessageBox.Show("U盘错误！");
				return;
			}

			// 检查是否选中U盘
			string strSelectDevice;
			try
			{
				strSelectDevice = comboBoxRemoveableDevice.SelectedItem.ToString();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("请选择U盘！\n" + ex.Message);
				return;
			}

			// 将combox中获取的内容分割，得到U盘盘符
			// TargetDevice[0]就是盘符
			string[] TargetDevice = strSelectDevice.Split(' ');
			//MessageBox.Show(TargetDevice[0]);

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
