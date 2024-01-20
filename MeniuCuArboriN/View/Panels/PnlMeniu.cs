using MeniuCuArboriN.ArboriN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeniuCuArboriN.View.Panels
{
    public class PnlMeniu : Panel
    {
        Form1 form;

        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;

        Button btnImg1;
        Button btnImg2;
        Button btnImg3;
        Button btnImg4;
        Button btnImg5;
        Button btnImg6;
        Button btnImg7;
        Button btnImg8;


        string path;

        List<ArboriN<Button>> listArbori;
        List<Button> buttonList;

        string tag;
        public PnlMeniu(Form1 form1) {
        
            this.form = form1;

            listArbori = new List<ArboriN<Button>>();

            this.Name = "PnlMeniu";
            this.Size = new System.Drawing.Size(322, 768);
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Font = new System.Drawing.Font("Century Gothic", 12);

            tag = "close";

            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();

            this.btnImg1 = new Button();
            this.btnImg2 = new Button();
            this.btnImg3 = new Button();
            this.btnImg4 = new Button();
            this.btnImg5 = new Button();
            this.btnImg6 = new Button();
            this.btnImg7 = new Button();
            this.btnImg8 = new Button();

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);

            this.btn1.Controls.Add(this.btnImg1);
            this.btn2.Controls.Add(this.btnImg2);
            this.btn3.Controls.Add(this.btnImg3);
            this.btn4.Controls.Add(this.btnImg4);
            this.btn5.Controls.Add(this.btnImg5);
            this.btn6.Controls.Add(this.btnImg6);
            this.btn7.Controls.Add(this.btnImg7);
            this.btn8.Controls.Add(this.btnImg8);

            path = Application.StartupPath + @"/data/img/";

            buttonList = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };

            //btnimg1
            this.btnImg1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg1.FlatAppearance.BorderSize = 0;
            this.btnImg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg1.Image = Image.FromFile(path + "right.png");
            this.btnImg1.Location = new System.Drawing.Point(174, 17);
            this.btnImg1.Size = new System.Drawing.Size(31, 27);
            this.btnImg1.Name = "btnImg1";

            //btnImg2
            this.btnImg2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg2.FlatAppearance.BorderSize = 0;
            this.btnImg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg2.Image = Image.FromFile(path + "right.png");
            this.btnImg2.Location = new System.Drawing.Point(174, 17);
            this.btnImg2.Size = new System.Drawing.Size(31, 27);
            this.btnImg2.Name = "btnImg2";

            //btnimg3
            this.btnImg3.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg3.FlatAppearance.BorderSize = 0;
            this.btnImg3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg3.Image = Image.FromFile(path + "right.png");
            this.btnImg3.Location = new System.Drawing.Point(174, 17);
            this.btnImg3.Size = new System.Drawing.Size(31, 27);
            this.btnImg3.Name = "btnImg3";

            //btnImg4
            this.btnImg4.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg4.FlatAppearance.BorderSize = 0;
            this.btnImg4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg4.Image = Image.FromFile(path + "right.png");
            this.btnImg4.Location = new System.Drawing.Point(174, 17);
            this.btnImg4.Size = new System.Drawing.Size(31, 27);
            this.btnImg4.Name = "btnImg4";

            //btnImg5
            this.btnImg5.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg5.FlatAppearance.BorderSize = 0;
            this.btnImg5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg5.Image = Image.FromFile(path + "right.png");
            this.btnImg5.Location = new System.Drawing.Point(174, 17);
            this.btnImg5.Size = new System.Drawing.Size(31, 27);
            this.btnImg5.Name = "btnImg5";

            //btnImg6
            this.btnImg6.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg6.FlatAppearance.BorderSize = 0;
            this.btnImg6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg6.Image = Image.FromFile(path + "right.png");
            this.btnImg6.Location = new System.Drawing.Point(174, 17);
            this.btnImg6.Size = new System.Drawing.Size(31, 27);
            this.btnImg6.Name = "btnImg6";

            //btnImg7
            this.btnImg7.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg7.FlatAppearance.BorderSize = 0;
            this.btnImg7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg7.Image = Image.FromFile(path + "right.png");
            this.btnImg7.Location = new System.Drawing.Point(174, 17);
            this.btnImg7.Size = new System.Drawing.Size(31, 27);
            this.btnImg7.Name = "btnImg7";

            //btnImg8
            this.btnImg8.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImg8.FlatAppearance.BorderSize = 0;
            this.btnImg8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg8.Image = Image.FromFile(path + "right.png");
            this.btnImg8.Location = new System.Drawing.Point(174, 17);
            this.btnImg8.Size = new System.Drawing.Size(31, 27);
            this.btnImg8.Name = "btnImg8";

            //btn1
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = FlatStyle.Flat;
            this.btn1.Size = new System.Drawing.Size(215, 61);
            this.btn1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Name = "btn1";

            //btn2
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = FlatStyle.Flat;
            this.btn2.Size = new System.Drawing.Size(215, 61);
            this.btn2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.Name = "btn2";

            //btn3
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = FlatStyle.Flat;
            this.btn3.Size = new System.Drawing.Size(215, 61);
            this.btn3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn3.Name = "btn3";

            //btn4
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = FlatStyle.Flat;
            this.btn4.Size = new System.Drawing.Size(215, 61);
            this.btn4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn4.Name = "btn4";

            //btn5
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = FlatStyle.Flat;
            this.btn5.Size = new System.Drawing.Size(215, 61);
            this.btn5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn5.Name = "btn5";

            //btn6
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = FlatStyle.Flat;
            this.btn6.Size = new System.Drawing.Size(215, 61);
            this.btn6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn6.Name = "btn6";

            //btn7
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = FlatStyle.Flat;
            this.btn7.Size = new System.Drawing.Size(215, 61);
            this.btn7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn7.Name = "btn7";

            //btn8
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = FlatStyle.Flat;
            this.btn8.Size = new System.Drawing.Size(215, 61);
            this.btn8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn8.Name = "btn8";

            this.btn1.Text = this.btn2.Text = this.btn3.Text = this.btn4.Text = this.btn5.Text = this.btn6.Text =
                this.btn7.Text = this.btn8.Text = "Text";

            this.btn1.Visible = this.btn2.Visible = this.btn3.Visible = this.btn4.Visible = this.btn5.Visible = this.btn6.Visible =
               this.btn7.Visible = this.btn8.Visible = false;

            this.btnImg1.Click += new EventHandler(btnsImg_Click);
            this.btnImg2.Click += new EventHandler(btnsImg_Click);
            this.btnImg3.Click += new EventHandler(btnsImg_Click);
            this.btnImg4.Click += new EventHandler(btnsImg_Click);
            this.btnImg5.Click += new EventHandler(btnsImg_Click);
            this.btnImg6.Click += new EventHandler(btnsImg_Click);
            this.btnImg7.Click += new EventHandler(btnsImg_Click);
            this.btnImg8.Click += new EventHandler(btnsImg_Click);

            this.btn1.Tag = this.btn2.Tag = this.btn3.Tag = this.btn4.Tag = this.btn5.Tag = this.btn6.Tag =
               this.btn7.Tag = this.btn8.Tag = tag;

            this.btnImg1.Tag = this.btnImg2.Tag = this.btnImg3.Tag = this.btnImg4.Tag = this.btnImg5.Tag = this.btnImg6.Tag =
               this.btnImg7.Tag = this.btnImg8.Tag = tag;

            //MessageBox.Show(btn1.Tag.ToString());

            ArboriN<Button> arbor1 = new ArboriN<Button>();
            arbor1.Add(null, btn1);
            arbor1.Add(btn1,btn2);
            arbor1.Add(btn1, btn3);
            arbor1.Add(btn1, btn5);
            arbor1.Add(btn3, btn4);

            ArboriN<Button> arbor2 = new ArboriN<Button>();
            arbor2.Add(null, btn6);

            ArboriN<Button> arbor3 = new ArboriN<Button>();    
            arbor3.Add(null, btn7);
            arbor3.Add(btn7, btn8);


            listArbori.Add(arbor1);
            listArbori.Add(arbor2);
            listArbori.Add(arbor3);


            createMenu();

        }

        Button findByChild(Button button)
        {

            for(int i=0;i<buttonList.Count;i++)
            {
                if (buttonList[i].Controls[0] == button)
                {
                    return buttonList[i];
                }
            }

            return null;
        }

        public void btnsImg_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            Button parent = findByChild(btn);

            if (btn.Tag.ToString().Equals("close"))
            {

                


                for (int i = 0; i < listArbori.Count; i++)
                {
                    if (listArbori[i].getNode().Value == parent)
                    {
                        TreeNodeN<Button> node = listArbori[i].findByValue(listArbori[i].getNode(), parent);
                        List<Button> list = new List<Button>();
                        list = listArbori[i].findByNode(listArbori[i].getNode(), node);
                        int s = parent.Location.Y;
                        for (int k = 0; k < list.Count; k++)
                        {
                            s += 67;
                            list[k].Location = new Point(parent.Location.X + 40, s);
                            list[k].Visible = true;
                        }
                    }
                }

                btn.Tag = "open";
            }
            else if (btn.Tag.ToString().Equals("open"))
            {

            }
          

           // MessageBox.Show(parent.Name);
        }

        public void createMenu()
        {
            int s=33;
            for(int i=0;i<listArbori.Count;i++)
            {
                s += 67;
                listArbori[i].getNode().Value.Location = new Point(0,s);
                listArbori[i].getNode().Value.Visible = true;

            }


        }


    }
}
