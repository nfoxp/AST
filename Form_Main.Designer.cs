namespace AST
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_Clock_AST = new System.Windows.Forms.Label();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.label_Clock_JST = new System.Windows.Forms.Label();
            this.pictureBox_STATIC_AST = new System.Windows.Forms.PictureBox();
            this.pictureBox_STATIC_JST = new System.Windows.Forms.PictureBox();
            this.pictureBox_AST_H1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_AST_H2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_AST_C = new System.Windows.Forms.PictureBox();
            this.pictureBox_AST_M2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_AST_M1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_H1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_H2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_C1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_C2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_M2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_M1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_S2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_JST_S1 = new System.Windows.Forms.PictureBox();
            this.label_Timer1 = new System.Windows.Forms.Label();
            this.label_Timer2 = new System.Windows.Forms.Label();
            this.timer_Timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_Timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_TimerStart1 = new System.Windows.Forms.Button();
            this.button_TimerStop1 = new System.Windows.Forms.Button();
            this.button_TimerStop2 = new System.Windows.Forms.Button();
            this.button_TimerStart2 = new System.Windows.Forms.Button();
            this.contextMenuStrip_Timer1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1_60 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_30 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Timer2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem2_60 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2_30 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2_10 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_STATIC_AST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_STATIC_JST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_H1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_H2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_M2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_H1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_H2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_M2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_S2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_S1)).BeginInit();
            this.contextMenuStrip_Timer1.SuspendLayout();
            this.contextMenuStrip_Timer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Clock_AST
            // 
            this.label_Clock_AST.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Clock_AST.ForeColor = System.Drawing.Color.White;
            this.label_Clock_AST.Location = new System.Drawing.Point(263, 108);
            this.label_Clock_AST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Clock_AST.Name = "label_Clock_AST";
            this.label_Clock_AST.Size = new System.Drawing.Size(92, 20);
            this.label_Clock_AST.TabIndex = 0;
            this.label_Clock_AST.Text = "00:00";
            this.label_Clock_AST.Visible = false;
            // 
            // timer_Main
            // 
            this.timer_Main.Tick += new System.EventHandler(this.timer_Main_Tick);
            // 
            // label_Clock_JST
            // 
            this.label_Clock_JST.AutoSize = true;
            this.label_Clock_JST.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Clock_JST.ForeColor = System.Drawing.Color.White;
            this.label_Clock_JST.Location = new System.Drawing.Point(327, 108);
            this.label_Clock_JST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Clock_JST.Name = "label_Clock_JST";
            this.label_Clock_JST.Size = new System.Drawing.Size(76, 17);
            this.label_Clock_JST.TabIndex = 1;
            this.label_Clock_JST.Text = "00:00:00";
            this.label_Clock_JST.Visible = false;
            // 
            // pictureBox_STATIC_AST
            // 
            this.pictureBox_STATIC_AST.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_STATIC_AST.Image")));
            this.pictureBox_STATIC_AST.Location = new System.Drawing.Point(16, 38);
            this.pictureBox_STATIC_AST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_STATIC_AST.Name = "pictureBox_STATIC_AST";
            this.pictureBox_STATIC_AST.Size = new System.Drawing.Size(67, 28);
            this.pictureBox_STATIC_AST.TabIndex = 5;
            this.pictureBox_STATIC_AST.TabStop = false;
            // 
            // pictureBox_STATIC_JST
            // 
            this.pictureBox_STATIC_JST.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_STATIC_JST.Image")));
            this.pictureBox_STATIC_JST.Location = new System.Drawing.Point(16, 100);
            this.pictureBox_STATIC_JST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_STATIC_JST.Name = "pictureBox_STATIC_JST";
            this.pictureBox_STATIC_JST.Size = new System.Drawing.Size(67, 28);
            this.pictureBox_STATIC_JST.TabIndex = 6;
            this.pictureBox_STATIC_JST.TabStop = false;
            // 
            // pictureBox_AST_H1
            // 
            this.pictureBox_AST_H1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AST_H1.Image")));
            this.pictureBox_AST_H1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox_AST_H1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_AST_H1.Name = "pictureBox_AST_H1";
            this.pictureBox_AST_H1.Size = new System.Drawing.Size(72, 82);
            this.pictureBox_AST_H1.TabIndex = 7;
            this.pictureBox_AST_H1.TabStop = false;
            // 
            // pictureBox_AST_H2
            // 
            this.pictureBox_AST_H2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AST_H2.Image")));
            this.pictureBox_AST_H2.Location = new System.Drawing.Point(163, 12);
            this.pictureBox_AST_H2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_AST_H2.Name = "pictureBox_AST_H2";
            this.pictureBox_AST_H2.Size = new System.Drawing.Size(72, 82);
            this.pictureBox_AST_H2.TabIndex = 8;
            this.pictureBox_AST_H2.TabStop = false;
            // 
            // pictureBox_AST_C
            // 
            this.pictureBox_AST_C.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AST_C.Image")));
            this.pictureBox_AST_C.Location = new System.Drawing.Point(229, 12);
            this.pictureBox_AST_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_AST_C.Name = "pictureBox_AST_C";
            this.pictureBox_AST_C.Size = new System.Drawing.Size(40, 82);
            this.pictureBox_AST_C.TabIndex = 9;
            this.pictureBox_AST_C.TabStop = false;
            // 
            // pictureBox_AST_M2
            // 
            this.pictureBox_AST_M2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AST_M2.Image")));
            this.pictureBox_AST_M2.Location = new System.Drawing.Point(336, 12);
            this.pictureBox_AST_M2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_AST_M2.Name = "pictureBox_AST_M2";
            this.pictureBox_AST_M2.Size = new System.Drawing.Size(72, 82);
            this.pictureBox_AST_M2.TabIndex = 11;
            this.pictureBox_AST_M2.TabStop = false;
            // 
            // pictureBox_AST_M1
            // 
            this.pictureBox_AST_M1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AST_M1.Image")));
            this.pictureBox_AST_M1.Location = new System.Drawing.Point(264, 12);
            this.pictureBox_AST_M1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_AST_M1.Name = "pictureBox_AST_M1";
            this.pictureBox_AST_M1.Size = new System.Drawing.Size(72, 82);
            this.pictureBox_AST_M1.TabIndex = 10;
            this.pictureBox_AST_M1.TabStop = false;
            // 
            // pictureBox_JST_H1
            // 
            this.pictureBox_JST_H1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_H1.Image")));
            this.pictureBox_JST_H1.Location = new System.Drawing.Point(91, 100);
            this.pictureBox_JST_H1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_H1.Name = "pictureBox_JST_H1";
            this.pictureBox_JST_H1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_JST_H1.TabIndex = 12;
            this.pictureBox_JST_H1.TabStop = false;
            // 
            // pictureBox_JST_H2
            // 
            this.pictureBox_JST_H2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_H2.Image")));
            this.pictureBox_JST_H2.Location = new System.Drawing.Point(115, 100);
            this.pictureBox_JST_H2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_H2.Name = "pictureBox_JST_H2";
            this.pictureBox_JST_H2.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_JST_H2.TabIndex = 13;
            this.pictureBox_JST_H2.TabStop = false;
            // 
            // pictureBox_JST_C1
            // 
            this.pictureBox_JST_C1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_C1.Image")));
            this.pictureBox_JST_C1.Location = new System.Drawing.Point(136, 100);
            this.pictureBox_JST_C1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_C1.Name = "pictureBox_JST_C1";
            this.pictureBox_JST_C1.Size = new System.Drawing.Size(13, 28);
            this.pictureBox_JST_C1.TabIndex = 14;
            this.pictureBox_JST_C1.TabStop = false;
            // 
            // pictureBox_JST_C2
            // 
            this.pictureBox_JST_C2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_C2.Image")));
            this.pictureBox_JST_C2.Location = new System.Drawing.Point(195, 100);
            this.pictureBox_JST_C2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_C2.Name = "pictureBox_JST_C2";
            this.pictureBox_JST_C2.Size = new System.Drawing.Size(13, 28);
            this.pictureBox_JST_C2.TabIndex = 17;
            this.pictureBox_JST_C2.TabStop = false;
            // 
            // pictureBox_JST_M2
            // 
            this.pictureBox_JST_M2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_M2.Image")));
            this.pictureBox_JST_M2.Location = new System.Drawing.Point(173, 100);
            this.pictureBox_JST_M2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_M2.Name = "pictureBox_JST_M2";
            this.pictureBox_JST_M2.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_JST_M2.TabIndex = 16;
            this.pictureBox_JST_M2.TabStop = false;
            // 
            // pictureBox_JST_M1
            // 
            this.pictureBox_JST_M1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_M1.Image")));
            this.pictureBox_JST_M1.Location = new System.Drawing.Point(149, 100);
            this.pictureBox_JST_M1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_M1.Name = "pictureBox_JST_M1";
            this.pictureBox_JST_M1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_JST_M1.TabIndex = 15;
            this.pictureBox_JST_M1.TabStop = false;
            // 
            // pictureBox_JST_S2
            // 
            this.pictureBox_JST_S2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_S2.Image")));
            this.pictureBox_JST_S2.Location = new System.Drawing.Point(232, 100);
            this.pictureBox_JST_S2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_S2.Name = "pictureBox_JST_S2";
            this.pictureBox_JST_S2.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_JST_S2.TabIndex = 19;
            this.pictureBox_JST_S2.TabStop = false;
            // 
            // pictureBox_JST_S1
            // 
            this.pictureBox_JST_S1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_JST_S1.Image")));
            this.pictureBox_JST_S1.Location = new System.Drawing.Point(208, 100);
            this.pictureBox_JST_S1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_JST_S1.Name = "pictureBox_JST_S1";
            this.pictureBox_JST_S1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_JST_S1.TabIndex = 18;
            this.pictureBox_JST_S1.TabStop = false;
            // 
            // label_Timer1
            // 
            this.label_Timer1.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Timer1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label_Timer1.Location = new System.Drawing.Point(85, 148);
            this.label_Timer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Timer1.Name = "label_Timer1";
            this.label_Timer1.Size = new System.Drawing.Size(97, 26);
            this.label_Timer1.TabIndex = 20;
            this.label_Timer1.Text = "00:00";
            // 
            // label_Timer2
            // 
            this.label_Timer2.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Timer2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label_Timer2.Location = new System.Drawing.Point(85, 185);
            this.label_Timer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Timer2.Name = "label_Timer2";
            this.label_Timer2.Size = new System.Drawing.Size(97, 26);
            this.label_Timer2.TabIndex = 21;
            this.label_Timer2.Text = "00:00";
            // 
            // timer_Timer1
            // 
            this.timer_Timer1.Interval = 1000;
            this.timer_Timer1.Tick += new System.EventHandler(this.timer_Timer1_Tick);
            // 
            // timer_Timer2
            // 
            this.timer_Timer2.Interval = 1000;
            this.timer_Timer2.Tick += new System.EventHandler(this.timer_Timer2_Tick);
            // 
            // button_TimerStart1
            // 
            this.button_TimerStart1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_TimerStart1.Location = new System.Drawing.Point(176, 146);
            this.button_TimerStart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TimerStart1.Name = "button_TimerStart1";
            this.button_TimerStart1.Size = new System.Drawing.Size(89, 29);
            this.button_TimerStart1.TabIndex = 22;
            this.button_TimerStart1.Text = "START";
            this.button_TimerStart1.UseVisualStyleBackColor = true;
            this.button_TimerStart1.Click += new System.EventHandler(this.button_TimerStart1_Click);
            // 
            // button_TimerStop1
            // 
            this.button_TimerStop1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_TimerStop1.Location = new System.Drawing.Point(263, 146);
            this.button_TimerStop1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TimerStop1.Name = "button_TimerStop1";
            this.button_TimerStop1.Size = new System.Drawing.Size(61, 29);
            this.button_TimerStop1.TabIndex = 23;
            this.button_TimerStop1.Text = "STOP";
            this.button_TimerStop1.UseVisualStyleBackColor = true;
            this.button_TimerStop1.Click += new System.EventHandler(this.button_TimerStop1_Click);
            // 
            // button_TimerStop2
            // 
            this.button_TimerStop2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_TimerStop2.Location = new System.Drawing.Point(263, 184);
            this.button_TimerStop2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TimerStop2.Name = "button_TimerStop2";
            this.button_TimerStop2.Size = new System.Drawing.Size(61, 29);
            this.button_TimerStop2.TabIndex = 25;
            this.button_TimerStop2.Text = "STOP";
            this.button_TimerStop2.UseVisualStyleBackColor = true;
            this.button_TimerStop2.Click += new System.EventHandler(this.button_TimerStop2_Click);
            // 
            // button_TimerStart2
            // 
            this.button_TimerStart2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_TimerStart2.Location = new System.Drawing.Point(176, 184);
            this.button_TimerStart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TimerStart2.Name = "button_TimerStart2";
            this.button_TimerStart2.Size = new System.Drawing.Size(89, 29);
            this.button_TimerStart2.TabIndex = 24;
            this.button_TimerStart2.Text = "START";
            this.button_TimerStart2.UseVisualStyleBackColor = true;
            this.button_TimerStart2.Click += new System.EventHandler(this.button_TimerStart2_Click);
            // 
            // contextMenuStrip_Timer1
            // 
            this.contextMenuStrip_Timer1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Timer1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1_60,
            this.ToolStripMenuItem1_30,
            this.ToolStripMenuItem1_10});
            this.contextMenuStrip_Timer1.Name = "contextMenuStrip_Timer1";
            this.contextMenuStrip_Timer1.Size = new System.Drawing.Size(124, 76);
            this.contextMenuStrip_Timer1.Click += new System.EventHandler(this.contextMenuStrip_Timer1_Click);
            // 
            // ToolStripMenuItem1_60
            // 
            this.ToolStripMenuItem1_60.Name = "ToolStripMenuItem1_60";
            this.ToolStripMenuItem1_60.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem1_60.Text = "１時間";
            this.ToolStripMenuItem1_60.Click += new System.EventHandler(this.ToolStripMenuItem1_60_Click);
            // 
            // ToolStripMenuItem1_30
            // 
            this.ToolStripMenuItem1_30.Name = "ToolStripMenuItem1_30";
            this.ToolStripMenuItem1_30.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem1_30.Text = "３０分";
            this.ToolStripMenuItem1_30.Click += new System.EventHandler(this.ToolStripMenuItem1_30_Click);
            // 
            // ToolStripMenuItem1_10
            // 
            this.ToolStripMenuItem1_10.Name = "ToolStripMenuItem1_10";
            this.ToolStripMenuItem1_10.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem1_10.Text = "１０分";
            this.ToolStripMenuItem1_10.Click += new System.EventHandler(this.ToolStripMenuItem1_10_Click);
            // 
            // contextMenuStrip_Timer2
            // 
            this.contextMenuStrip_Timer2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Timer2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2_60,
            this.ToolStripMenuItem2_30,
            this.ToolStripMenuItem2_10});
            this.contextMenuStrip_Timer2.Name = "contextMenuStrip_Timer2";
            this.contextMenuStrip_Timer2.Size = new System.Drawing.Size(124, 76);
            this.contextMenuStrip_Timer2.Click += new System.EventHandler(this.contextMenuStrip_Timer2_Click);
            // 
            // ToolStripMenuItem2_60
            // 
            this.ToolStripMenuItem2_60.Name = "ToolStripMenuItem2_60";
            this.ToolStripMenuItem2_60.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem2_60.Text = "１時間";
            this.ToolStripMenuItem2_60.Click += new System.EventHandler(this.ToolStripMenuItem2_60_Click);
            // 
            // ToolStripMenuItem2_30
            // 
            this.ToolStripMenuItem2_30.Name = "ToolStripMenuItem2_30";
            this.ToolStripMenuItem2_30.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem2_30.Text = "３０分";
            this.ToolStripMenuItem2_30.Click += new System.EventHandler(this.ToolStripMenuItem2_30_Click);
            // 
            // ToolStripMenuItem2_10
            // 
            this.ToolStripMenuItem2_10.Name = "ToolStripMenuItem2_10";
            this.ToolStripMenuItem2_10.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem2_10.Text = "１０分";
            this.ToolStripMenuItem2_10.Click += new System.EventHandler(this.ToolStripMenuItem2_10_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(425, 226);
            this.Controls.Add(this.pictureBox_JST_S2);
            this.Controls.Add(this.pictureBox_JST_S1);
            this.Controls.Add(this.button_TimerStart2);
            this.Controls.Add(this.button_TimerStart1);
            this.Controls.Add(this.button_TimerStop2);
            this.Controls.Add(this.label_Timer2);
            this.Controls.Add(this.button_TimerStop1);
            this.Controls.Add(this.label_Timer1);
            this.Controls.Add(this.pictureBox_JST_C2);
            this.Controls.Add(this.pictureBox_JST_M2);
            this.Controls.Add(this.pictureBox_JST_M1);
            this.Controls.Add(this.pictureBox_JST_C1);
            this.Controls.Add(this.pictureBox_JST_H2);
            this.Controls.Add(this.pictureBox_JST_H1);
            this.Controls.Add(this.pictureBox_AST_M2);
            this.Controls.Add(this.pictureBox_AST_M1);
            this.Controls.Add(this.pictureBox_AST_C);
            this.Controls.Add(this.pictureBox_AST_H2);
            this.Controls.Add(this.pictureBox_AST_H1);
            this.Controls.Add(this.pictureBox_STATIC_JST);
            this.Controls.Add(this.pictureBox_STATIC_AST);
            this.Controls.Add(this.label_Clock_JST);
            this.Controls.Add(this.label_Clock_AST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "アストルティア時計";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_STATIC_AST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_STATIC_JST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_H1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_H2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_M2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AST_M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_H1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_H2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_M2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_S2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JST_S1)).EndInit();
            this.contextMenuStrip_Timer1.ResumeLayout(false);
            this.contextMenuStrip_Timer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Clock_AST;
        private System.Windows.Forms.Timer timer_Main;
        private System.Windows.Forms.Label label_Clock_JST;
        private System.Windows.Forms.PictureBox pictureBox_STATIC_AST;
        private System.Windows.Forms.PictureBox pictureBox_STATIC_JST;
        private System.Windows.Forms.PictureBox pictureBox_AST_H1;
        private System.Windows.Forms.PictureBox pictureBox_AST_H2;
        private System.Windows.Forms.PictureBox pictureBox_AST_C;
        private System.Windows.Forms.PictureBox pictureBox_AST_M2;
        private System.Windows.Forms.PictureBox pictureBox_AST_M1;
        private System.Windows.Forms.PictureBox pictureBox_JST_H1;
        private System.Windows.Forms.PictureBox pictureBox_JST_H2;
        private System.Windows.Forms.PictureBox pictureBox_JST_C1;
        private System.Windows.Forms.PictureBox pictureBox_JST_C2;
        private System.Windows.Forms.PictureBox pictureBox_JST_M2;
        private System.Windows.Forms.PictureBox pictureBox_JST_M1;
        private System.Windows.Forms.PictureBox pictureBox_JST_S2;
        private System.Windows.Forms.PictureBox pictureBox_JST_S1;
        private System.Windows.Forms.Label label_Timer1;
        private System.Windows.Forms.Label label_Timer2;
        private System.Windows.Forms.Timer timer_Timer1;
        private System.Windows.Forms.Timer timer_Timer2;
        private System.Windows.Forms.Button button_TimerStart1;
        private System.Windows.Forms.Button button_TimerStop1;
        private System.Windows.Forms.Button button_TimerStop2;
        private System.Windows.Forms.Button button_TimerStart2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Timer1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_60;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_30;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Timer2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2_60;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2_30;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2_10;
    }
}

