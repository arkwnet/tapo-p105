
namespace TapoP105
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.statusLabel = new System.Windows.Forms.Label();
			this.controlButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.statusLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.statusLabel.Location = new System.Drawing.Point(12, 9);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(86, 33);
			this.statusLabel.TabIndex = 0;
			this.statusLabel.Text = "WAIT";
			this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// controlButton
			// 
			this.controlButton.Location = new System.Drawing.Point(12, 45);
			this.controlButton.Name = "controlButton";
			this.controlButton.Size = new System.Drawing.Size(169, 28);
			this.controlButton.TabIndex = 1;
			this.controlButton.Text = "ON / OFF";
			this.controlButton.UseVisualStyleBackColor = true;
			this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(193, 85);
			this.Controls.Add(this.controlButton);
			this.Controls.Add(this.statusLabel);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "TapoP105";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Button controlButton;
	}
}

