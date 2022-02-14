using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TapoP105
{
	public partial class Form1 : Form
	{
		Boolean status = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void controlButton_Click(object sender, EventArgs e)
		{
			statusLabel.Text = "WAIT";
			Process process = new Process();
			process.StartInfo.FileName = "python";
			process.StartInfo.Arguments = "TurnOn.py";
			if (status == true)
			{
				process.StartInfo.Arguments = "TurnOff.py";
			}
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			//MessageBox.Show(process.StandardError.ReadToEnd());
			if (process.StandardError.ReadToEnd() == "")
			{
				switch (status)
				{
					case false:
						status = true;
						break;
					case true:
						status = false;
						break;
				}
			}
			setText();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo.FileName = "python";
			process.StartInfo.Arguments = "GetStatus.py";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			if (process.StandardOutput.ReadToEnd().Contains("True") == true)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			setText();
		}

		private void setText()
		{
			if (status == false)
			{
				statusLabel.Text = "OFF";
			}
			else if (status == true)
			{
				statusLabel.Text = "ON";
			}
		}
	}
}
