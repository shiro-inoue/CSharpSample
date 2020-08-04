namespace CSharpSample01
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
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.centerButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.childWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.coordinateGroupBox = new System.Windows.Forms.GroupBox();
            this.hTrackBar = new System.Windows.Forms.TrackBar();
            this.hValueLabel = new System.Windows.Forms.Label();
            this.wValueLabel = new System.Windows.Forms.Label();
            this.mValueLabel = new System.Windows.Forms.Label();
            this.wTrackBar = new System.Windows.Forms.TrackBar();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.movementLabel = new System.Windows.Forms.Label();
            this.backgroundColorGroupBox = new System.Windows.Forms.GroupBox();
            this.gTrackBar = new System.Windows.Forms.TrackBar();
            this.rTrackBar = new System.Windows.Forms.TrackBar();
            this.bValueLabel = new System.Windows.Forms.Label();
            this.gValueLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.buttonGroupBox.SuspendLayout();
            this.coordinateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.backgroundColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.centerButton);
            this.buttonGroupBox.Controls.Add(this.downButton);
            this.buttonGroupBox.Controls.Add(this.rightButton);
            this.buttonGroupBox.Controls.Add(this.leftButton);
            this.buttonGroupBox.Controls.Add(this.upButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(30, 30);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(297, 246);
            this.buttonGroupBox.TabIndex = 0;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "子ウインドウ位置制御";
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(110, 104);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(75, 45);
            this.centerButton.TabIndex = 9;
            this.centerButton.Text = "・";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(110, 164);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 45);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(203, 104);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 45);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "→";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(15, 104);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 45);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "←";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(110, 36);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 45);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // childWindowCheckBox
            // 
            this.childWindowCheckBox.AutoSize = true;
            this.childWindowCheckBox.Location = new System.Drawing.Point(365, 39);
            this.childWindowCheckBox.Name = "childWindowCheckBox";
            this.childWindowCheckBox.Size = new System.Drawing.Size(153, 22);
            this.childWindowCheckBox.TabIndex = 1;
            this.childWindowCheckBox.Text = "子ウインドウ表示";
            this.childWindowCheckBox.UseVisualStyleBackColor = true;
            this.childWindowCheckBox.CheckedChanged += new System.EventHandler(this.childWindowCheckBox_CheckedChanged);
            // 
            // coordinateGroupBox
            // 
            this.coordinateGroupBox.Controls.Add(this.hTrackBar);
            this.coordinateGroupBox.Controls.Add(this.hValueLabel);
            this.coordinateGroupBox.Controls.Add(this.wValueLabel);
            this.coordinateGroupBox.Controls.Add(this.mValueLabel);
            this.coordinateGroupBox.Controls.Add(this.wTrackBar);
            this.coordinateGroupBox.Controls.Add(this.mTrackBar);
            this.coordinateGroupBox.Controls.Add(this.heightLabel);
            this.coordinateGroupBox.Controls.Add(this.widthLabel);
            this.coordinateGroupBox.Controls.Add(this.movementLabel);
            this.coordinateGroupBox.Location = new System.Drawing.Point(365, 67);
            this.coordinateGroupBox.Name = "coordinateGroupBox";
            this.coordinateGroupBox.Size = new System.Drawing.Size(377, 181);
            this.coordinateGroupBox.TabIndex = 2;
            this.coordinateGroupBox.TabStop = false;
            this.coordinateGroupBox.Text = "子ウインドウ座標制御";
            // 
            // hTrackBar
            // 
            this.hTrackBar.Location = new System.Drawing.Point(194, 113);
            this.hTrackBar.Minimum = 1;
            this.hTrackBar.Name = "hTrackBar";
            this.hTrackBar.Size = new System.Drawing.Size(147, 69);
            this.hTrackBar.TabIndex = 8;
            this.hTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hTrackBar.Value = 1;
            this.hTrackBar.Scroll += new System.EventHandler(this.hTrackBar_Scroll);
            // 
            // hValueLabel
            // 
            this.hValueLabel.AutoSize = true;
            this.hValueLabel.Location = new System.Drawing.Point(101, 113);
            this.hValueLabel.Name = "hValueLabel";
            this.hValueLabel.Size = new System.Drawing.Size(59, 18);
            this.hValueLabel.TabIndex = 7;
            this.hValueLabel.Text = "hValue";
            // 
            // wValueLabel
            // 
            this.wValueLabel.AutoSize = true;
            this.wValueLabel.Location = new System.Drawing.Point(101, 75);
            this.wValueLabel.Name = "wValueLabel";
            this.wValueLabel.Size = new System.Drawing.Size(62, 18);
            this.wValueLabel.TabIndex = 6;
            this.wValueLabel.Text = "wValue";
            // 
            // mValueLabel
            // 
            this.mValueLabel.AutoSize = true;
            this.mValueLabel.Location = new System.Drawing.Point(101, 33);
            this.mValueLabel.Name = "mValueLabel";
            this.mValueLabel.Size = new System.Drawing.Size(63, 18);
            this.mValueLabel.TabIndex = 5;
            this.mValueLabel.Text = "mValue";
            // 
            // wTrackBar
            // 
            this.wTrackBar.Location = new System.Drawing.Point(194, 75);
            this.wTrackBar.Minimum = 1;
            this.wTrackBar.Name = "wTrackBar";
            this.wTrackBar.Size = new System.Drawing.Size(147, 69);
            this.wTrackBar.TabIndex = 4;
            this.wTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.wTrackBar.Value = 1;
            this.wTrackBar.Scroll += new System.EventHandler(this.wTrackBar_Scroll);
            // 
            // mTrackBar
            // 
            this.mTrackBar.Location = new System.Drawing.Point(194, 33);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(147, 69);
            this.mTrackBar.TabIndex = 3;
            this.mTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackBar.Value = 100;
            this.mTrackBar.Scroll += new System.EventHandler(this.mTrackBar_Scroll);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(17, 113);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(47, 18);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "高さ：";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(17, 75);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 18);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "幅：";
            // 
            // movementLabel
            // 
            this.movementLabel.AutoSize = true;
            this.movementLabel.Location = new System.Drawing.Point(17, 33);
            this.movementLabel.Name = "movementLabel";
            this.movementLabel.Size = new System.Drawing.Size(71, 18);
            this.movementLabel.TabIndex = 0;
            this.movementLabel.Text = "移動量：";
            // 
            // backgroundColorGroupBox
            // 
            this.backgroundColorGroupBox.Controls.Add(this.gTrackBar);
            this.backgroundColorGroupBox.Controls.Add(this.rTrackBar);
            this.backgroundColorGroupBox.Controls.Add(this.bValueLabel);
            this.backgroundColorGroupBox.Controls.Add(this.gValueLabel);
            this.backgroundColorGroupBox.Controls.Add(this.rValueLabel);
            this.backgroundColorGroupBox.Controls.Add(this.bLabel);
            this.backgroundColorGroupBox.Controls.Add(this.gLabel);
            this.backgroundColorGroupBox.Controls.Add(this.rLabel);
            this.backgroundColorGroupBox.Location = new System.Drawing.Point(365, 262);
            this.backgroundColorGroupBox.Name = "backgroundColorGroupBox";
            this.backgroundColorGroupBox.Size = new System.Drawing.Size(377, 176);
            this.backgroundColorGroupBox.TabIndex = 3;
            this.backgroundColorGroupBox.TabStop = false;
            this.backgroundColorGroupBox.Text = "子ウインドウ背景色制御";
            // 
            // gTrackBar
            // 
            this.gTrackBar.Location = new System.Drawing.Point(194, 70);
            this.gTrackBar.Maximum = 255;
            this.gTrackBar.Name = "gTrackBar";
            this.gTrackBar.Size = new System.Drawing.Size(147, 69);
            this.gTrackBar.TabIndex = 7;
            this.gTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gTrackBar.Value = 128;
            this.gTrackBar.Scroll += new System.EventHandler(this.gTrackBar_Scroll);
            // 
            // rTrackBar
            // 
            this.rTrackBar.Location = new System.Drawing.Point(194, 31);
            this.rTrackBar.Maximum = 255;
            this.rTrackBar.Name = "rTrackBar";
            this.rTrackBar.Size = new System.Drawing.Size(147, 69);
            this.rTrackBar.TabIndex = 6;
            this.rTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rTrackBar.Value = 128;
            this.rTrackBar.Scroll += new System.EventHandler(this.rTrackBar_Scroll);
            // 
            // bValueLabel
            // 
            this.bValueLabel.AutoSize = true;
            this.bValueLabel.Location = new System.Drawing.Point(101, 116);
            this.bValueLabel.Name = "bValueLabel";
            this.bValueLabel.Size = new System.Drawing.Size(59, 18);
            this.bValueLabel.TabIndex = 5;
            this.bValueLabel.Text = "bValue";
            // 
            // gValueLabel
            // 
            this.gValueLabel.AutoSize = true;
            this.gValueLabel.Location = new System.Drawing.Point(101, 70);
            this.gValueLabel.Name = "gValueLabel";
            this.gValueLabel.Size = new System.Drawing.Size(58, 18);
            this.gValueLabel.TabIndex = 4;
            this.gValueLabel.Text = "gValue";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Location = new System.Drawing.Point(101, 31);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(56, 18);
            this.rValueLabel.TabIndex = 3;
            this.rValueLabel.Text = "rValue";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(17, 116);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(56, 18);
            this.bLabel.TabIndex = 2;
            this.bLabel.Text = "色(B)：";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(17, 70);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(57, 18);
            this.gLabel.TabIndex = 1;
            this.gLabel.Text = "色(G)：";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(17, 31);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(56, 18);
            this.rLabel.TabIndex = 0;
            this.rLabel.Text = "色(R)：";
            // 
            // bTrackBar
            // 
            this.bTrackBar.Location = new System.Drawing.Point(559, 378);
            this.bTrackBar.Maximum = 255;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(147, 69);
            this.bTrackBar.TabIndex = 8;
            this.bTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bTrackBar.Value = 128;
            this.bTrackBar.Scroll += new System.EventHandler(this.bTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTrackBar);
            this.Controls.Add(this.backgroundColorGroupBox);
            this.Controls.Add(this.coordinateGroupBox);
            this.Controls.Add(this.childWindowCheckBox);
            this.Controls.Add(this.buttonGroupBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "入門課題";
            this.buttonGroupBox.ResumeLayout(false);
            this.coordinateGroupBox.ResumeLayout(false);
            this.coordinateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.backgroundColorGroupBox.ResumeLayout(false);
            this.backgroundColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox buttonGroupBox;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button rightButton;
		private System.Windows.Forms.Button leftButton;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.CheckBox childWindowCheckBox;
		private System.Windows.Forms.GroupBox coordinateGroupBox;
		private System.Windows.Forms.TrackBar hTrackBar;
		private System.Windows.Forms.Label hValueLabel;
		private System.Windows.Forms.Label wValueLabel;
		private System.Windows.Forms.Label mValueLabel;
		private System.Windows.Forms.TrackBar wTrackBar;
		private System.Windows.Forms.TrackBar mTrackBar;
		private System.Windows.Forms.Label heightLabel;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label movementLabel;
		private System.Windows.Forms.GroupBox backgroundColorGroupBox;
		private System.Windows.Forms.TrackBar gTrackBar;
		private System.Windows.Forms.TrackBar rTrackBar;
		private System.Windows.Forms.Label bValueLabel;
		private System.Windows.Forms.Label gValueLabel;
		private System.Windows.Forms.Label rValueLabel;
		private System.Windows.Forms.Label bLabel;
		private System.Windows.Forms.Label gLabel;
		private System.Windows.Forms.Label rLabel;
		private System.Windows.Forms.TrackBar bTrackBar;
		private System.Windows.Forms.Button centerButton;
	}
}

