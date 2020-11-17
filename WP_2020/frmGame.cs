using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020.Properties;

namespace WP_2020
{
    public partial class frmGame : Form
    {
        List<Image> list = new List<Image>();
        Poker p = new Poker();
        List<int> poker;
        int click;
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            #region 加入图片
            list.Add(Resources._000);
            list.Add(Resources.AC);
            list.Add(Resources.AD);
            list.Add(Resources.AH);
            list.Add(Resources.AS);
            list.Add(Resources._2C);
            list.Add(Resources._2D);
            list.Add(Resources._2H);
            list.Add(Resources._2S);
            list.Add(Resources._3C);
            list.Add(Resources._3D);
            list.Add(Resources._3H);
            list.Add(Resources._3S);
            list.Add(Resources._4C);
            list.Add(Resources._4D);
            list.Add(Resources._4H);
            list.Add(Resources._4S);
            list.Add(Resources._5C);
            list.Add(Resources._5D);
            list.Add(Resources._5H);
            list.Add(Resources._5S);
            list.Add(Resources._6C);
            list.Add(Resources._6D);
            list.Add(Resources._6H);
            list.Add(Resources._6S);
            list.Add(Resources._7C);
            list.Add(Resources._7D);
            list.Add(Resources._7H);
            list.Add(Resources._7S);
            list.Add(Resources._8C);
            list.Add(Resources._8D);
            list.Add(Resources._8H);
            list.Add(Resources._8S);
            list.Add(Resources._9C);
            list.Add(Resources._9D);
            list.Add(Resources._9H);
            list.Add(Resources._9S);
            list.Add(Resources._10C);
            list.Add(Resources._10D);
            list.Add(Resources._10H);
            list.Add(Resources._10S);
            list.Add(Resources.JC);
            list.Add(Resources.JD);
            list.Add(Resources.JH);
            list.Add(Resources.JS);
            list.Add(Resources.KC);
            list.Add(Resources.KD);
            list.Add(Resources.KH);
            list.Add(Resources.KS);
            list.Add(Resources.QC);
            list.Add(Resources.QD);
            list.Add(Resources.QH);
            list.Add(Resources.QS);
            #endregion

            picResult.Image = list[0];
            poker = p.GetPoker(52);
            click = 0;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (click < 52)
            {
                rtbLog.Text = "里面还剩下 " + (51-click).ToString() + " 张";
                picResult.Image = list[poker[click]+1];
                click += 1;
            }
            else
            {
                MessageBox.Show("抽完了");
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            click = 0;
            poker = p.GetPoker(52);
            picResult.Image = list[0];
            rtbLog.Text = "";
        }
    }
}
