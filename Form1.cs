using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using Awesomium.Core;
using Awesomium.Windows.Forms;

namespace goparceyourself
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            choice_type.Items.Add("Размер");
            choice_type.Items.Add("Вставка");
            choice_type.Items.Add("Цвет");
            choice_type.Items.Add("Металл");
            size_box.Visible = false;
           
        }
        List<TextBox> choices = new List<TextBox>();
        List<int> choices_sort = new List<int>();
        List<CheckingWB> images = new List<CheckingWB>();
        int x = 0, y = 0;
        int img_x = 0, img_y = 0;
        /// <summary>
        /// Переход по входной ссылке
        /// </summary>
        public string getRequest(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.AllowAutoRedirect = true;//Запрещаем автоматический реддирект 
                httpWebRequest.Method = "GET"; //Можно не указывать, по умолчанию используется GET. 
                httpWebRequest.Referer = url; // Реферер. Тут можно указать любой URL
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
                        {
                            return reader.ReadToEnd();//ready html
                        }
                    }
                }
            }
            catch
            {
                return String.Empty;
            }
        }
        
        /// <summary>
        /// Перевод входной страницы
        /// </summary>
        public string TranslateText(string input)
        {
            Regex item_tao = new Regex(@"(https://item.taobao.com/item)" + @".+" + @"\&" + @"(id=)" + @"(\d+)");
            Regex world_tao = new Regex(@"(https://world.taobao.com/item/)" + @"(\d+)" + "(.htm)" + ".+");
            Regex detail_tmall = new Regex(@"(https://detail.tmall.com/item\.htm\?)" + "(id=)" + @"(\d+)");
            Regex detail_tmall_long = new Regex(@"(https://detail.tmall.com/item)" + @".+" + @"\&" + @"(id=)" + @"(\d+)" + @".+");
            Regex world_tmall = new Regex(@"(https://world.tmall.com/item/)" + @"(\d+)" + @".+");

            MatchCollection match_item_tao = item_tao.Matches(input);
            MatchCollection match_world_tao = world_tao.Matches(input);
            MatchCollection match_detail_tmall = detail_tmall.Matches(input);
            MatchCollection match_detail_tmall_long = detail_tmall_long.Matches(input);
            MatchCollection match_world_tmall_long = world_tmall.Matches(input);

            String url_ready = String.Empty;

            if (match_item_tao.Count > 0)
                url_ready = match_item_tao[0].Groups[1] + ".htm?" + match_item_tao[0].Groups[2] + match_item_tao[0].Groups[3];
            else if (match_world_tao.Count > 0)
                url_ready = match_world_tao[0].Groups[1] + "" + match_world_tao[0].Groups[2] + match_world_tao[0].Groups[3] + "/";
            else if (match_detail_tmall_long.Count > 0)
                url_ready = match_detail_tmall_long[0].Groups[1] + ".htm?" + match_detail_tmall_long[0].Groups[2] + match_detail_tmall_long[0].Groups[3];
            else if (match_detail_tmall.Count > 0)
                url_ready = input;
            else if (match_world_tmall_long.Count > 0)
                url_ready = input;

            string url = String.Format("https://z5h64q92x9.net/tr-start?ui=ru&url={0}&lang=zh-ru",url_ready);
            return url;
        }

        /// <summary>
        /// Собрать товар
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;

            img_x = 0;
            img_y = 0;

            foreach (TextBox ch in choices)
                ch.Dispose();

            choices.Clear();

            foreach (Control ch in Controls)
            {
                if (ch.Name.Contains("choice") && ch.Name != "choice_type")
                {
                    ch.Dispose();
                }
            }

            foreach (Control c in Controls)
                if (c.GetType() == typeof(TextBox) && !c.Name.Contains("link"))
                    c.Text = "";

            Application.DoEvents();

            webControl1.Source = new Uri(TranslateText(link.Text));

            foreach (Control c in Controls)
                c.Enabled = false;

            richTextBox3.Text = getRequest(link.Text);

            try { Findname(); }
            catch{ MessageBox.Show("Name is lost"); }

            try { Findprice(); }
            catch { MessageBox.Show("Price is lost"); }

            try { Features_on_item(); }
            catch { MessageBox.Show("Features is lost"); }

            try { Metal_on_tmall(); }
            catch { MessageBox.Show("Metal is lost"); }

            try { Incrust_on_tmall(); }
            catch { MessageBox.Show("Incrust is lost"); }

            Choice_on_item(); 

            Choice_on_tmall();

            Get_images();

            foreach (Control c in Controls)
                c.Enabled = true;
        }

        /// <summary>
        /// Парс имени
        /// </summary>
        private bool Findname()
        {
            Regex name_item = new Regex("<span itemprop=" + '\u0022' + "name" + '\u0022' + " " + "class=" + '\u0022' + "t-title" + '\u0022' + @">(.+)" + "</span>");
            Regex name_world_tmall = new Regex("<h1 data - spm = \"1000983\">" + "(.+)" + "</h1>");
            Regex script = new Regex("<title>" + @"(.+)" + "-tmall.com");

            MatchCollection matches_name_item = name_item.Matches(richTextBox3.Text);
            MatchCollection matches_name_world_tmall = name_world_tmall.Matches(richTextBox3.Text);
            MatchCollection matches_script = script.Matches(richTextBox3.Text);

            if (matches_name_item.Count > 0)
            {
                name.Text = matches_name_item[0].Groups[1] + "\n";
                return true;
            }
            else if (matches_name_world_tmall.Count > 0)
            {
                name.Text = matches_name_world_tmall[0].Groups[1] + "\n";
                return true;
            }
            else if (matches_script.Count > 0)
            {
                name.Text = matches_script[0].Groups[1] + "\n";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Парс цены
        /// </summary>
        private bool Findprice()
        {
            Regex price_world_mall = new Regex("<span class=\"tm-price\"" + @">(.+)" + "</span>");
            Regex price_item = new Regex("<span itemprop=" + '\u0022' + "price" + '\u0022' + " " + "content=" + '\u0022' + ".+" + '\u0022' +  @">(.+)" + "</span>");
            Regex script = new Regex("{\"price\":\""+@"(\d+\.\d+)" + "\",\"priceCent\":"+@".+"+",\"skuId\":\""+ @".+" + "\",\"stock\":" + @"\d\d");

            MatchCollection matches_price_world_mall = price_world_mall.Matches(richTextBox3.Text);
            MatchCollection matches_price_item = price_item.Matches(richTextBox3.Text);
            MatchCollection matches_script = script.Matches(richTextBox3.Text);

            if (matches_price_world_mall.Count > 0)
            {
                price.Text = matches_price_world_mall[0].Groups[1] + "\n";
                return true;
            }
            else if (matches_price_item.Count > 0)  
            {
                price.Text =  matches_price_item[0].Groups[1] + "\n";
                return true;
            }
            else if (matches_script.Count > 0)
            {
                price.Text =  matches_script[0].Groups[1] + "\n";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Парс металла со странички "tmall"
        /// </summary> 
        private bool Metal_on_tmall()
        {
            Regex metal1_tmall = new Regex("<li title=\"&nbsp;" +  @"(.+)" + "\">贵金属成色:&nbsp;" + @".+" + "</li>");
            Regex metal2_tmall = new Regex("<li title=\"&nbsp;" + @"(.+)" + "\">金属材质:&nbsp;" + @".+" + "</li>");
            Regex metal3_tmall = new Regex("<li title=\"&nbsp;" + @"(.+)" + "\">材质:&nbsp;" + @".+" + "</li>");

            MatchCollection matches_metal1_tmall = metal1_tmall.Matches(richTextBox3.Text);
            MatchCollection matches_metal2_tmall = metal2_tmall.Matches(richTextBox3.Text);
            MatchCollection matches_metal3_tmall = metal3_tmall.Matches(richTextBox3.Text);

            if (matches_metal1_tmall.Count > 0)
            {
                metal.Text = WebUtility.HtmlDecode(Convert.ToString(matches_metal1_tmall[0].Groups[1])) + "\n";
                return true;
            }

            else if (matches_metal2_tmall.Count > 0)
            {
                metal.Text = WebUtility.HtmlDecode(Convert.ToString(matches_metal2_tmall[0].Groups[1])) + "\n";
                return true;
            }

            else if (matches_metal3_tmall.Count > 0)
            {
                metal.Text = WebUtility.HtmlDecode(Convert.ToString(matches_metal3_tmall[0].Groups[1])) + "\n";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Парс вставки со странички "tmall"
        /// </summary>
        private bool Incrust_on_tmall()
        {
            Regex incrust_tmall = new Regex("<li title=\"&nbsp;" + @"(.+)" + "\">镶嵌材质:&nbsp;" + @".+" + "</li>");

            MatchCollection matches_incrust_tmall = incrust_tmall.Matches(richTextBox3.Text);

            if (matches_incrust_tmall.Count > 0)
            {
                incrust.Text = WebUtility.HtmlDecode(Convert.ToString(matches_incrust_tmall[0].Groups[1])) + "\n";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Парс характеристик со странички "item"
        /// </summary>
        private bool Features_on_item()
        {
            Regex features_item = new Regex("<li title=\"" + @"  (.+)" + "\">");
            //  Regex weight_item = new Regex("<div>" + @".+" + @"(\d)" + @"(.)" + @"(\d\d)" + "克" + @".+" + "</div>");


            MatchCollection matches_features_item = features_item.Matches(richTextBox3.Text);
            // MatchCollection matches_weight_item = weight_item.Matches(richTextBox3.Text);

            if (matches_features_item.Count > 0)
            {
                metal.Text = matches_features_item[1].Groups[1].ToString();
                incrust.Text = matches_features_item[8].Groups[1].ToString();
                // richTextBox1.Text += "Weight: " + matches_weight_item[0].Groups[1] + "," + matches_weight_item[0].Groups[3] + "\n";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Парс выбора со странички "item"
        /// </summary>
        private bool Choice_on_item()
        {
            Regex choice_item = new Regex("<li class=\"J_SKU\" data-pv=" + @".+" + ">\n" + @".+" +"<span>" + @"(.+)" + "</span></a>\n</li>"); 

            MatchCollection matches_choice_item = choice_item.Matches(richTextBox3.Text);

            if (matches_choice_item.Count > 0)
            {
                for (int n = 0; n < matches_choice_item.Count; n++)
                {
                    TextBox choice = new TextBox();
                    choices.Add(choice);
                    choice.Name = "choice" + (n + 1).ToString();
                    choice.Text = matches_choice_item[n].Groups[1].ToString();
                    choice.Location = new Point(835 + x, 115 + y);

                    if (choices.Count % 6 == 0)
                    {
                        x += 142;
                        y = 0;
                    }
                    else
                    {
                        y += 26;
                    }

                    Controls.Add(choice);
                }

                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webControl1.Reload(true);    
        }

        private void choice_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choice_type.SelectedItem.ToString() == "Размер")
                size_box.Visible = true;
            else size_box.Visible = false;
        }

        private void Get_size(object sender, EventArgs e)
        {
            int n = 0;
            float ss = Convert.ToSingle(size_begin.Text);

            char[] num = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            foreach (TextBox tb in choices)
            {
                string s = "";
                foreach (char ch in tb.Text)
                    {
                        for ( int m =0; m < 10; m ++)
                        {
                            if (ch == num[m])
                                s += ch;
                        }
                    }
            choices_sort.Add(Convert.ToInt32(s));
            }

            choices_sort.Sort();

            foreach (TextBox tb in choices)
            {
                if (n < choices_sort.Count)
                {
                    tb.Text = choices_sort[n].ToString()+"->"+ss.ToString();
                    ss += Convert.ToSingle(size_step.Text);
                }
                n++;
            }
        }

        private void Confirm_size(object sender, EventArgs e)
        {
            foreach (TextBox tb in choices)
            {
                tb.Text = tb.Text.Substring(tb.Text.IndexOf('>') + 1);
            }
        }

        /// <summary>
        /// Парс выбора со странички "tmall"
        /// </summary>
        private bool Choice_on_tmall()
        {
            Regex choice_tmall = new Regex("<li data-value=" + @".+" +" "+ "title="+@".+"+">\n" + @".+" +"\n<span>" + @"(.+)"+ "</span>\n</a>\n</li>");

            MatchCollection matches_choice_tmall = choice_tmall.Matches(richTextBox3.Text);

            if (matches_choice_tmall.Count > 0)
            {
                for (int n = 0; n < matches_choice_tmall.Count; n++)
                {
                    choices_sort.Add(Convert.ToInt32(matches_choice_tmall[n].Groups[1]));
                }
                choices_sort.Sort();
                for (int n = 0; n < choices_sort.Count; n++)
                {
                    TextBox choice = new TextBox();
                    choices.Add(choice);
                    choice.Name = "choice" + (n + 1).ToString();
                    choice.Text = choices_sort[n].ToString();
                    choice.Location = new Point(835 + x, 115 + y);

                    if (choices.Count % 6 == 0)
                    {
                        x += 142;
                        y = 0;
                    }
                    else
                    {
                        y += 26;
                    }

                    Controls.Add(choice);
                }

                return true;
            }
                return false;
        }


        /// <summary>
        /// Парсинг изображений товара
        /// </summary>
        /// <returns>true при наличии изображений, false - при отсутствии</returns>
        private bool Get_images()
        { 
            Regex img_tmall = new Regex("img.alicdn.com/" + @"(.+)" + ".jpg_" + @"(.+)" + "\" /></a>");

            MatchCollection matches_img_tmall = img_tmall.Matches(richTextBox3.Text);

            if (matches_img_tmall.Count > 0)
            {
                for (int n = 0; n != matches_img_tmall.Count; n++)
                {
                    CheckingWB img_parser = new CheckingWB();
                    images.Add(img_parser);
                    img_parser.Name = "img" + (n+1).ToString();
                    img_parser.source(new Uri("http://img.alicdn.com/" + matches_img_tmall[n].Groups[1].ToString() + ".jpg_430x430q90.jpg"));
                    img_parser.Check();
                    img_parser.Location = new Point(12 + img_x, 42 + img_y);

                    if (images.Count % 2 == 0)
                    {
                        img_x = 0;
                        img_y += 152;
                    }
                    else
                    {
                        img_x += 192;
                    }

                    img_parser.Visible = true;
                    Controls.Add(img_parser);
                }
                    return true;
                
            }

            return false;
        }
    }
}
