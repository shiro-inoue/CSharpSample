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
    public partial class Form1 : Form
    {
        // 子ウインドウ
        Form2 form2 = null;

        //ディスプレイの幅
        private int dWidth;
        //ディスプレイの高さ
        private int dHeight;

        public Form1()
        {
            InitializeComponent();

            // 子ウインドウを生成
            if (form2 == null)
            {
                form2 = new Form2();

                // 子ウインドウの色
                form2.BackColor = Color.FromArgb(0x80, 0x80, 0x80);
            }

            // 画面解像度の取得
            getScreenResolution();

            // TrackBar関連コントロールの初期化
            // [移動量]TrackBarコントロール：最大値=画面解像度の幅
            mValueLabel.Text = mTrackBar.Value.ToString();

            // [幅]TrackBarコントロール    ：最大値=画面解像度の幅
            wTrackBar.Maximum = dWidth;
            wTrackBar.Value = form2.Width;
            wValueLabel.Text = form2.Width.ToString();

            // [高さ]TrackBarコントロール  ：最大値=画面解像度の高さ
            hTrackBar.Maximum = dHeight;
            hTrackBar.Value = form2.Height;
            hValueLabel.Text = form2.Height.ToString();

            // RGB値の初期化
            rValueLabel.Text = rTrackBar.Value.ToString();
            gValueLabel.Text = gTrackBar.Value.ToString();
            bValueLabel.Text = bTrackBar.Value.ToString();

        }

        // 画面解像度の取得
        private void getScreenResolution()
        {
            //ディスプレイの幅
            dWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //ディスプレイの高さ
            dHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        private void childWindowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (((CheckBox)(sender)).CheckState)
            {
                case CheckState.Checked:
                    form2.Show();
                    break;
                case CheckState.Unchecked:
                    form2.Hide();
                    break;
                default:
                    break;
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            // [↑]ボタン：子ウインドウを上にTrackBarコントロールの移動量だけ移動させる
            //// 移動すると上にはみ出る場合
            //if (form2.Top - mTrackBar.Value < 0)
            //{
            //    // 子ウインドウY座標
            //    form2.Top = 0;
            //}
            //else
            //{
            // 子ウインドウY座標
            form2.Top = form2.Top - mTrackBar.Value;
            //}
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            // [↓]ボタン：子ウインドウを下にTrackBarコントロールの移動量だけ移動させる
            //// 移動すると下にはみ出る場合
            //if (form2.Bottom + mTrackBar.Value > dHeight)
            //{
            //    // 子ウインドウY座標
            //    form2.Top = dHeight - form2.Height;
            //}
            //else
            //{
            // 子ウインドウY座標
            form2.Top = form2.Top + mTrackBar.Value;
            //}
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            // [←]ボタン：子ウインドウを左にTrackBarコントロールの移動量だけ移動させる
            //// 移動すると左にはみ出る場合
            //if (form2.Left - mTrackBar.Value < 0)
            //{
            //    // 子ウインドウY座標
            //    form2.Left = 0;
            //}
            //else
            //{
            // 子ウインドウX座標
            form2.Left = form2.Left - mTrackBar.Value;
            //}
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            // [→]ボタン：子ウインドウを右にTrackBarコントロールの移動量だけ移動させる
            //// 移動すると右にはみ出る場合
            //if (form2.Right + mTrackBar.Value > dWidth)
            //{
            //    // 子ウインドウY座標
            //    form2.Left = dWidth - form2.Width;
            //}
            //else
            //{
            // 子ウインドウX座標
            form2.Left = form2.Left + mTrackBar.Value;
            //}
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            // [・]ボタン：子ウインドウを画面中央に移動させる。（画面中央は、画面解像度の幅、高さを取得して動的に算出すること）
            // 子ウインドウX座標
            form2.Left = (dWidth - form2.Width) / 2;
            // 子ウインドウY座標
            form2.Top = (dHeight - form2.Height) / 2;
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            // [移動量]TrackBarコントロール：このTrackBarコントロールの値だけ[↑]ボタン、[↓]ボタン、[←]ボタン、[→]ボタン押下時に子ウインドウをそれぞれに移動する。最小値は、1。最大値は、画面解像度の幅。
            // 表示値の設定
            mValueLabel.Text = mTrackBar.Value.ToString();
        }

        private void wTrackBar_Scroll(object sender, EventArgs e)
        {
            // [幅]TrackBarコントロール：このTrackBarコントロールの値だけ子ウインドウの幅を変化させる。最小値は、1。最大値は、画面解像度の幅。	
            // 表示値の設定
            wValueLabel.Text = wTrackBar.Value.ToString();

            // 子ウインドウのサイズ
            form2.Size = new Size(wTrackBar.Value, hTrackBar.Value);
        }

        private void hTrackBar_Scroll(object sender, EventArgs e)
        {
            // [高さ]TrackBarコントロール：このTrackBarコントロールの値だけ子ウインドウの高さを変化させる。最小値は、1。最大値は、画面解像度の高さ。	
            // 表示値の設定
            hValueLabel.Text = hTrackBar.Value.ToString();

            // 子ウインドウのサイズ
            form2.Size = new Size(wTrackBar.Value, hTrackBar.Value);
        }

        private void rTrackBar_Scroll(object sender, EventArgs e)
        {
            // [色（R）]TrackBarコントロール：このTrackBarコントロールの値だけ子ウインドウの背景色のR成分を変化させること。最小値は、0。最大値は、255。	
            // 表示値の設定
            rValueLabel.Text = rTrackBar.Value.ToString();

            // 子ウインドウの色
            form2.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }

        private void gTrackBar_Scroll(object sender, EventArgs e)
        {
            // [色（G）]TrackBarコントロール：このTrackBarコントロールの値だけ子ウインドウの背景色のG成分を変化させること。最小値は、0。最大値は、255。	
            // 表示値の設定
            gValueLabel.Text = gTrackBar.Value.ToString();

            // 子ウインドウの色
            form2.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }

        private void bTrackBar_Scroll(object sender, EventArgs e)
        {
            // [色（B）]TrackBarコントロール：このTrackBarコントロールの値だけ子ウインドウの背景色のB成分を変化させること。最小値は、0。最大値は、255。	
            // 表示値の設定
            bValueLabel.Text = bTrackBar.Value.ToString();

            // 子ウインドウの色
            form2.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }
    }
}
