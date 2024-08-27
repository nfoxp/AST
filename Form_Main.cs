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
            // �^�C�}�[�N��
            getASTTime(DateTime.Now);
            timer_Main.Enabled = true;

            // �R���g���[��������
            button_TimerStop1.Enabled = false;
            button_TimerStop2.Enabled = false;
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // �^�C�}�[��~
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
            // ���ݎ����擾
            int dt_h = dt.Hour;
            int dt_m = dt.Minute;
            int dt_s = dt.Second;
            int timeAll = dt_h * 60 * 60 + dt_m * 60 + dt_s;

            // AST �ɕϊ�
            int ast_time = timeAll % 4320;  // AST �� JST �� 20����1
            int ast_h = ast_time / 180;
            int ast_m = (ast_time % 180) / 3;

            // �����񐶐�
            string str_ast = ast_h.ToString("d2") + @":" + ast_m.ToString("d2");
            string str_jst = dt.ToString("HH:mm:ss");

            // �f�W�^���摜�o��
            drawAST(str_ast);
            drawJST(str_jst);
        
            // �^�C�g���o�[�ݒ�
            this.Text = @"[" + str_ast + @"]�@�A�X�g���e�B�A���v";   
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

        // �L�[�C�x���g
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

        // �{�^���C�x���g
        private void button_TimerStart1_Click(object sender, EventArgs e)
        {
            // �R���e�L�X�g���j���[�\��
            contextMenuStrip_Timer1.Show(button_TimerStart1, button_TimerStart1.Width, 0);
        }

        private void button_TimerStop1_Click(object sender, EventArgs e)
        {
            // �^�C�}�[�P��~
            timer_Timer1.Enabled = false;

            // �R���g���[������
            button_TimerStart1.Enabled = true;
            button_TimerStop1.Enabled = false;

            intTimerCount1 = 0;
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        private void button_TimerStart2_Click(object sender, EventArgs e)
        {
            // �R���e�L�X�g���j���[�\��
            contextMenuStrip_Timer2.Show(button_TimerStart2, button_TimerStart2.Width, 0);
        }

        private void button_TimerStop2_Click(object sender, EventArgs e)
        {
            // �^�C�}�[�Q��~
            timer_Timer2.Enabled = false;

            // �R���g���[������
            button_TimerStart2.Enabled = true;
            button_TimerStop2.Enabled = false;

            intTimerCount2 = 0;
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        // �^�C�}�[�P
        private void timer_Timer1_Tick(object sender, EventArgs e)
        {
            // �^�C�}�[�P
            intTimerCount1--;
            if (intTimerCount1 == 0)
            {
                button_TimerStop1.PerformClick();
                timer_Timer1.Enabled = false;
            }

            // �^�C�}�[�\��
            label_Timer1.Text = getTimerString(intTimerCount1);
        }

        // �^�C�}�[�Q
        private void timer_Timer2_Tick(object sender, EventArgs e)
        {
            // �^�C�}�[�Q
            intTimerCount2--;
            if (intTimerCount2 == 0)
            {
                button_TimerStop2.PerformClick();
                timer_Timer2.Enabled = false;
            }

            // �^�C�}�[�\��
            label_Timer2.Text = getTimerString(intTimerCount2);
        }

        private string getTimerString(int intTime)
        {
            int intTime_h = intTime / 60;
            int intTime_m = (intTime % 60);
            return intTime_h.ToString("D2") + ":" + intTime_m.ToString("D2");
        }

        // �R���e�L�X�g���j���[�P
        private void contextMenuStrip_Timer1_Click(object sender, EventArgs e)
        {
            // �^�C�}�[�P�J�n
            timer_Timer1.Enabled = true;

            // �R���g���[������
            button_TimerStart1.Enabled = false;
            button_TimerStop1.Enabled = true;

            // �^�C�}�[�\��
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

        // �R���e�L�X�g���j���[�Q
        private void contextMenuStrip_Timer2_Click(object sender, EventArgs e)
        {
            // �^�C�}�[�Q�J�n
            timer_Timer2.Enabled = true;

            // �R���g���[������
            button_TimerStart2.Enabled = false;
            button_TimerStop2.Enabled = true;

            // �^�C�}�[�\��
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