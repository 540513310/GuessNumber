using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace mygame
{
    public partial class Form1 : Form
    {
        DateTime dt;
        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
        }
        Form2 fm2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            //為了測試先暫時把自動生成數放在這裡
            
            lbtemp.Text = strGene;
            dt = DateTime.Now;
            //timer1.Stop();
            // fm2.MdiParent = this;
            //fm2.Show();
            lbGuess1.Text = "";
            lbGuess2.Text = "";
            lbGuess3.Text = "";
            lbGuess4.Text = "";
            lbGuess5.Text = "";
            lbGuess6.Text = "";
            lbGuess7.Text = "";
            lbGuess8.Text = "";
            lbGuess9.Text = "";
            lbGuess10.Text = "";

            lb1.Text = "";
            lb2.Text = "";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            lb6.Text = "";
            lb7.Text = "";
            lb8.Text = "";
            lb9.Text = "";
            lb10.Text = "";

            //foreach (Control Allctl in this.Controls)
            //{
            //    if (Allctl is GroupBox)
            //    {
            //        foreach (Control ctl in this.groupBox1.Controls)
            //        {
            //            if (ctl is TextBox)
            //            {
            //                ctl.Text = "";
            //            }
            //        }
            //    }
            //}
            foreach (Control ctl in this.groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox2.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox3.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox4.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            foreach (Control ctl in this.groupBox5.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox6.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox7.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            foreach (Control ctl in this.groupBox8.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox9.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            foreach (Control ctl in this.groupBox10.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

        }

        //從其他地方刷新
        public void refresh()
        {
            dt = DateTime.Now;
            //timer1.Stop();
            // fm2.MdiParent = this;
            //fm2.Show();
            lbGuess1.Text = "";
            lbGuess2.Text = "";
            lbGuess3.Text = "";
            lbGuess4.Text = "";
            lbGuess5.Text = "";
            lbGuess6.Text = "";
            lbGuess7.Text = "";
            lbGuess8.Text = "";
            lbGuess9.Text = "";
            lbGuess10.Text = "";

            lb1.Text = "";
            lb2.Text = "";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            lb6.Text = "";
            lb7.Text = "";
            lb8.Text = "";
            lb9.Text = "";
            lb10.Text = "";


            lbTimeSpan.Text = "";

            //foreach (Control Allctl in this.Controls)
            //{
            //    if (Allctl is GroupBox)
            //    {
            //        foreach (Control ctl in this.groupBox1.Controls)
            //        {
            //            if (ctl is TextBox)
            //            {
            //                ctl.Text = "";
            //            }
            //        }
            //    }
            //}
            foreach (Control ctl in this.groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox2.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox3.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox4.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            foreach (Control ctl in this.groupBox5.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox6.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox7.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            foreach (Control ctl in this.groupBox8.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }

            foreach (Control ctl in this.groupBox9.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            foreach (Control ctl in this.groupBox10.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
        }

        //點擊數字鍵時觸發這個函數，先判斷焦點艘在位置，在判斷焦點所在的文本框的長度是否小於4
        //再判斷所選的數字是否已經存在于該文本框，兩個條件都符合后就輸入成功。
        int focusIntxt = 1;//第一次點擊數字按鍵時，按鍵的內容輸入到第一個textbox中
        void showText(object obj, EventArgs e)
        {
            lbNote.Text = "";
            switch (focusIntxt)
            {
                case 1: if (this.lbGuess1.Text.Length < 4) { if (this.lbGuess1.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess1.Text = this.lbGuess1.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; } break;
                case 2: if (this.lbGuess2.Text.Length < 4) { if (this.lbGuess2.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess2.Text = this.lbGuess2.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 3: if (this.lbGuess3.Text.Length < 4) { if (this.lbGuess3.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess3.Text = this.lbGuess3.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 4: if (this.lbGuess4.Text.Length < 4) { if (this.lbGuess4.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess4.Text = this.lbGuess4.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 5: if (this.lbGuess5.Text.Length < 4) { if (this.lbGuess5.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess5.Text = this.lbGuess5.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 6: if (this.lbGuess6.Text.Length < 4) { if (this.lbGuess6.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess6.Text = this.lbGuess6.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 7: if (this.lbGuess7.Text.Length < 4) { if (this.lbGuess7.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess7.Text = this.lbGuess7.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 8: if (this.lbGuess8.Text.Length < 4) { if (this.lbGuess8.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess8.Text = this.lbGuess8.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 9: if (this.lbGuess9.Text.Length < 4) { if (this.lbGuess9.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess9.Text = this.lbGuess9.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;
                case 10: if (this.lbGuess10.Text.Length < 4) { if (this.lbGuess10.Text.Contains(((Button)obj).Text)) { lbNote.Text = "輸入的數字不能重複"; } else { this.lbGuess10.Text = this.lbGuess10.Text + ((Button)obj).Text; } } else { this.lbNote.Text = "只能輸入4位數"; }; break;


            }
        }

        //当右边的分析器中数字键1被点击时
        int no1Click = 1;  //存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
        void btnNoClick1(object obj, EventArgs e)
        {
            //int i = 1;
            if (no1Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox1.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox1.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no1Click++;

        }

        //当右边的分析器中数字键2被点击时
        int no2Click = 1;
        void btnNoClick2(object obj, EventArgs e)
        {
           // int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no2Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox2.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox2.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no2Click++;

        }
        //当右边的分析器中数字键3被点击时
        int no3Click = 1;
        void btnNoClick3(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no3Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox3.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox3.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no3Click++;

        }

        //当右边的分析器中数字键4被点击时
        int no4Click = 1;
        void btnNoClick4(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no4Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox4.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox4.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no4Click++;

        }

        //当右边的分析器中数字键5被点击时
        int no5Click = 1;
        void btnNoClick5(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no5Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox5.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox5.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no5Click++;
        }

        //当右边的分析器中数字键6被点击时
        int no6Click = 1;
        void btnNoClick6(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no6Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox6.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox6.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no6Click++;
        }


        //当右边的分析器中数字键7被点击时
        int no7Click = 1;
        void btnNoClick7(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no7Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox7.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox7.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no7Click++;
        }

        //当右边的分析器中数字键8被点击时
        int no8Click = 1;
        void btnNoClick8(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no8Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox8.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox8.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no8Click++;
        }

        //当右边的分析器中数字键9被点击时
        int no9Click = 1;
        void btnNoClick9(object obj, EventArgs e)
        {
           // int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no9Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox9.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox9.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no9Click++;
        }


        //当右边的分析器中数字键0被点击时
        int no0Click = 1;
        void btnNoClick10(object obj, EventArgs e)
        {
            //int i = 1;//存放数字键被点击的次数，奇数次时，textbox的内容为“x”，偶次数时内容为空
            if (no0Click % 2 == 0)
            {
                //groupbox中的所有textbox的内容为空
                foreach (Control ctl in this.groupBox10.Controls)
                {
                    ctl.Text = "";
                }
            }
            else
            {
                //当点击的次数为奇数时groupbox中的所有textbox的内容为“×”
                foreach (Control ctl in this.groupBox10.Controls)
                {
                    ctl.Text = "×";
                }
            }
            no0Click++;
        }


        //当textbox被点击时，把textbox的内容设置为“√”
        int txtCheck = 1;
        void txtboxClick(object obj, EventArgs e)
        {
            if (txtCheck % 2 == 1)
            {
                ((TextBox)obj).Text = "√";
            }
            else ((TextBox)obj).Text = "";
            txtCheck++;
        }


        //產生隨機數，返回隨機數的字符串string型
        public static string GenerateNum()
        {
            string[] autoArray = new string[] { "", "", "", ""};//用於存放計算機自動產生的隨機數
            //通過哈希表來確保產生的隨機數絕對地隨機
            Hashtable hash = new Hashtable();//創建哈希表，必須引入命名空間using.system.collections
            Random rd = new Random();
            int rdNum = 4;
            for (int i = 0; i < rdNum; i++)
            {

                int r = rd.Next(0, 9);//自動產生隨機數
                if (!hash.ContainsValue(r))//判斷隨機數是否存在哈希表中，如果該還沒存在哈希表中，則添加進去
                {
                    hash.Add(r, r);  //把隨機數添加到哈希表中，Hashtable.add(key,value)

                    string str = r.ToString();
                    autoArray[i] = str;

                }
                else i--;

            }
            string strAutoNum = string.Join("", autoArray);
            return strAutoNum;

        }

       
        


        //調用產生隨機數的函數，並把該函數的返回值放在strGene中
        string strGene = GenerateNum();

        int count = 0;//'全局變量count用來定位光標所在位置
        //返回用戶輸入的數字，如果輸入的數字小於4位，則提示用戶注意
        //獲取用戶在文本框中輸入的4位數字，該函數的返回值為用戶輸入的4位數
        public string lbGuess()
        {
            string strGuess = "";
            switch (count)
            {
                case 0: if (lbGuess1.Text.Length == 4) { strGuess = lbGuess1.Text; count++; } break;
                case 1: if (lbGuess2.Text.Length == 4) { strGuess = lbGuess2.Text; count++; } break;
                case 2: if (lbGuess3.Text.Length == 4) { strGuess = lbGuess3.Text; count++; } break;
                case 3: if (lbGuess4.Text.Length == 4) { strGuess = lbGuess4.Text; count++; } break;
                case 4: if (lbGuess5.Text.Length == 4) { strGuess = lbGuess5.Text; count++; } break;
                case 5: if (lbGuess6.Text.Length == 4) { strGuess = lbGuess6.Text; count++; } break;
                case 6: if (lbGuess7.Text.Length == 4) { strGuess = lbGuess7.Text; count++; } break;
                case 7: if (lbGuess8.Text.Length == 4) { strGuess = lbGuess8.Text; count++; } break;
                case 8: if (lbGuess9.Text.Length == 4) { strGuess = lbGuess9.Text; count++; } break;
                case 9: if (lbGuess10.Text.Length == 4) { strGuess = lbGuess10.Text; count++; } break;
                default: break;
            }
            return strGuess;
        }

        public string Result(string generate, string guess)
        {
            //
            int countOfA = 0;//用來存放A的個數
            var hash = new Dictionary<char, int>();//泛型數據Dictionary用於存放鍵值對
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == generate[i])
                {
                    countOfA++;
                }
                if (!hash.ContainsKey(generate[i]))
                {
                    hash.Add(generate[i], 1);
                }
            }
            if (countOfA == 4)
            {
                return "4A0B";
            }
            int countOfB = 0;//用來存放B的個數
            for (int i = 0; i < 4; i++)
            {
                if (hash.ContainsKey(guess[i]))
                {
                    countOfB++;//這裡得到的是計算機生成樹與用戶所猜數重複的個數
                }
            }
            countOfB = countOfB - countOfA;//重複的數字減去位置也相同的數得到B的個數
            return string.Format("{0}A{1}B", countOfA, countOfB);


        }
        //outPutToLabel用來控制結果輸出到那個label中
        int outPutToLabel = 1;
        //該函數用來輸出結果到label中，
        //參數re位通過result函數比較后得到的結果
        public void OPToLabel(string re)
        {
            switch (outPutToLabel)
            {

                case 1: lb1.Text = re; outPutToLabel++; break;
                case 2: lb2.Text = re; outPutToLabel++; break;
                case 3: lb3.Text = re; outPutToLabel++; break;
                case 4: lb4.Text = re; outPutToLabel++; break;
                case 5: lb5.Text = re; outPutToLabel++; break;
                case 6: lb6.Text = re; outPutToLabel++; break;
                case 7: lb7.Text = re; outPutToLabel++; break;
                case 8: lb8.Text = re; outPutToLabel++; break;
                case 9: lb9.Text = re; outPutToLabel++; break;
                case 10: lb10.Text = re; outPutToLabel++; break;

            }


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        //這個函數用來刪除數組a中的一個數
        //arr是數組
        //num是要從數組arr中刪除的數
        public static int[] DeleteArr(int num, int[] arr)
        {
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                list.Add(i);//把数组的每一个元素保存到一个集合中
            }
            list.Remove(num);//根据集合删除指定下标的元素
            arr = new int[list.Count];//重新new一个数组
            for (int j = 0; j < list.Count; j++)
            {
                arr[j] = list[j];//把删除后的集合每一个保存到该数组
            }
            return arr;//返回该数组
        }


        //把字符串數組中的某條記錄刪除
        public static string[] DeleteStrArr(string str, string[] StrArr)
        {
            List<string> list = new List<string>();
            foreach (string i in StrArr)
            {
                list.Add(i);//把数组的每一个元素保存到一个集合中
            }
            list.Remove(str);//根据集合删除指定下标的元素
            StrArr = new string[list.Count];//重新new一个数组
            for (int j = 0; j < list.Count; j++)
            {
                StrArr[j] = list[j];//把删除后的集合每一个保存到该数组
            }
            return StrArr;//返回该数组
        }

        //這個函數用來為數組a增加一個數
        //arr是數組
        //num是要加入數組arr中的數
        public static int[] AddArr(int num, int[] arr)
        {
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                list.Add(i);//把数组的每一个元素保存到一个集合中
            }
            list.Add(num);//根据集合删除指定下标的元素
            arr = new int[list.Count];//重新new一个数组
            for (int j = 0; j < list.Count; j++)
            {
                arr[j] = list[j];//把删除后的集合每一个保存到该数组
            }
            return arr;//返回该数组
        }


        

        //把數組轉化為string，並且每個元素用“，”隔開
        string strAfterInser="";

        public int spanTime = 0;

        private void button13_Click(object sender, EventArgs e)
        {
            string guessNum = this.lbGuess();
            if (guessNum == "")
            {
                lbNote.Text = "輸入數字不能小於4位";
            }
            else
            {
                string result = this.Result(strGene, guessNum);
                OPToLabel(result);
                //判斷結果是否正確，結果正確則彈出“恭喜”窗口，並且時間停止，並且還要把時間插入數據庫
                if (result == "4A0B")
                { 
                    //這裡彈出“恭喜”的窗口
                    timer1.Stop();
                    //計算時間
                    int spantimeM = int.Parse(lbTimeSpan.Text.Substring(5, 2));
                    int spantimeS = int.Parse(lbTimeSpan.Text.Substring(8, 2));
                    spanTime = spantimeM * 60 + spantimeS;



                    //把1.txt中的數字讀取出來，并放到一個數組中
                    StreamReader readfromFile = new StreamReader("D:/1.txt", Encoding.Default);
                    string hitory = readfromFile.ReadLine();
                    readfromFile.Close();


                    string[] temp = hitory.Split(',');

                    int[] a = new int[] { 0, 0, 0, 0, 0 };
                    for (int j=0; j < 5; j++)
                    {
                         //int[] a =new int[]{0,0,0,0,0};
                         a[j]= int.Parse(temp[j]);//數組a[]存放著5個時間數
                    }

                    //找出a[]中最大的數字，和本次用時比較，如果最大數比本次用時還要大則刪除數組中的最大數

                    int max = a[0];
                    for (int i = 1; i < 5;i++ )
                    {
                        if (max < a[i]) max = a[i];//這樣max中存放的就是數組中最大的數啦

                    }
                    //如果最大數比本次用時還要大則刪除數組中的最大數
                    if (max > spanTime)
                    {
                        //把數組a[]中的等於max的數刪除掉
                        a = DeleteArr(max, a);
                        //把本次所用時間插入到數組中
                        a = AddArr(spanTime, a);//這樣a[]中就存放了新加入的5條記錄
                        //把a[]放回到D:/1.txt中
                        //string strAfterInser;//把數組轉化為string，並且每個元素用“，”隔開
                        foreach (int array in a)
                        {
                            string str;
                            str = array.ToString();
                            str = str + ",";
                            strAfterInser += str;

                        }
                        //把str重新寫入到D:/1.txt中
                        FileStream fs = new FileStream("D:/1.txt", FileMode.Create);
                        StreamWriter writeFile = new StreamWriter(fs);
                        writeFile.Write(strAfterInser);
                        writeFile.Close();
                        //同時也要把D:/2.txt中的最後一名刪除掉
                        StreamReader TopFive = new StreamReader("D:/2.txt", Encoding.Default);
                        string top = TopFive.ReadLine();
                        TopFive.Close();
                        string[] scoreAndName = top.Split(',');
                        string thelastOneScoreName="";
                        foreach (string scoreName in scoreAndName)
                        {
                            if (scoreName.Contains(max .ToString ()))//找到了最大的那條記錄
                            {
                                //把最大的那條記錄刪除，并重新寫到D:/2.txt，這時D:/2.txt中只有4條記錄
                                thelastOneScoreName = scoreName;//找到最大那條記錄
                            }
                        }
                        //把最大的那條記錄刪除
                        string[] afterDeleteLastScoreName = DeleteStrArr(thelastOneScoreName, scoreAndName);//afterDeleteLastScoreName數組存放著刪除最記錄的排行榜數組
                        //把string[]轉化為string
                        string newFourRecord="";
                        foreach (string array in afterDeleteLastScoreName)
                        {
                            string str= array;
                            if (array != "")
                            {
                                str = str + ",";
                                newFourRecord += str;
                            }
                        }
                        
                        //把這4個記錄重新寫到D:/2.txt中
                        FileStream fs2 = new FileStream("D:/2.txt", FileMode.Create);
                        StreamWriter writeScoreName = new StreamWriter(fs2);
                        writeScoreName.Write(newFourRecord);
                        writeScoreName.Close();


                        //彈出恭喜進入前5名的窗口
                        Top5 tp = new Top5();
                        tp.Show();

                    }
                    else//成功但是并不進入前5則彈出“恭喜”窗口，用戶可以接著挑戰
                    {
                        congratulate cg = new congratulate();
                        cg.Show();
                        cg.evtFrm += new congratulate.ShowFrm(restart);
                    }
                   
                    ////D:/2.txt中的內容是排行榜，包括名字及用時
                    //StreamReader TopFive = new StreamReader("D:/2.txt", Encoding.Default);
                    //string top = TopFive.ReadLine();
                    //string[] scoreAndName = top.Split(',');

                   
                }




                //結果不正確了，而且已近玩了10次了的話，則彈出“失敗”的窗口，而且時間停止。
                if (focusIntxt ==10)
                { 
                    //彈出失敗窗口
                    //委託：
                    failcs fl = new failcs();
                    fl.Show();
                    fl.evtFrm += new failcs.ShowFrm(restart);

                    
                }
                //結果并不正確，但是所玩的次數還沒為10，則次數加1。
                focusIntxt++;
            }
            lbNote.Text = "";
        }
        //当点击重新开始时，刷新页面
        private void restart(object sender, EventArgs e)
        {
            //this.Refresh();
            Form1_Load(this, null);
            count = 0;
            focusIntxt = 1;
            outPutToLabel = 1;

        }


        

        //当点击查排行榜时
        private void Ranklist(object sender, EventArgs e)
        {
            //弹出排行榜窗口
            frmRankList freRank = new frmRankList();
            freRank.Show();

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }
        //當點擊刪除按鈕時
        private void button11_Click(object sender, EventArgs e)
        {
            switch (focusIntxt)
            {
                case 1: if (lbGuess1.Text.Length > 0) { lbGuess1.Text = lbGuess1.Text.Substring(0, lbGuess1.Text.Length - 1); } else lbGuess1.Text = ""; break;
                case 2: if (lbGuess2.Text.Length > 0) {lbGuess2.Text = lbGuess2.Text.Substring(0, lbGuess2.Text.Length - 1);}   else lbGuess2.Text = ""; break;
                case 3: if (lbGuess3.Text.Length > 0) {lbGuess3.Text = lbGuess3.Text.Substring(0, lbGuess3.Text.Length - 1);}   else lbGuess3.Text = ""; break;
                case 4: if (lbGuess4.Text.Length > 0) {lbGuess4.Text = lbGuess4.Text.Substring(0, lbGuess4.Text.Length - 1);}   else lbGuess4.Text = ""; break;
                case 5: if (lbGuess5.Text.Length > 0) {lbGuess5.Text = lbGuess5.Text.Substring(0, lbGuess5.Text.Length - 1);}   else lbGuess5.Text = ""; break;
                case 6: if (lbGuess6.Text.Length > 0) { lbGuess6.Text = lbGuess6.Text.Substring(0, lbGuess6.Text.Length - 1);}  else lbGuess6.Text = ""; break;
                case 7: if (lbGuess7.Text.Length > 0) {lbGuess7.Text = lbGuess7.Text.Substring(0, lbGuess7.Text.Length - 1);}   else lbGuess7.Text = ""; break;
                case 8: if (lbGuess8.Text.Length > 0) { lbGuess8.Text = lbGuess8.Text.Substring(0, lbGuess8.Text.Length - 1); } else lbGuess8.Text = "";break;
                case 9: if (lbGuess9.Text.Length > 0) {lbGuess9.Text = lbGuess9.Text.Substring(0, lbGuess9.Text.Length - 1);}   else lbGuess9.Text = ""; break;
                case 10:if (lbGuess10.Text.Length > 0) { lbGuess10.Text = lbGuess10.Text.Substring(0, lbGuess10.Text.Length - 1); } else lbGuess10.Text = ""; break;
            }

        }
        //當點擊清空按鈕時
        private void button12_Click(object sender, EventArgs e)
        {
            switch (focusIntxt)
            {
                case 1: lbGuess1.Text = ""; break;
                case 2: lbGuess2.Text ="" ; break;
                case 3: lbGuess3.Text ="" ; break;
                case 4: lbGuess4.Text = ""; break;
                case 5: lbGuess5.Text = ""; break;
                case 6: lbGuess6.Text ="" ; break;
                case 7: lbGuess7.Text = ""; break;
                case 8: lbGuess8.Text = ""; break;
                case 9: lbGuess9.Text = ""; break;
                case 10: lbGuess10.Text = ""; break;
            }
        }

        public  void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Start();
            TimeSpan sp = DateTime.Now-dt ;
            lbTimeSpan.Text ="所用時間：" +string.Format("{0:d2}:{1:d2}",  sp.Minutes, sp.Seconds);
            if (outPutToLabel == 11)
            {
                timer1.Stop();
            }
        }
    }
}
