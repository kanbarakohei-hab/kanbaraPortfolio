using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbaraProject
{
    public class Koma
    {

        public Label 駒情報A { get; set; }

        public static Label 駒情報B { get; set; }

        public static Point 位置 { get; set; }
        public static Color 色A { get; set; }
        public static Color 色B { get; set; }
        public static Label マージン { get; set; }
        public static string 名前 { get; set; }
        public static Label パディング { get; set; }
        public static Label サイズ { get; set; }
        public static int インデックス { get; set; }
        public static string 文字 { get; set; }

        public const bool 味方 = true;
        public const bool 敵 = false;

        const int 定数 = 17;
        const int 定数2 = 27;
        public const int one = 定数;
        public const int two = 定数 + (定数2 * 1);
        public const int thr = 定数 + (定数2 * 2);
        public const int fou = 定数 + (定数2 * 3);
        public const int fiv = 定数 + (定数2 * 4);
        public const int six = 定数 + (定数2 * 5);
        public const int sev = 定数 + (定数2 * 6);
        public const int eig = 定数 + (定数2 * 7);
        public const int nin = 定数 + (定数2 * 8);

        const int 横定数 = 73;
        public const int 壱 = 横定数 + (定数2 * 8);
        public const int 弐 = 横定数 + (定数2 * 7);
        public const int 参 = 横定数 + (定数2 * 6);
        public const int 四 = 横定数 + (定数2 * 5);
        public const int 伍 = 横定数 + (定数2 * 4);
        public const int 六 = 横定数 + (定数2 * 3);
        public const int 七 = 横定数 + (定数2 * 2);
        public const int 八 = 横定数 + (定数2 * 1);
        public const int 九 = 横定数;

        public System.Drawing.Point 壱one = new System.Drawing.Point(壱, one);
        public System.Drawing.Point 壱two = new System.Drawing.Point(壱, two);
        public System.Drawing.Point 壱thr = new System.Drawing.Point(壱, thr);
        public System.Drawing.Point 壱fou = new System.Drawing.Point(壱, fou);
        public System.Drawing.Point 壱fiv = new System.Drawing.Point(壱, fiv);
        public System.Drawing.Point 壱six = new System.Drawing.Point(壱, six);
        public System.Drawing.Point 壱sev = new System.Drawing.Point(壱, sev);
        public System.Drawing.Point 壱eig = new System.Drawing.Point(壱, eig);
        public System.Drawing.Point 壱nin = new System.Drawing.Point(壱, nin);

        public System.Drawing.Point 弐one = new System.Drawing.Point(弐, one);
        public System.Drawing.Point 弐two = new System.Drawing.Point(弐, two);
        public System.Drawing.Point 弐thr = new System.Drawing.Point(弐, thr);
        public System.Drawing.Point 弐fou = new System.Drawing.Point(弐, fou);
        public System.Drawing.Point 弐fiv = new System.Drawing.Point(弐, fiv);
        public System.Drawing.Point 弐six = new System.Drawing.Point(弐, six);
        public System.Drawing.Point 弐sev = new System.Drawing.Point(弐, sev);
        public System.Drawing.Point 弐eig = new System.Drawing.Point(弐, eig);
        public System.Drawing.Point 弐nin = new System.Drawing.Point(弐, nin);

        public System.Drawing.Point 参one = new System.Drawing.Point(参, one);
        public System.Drawing.Point 参two = new System.Drawing.Point(参, two);
        public System.Drawing.Point 参thr = new System.Drawing.Point(参, thr);
        public System.Drawing.Point 参fou = new System.Drawing.Point(参, fou);
        public System.Drawing.Point 参fiv = new System.Drawing.Point(参, fiv);
        public System.Drawing.Point 参six = new System.Drawing.Point(参, six);
        public System.Drawing.Point 参sev = new System.Drawing.Point(参, sev);
        public System.Drawing.Point 参eig = new System.Drawing.Point(参, eig);
        public System.Drawing.Point 参nin = new System.Drawing.Point(参, nin);

        public System.Drawing.Point 四one = new System.Drawing.Point(四, one);
        public System.Drawing.Point 四two = new System.Drawing.Point(四, two);
        public System.Drawing.Point 四thr = new System.Drawing.Point(四, thr);
        public System.Drawing.Point 四fou = new System.Drawing.Point(四, fou);
        public System.Drawing.Point 四fiv = new System.Drawing.Point(四, fiv);
        public System.Drawing.Point 四six = new System.Drawing.Point(四, six);
        public System.Drawing.Point 四sev = new System.Drawing.Point(四, sev);
        public System.Drawing.Point 四eig = new System.Drawing.Point(四, eig);
        public System.Drawing.Point 四nin = new System.Drawing.Point(四, nin);

        public System.Drawing.Point 伍one = new System.Drawing.Point(伍, one);
        public System.Drawing.Point 伍two = new System.Drawing.Point(伍, two);
        public System.Drawing.Point 伍thr = new System.Drawing.Point(伍, thr);
        public System.Drawing.Point 伍fou = new System.Drawing.Point(伍, fou);
        public System.Drawing.Point 伍fiv = new System.Drawing.Point(伍, fiv);
        public System.Drawing.Point 伍six = new System.Drawing.Point(伍, six);
        public System.Drawing.Point 伍sev = new System.Drawing.Point(伍, sev);
        public System.Drawing.Point 伍eig = new System.Drawing.Point(伍, eig);
        public System.Drawing.Point 伍nin = new System.Drawing.Point(伍, nin);

        public System.Drawing.Point 六one = new System.Drawing.Point(六, one);
        public System.Drawing.Point 六two = new System.Drawing.Point(六, two);
        public System.Drawing.Point 六thr = new System.Drawing.Point(六, thr);
        public System.Drawing.Point 六fou = new System.Drawing.Point(六, fou);
        public System.Drawing.Point 六fiv = new System.Drawing.Point(六, fiv);
        public System.Drawing.Point 六six = new System.Drawing.Point(六, six);
        public System.Drawing.Point 六sev = new System.Drawing.Point(六, sev);
        public System.Drawing.Point 六eig = new System.Drawing.Point(六, eig);
        public System.Drawing.Point 六nin = new System.Drawing.Point(六, nin);

        public System.Drawing.Point 七one = new System.Drawing.Point(七, one);
        public System.Drawing.Point 七two = new System.Drawing.Point(七, two);
        public System.Drawing.Point 七thr = new System.Drawing.Point(七, thr);
        public System.Drawing.Point 七fou = new System.Drawing.Point(七, fou);
        public System.Drawing.Point 七fiv = new System.Drawing.Point(七, fiv);
        public System.Drawing.Point 七six = new System.Drawing.Point(七, six);
        public System.Drawing.Point 七sev = new System.Drawing.Point(七, sev);
        public System.Drawing.Point 七eig = new System.Drawing.Point(七, eig);
        public System.Drawing.Point 七nin = new System.Drawing.Point(七, nin);

        public System.Drawing.Point 八one = new System.Drawing.Point(八, one);
        public System.Drawing.Point 八two = new System.Drawing.Point(八, two);
        public System.Drawing.Point 八thr = new System.Drawing.Point(八, thr);
        public System.Drawing.Point 八fou = new System.Drawing.Point(八, fou);
        public System.Drawing.Point 八fiv = new System.Drawing.Point(八, fiv);
        public System.Drawing.Point 八six = new System.Drawing.Point(八, six);
        public System.Drawing.Point 八sev = new System.Drawing.Point(八, sev);
        public System.Drawing.Point 八eig = new System.Drawing.Point(八, eig);
        public System.Drawing.Point 八nin = new System.Drawing.Point(八, nin);

        public System.Drawing.Point 九one = new System.Drawing.Point(九, one);
        public System.Drawing.Point 九two = new System.Drawing.Point(九, two);
        public System.Drawing.Point 九thr = new System.Drawing.Point(九, thr);
        public System.Drawing.Point 九fou = new System.Drawing.Point(九, fou);
        public System.Drawing.Point 九fiv = new System.Drawing.Point(九, fiv);
        public System.Drawing.Point 九six = new System.Drawing.Point(九, six);
        public System.Drawing.Point 九sev = new System.Drawing.Point(九, sev);
        public System.Drawing.Point 九eig = new System.Drawing.Point(九, eig);
        public System.Drawing.Point 九nin = new System.Drawing.Point(九, nin);

        public static List<Label> 駒 = new List<Label>();


    }
}
