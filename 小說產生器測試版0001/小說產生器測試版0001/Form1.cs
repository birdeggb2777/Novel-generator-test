using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小說產生器測試版0001
{
    public partial class Form1 : Form
    {
        Boolean luckly = false;
        Boolean bad=false;
        public Form1()
        {
            InitializeComponent();
        }
        private void die()
        {
            textBox1.Text += "然後我就死了\r\n";
            if (bad == true) { label2.Text = "C"; }
            else { label2.Text = "D"; }
        }
        private void 湖()
        {
            textBox1.Text += "啊，我快淹死了...「救命啊」\r\n";
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 400);
            if (ran1 <= 100) { textBox1.Text += "可是沒有人來救我。\r\n"; die(); }
            else if (ran1 <= 200) { textBox1.Text += "可是沒有人來救我。\r\n當我醒過來的時候，發現自己在醫院裡面。\r\n"; 醫院(); }
            else if (ran1 <= 300) { textBox1.Text += "這時，出現了一位警察，他趕緊下水救我。\r\n我被送到了醫院\r\n"; 醫院(); }
            else  { textBox1.Text += "這時，出現了一位小朋友，他趕緊下水救我。\r\n可是他不會游泳...\r\n我和他一起沉進了水底\r\n";bad = true;  die(); }
        }
        private void 戶外()
        {
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 400);
            if (ran1 <= 100) { textBox1.Text += "「啊，下雨了」\r\n我趕緊找一棵樹避雨。\r\n等了一段時間，雨都沒有停。\r\n「還是先睡一覺好了」\r\n然後我就睡著了。\r\n"; start(); }
            else if (ran1 <= 200) { textBox1.Text += "「啊，下雨了」\r\n我趕緊找一棵樹避雨。\r\n等了一段時間，雨都沒有停。\r\n這時，一道閃電打中了這棵樹。\r\n" ; die(); }
            else if (ran1 <= 300) { textBox1.Text += "好想睡覺，回家去好了。\r\n我往家的方向走，大約走了十多分鐘，走到了家裡。\r\n"; 家(); }
             else { textBox1.Text += "這裡好無聊，我去學校逛逛好了。\r\n我往學校的方向走，大約走了三十多分鐘，走到了學校。\r\n"; 學校(); }

        }
        private void 醫院()
        {
            textBox1.Text += "感覺意識有點模糊。\r\n";
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 300);
            if (ran1 <= 100) { textBox1.Text += "這時，一位護士給自己打針。\r\n打了針之後...\r\n「啊，我的頭好痛」\r\n我痛不欲生，在病床上打滾。\r\n"; bad = true; die(); }
            else if (ran1 <= 200) { textBox1.Text += "這時，一位護士給自己打針。\r\n打了針之後...\r\n「好累，好想睡覺」\r\n然後我就睡著了。\r\n"; start(); }
            else { textBox1.Text += "這時，一位護士給自己打針。\r\n打了針之後...\r\n「啊，感覺好多了」\r\n感覺身體好多了之後，我走到戶外走走。\r\n"; 戶外(); }
          

        }
        private void 房子()
        {
            textBox1.Text += "「這是哪裡?」\r\n";
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 400);
            if (ran1 <= 100) { textBox1.Text += "看到附近沒人，我打開門走了出去。\r\n結果一踏出門就掉進了湖裡...r\n"; 湖(); }
            else if (ran1 <= 200) { textBox1.Text += "看到附近沒人，我打開門走了出去。\r\n我發現自己在一個小鎮\r\n"; 戶外(); }
            else if (ran1 <= 300) { textBox1.Text += "前方有一個人，似乎嚇了好一大跳。\r\n「啊，小偷啊」\r\n他從口袋中拿出了刀，往我衝了過來。\r\n我隨即和他發生扭打。\r\n結果，那把刀刺進了我的心臟...\r\n"; bad = true; die(); }
            else { textBox1.Text += "前方有一個人，似乎嚇了好一大跳。\r\n「啊，小偷啊」\r\n我還搞不清楚狀況，就被送到警局了。\r\n"; 警局(); }

        }
        private void 家()
        {
            
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 200);
            if (ran1 <= 100) { textBox1.Text += "「好累，睡個覺吧」\r\n我趴在床上，睡著了\r\n"; ; start(); }        
            else { textBox1.Text += "這裡好無聊，我還是出去好了\r\n"; 戶外(); }

        }
        private void 商店()
        {
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 550);
            if (ran1 <= 100) { textBox1.Text += "「肚子好餓」我隨手打開了一包零食來吃。\r\n「喂！你還沒付錢呢」一位店員用手指著，我大聲的說。\r\n糟了，我身上好像沒錢。\r\n然後我就被送到警局了。\r\n"; bad = true; 警局(); }
            else if (ran1 <= 200) { textBox1.Text += "「你想要買什麼?」一位店員問我\r\n「不用了，我沒有要買什麼」\r\n我走出了商店。\r\n"; 戶外(); }
            else if (ran1 <= 300) { textBox1.Text += "「你想要買什麼?」一位店員問我\r\n「不用了，我沒有要買什麼」\r\n我走出了商店。\r\n結果一踏出商店的大門就掉進了湖裡\r\n"; 湖(); }
            else if (ran1 <= 400) { textBox1.Text += "「肚子好餓」我隨手打開了一包零食來吃。\r\n「喂！你還沒付錢呢」一位店員用手指著，我大聲的說。\r\n糟了，我身上好像沒錢。\r\n我趕緊往外跑。\r\n結果一跑出商店的大門就掉進了湖裡。\r\n"; 湖(); }
            else if (ran1 <= 500) { textBox1.Text += "「肚子好餓」我隨手打開了一包零食來吃。\r\n「喂！你還沒付錢呢」一位店員用手指著，我大聲的說。\r\n糟了，我身上好像沒錢。\r\n我趕緊往外跑。\r\n結果店員拿著一把刀追了上來。\r\n我隨即和他發生扭打。\r\n結果，那把刀刺進了我的心臟...\r\n"; bad = true; die(); }
            else  { textBox1.Text += "「肚子好餓」我隨手打開了一包零食來吃。\r\n「喂！你還沒付錢呢」一位店員用手指著，我大聲的說。\r\n糟了，我身上好像沒錢。\r\n我趕緊往外跑。\r\n結果店員拿著一把刀追了上來。\r\n我隨即和他發生扭打。\r\n我在扭打他的過程中，把他的刀搶了過來，刺了回去。\r\n刀子很狠的刺進了他的心臟\r\n我嚇到了，趕緊把刀子拔出來。\r\n就在刀子拔起來的一瞬間\r\n他的血噴的我滿身都是。\r\n「衣服都弄髒了」我露出了不悅的表情\r\n「回家換衣服吧」\r\n我把刀扔在一旁，回家洗了個早，然後就上床睡覺了\r\n"; label2.Text = "S"; }

        }
        private void 學校()
        {
            textBox1.Text += "這裡好像沒什麼好逛的，去其他地方看看好了。\r\n我走出了學校\r\n"; 戶外(); 
        }
        private void 警局()
        {
            textBox1.Text += "從此，再也沒有人聽到關於我的消息。\r\n";
            if (bad == true) { label2.Text = "A"; }
            else { label2.Text = "B"; }
        }
        private void start()
        {
            textBox1.Text += "\r\n我醒了過來，好像睡了很久。" +"\r\n" + "「這是哪裡?」\r\n";
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 600);
            if (ran1 <= 100) { textBox1.Text += "我發現我正在湖中央\r\n";湖(); }
            else if (ran1 <= 200) { textBox1.Text += "我發現我在一個小鎮\r\n"; 戶外(); }
            else if (ran1 <= 300) { textBox1.Text += "我發現我在醫院裡面\r\n"; 醫院(); }
            else if (ran1 <= 400) { textBox1.Text += "我發現我在一間房子裡面\r\n"; 房子(); }
            else if (ran1 <= 500) { textBox1.Text += "我發現我在一家商店\r\n"; 商店(); }
            else  { textBox1.Text += "我發現我在一間學校\r\n"; 學校(); }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "E";
            textBox1.Text = "";
            luckly = false;
            bad = false;
            textBox1.Text += "我醒了過來，好像睡了很久。" + "\r\n" + "「這是哪裡?」\r\n";
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            int ran1;
            ran1 = ran.Next(0, 600);
            if (ran1 <= 100) { textBox1.Text += "我發現我正在湖中央\r\n"; 湖(); }
            else if (ran1 <= 200) { textBox1.Text += "我發現我在一個小鎮\r\n"; 戶外(); }
            else if (ran1 <= 300) { textBox1.Text += "我發現我在醫院裡面\r\n"; 醫院(); }
            else if (ran1 <= 400) { textBox1.Text += "我發現我在一間房子裡面\r\n"; 房子(); }
            else if (ran1 <= 500) { textBox1.Text += "我發現我在一家商店\r\n"; 商店(); }
            else { textBox1.Text += "我發現我在一間學校\r\n"; 學校(); }
            button1.Enabled = false;
            timer1.Enabled = true;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
