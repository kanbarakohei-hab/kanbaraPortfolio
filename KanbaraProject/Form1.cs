using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbaraProject
{
    public partial class Form1 : Form
    {
        //クラス変数を定義
        //変数名を英語に変える
        Koma koma2 = new Koma();
        public static int countX = 0;
        public static int countY = 0;
        public static int countZ = 0;
        public static int 判定A;
        public static bool 判定B = false;
        KomaColor color = new KomaColor();
        public Form1()
        {
            //駒を生成するメソッド(修正必要)
            InitializeComponent();
        }
        //現在不要
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //現在不要(ページロード時に呼ばれる関数)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //駒(空白を含む)をクリック時に呼ばれる関数
        //参照「81個」になっていればOK
        //関数名を英語に変える
        private void 将棋_Click(object sender, EventArgs e)
        {
            try
            {
                //名前が味方か空白のとき
                #region 味方選択
                if (判定A == 0)
                {
                    //情報を渡すために使う
                    koma2.駒情報A = ((Label)sender);
                    Koma.文字 = (((Label)sender).Text);
                    //Koma.インデックス = (((Label)sender).TabIndex);
                    Koma.色A = (((Label)sender).ForeColor);
                    Koma.色B = (((Label)sender).BackColor);
                    Koma.名前 = (((Label)sender).Name);

                    // 空白か敵の駒を押しても何もせずに返却する
                    if (((Label)sender).Name.IndexOf("空白") == 0 || (((Label)sender).Name.IndexOf("敵") == 2))
                    {
                        return;
                    }
                    #region 押したら色変更
                    //押したラベルが濃い色
                    //空白はチョコレート(76, 173, 116)
                    //それ以外のラベルが深桃色になる
                    foreach (Label str in Koma.駒)
                    {
                        //
                        if (str.Name == ((Label)sender).Name)
                        {
                            str.BackColor = System.Drawing.Color.FromArgb(110, 96, 10);// 濃い色
                        }
                        else if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = System.Drawing.Color.FromArgb(76, 173, 116);// チョコレート
                        }
                        else
                        {
                            str.BackColor = System.Drawing.Color.FromArgb(0, 70, 56);// 深桃色
                        }
                    }
                    #endregion

                    //名前が歩の場合、歩の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("歩") == 0)
                    {
                        Logic.hoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が香の場合、香の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("香") == 0)
                    {
                        Logic.kyoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が桂の場合、桂の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("桂") == 0)
                    {
                        Logic.keimaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が銀の場合、銀の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("銀") == 0)
                    {
                        Logic.ginLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が金の場合、金の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("金") == 0)
                    {
                        Logic.kinLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が王の場合、王の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("王") == 0)
                    {
                        Logic.ouLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が飛車の場合、飛車の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("飛") == 0)
                    {
                        Logic.hisyaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が角の場合、角の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("角") == 0)
                    {
                        Logic.kakuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    判定A = 1;
                    return;
                }
                #endregion

                #region 移動
                if (判定A == 1)
                {
                    //色が変化していないならreturn(移動できる場所以外かつ移動させる駒以外)
                    if (((Label)sender).BackColor != System.Drawing.Color.FromArgb(128, 203, 196) 
                        && ((Label)sender).BackColor != System.Drawing.Color.FromArgb(110, 96, 10))
                    {
                        return;
                    }
                    //移動させる駒なら
                    if (((Label)sender).BackColor == System.Drawing.Color.FromArgb(110, 96, 10))
                    {
                        //色を元に戻して、判定Aに0を入れてreturn
                        foreach (Label str in Koma.駒)
                        {
                            if (str.Name.IndexOf("空白") == 0)
                            {
                                str.BackColor = color.paleGreen;
                            }
                            //それ以外の場合
                            else
                            {
                                str.BackColor = color.darkGreen;
                            }
                        }
                        判定A = 0;
                        return;
                    }

                    foreach (Label str in Koma.駒)
                    {
                        //ラベルの色を変化させる
                        //空白の場合
                        if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.paleGreen;
                        }
                        //それ以外の場合
                        else
                        {
                            str.BackColor = color.darkGreen;
                        }
                    }
                    foreach (Label str in Koma.駒)
                    {
                        if ((koma2.駒情報A.Location) == (str.Location))
                        {
                            str.BackColor = color.paleGreen;
                            str.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                            str.Margin = new System.Windows.Forms.Padding(1);
                            str.Name = "空白" + ((50 + countZ).ToString());
                            str.Text = "□";
                            //str.Click += new System.EventHandler(this.将棋_Click);
                            str.Visible = true;
                        }
                        if (((Point)((Label)sender).Location) == ((Point)str.Location))
                        {
                            str.BackColor = Koma.色B;
                            str.ForeColor = Koma.色A;
                            //str.Margin = (Padding)Koma.駒情報B.Margin;
                            str.Name = Koma.名前;
                            //str.Padding = (Padding)Koma.駒情報B.Padding;
                            //str.Size = (Size)Koma.駒情報B.Size;
                            str.Text = Koma.文字;
                            //str.Click += new System.EventHandler(this.将棋_Click);
                            str.Visible = true;
                        }
                    }

                    判定A = 2;
                    return;
                }
                #endregion

                //名前が敵か空白のとき時

                #region 敵選択
                if (判定A == 2)
                {
                    //情報を渡すために使う
                    koma2.駒情報A = ((Label)sender);
                    Koma.文字 = (((Label)sender).Text);
                    //Koma.インデックス = (((Label)sender).TabIndex);
                    Koma.色A = (((Label)sender).ForeColor);
                    Koma.色B = (((Label)sender).BackColor);
                    Koma.名前 = (((Label)sender).Name);
                    if (((Label)sender).Name.IndexOf("空白") == 0 || (((Label)sender).Name.IndexOf("味") == 2))
                    {
                        return;
                    }

                    #region 押したら色変更
                    //押したラベルが黒
                    //空白はチョコレート
                    //それ以外のラベルが深桃色になる
                    foreach (Label str in Koma.駒)
                    {
                        if (str.Name == ((Label)sender).Name)
                        {
                            str.BackColor = System.Drawing.Color.FromArgb(110, 96, 10);
                        }
                        else if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = System.Drawing.Color.FromArgb(76, 173, 116);
                        }
                        else
                        {
                            str.BackColor = System.Drawing.Color.FromArgb(0, 70, 56);
                        }
                    }
                    #endregion

                    //歩の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("歩") == 0)
                    {
                        Logic2.hoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //香の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("香") == 0)
                    {
                        Logic2.kyoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //桂の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("桂") == 0)
                    {
                        Logic2.keimaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //銀の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("銀") == 0)
                    {
                        Logic2.ginLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //金の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("金") == 0)
                    {
                        Logic2.kinLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //王の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("玉") == 0)
                    {
                        Logic2.gyokuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //飛車の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("飛") == 0)
                    {
                        Logic2.hisyaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //角の移動できる場所を色変換
                    if (((Label)sender).Name.IndexOf("角") == 0)
                    {
                        Logic2.kakuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    判定A = 3;
                    return;
                }
                #endregion

                #region 移動
                if (判定A == 3)
                {
                    //白黒じゃないならreturn
                    if (((Label)sender).BackColor != System.Drawing.Color.FromArgb(128, 203, 196) && ((Label)sender).BackColor != System.Drawing.Color.FromArgb(110, 96, 10))
                    {
                        return;
                    }
                    //移動させる駒なら
                    if (((Label)sender).BackColor == System.Drawing.Color.FromArgb(110, 96, 10))
                    {
                        //色を元に戻して、判定Aに2を入れてreturn
                        foreach (Label str in Koma.駒)
                        {
                            if (str.Name.IndexOf("空白") == 0)
                            {
                                str.BackColor = color.paleGreen;
                            }
                            //それ以外の場合
                            else
                            {
                                str.BackColor = color.darkGreen;
                            }
                        }
                        判定A = 2;
                        return;
                    }
                    foreach (Label str in Koma.駒)
                    {
                        //ラベルの色を初期化する
                        if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.paleGreen;
                        }
                        else
                        {
                            str.BackColor = color.darkGreen;
                        }
                    }
                    foreach (Label str in Koma.駒)
                    {
                        if ((koma2.駒情報A.Location) == (str.Location))
                        {
                            str.BackColor = color.paleGreen;
                            str.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                            str.Margin = new System.Windows.Forms.Padding(1);
                            str.Name = "空白" + ((50 + countZ).ToString());
                            str.Text = "□";
                            //str.Click += new System.EventHandler(this.将棋_Click);
                            str.Visible = true;
                        }
                        if (((Point)((Label)sender).Location) == ((Point)str.Location))
                        {
                            str.BackColor = Koma.色B;
                            str.ForeColor = Koma.色A;
                            //str.Margin = (Padding)Koma.駒情報B.Margin;
                            str.Name = Koma.名前;
                            //str.Padding = (Padding)Koma.駒情報B.Padding;
                            //str.Size = (Size)Koma.駒情報B.Size;
                            str.Text = Koma.文字;
                            //str.Click += new System.EventHandler(this.将棋_Click);
                            str.Visible = true;
                        }
                    }
                    判定A = 0;
                    return;
                }
                #endregion

            }
            catch { }
            finally { countZ++; }
        }
    }
}
