using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AST
{
    public partial class Form_Main : Form
    {
        private int intTimerCount1 = 0;
        private int intTimerCount2 = 0;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // タイマー起動
            getASTTime(DateTime.Now);
            timer_Main.Enabled = true;

            // コントロール初期化
            button_TimerStop1.Enabled = false;
            button_TimerStop2.Enabled = false;
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // タイマー停止
            timer_Main.Enabled = false;
            timer_Timer1.Enabled = false;
            timer_Timer2.Enabled = false;
        }

        private void timer_Main_Tick(object sender, EventArgs e)
        {
            getASTTime(DateTime.Now);
        }

        private void getASTTime(DateTime dt)
        {
            // 現在時刻取得
            int dt_h = dt.Hour;
            int dt_m = dt.Minute;
            int dt_s = dt.Second;
            int timeAll = dt_h * 60 * 60 + dt_m * 60 + dt_s;

            // AST に変換
            int ast_time = timeAll % 4320;  // AST は JST の 20分の1
            int ast_h = ast_time / 180;
            int ast_m = (ast_time % 180) / 3;

            // 文字列生成
            string str_ast = ast_h.ToString("d2") + @":" + ast_m.ToString("d2");
            string str_jst = dt.ToString("HH:mm:ss");

            // デジタル画像出力
            drawAST(str_ast);
            drawJST(str_jst);
        
            // タイトルバー設定
            this.Text = @"[" + str_ast + @"]　アストルティア時計";   
        }

        private void drawAST(string ast)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            pictureBox_AST_H1.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_l_" + ast.Substring(0, 1).ToString() + ".jpg"));
            pictureBox_AST_H2.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_l_" + ast.Substring(1, 1).ToString() + ".jpg"));
            pictureBox_AST_M1.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_l_" + ast.Substring(3, 1).ToString() + ".jpg"));
            pictureBox_AST_M2.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_l_" + ast.Substring(4, 1).ToString() + ".jpg"));
        }

        private void drawJST(string jst)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            pictureBox_JST_H1.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_s_" + jst.Substring(0, 1).ToString() + ".jpg"));
            pictureBox_JST_H2.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_s_" + jst.Substring(1, 1).ToString() + ".jpg"));
            pictureBox_JST_M1.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_s_" + jst.Substring(3, 1).ToString() + ".jpg"));
            pictureBox_JST_M2.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_s_" + jst.Substring(4, 1).ToString() + ".jpg"));
            pictureBox_JST_S1.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_s_" + jst.Substring(6, 1).ToString() + ".jpg"));
            pictureBox_JST_S2.Image = new Bitmap(assembly.GetManifestResourceStream("AST.img_ast_num_s_" + jst.Substring(7, 1).ToString() + ".jpg"));
        }

        // キーイベント
        private void Form_Main_KeyUp(object sender, KeyEventArgs e)
        {
            //
            switch (e.KeyCode)
            {
                case Keys.F1:
                    button_TimerStart1.PerformClick();
                    break;
                case Keys.F2:
                    button_TimerStart2.PerformClick();
                    break;
            }
            switch (e.KeyValue)
            {
                case 49:
                    //if (contextMenuStrip_Timer1.CanFocus())
                    ToolStripMenuItem1_60.PerformClick();
                    //if (contextMenuStrip_Timer2.CanSelect())
                    //    ToolStripMenuItem2_60.PerformClick();
                    break;
                case 50:
                    if (contextMenuStrip_Timer1.CanSelect)
                        ToolStripMenuItem1_30.PerformClick();
                    if (contextMenuStrip_Timer2.CanSelect)
                        ToolStripMenuItem2_30.PerformClick();
                    break;
                case 51:
                    if (contextMenuStrip_Timer1.CanSelect)
                        ToolStripMenuItem1_10.PerformClick();
                    if (contextMenuStrip_Timer2.CanSelect)
                        ToolStripMenuItem2_10.PerformClick();
                    break;
            }
        }

        // ボタンイベント
        private void button_TimerStart1_Click(object sender, EventArgs e)
        {
            // コンテキストメニュー表示
            contextMenuStrip_Timer1.Show(button_TimerStart1, button_TimerStart1.Width, 0);
        }

        private void button_TimerStop1_Click(object sender, EventArgs e)
        {
            // タイマー１停止
            timer_Timer1.Enabled = false;

            // コントロール制御
            button_TimerStart1.Enabled = true;
            button_TimerStop1.Enabled = false;

            intTimerCount1 = 0;
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        private void button_TimerStart2_Click(object sender, EventArgs e)
        {
            // コンテキストメニュー表示
            contextMenuStrip_Timer2.Show(button_TimerStart2, button_TimerStart2.Width, 0);
        }

        private void button_TimerStop2_Click(object sender, EventArgs e)
        {
            // タイマー２停止
            timer_Timer2.Enabled = false;

            // コントロール制御
            button_TimerStart2.Enabled = true;
            button_TimerStop2.Enabled = false;

            intTimerCount2 = 0;
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        // タイマー１
        private void timer_Timer1_Tick(object sender, EventArgs e)
        {
            // タイマー１
            intTimerCount1--;
            if (intTimerCount1 == 0)
            {
                button_TimerStop1.PerformClick();
                timer_Timer1.Enabled = false;
            }

            // タイマー表示
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        // タイマー２
        private void timer_Timer2_Tick(object sender, EventArgs e)
        {
            // タイマー２
            intTimerCount2--;
            if (intTimerCount2 == 0)
            {
                button_TimerStop2.PerformClick();
                timer_Timer2.Enabled = false;
            }

            // タイマー表示
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        private string getTimerString(int intTime)
        {
            int intTime_h = intTime / 60;
            int intTime_m = (intTime % 60);
            return intTime_h.ToString("D2") + ":" + intTime_m.ToString("D2");
        }

        // コンテキストメニュー１
        private void contextMenuStrip_Timer1_Click(object sender, EventArgs e)
        {
            // タイマー１開始
            timer_Timer1.Enabled = true;

            // コントロール制御
            button_TimerStart1.Enabled = false;
            button_TimerStop1.Enabled = true;

            // タイマー表示
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        private void ToolStripMenuItem1_60_Click(object sender, EventArgs e)
        {
            intTimerCount1 = 3600;
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        private void ToolStripMenuItem1_30_Click(object sender, EventArgs e)
        {
            intTimerCount1 = 1800;
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        private void ToolStripMenuItem1_10_Click(object sender, EventArgs e)
        {
            intTimerCount1 = 600;
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        // コンテキストメニュー２
        private void contextMenuStrip_Timer2_Click(object sender, EventArgs e)
        {
            // タイマー２開始
            timer_Timer2.Enabled = true;

            // コントロール制御
            button_TimerStart2.Enabled = false;
            button_TimerStop2.Enabled = true;

            // タイマー表示
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        private void ToolStripMenuItem2_60_Click(object sender, EventArgs e)
        {
            intTimerCount2 = 3600;
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        private void ToolStripMenuItem2_30_Click(object sender, EventArgs e)
        {
            intTimerCount2 = 1800;
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        private void ToolStripMenuItem2_10_Click(object sender, EventArgs e)
        {
            intTimerCount2 = 600;
            label_Timer2.Text = getTimerString(intTimerCount2);
        }
    }
}