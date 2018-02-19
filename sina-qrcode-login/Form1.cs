using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace sina_qrcode_login
{
    public partial class Form1 : Form
    {
        string qrid = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void getqrcode() //获取登陆二维码并显示在qrcode(picturebox)上
        {
            string imageurl = "";
            String jsonString = HTTP.GetMiddleString(HTTP.Get("https://login.sina.com.cn/sso/qrcode/image?entry=weibo&size=180&callback=STK"), "(", ")");
            try
            {
                JObject jsonObj = JObject.Parse(jsonString);
                imageurl = "http:" + (string)jsonObj["data"]["image"]; //解析获得qrcode的地址
                qrid = (string)jsonObj["data"]["qrid"];
            }
            catch (JsonException e)
            {
                Debug.WriteLine(e.Message); //json 解析出错的异常处理
            }
            Image qrcodeimages = Image.FromStream(WebRequest.Create(imageurl).GetResponse().GetResponseStream()); //获取qrcode
            qrcode.Image = qrcodeimages; //显示qrcode
            timer1.Enabled = true; //二维码监控开始。监控二维码的状态（是否扫描，确认登陆）
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string url = "https://login.sina.com.cn/sso/qrcode/check?entry=weibo&qrid=" + qrid + "&callback=STK";
            string res = HTTP.GetMiddleString(HTTP.Get(url), "(", ")");
            try
            {
                JObject jObject = JObject.Parse(res);
                string msg = (string)jObject["msg"];
                if (msg == "succ")
                {
                    msg = "扫码成功";
                    string alt = (string)jObject["data"]["alt"];
                    login(alt);
                    timer1.Enabled = false; //二维码监控停止
                }
                login_msg.Text = msg;
            }
            catch (JsonException error)
            {
                Debug.WriteLine(error.Message); //json 解析出错的异常处理
            }

        }

        private void login(string alt)
        {
            string nick = "";
            string uid = "";
            string url = "https://login.sina.com.cn/sso/login.php?entry=weibo&returntype=TEXT&crossdomain=1&cdult=3&domain=weibo.com&alt=" + alt + "&savestate=30&callback=STK"; //登陆获取账号信息
            string res = HTTP.GetMiddleString(HTTP.Get(url), "(", ")"); //登陆返回。如果需要取Cookies返回，请修改此处，另外返回json中的crossDomainUrlList[3]，在未登陆的状态下访问，可以跳转到登陆成功的个人账号主页
            try
            {
                JObject jObject = JObject.Parse(res);
                nick = (string)jObject["nick"];
                uid = (string)jObject["uid"];
            }catch (JsonException e)
            {
                nick = "登陆出错";
                uid = "登陆出错";
                Debug.WriteLine(e.Message);//json 解析出错的异常处理
            }
            user_info.Text = "nick:" + nick + "\n" + "uid:" + uid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getqrcode();
        }

        private void qrcode_Click(object sender, EventArgs e)
        {
            getqrcode();
        }
    }
}
