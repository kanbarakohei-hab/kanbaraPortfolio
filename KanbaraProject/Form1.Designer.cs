using System;
using System.Drawing;

namespace KanbaraProject
{
    partial class Form1
    {
        Koma koma = new Koma();


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
            KomaColor color = new KomaColor();
            #region
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            //■this.button1 = new System.Windows.Forms.Button();
            this.titile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();

            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();

            this.玉 = new System.Windows.Forms.Label();
            this.金3 = new System.Windows.Forms.Label();
            this.金4 = new System.Windows.Forms.Label();
            this.銀4 = new System.Windows.Forms.Label();
            this.銀3 = new System.Windows.Forms.Label();
            this.香3 = new System.Windows.Forms.Label();
            this.桂3 = new System.Windows.Forms.Label();
            this.桂4 = new System.Windows.Forms.Label();
            this.香4 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.飛2 = new System.Windows.Forms.Label();
            this.角2 = new System.Windows.Forms.Label();
            this.歩10 = new System.Windows.Forms.Label();
            this.歩11 = new System.Windows.Forms.Label();
            this.歩12 = new System.Windows.Forms.Label();
            this.歩13 = new System.Windows.Forms.Label();
            this.歩14 = new System.Windows.Forms.Label();
            this.歩15 = new System.Windows.Forms.Label();
            this.歩16 = new System.Windows.Forms.Label();
            this.歩17 = new System.Windows.Forms.Label();
            this.歩18 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.香2 = new System.Windows.Forms.Label();
            this.桂2 = new System.Windows.Forms.Label();
            this.銀2 = new System.Windows.Forms.Label();
            this.金2 = new System.Windows.Forms.Label();
            this.王 = new System.Windows.Forms.Label();
            this.金1 = new System.Windows.Forms.Label();
            this.銀1 = new System.Windows.Forms.Label();
            this.桂1 = new System.Windows.Forms.Label();
            this.香1 = new System.Windows.Forms.Label();
            this.角1 = new System.Windows.Forms.Label();
            this.飛1 = new System.Windows.Forms.Label();
            this.歩9 = new System.Windows.Forms.Label();
            this.歩8 = new System.Windows.Forms.Label();
            this.歩7 = new System.Windows.Forms.Label();
            this.歩6 = new System.Windows.Forms.Label();
            this.歩5 = new System.Windows.Forms.Label();
            this.歩4 = new System.Windows.Forms.Label();
            this.歩3 = new System.Windows.Forms.Label();
            this.歩1 = new System.Windows.Forms.Label();
            this.歩2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            #endregion
            #region 駒リスト

            Koma.駒.Add(this.玉);
            Koma.駒.Add(this.王);
            Koma.駒.Add(this.金1);
            Koma.駒.Add(this.金2);
            Koma.駒.Add(this.金3);
            Koma.駒.Add(this.金4);
            Koma.駒.Add(this.銀1);
            Koma.駒.Add(this.銀2);
            Koma.駒.Add(this.銀3);
            Koma.駒.Add(this.銀4);
            Koma.駒.Add(this.桂1);
            Koma.駒.Add(this.桂2);
            Koma.駒.Add(this.桂3);
            Koma.駒.Add(this.桂4);
            Koma.駒.Add(this.香1);
            Koma.駒.Add(this.香2);
            Koma.駒.Add(this.香3);
            Koma.駒.Add(this.香4);
            Koma.駒.Add(this.飛1);
            Koma.駒.Add(this.飛2);
            Koma.駒.Add(this.角1);
            Koma.駒.Add(this.角2);
            Koma.駒.Add(this.歩1);
            Koma.駒.Add(this.歩2);
            Koma.駒.Add(this.歩3);
            Koma.駒.Add(this.歩4);
            Koma.駒.Add(this.歩5);
            Koma.駒.Add(this.歩6);
            Koma.駒.Add(this.歩7);
            Koma.駒.Add(this.歩8);
            Koma.駒.Add(this.歩9);
            Koma.駒.Add(this.歩10);
            Koma.駒.Add(this.歩11);
            Koma.駒.Add(this.歩12);
            Koma.駒.Add(this.歩13);
            Koma.駒.Add(this.歩14);
            Koma.駒.Add(this.歩15);
            Koma.駒.Add(this.歩16);
            Koma.駒.Add(this.歩17);
            Koma.駒.Add(this.歩18);
            Koma.駒.Add(this.label60);
            Koma.駒.Add(this.label59);
            Koma.駒.Add(this.label58);
            Koma.駒.Add(this.label40);
            Koma.駒.Add(this.label38);
            Koma.駒.Add(this.label37);
            Koma.駒.Add(this.label36);
            Koma.駒.Add(this.label35);
            Koma.駒.Add(this.label34);
            Koma.駒.Add(this.label33);
            Koma.駒.Add(this.label32);
            Koma.駒.Add(this.label31);
            Koma.駒.Add(this.label30);
            Koma.駒.Add(this.label29);
            Koma.駒.Add(this.label28);
            Koma.駒.Add(this.label27);
            Koma.駒.Add(this.label26);
            Koma.駒.Add(this.label25);
            Koma.駒.Add(this.label24);
            Koma.駒.Add(this.label23);
            Koma.駒.Add(this.label22);
            Koma.駒.Add(this.label21);
            Koma.駒.Add(this.label20);
            Koma.駒.Add(this.label19);
            Koma.駒.Add(this.label18);
            Koma.駒.Add(this.label17);
            Koma.駒.Add(this.label16);
            Koma.駒.Add(this.label15);
            Koma.駒.Add(this.label14);
            Koma.駒.Add(this.label13);
            Koma.駒.Add(this.label12);
            Koma.駒.Add(this.label11);
            Koma.駒.Add(this.label10);
            Koma.駒.Add(this.label9);
            Koma.駒.Add(this.label8);
            Koma.駒.Add(this.label7);
            Koma.駒.Add(this.label6);
            Koma.駒.Add(this.label5);
            Koma.駒.Add(this.label4);
            Koma.駒.Add(this.label3);
            Koma.駒.Add(this.label2);
            #endregion
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.Location = new System.Drawing.Point(168, 90);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(407, 462);
            this.mainPanel.TabIndex = 2;

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.玉);
            this.panel1.Controls.Add(this.金3);
            this.panel1.Controls.Add(this.金4);
            this.panel1.Controls.Add(this.銀4);
            this.panel1.Controls.Add(this.銀3);
            this.panel1.Controls.Add(this.香3);
            this.panel1.Controls.Add(this.桂3);
            this.panel1.Controls.Add(this.桂4);
            this.panel1.Controls.Add(this.香4);
            this.panel1.Controls.Add(this.label60);
            this.panel1.Controls.Add(this.label59);
            this.panel1.Controls.Add(this.label58);
            this.panel1.Controls.Add(this.飛2);
            this.panel1.Controls.Add(this.角2);
            this.panel1.Controls.Add(this.歩10);
            this.panel1.Controls.Add(this.歩11);
            this.panel1.Controls.Add(this.歩12);
            this.panel1.Controls.Add(this.歩13);
            this.panel1.Controls.Add(this.歩14);
            this.panel1.Controls.Add(this.歩15);
            this.panel1.Controls.Add(this.歩16);
            this.panel1.Controls.Add(this.歩17);
            this.panel1.Controls.Add(this.歩18);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.香2);
            this.panel1.Controls.Add(this.桂2);
            this.panel1.Controls.Add(this.銀2);
            this.panel1.Controls.Add(this.金2);
            this.panel1.Controls.Add(this.王);
            this.panel1.Controls.Add(this.金1);
            this.panel1.Controls.Add(this.銀1);
            this.panel1.Controls.Add(this.桂1);
            this.panel1.Controls.Add(this.香1);
            this.panel1.Controls.Add(this.角1);
            this.panel1.Controls.Add(this.飛1);
            this.panel1.Controls.Add(this.歩9);
            this.panel1.Controls.Add(this.歩8);
            this.panel1.Controls.Add(this.歩7);
            this.panel1.Controls.Add(this.歩6);
            this.panel1.Controls.Add(this.歩5);
            this.panel1.Controls.Add(this.歩4);
            this.panel1.Controls.Add(this.歩3);
            this.panel1.Controls.Add(this.歩1);
            this.panel1.Controls.Add(this.歩2);

            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);

            this.panel1.Location = new System.Drawing.Point(12, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 270);
            this.panel1.TabIndex = 5;

            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(5, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 100);
            this.panel2.TabIndex = 100;

            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Location = new System.Drawing.Point(323, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 100);
            this.panel3.TabIndex = 101;

            #region
            // 
            // titile
            // 
            float fontSize = 20f;
            titile.Font = new Font(titile.Font.OriginalFontName, fontSize);
            this.titile.BackColor = color.darkGreen;
            this.titile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titile.Location = new System.Drawing.Point(10, 10);
            this.titile.Margin = new System.Windows.Forms.Padding(1);
            this.titile.Name = "title";
            this.titile.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.titile.Size = new System.Drawing.Size(280, 40);
            this.titile.TabIndex = 150;
            this.titile.Text = "■■■将棋の時間■■■";

            // 
            // 玉
            // 
            this.玉.BackColor = color.darkGreen;
            this.玉.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.玉.Location = koma.伍one;
            this.玉.Margin = new System.Windows.Forms.Padding(1);
            this.玉.Name = "玉2敵";
            this.玉.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.玉.Size = new System.Drawing.Size(25, 25);
            this.玉.TabIndex = 89;
            this.玉.Text = "玉";
            this.玉.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 金3
            // 
            this.金3.BackColor = color.darkGreen;
            this.金3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.金3.Location = koma.六one;
            this.金3.Margin = new System.Windows.Forms.Padding(1);
            this.金3.Name = "金3敵";
            this.金3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.金3.Size = new System.Drawing.Size(25, 25);
            this.金3.TabIndex = 88;
            this.金3.Text = "金";
            this.金3.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 金4
            // 
            this.金4.BackColor = color.darkGreen;
            this.金4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.金4.Location = koma.四one;
            this.金4.Margin = new System.Windows.Forms.Padding(1);
            this.金4.Name = "金4敵";
            this.金4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.金4.Size = new System.Drawing.Size(25, 25);
            this.金4.TabIndex = 87;
            this.金4.Text = "金";
            this.金4.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 銀4
            // 
            this.銀4.BackColor = color.darkGreen;
            this.銀4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.銀4.Location = koma.参one;
            this.銀4.Margin = new System.Windows.Forms.Padding(1);
            this.銀4.Name = "銀4敵";
            this.銀4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.銀4.Size = new System.Drawing.Size(25, 25);
            this.銀4.TabIndex = 86;
            this.銀4.Text = "銀";
            this.銀4.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 銀3
            // 
            this.銀3.BackColor = color.darkGreen;
            this.銀3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.銀3.Location = koma.七one;
            this.銀3.Margin = new System.Windows.Forms.Padding(1);
            this.銀3.Name = "銀3敵";
            this.銀3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.銀3.Size = new System.Drawing.Size(25, 25);
            this.銀3.TabIndex = 85;
            this.銀3.Text = "銀";
            this.銀3.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 香3
            // 
            this.香3.BackColor = color.darkGreen;
            this.香3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.香3.Location = koma.壱one;
            this.香3.Margin = new System.Windows.Forms.Padding(1);
            this.香3.Name = "香3敵";
            this.香3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.香3.Size = new System.Drawing.Size(25, 25);
            this.香3.TabIndex = 84;
            this.香3.Text = "香";
            this.香3.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 桂3
            // 
            this.桂3.BackColor = color.darkGreen;
            this.桂3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.桂3.Location = koma.弐one;
            this.桂3.Margin = new System.Windows.Forms.Padding(1);
            this.桂3.Name = "桂3敵";
            this.桂3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.桂3.Size = new System.Drawing.Size(25, 25);
            this.桂3.TabIndex = 83;
            this.桂3.Text = "桂";
            this.桂3.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 桂4
            // 
            this.桂4.BackColor = color.darkGreen;
            this.桂4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.桂4.Location = koma.八one;
            this.桂4.Margin = new System.Windows.Forms.Padding(1);
            this.桂4.Name = "桂4敵";
            this.桂4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.桂4.Size = new System.Drawing.Size(25, 25);
            this.桂4.TabIndex = 82;
            this.桂4.Text = "桂";
            this.桂4.Click += new System.EventHandler(this.将棋_Click);

            // 
            // 香4
            // 
            this.香4.BackColor = color.darkGreen;
            this.香4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.香4.Location = koma.九one;
            this.香4.Margin = new System.Windows.Forms.Padding(1);
            this.香4.Name = "香4敵";
            this.香4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.香4.Size = new System.Drawing.Size(25, 25);
            this.香4.TabIndex = 81;
            this.香4.Text = "香";
            this.香4.Click += new System.EventHandler(this.将棋_Click);

            // 
            // label60
            // 
            this.label60.BackColor = color.paleGreen;
            this.label60.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label60.Location = koma.九two;
            this.label60.Margin = new System.Windows.Forms.Padding(1);
            this.label60.Name = "空白42";
            this.label60.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label60.Size = new System.Drawing.Size(25, 25);
            this.label60.TabIndex = 80;
            this.label60.Text = "□";
            this.label60.Click += new System.EventHandler(this.将棋_Click);

            // 
            // label59
            // 
            this.label59.BackColor = color.paleGreen;
            this.label59.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label59.Location = koma.七two;
            this.label59.Margin = new System.Windows.Forms.Padding(1);
            this.label59.Name = "空白40";
            this.label59.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label59.Size = new System.Drawing.Size(25, 25);
            this.label59.TabIndex = 79;
            this.label59.Text = "□";
            this.label59.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label58
            // 
            this.label58.BackColor = color.paleGreen;
            this.label58.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label58.Location = koma.六two;
            this.label58.Margin = new System.Windows.Forms.Padding(1);
            this.label58.Name = "空白41";
            this.label58.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label58.Size = new System.Drawing.Size(25, 25);
            this.label58.TabIndex = 78;
            this.label58.Text = "□";
            this.label58.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 飛2
            // 
            this.飛2.BackColor = color.darkGreen;
            this.飛2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.飛2.Location = koma.八two;
            this.飛2.Margin = new System.Windows.Forms.Padding(1);
            this.飛2.Name = "飛2敵";
            this.飛2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.飛2.Size = new System.Drawing.Size(25, 25);
            this.飛2.TabIndex = 69;
            this.飛2.Text = "飛";
            this.飛2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 角2
            // 
            this.角2.BackColor = color.darkGreen;
            this.角2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.角2.Location = koma.弐two;
            this.角2.Margin = new System.Windows.Forms.Padding(1);
            this.角2.Name = "角2敵";
            this.角2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.角2.Size = new System.Drawing.Size(25, 25);
            this.角2.TabIndex = 68;
            this.角2.Text = "角";
            this.角2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩10
            // 
            this.歩10.BackColor = color.darkGreen;
            this.歩10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩10.Location = koma.九thr;
            this.歩10.Margin = new System.Windows.Forms.Padding(1);
            this.歩10.Name = "歩1敵";
            this.歩10.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩10.Size = new System.Drawing.Size(25, 25);
            this.歩10.TabIndex = 67;
            this.歩10.Text = "歩";
            this.歩10.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩11
            // 
            this.歩11.BackColor = color.darkGreen;
            this.歩11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩11.Location = koma.八thr;
            this.歩11.Margin = new System.Windows.Forms.Padding(1);
            this.歩11.Name = "歩2敵";
            this.歩11.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩11.Size = new System.Drawing.Size(25, 25);
            this.歩11.TabIndex = 66;
            this.歩11.Text = "歩";
            this.歩11.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩12
            // 
            this.歩12.BackColor = color.darkGreen;
            this.歩12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩12.Location = koma.七thr;
            this.歩12.Margin = new System.Windows.Forms.Padding(1);
            this.歩12.Name = "歩3敵";
            this.歩12.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩12.Size = new System.Drawing.Size(25, 25);
            this.歩12.TabIndex = 65;
            this.歩12.Text = "歩";
            this.歩12.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩13
            // 
            this.歩13.BackColor = color.darkGreen;
            this.歩13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩13.Location = koma.六thr;
            this.歩13.Margin = new System.Windows.Forms.Padding(1);
            this.歩13.Name = "歩4敵";
            this.歩13.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩13.Size = new System.Drawing.Size(25, 25);
            this.歩13.TabIndex = 64;
            this.歩13.Text = "歩";
            this.歩13.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩14
            // 
            this.歩14.BackColor = color.darkGreen;
            this.歩14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩14.Location = koma.伍thr;
            this.歩14.Margin = new System.Windows.Forms.Padding(1);
            this.歩14.Name = "歩5敵";
            this.歩14.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩14.Size = new System.Drawing.Size(25, 25);
            this.歩14.TabIndex = 63;
            this.歩14.Text = "歩";
            this.歩14.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩15
            // 
            this.歩15.BackColor = color.darkGreen;
            this.歩15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩15.Location = koma.四thr;
            this.歩15.Margin = new System.Windows.Forms.Padding(1);
            this.歩15.Name = "歩6敵";
            this.歩15.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩15.Size = new System.Drawing.Size(25, 25);
            this.歩15.TabIndex = 62;
            this.歩15.Text = "歩";
            this.歩15.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩16
            // 
            this.歩16.BackColor = color.darkGreen;
            this.歩16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩16.Location = koma.参thr;
            this.歩16.Margin = new System.Windows.Forms.Padding(1);
            this.歩16.Name = "歩7敵";
            this.歩16.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩16.Size = new System.Drawing.Size(25, 25);
            this.歩16.TabIndex = 61;
            this.歩16.Text = "歩";
            this.歩16.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩17
            // 
            this.歩17.BackColor = color.darkGreen;
            this.歩17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩17.Location = koma.弐thr;
            this.歩17.Margin = new System.Windows.Forms.Padding(1);
            this.歩17.Name = "歩8敵";
            this.歩17.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩17.Size = new System.Drawing.Size(25, 25);
            this.歩17.TabIndex = 60;
            this.歩17.Text = "歩";
            this.歩17.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩18
            // 
            this.歩18.BackColor = color.darkGreen;
            this.歩18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩18.Location = koma.壱thr;
            this.歩18.Margin = new System.Windows.Forms.Padding(1);
            this.歩18.Name = "歩9敵";
            this.歩18.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩18.Size = new System.Drawing.Size(25, 25);
            this.歩18.TabIndex = 59;
            this.歩18.Text = "歩";
            this.歩18.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label40
            // 
            this.label40.BackColor = color.paleGreen;
            this.label40.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label40.Location = koma.伍two;
            this.label40.Margin = new System.Windows.Forms.Padding(1);
            this.label40.Name = "空白1";
            this.label40.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label40.Size = new System.Drawing.Size(25, 25);
            this.label40.TabIndex = 57;
            this.label40.Text = "□";
            this.label40.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label38
            // 
            this.label38.BackColor = color.paleGreen;
            this.label38.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label38.Location = koma.四two;
            this.label38.Margin = new System.Windows.Forms.Padding(1);
            this.label38.Name = "空白2";
            this.label38.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label38.Size = new System.Drawing.Size(25, 25);
            this.label38.TabIndex = 55;
            this.label38.Text = "□";
            this.label38.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label37
            // 
            this.label37.BackColor = color.paleGreen;
            this.label37.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label37.Location = koma.参two;
            this.label37.Margin = new System.Windows.Forms.Padding(1);
            this.label37.Name = "空白3";
            this.label37.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label37.Size = new System.Drawing.Size(25, 25);
            this.label37.TabIndex = 54;
            this.label37.Text = "□";
            this.label37.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label36
            // 
            this.label36.BackColor = color.paleGreen;
            this.label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label36.Location = koma.壱two;
            this.label36.Margin = new System.Windows.Forms.Padding(1);
            this.label36.Name = "空白4";
            this.label36.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label36.Size = new System.Drawing.Size(25, 25);
            this.label36.TabIndex = 53;
            this.label36.Text = "□";
            this.label36.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label35
            // 
            this.label35.BackColor = color.paleGreen;
            this.label35.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label35.Location = koma.九fou;
            this.label35.Margin = new System.Windows.Forms.Padding(1);
            this.label35.Name = "空白5";
            this.label35.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label35.Size = new System.Drawing.Size(25, 25);
            this.label35.TabIndex = 52;
            this.label35.Text = "□";
            this.label35.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label34
            // 
            this.label34.BackColor = color.paleGreen;
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label34.Location = koma.八fou;
            this.label34.Margin = new System.Windows.Forms.Padding(1);
            this.label34.Name = "空白6";
            this.label34.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label34.Size = new System.Drawing.Size(25, 25);
            this.label34.TabIndex = 51;
            this.label34.Text = "□";
            this.label34.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label33
            // 
            this.label33.BackColor = color.paleGreen;
            this.label33.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label33.Location = koma.七fou;
            this.label33.Margin = new System.Windows.Forms.Padding(1);
            this.label33.Name = "空白7";
            this.label33.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label33.Size = new System.Drawing.Size(25, 25);
            this.label33.TabIndex = 50;
            this.label33.Text = "□";
            this.label33.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label32
            // 
            this.label32.BackColor = color.paleGreen;
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label32.Location = koma.六fou;
            this.label32.Margin = new System.Windows.Forms.Padding(1);
            this.label32.Name = "空白8";
            this.label32.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label32.Size = new System.Drawing.Size(25, 25);
            this.label32.TabIndex = 49;
            this.label32.Text = "□";
            this.label32.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label31
            // 
            this.label31.BackColor = color.paleGreen;
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = koma.伍fou;
            this.label31.Margin = new System.Windows.Forms.Padding(1);
            this.label31.Name = "空白9";
            this.label31.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label31.Size = new System.Drawing.Size(25, 25);
            this.label31.TabIndex = 48;
            this.label31.Text = "□";
            this.label31.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label30
            // 
            this.label30.BackColor = color.paleGreen;
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label30.Location = koma.四fou;
            this.label30.Margin = new System.Windows.Forms.Padding(1);
            this.label30.Name = "空白10";
            this.label30.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label30.Size = new System.Drawing.Size(25, 25);
            this.label30.TabIndex = 47;
            this.label30.Text = "□";
            this.label30.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label29
            // 
            this.label29.BackColor = color.paleGreen;
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = koma.参fou;
            this.label29.Margin = new System.Windows.Forms.Padding(1);
            this.label29.Name = "空白11";
            this.label29.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label29.Size = new System.Drawing.Size(25, 25);
            this.label29.TabIndex = 46;
            this.label29.Text = "□";
            this.label29.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label28
            // 
            this.label28.BackColor = color.paleGreen;
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = koma.弐fou;
            this.label28.Margin = new System.Windows.Forms.Padding(1);
            this.label28.Name = "空白12";
            this.label28.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label28.Size = new System.Drawing.Size(25, 25);
            this.label28.TabIndex = 45;
            this.label28.Text = "□";
            this.label28.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label27
            // 
            this.label27.BackColor = color.paleGreen;
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = koma.壱fou;
            this.label27.Margin = new System.Windows.Forms.Padding(1);
            this.label27.Name = "空白13";
            this.label27.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label27.Size = new System.Drawing.Size(25, 25);
            this.label27.TabIndex = 44;
            this.label27.Text = "□";
            this.label27.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label26
            // 
            this.label26.BackColor = color.paleGreen;
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = koma.九fiv;
            this.label26.Margin = new System.Windows.Forms.Padding(1);
            this.label26.Name = "空白14";
            this.label26.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label26.Size = new System.Drawing.Size(25, 25);
            this.label26.TabIndex = 43;
            this.label26.Text = "□";
            this.label26.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label25
            // 
            this.label25.BackColor = color.paleGreen;
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = koma.八fiv;
            this.label25.Margin = new System.Windows.Forms.Padding(1);
            this.label25.Name = "空白15";
            this.label25.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label25.Size = new System.Drawing.Size(25, 25);
            this.label25.TabIndex = 42;
            this.label25.Text = "□";
            this.label25.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label24
            // 
            this.label24.BackColor = color.paleGreen;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = koma.七fiv;
            this.label24.Margin = new System.Windows.Forms.Padding(1);
            this.label24.Name = "空白16";
            this.label24.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label24.Size = new System.Drawing.Size(25, 25);
            this.label24.TabIndex = 41;
            this.label24.Text = "□";
            this.label24.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label23
            // 
            this.label23.BackColor = color.paleGreen;
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = koma.六fiv;
            this.label23.Margin = new System.Windows.Forms.Padding(1);
            this.label23.Name = "空白17";
            this.label23.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label23.Size = new System.Drawing.Size(25, 25);
            this.label23.TabIndex = 40;
            this.label23.Text = "□";
            this.label23.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label22
            // 
            this.label22.BackColor = color.paleGreen;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = koma.伍fiv;
            this.label22.Margin = new System.Windows.Forms.Padding(1);
            this.label22.Name = "空白18";
            this.label22.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label22.Size = new System.Drawing.Size(25, 25);
            this.label22.TabIndex = 39;
            this.label22.Text = "□";
            this.label22.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label21
            // 
            this.label21.BackColor = color.paleGreen;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = koma.四fiv;
            this.label21.Margin = new System.Windows.Forms.Padding(1);
            this.label21.Name = "空白19";
            this.label21.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label21.Size = new System.Drawing.Size(25, 25);
            this.label21.TabIndex = 38;
            this.label21.Text = "□";
            this.label21.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label20
            // 
            this.label20.BackColor = color.paleGreen;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = koma.参fiv;
            this.label20.Margin = new System.Windows.Forms.Padding(1);
            this.label20.Name = "空白20";
            this.label20.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label20.Size = new System.Drawing.Size(25, 25);
            this.label20.TabIndex = 37;
            this.label20.Text = "□";
            this.label20.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label19
            // 
            this.label19.BackColor = color.paleGreen;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = koma.弐fiv;
            this.label19.Margin = new System.Windows.Forms.Padding(1);
            this.label19.Name = "空白21";
            this.label19.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label19.Size = new System.Drawing.Size(25, 25);
            this.label19.TabIndex = 36;
            this.label19.Text = "□";
            this.label19.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label18
            // 
            this.label18.BackColor = color.paleGreen;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = koma.壱fiv;
            this.label18.Margin = new System.Windows.Forms.Padding(1);
            this.label18.Name = "空白22";
            this.label18.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label18.Size = new System.Drawing.Size(25, 25);
            this.label18.TabIndex = 35;
            this.label18.Text = "□";
            this.label18.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label17
            // 
            this.label17.BackColor = color.paleGreen;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = koma.九six;
            this.label17.Margin = new System.Windows.Forms.Padding(1);
            this.label17.Name = "空白23";
            this.label17.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label17.Size = new System.Drawing.Size(25, 25);
            this.label17.TabIndex = 34;
            this.label17.Text = "□";
            this.label17.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label16
            // 
            this.label16.BackColor = color.paleGreen;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = koma.八six;
            this.label16.Margin = new System.Windows.Forms.Padding(1);
            this.label16.Name = "空白24";
            this.label16.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label16.Size = new System.Drawing.Size(25, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "□";
            this.label16.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label15
            // 
            this.label15.BackColor = color.paleGreen;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = koma.七six;
            this.label15.Margin = new System.Windows.Forms.Padding(1);
            this.label15.Name = "空白25";
            this.label15.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label15.Size = new System.Drawing.Size(25, 25);
            this.label15.TabIndex = 32;
            this.label15.Text = "□";
            this.label15.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label14
            // 
            this.label14.BackColor = color.paleGreen;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = koma.六six;
            this.label14.Margin = new System.Windows.Forms.Padding(1);
            this.label14.Name = "空白26";
            this.label14.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label14.Size = new System.Drawing.Size(25, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "□";
            this.label14.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label13
            // 
            this.label13.BackColor = color.paleGreen;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = koma.伍six;
            this.label13.Margin = new System.Windows.Forms.Padding(1);
            this.label13.Name = "空白27";
            this.label13.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label13.Size = new System.Drawing.Size(25, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "□";
            this.label13.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label12
            // 
            this.label12.BackColor = color.paleGreen;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = koma.四six;
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "空白28";
            this.label12.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label12.Size = new System.Drawing.Size(25, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "□";
            this.label12.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label11
            // 
            this.label11.BackColor = color.paleGreen;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = koma.参six;
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "空白29";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label11.Size = new System.Drawing.Size(25, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "□";
            this.label11.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label10
            // 
            this.label10.BackColor = color.paleGreen;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = koma.弐six;
            this.label10.Margin = new System.Windows.Forms.Padding(1);
            this.label10.Name = "空白30";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label10.Size = new System.Drawing.Size(25, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "□";
            this.label10.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label9
            // 
            this.label9.BackColor = color.paleGreen;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = koma.壱six;
            this.label9.Margin = new System.Windows.Forms.Padding(1);
            this.label9.Name = "空白31";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label9.Size = new System.Drawing.Size(25, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "□";
            this.label9.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label8
            // 
            this.label8.BackColor = color.paleGreen;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = koma.九eig;
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "空白32";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(25, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "□";
            this.label8.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label7
            // 
            this.label7.BackColor = color.paleGreen;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = koma.七eig;
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "空白33";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "□";
            this.label7.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label6
            // 
            this.label6.BackColor = color.paleGreen;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = koma.六eig;
            this.label6.Margin = new System.Windows.Forms.Padding(1);
            this.label6.Name = "空白34";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "□";
            this.label6.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label5
            // 
            this.label5.BackColor = color.paleGreen;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = koma.伍eig;
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "空白35";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "□";
            this.label5.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label4
            // 
            this.label4.BackColor = color.paleGreen;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = koma.四eig;
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "空白36";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "□";
            this.label4.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label3
            // 
            this.label3.BackColor = color.paleGreen;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = koma.参eig;
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "空白37";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "□";
            this.label3.Click += new System.EventHandler(this.将棋_Click);
            // 
            // label2
            // 
            this.label2.BackColor = color.paleGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = koma.壱eig;
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "空白38";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "□";
            this.label2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 香2
            // 
            this.香2.BackColor = color.darkGreen;
            this.香2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.香2.Location = koma.壱nin;
            this.香2.Margin = new System.Windows.Forms.Padding(1);
            this.香2.Name = "香2味";
            this.香2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.香2.Size = new System.Drawing.Size(25, 25);
            this.香2.TabIndex = 18;
            this.香2.Text = "香";
            this.香2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 桂2
            // 
            this.桂2.BackColor = color.darkGreen;
            this.桂2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.桂2.Location = koma.弐nin;
            this.桂2.Margin = new System.Windows.Forms.Padding(1);
            this.桂2.Name = "桂2味";
            this.桂2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.桂2.Size = new System.Drawing.Size(25, 25);
            this.桂2.TabIndex = 17;
            this.桂2.Text = "桂";
            this.桂2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 銀2
            // 
            this.銀2.BackColor = color.darkGreen;
            this.銀2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.銀2.Location = koma.参nin;
            this.銀2.Margin = new System.Windows.Forms.Padding(1);
            this.銀2.Name = "銀2味";
            this.銀2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.銀2.Size = new System.Drawing.Size(25, 25);
            this.銀2.TabIndex = 16;
            this.銀2.Text = "銀";
            this.銀2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 金2
            // 
            this.金2.BackColor = color.darkGreen;
            this.金2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.金2.Location = koma.四nin;
            this.金2.Margin = new System.Windows.Forms.Padding(1);
            this.金2.Name = "金2味";
            this.金2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.金2.Size = new System.Drawing.Size(25, 25);
            this.金2.TabIndex = 15;
            this.金2.Text = "金";
            this.金2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 王
            // 
            this.王.BackColor = color.darkGreen;
            this.王.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.王.Location = koma.伍nin;
            this.王.Margin = new System.Windows.Forms.Padding(1);
            this.王.Name = "王1味";
            this.王.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.王.Size = new System.Drawing.Size(25, 25);
            this.王.TabIndex = 14;
            this.王.Text = "王";
            this.王.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 金1
            // 
            this.金1.BackColor = color.darkGreen;
            this.金1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.金1.Location = koma.六nin;
            this.金1.Margin = new System.Windows.Forms.Padding(1);
            this.金1.Name = "金1味";
            this.金1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.金1.Size = new System.Drawing.Size(25, 25);
            this.金1.TabIndex = 13;
            this.金1.Text = "金";
            this.金1.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 銀1
            // 
            this.銀1.BackColor = color.darkGreen;
            this.銀1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.銀1.Location = koma.七nin;
            this.銀1.Margin = new System.Windows.Forms.Padding(1);
            this.銀1.Name = "銀1味";
            this.銀1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.銀1.Size = new System.Drawing.Size(25, 25);
            this.銀1.TabIndex = 12;
            this.銀1.Text = "銀";
            this.銀1.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 桂1
            // 
            this.桂1.BackColor = color.darkGreen;
            this.桂1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.桂1.Location = koma.八nin;
            this.桂1.Margin = new System.Windows.Forms.Padding(1);
            this.桂1.Name = "桂1味";
            this.桂1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.桂1.Size = new System.Drawing.Size(25, 25);
            this.桂1.TabIndex = 11;
            this.桂1.Text = "桂";
            this.桂1.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 香1
            // 
            this.香1.BackColor = color.darkGreen;
            this.香1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.香1.Location = koma.九nin;
            this.香1.Margin = new System.Windows.Forms.Padding(1);
            this.香1.Name = "香1味";
            this.香1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.香1.Size = new System.Drawing.Size(25, 25);
            this.香1.TabIndex = 10;
            this.香1.Text = "香";
            this.香1.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 角1
            // 
            this.角1.BackColor = color.darkGreen;
            this.角1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.角1.Location = koma.八eig;
            this.角1.Margin = new System.Windows.Forms.Padding(1);
            this.角1.Name = "角1味";
            this.角1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.角1.Size = new System.Drawing.Size(25, 25);
            this.角1.TabIndex = 9;
            this.角1.Text = "角";
            this.角1.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 飛1
            // 
            this.飛1.BackColor = color.darkGreen;
            this.飛1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.飛1.Location = koma.弐eig;
            this.飛1.Margin = new System.Windows.Forms.Padding(1);
            this.飛1.Name = "飛1味";
            this.飛1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.飛1.Size = new System.Drawing.Size(25, 25);
            this.飛1.TabIndex = 8;
            this.飛1.Text = "飛";
            this.飛1.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩9
            // 
            this.歩9.BackColor = color.darkGreen;
            this.歩9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩9.Location = koma.壱sev;
            this.歩9.Margin = new System.Windows.Forms.Padding(1);
            this.歩9.Name = "歩9味";
            this.歩9.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩9.Size = new System.Drawing.Size(25, 25);
            this.歩9.TabIndex = 7;
            this.歩9.Text = "歩";
            this.歩9.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩8
            // 
            this.歩8.BackColor = color.darkGreen;
            this.歩8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩8.Location = koma.弐sev;
            this.歩8.Margin = new System.Windows.Forms.Padding(1);
            this.歩8.Name = "歩8味";
            this.歩8.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩8.Size = new System.Drawing.Size(25, 25);
            this.歩8.TabIndex = 6;
            this.歩8.Text = "歩";
            this.歩8.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩7
            // 
            this.歩7.BackColor = color.darkGreen;
            this.歩7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩7.Location = koma.参sev;
            this.歩7.Margin = new System.Windows.Forms.Padding(1);
            this.歩7.Name = "歩7味";
            this.歩7.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩7.Size = new System.Drawing.Size(25, 25);
            this.歩7.TabIndex = 5;
            this.歩7.Text = "歩";
            this.歩7.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩6
            // 
            this.歩6.BackColor = color.darkGreen;
            this.歩6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩6.Location = koma.四sev;
            this.歩6.Margin = new System.Windows.Forms.Padding(1);
            this.歩6.Name = "歩6味";
            this.歩6.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩6.Size = new System.Drawing.Size(25, 25);
            this.歩6.TabIndex = 4;
            this.歩6.Text = "歩";
            this.歩6.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩5
            // 
            this.歩5.BackColor = color.darkGreen;
            this.歩5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩5.Location = koma.伍sev;
            this.歩5.Margin = new System.Windows.Forms.Padding(1);
            this.歩5.Name = "歩5味";
            this.歩5.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩5.Size = new System.Drawing.Size(25, 25);
            this.歩5.TabIndex = 3;
            this.歩5.Text = "歩";
            this.歩5.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩4
            // 
            this.歩4.BackColor = color.darkGreen;
            this.歩4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩4.Location = koma.六sev;
            this.歩4.Margin = new System.Windows.Forms.Padding(1);
            this.歩4.Name = "歩4味";
            this.歩4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩4.Size = new System.Drawing.Size(25, 25);
            this.歩4.TabIndex = 2;
            this.歩4.Text = "歩";
            this.歩4.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩3
            // 
            this.歩3.BackColor = color.darkGreen;
            this.歩3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩3.Location = koma.七sev;
            this.歩3.Margin = new System.Windows.Forms.Padding(1);
            this.歩3.Name = "歩3味";
            this.歩3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩3.Size = new System.Drawing.Size(25, 25);
            this.歩3.TabIndex = 1;
            this.歩3.Text = "歩";
            this.歩3.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩2
            // 
            this.歩2.BackColor = color.darkGreen;
            this.歩2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩2.Location = koma.八sev;
            this.歩2.Margin = new System.Windows.Forms.Padding(1);
            this.歩2.Name = "歩2味";
            this.歩2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩2.Size = new System.Drawing.Size(25, 25);
            this.歩2.TabIndex = 0;
            this.歩2.Text = "歩";
            this.歩2.Click += new System.EventHandler(this.将棋_Click);
            // 
            // 歩1
            // 
            this.歩1.BackColor = color.darkGreen;
            this.歩1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.歩1.Location = koma.九sev;
            this.歩1.Margin = new System.Windows.Forms.Padding(1);
            this.歩1.Name = "歩1味";
            this.歩1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.歩1.Size = new System.Drawing.Size(25, 25);
            this.歩1.TabIndex = 0;
            this.歩1.Text = "歩";
            this.歩1.Click += new System.EventHandler(this.将棋_Click);

            #endregion

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titile);
            //■this.Controls.Add(this.button1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        #region　インスタンス
        private System.Windows.Forms.Panel mainPanel;
        //■private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label 歩1;
        private System.Windows.Forms.Label 歩2;
        private System.Windows.Forms.Label 歩9;
        private System.Windows.Forms.Label 歩8;
        private System.Windows.Forms.Label 歩7;
        private System.Windows.Forms.Label 歩6;
        private System.Windows.Forms.Label 歩5;
        private System.Windows.Forms.Label 歩4;
        private System.Windows.Forms.Label 歩3;
        private System.Windows.Forms.Label 香2;
        private System.Windows.Forms.Label 桂2;
        private System.Windows.Forms.Label 銀2;
        private System.Windows.Forms.Label 金2;
        private System.Windows.Forms.Label 王;
        private System.Windows.Forms.Label 金1;
        private System.Windows.Forms.Label 銀1;
        private System.Windows.Forms.Label 桂1;
        private System.Windows.Forms.Label 香1;
        private System.Windows.Forms.Label 角1;
        private System.Windows.Forms.Label 飛1;
        private System.Windows.Forms.Label 飛2;
        private System.Windows.Forms.Label 角2;
        private System.Windows.Forms.Label 歩10;
        private System.Windows.Forms.Label 歩11;
        private System.Windows.Forms.Label 歩12;
        private System.Windows.Forms.Label 歩13;
        private System.Windows.Forms.Label 歩14;
        private System.Windows.Forms.Label 歩15;
        private System.Windows.Forms.Label 歩16;
        private System.Windows.Forms.Label 歩17;
        private System.Windows.Forms.Label 歩18;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 玉;
        private System.Windows.Forms.Label 金3;
        private System.Windows.Forms.Label 金4;
        private System.Windows.Forms.Label 銀4;
        private System.Windows.Forms.Label 銀3;
        private System.Windows.Forms.Label 香3;
        private System.Windows.Forms.Label 桂3;
        private System.Windows.Forms.Label 桂4;
        private System.Windows.Forms.Label 香4;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        #endregion
    }
}

