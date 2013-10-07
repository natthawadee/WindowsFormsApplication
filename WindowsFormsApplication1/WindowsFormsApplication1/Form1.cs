using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = ("                คำตอบของคุณ\n\n ตอนที่ 1 ข้อมูลทั่วไปของผู้ตอบแบบสอบถาม\n" + Environment.NewLine);



            if (optMale.Checked == true)
            {
                str = str + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                str = str + "เพศ : หญิง" + Environment.NewLine;
            }




                        if (opt1.Checked == true)
            {
                str = str + "อายุ :20-30 ปี" + Environment.NewLine;
            }

            if (opt2.Checked == true)
            {
                str = str + "อายุ :31-40 ปี" + Environment.NewLine;
            }

            if (opt3.Checked == true)
            {
                str = str + "อายุ :41-50 ปี" + Environment.NewLine;
            }

            if (opt4.Checked == true)
            {
                str = str + "อายุ :51-60 ปี" + Environment.NewLine;
            }


         
            if (opt5.Checked == true)
            {
                str = str + "วุฒิการศึกษา :ต่ำกว่าปริญญาตรี" + Environment.NewLine;
            }

            if (opt6.Checked == true)
            {
                str = str + "วุฒิการศึกษา :ปริญญาตรี" + Environment.NewLine;
            }

            if (opt7.Checked == true)
            {
                str = str + "วุฒิการศึกษา :ปริญญาโท" + Environment.NewLine;
            }

            if (opt8.Checked == true)
            {
                str = str + "วุฒิการศึกษา :ปริญญาเอก" + Environment.NewLine;
            }





            str = str + "\n\nตอนที่ 2 ระดับความพึงพอใจของผู้รับบริการ  \n " + Environment.NewLine;
            if (opt9.Checked == true)
            {
                str = str + "ขั้นตอนในการให้บริการมีความคล่องตัว ไม่ซับซ้อน :มาก" + Environment.NewLine;
            }

            if (opt10.Checked == true)
            {
                str = str + "ขั้นตอนในการให้บริการมีความคล่องตัว ไม่ซับซ้อน :ปานกลาง" + Environment.NewLine;
            }

            if (opt11.Checked == true)
            {
                str = str + "ขั้นตอนในการให้บริการมีความคล่องตัว ไม่ซับซ้อน :น้อย" + Environment.NewLine;
            }




            
            if (opt12.Checked == true)
            {
                str = str + "ขั้นตอนในการให้บริการมีความเหมาะสม  :มาก" + Environment.NewLine;
            }

            if (opt13.Checked == true)
            {
                str = str + "ขั้นตอนในการให้บริการมีความเหมาะสม  :ปานกลาง" + Environment.NewLine;
            }

            if (opt14.Checked == true)
            {
                str = str + "ขั้นตอนในการให้บริการมีความเหมาะสม  :น้อย" + Environment.NewLine;
            }





            
            if (opt15.Checked == true)
            {
                str = str + "ระยะเวลาในการให้บริการมีความเหมาะสม  :มาก" + Environment.NewLine;
            }

            if (opt16.Checked == true)
            {
                str = str + "ระยะเวลาในการให้บริการมีความเหมาะสม  :ปานกลาง" + Environment.NewLine;
            }

            if (opt17.Checked == true)
            {
                str = str + "ระยะเวลาในการให้บริการมีความเหมาะสม  :น้อย" + Environment.NewLine;
            }




            
            if (opt18.Checked == true)
            {
                str = str + "ให้บริการด้วยความเสมอภาคตามลำดับก่อน-หลัง  :มาก" + Environment.NewLine;
            }

            if (opt19.Checked == true)
            {
                str = str + "ให้บริการด้วยความเสมอภาคตามลำดับก่อน-หลัง  :ปานกลาง" + Environment.NewLine;
            }

            if (opt20.Checked == true)
            {
                str = str + "ให้บริการด้วยความเสมอภาคตามลำดับก่อน-หลัง  :น้อย" + Environment.NewLine;
            }



            
            if (opt21.Checked == true)
            {
                str = str + "ให้บริการด้วยความสะดวกรวดเร็ว ทันตามกำหนดเวลา  :มาก" + Environment.NewLine;
            }

            if (opt22.Checked == true)
            {
                str = str + "ให้บริการด้วยความสะดวกรวดเร็ว ทันตามกำหนดเวลา  :ปานกลาง" + Environment.NewLine;
            }

            if (opt23.Checked == true)
            {
                str = str + "ให้บริการด้วยความสะดวกรวดเร็ว ทันตามกำหนดเวลา  :น้อย";
            }


            MessageBox.Show(str, "ตรวจสอบ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }          

        }
    }

