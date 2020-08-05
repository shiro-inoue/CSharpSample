using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSample01
{
    public partial class MainForm : Form
    {
        // 子ウインドウ
        private readonly SubForm subform = new SubForm();

        //ディスプレイの幅
        private int dWidth;
        //ディスプレイの高さ
        private int dHeight;

        public MainForm()
        {
            InitializeComponent();

            getScreenResolution();

            initTrackBar();

            initValueLabel();
        }

        // 画面解像度の取得
        private void getScreenResolution()
        {
            dWidth = Screen.PrimaryScreen.Bounds.Width;
            dHeight = Screen.PrimaryScreen.Bounds.Height;
        }

        // TrackBar関連コントロールの初期化
        private void initTrackBar()
        {
            mValueLabel.Text = mTrackBar.Value.ToString();

            wTrackBar.Maximum = dWidth;
            wTrackBar.Value = 300;
            wValueLabel.Text = wTrackBar.Value.ToString();

            hTrackBar.Maximum = dHeight;
            hTrackBar.Value = 200;
            hValueLabel.Text = hTrackBar.Value.ToString();
        }

        // RGB値の初期化
        private void initValueLabel()
        {
            rValueLabel.Text = rTrackBar.Value.ToString();
            gValueLabel.Text = gTrackBar.Value.ToString();
            bValueLabel.Text = bTrackBar.Value.ToString();
        }

        // 子ウインドウ表示のチェックボックスイベントハンドラ
        private void childWindowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            subform.Visible = childWindowCheckBox.Checked;
        }

        // 上ボタンイベントハンドラ
        private void upButton_Click(object sender, EventArgs e)
        {
            subform.Top = subform.Top - mTrackBar.Value;
        }

        // 下ボタンイベントハンドラ
        private void downButton_Click(object sender, EventArgs e)
        {
            subform.Top = subform.Top + mTrackBar.Value;
        }

        // 左ボタンイベントハンドラ
        private void leftButton_Click(object sender, EventArgs e)
        {
            subform.Left = subform.Left - mTrackBar.Value;
        }

        // 右ボタンイベントハンドラ
        private void rightButton_Click(object sender, EventArgs e)
        {
            subform.Left = subform.Left + mTrackBar.Value;
        }

        // 中心ボタンイベントハンドラ
        private void centerButton_Click(object sender, EventArgs e)
        {
            // [・]ボタン：子ウインドウを画面中央に移動させる。（画面中央は、画面解像度の幅、高さを取得して動的に算出すること）
            subform.Left = (dWidth - subform.Width) / 2;
            subform.Top = (dHeight - subform.Height) / 2;
        }

        // 移動量TrackBarイベントハンドラ
        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            mValueLabel.Text = mTrackBar.Value.ToString();
        }

        // 幅高さTrackBarイベントハンドラ
        private void whTrackBar_Scroll(object sender, EventArgs e)
        {
            wValueLabel.Text = wTrackBar.Value.ToString();
            hValueLabel.Text = hTrackBar.Value.ToString();

            subform.Size = new Size(wTrackBar.Value, hTrackBar.Value);
        }

        // RGBTrackBarイベントハンドラ
        private void rgbTrackBar_Scroll(object sender, EventArgs e)
        {
            rValueLabel.Text = rTrackBar.Value.ToString();
            gValueLabel.Text = gTrackBar.Value.ToString();
            bValueLabel.Text = bTrackBar.Value.ToString();

            subform.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }
    }
}
