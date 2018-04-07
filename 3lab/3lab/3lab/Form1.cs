using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lab
{
    public class Phone
    {
    
        public int Number { get; set; }
        public string Brand { get; set;}
        public int power { get; set; }
        public int kol_proc { get; set; }
        public int pixel { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }

    }

    public class PhonePost
    {

        public int Number { get; set; }
        public string Brand { get; set; }
        public int power { get; set; }
        public int kol_proc { get; set; }
        public int pixel { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }

    }




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Phone> phones = new List<Phone>
            {
                new Phone {Number = 0, Brand="Microsoft",power=300,kol_proc=2,pixel=12,height=150,width=90,depth=20 },
                new Phone {Number = 1, Brand="Microsoft",power=320,kol_proc=2,pixel=15,height=150,width=90,depth=20 },
                new Phone {Number = 2, Brand="LG",power=230,kol_proc=2,pixel=12,height=130,width=90,depth=20  },
                new Phone {Number = 3, Brand="Apple",power=100,kol_proc=2,pixel=13,height=124,width=90,depth=20  },
                new Phone {Number = 4, Brand="Microsoft" ,power=330,kol_proc=2,pixel=12,height=150,width=90,depth=20 },
                new Phone {Number = 5, Brand="Apple",power=370,kol_proc=2,pixel=17,height=150,width=90,depth=20  },
                new Phone {Number = 6, Brand="Microsoft",power=400,kol_proc=2,pixel=12,height=150,width=90,depth=20  },
                new Phone {Number = 7, Brand="Apple",power=100,kol_proc=2,pixel=13,height=124,width=90,depth=20  },
                new Phone {Number = 8, Brand="Microsoft" ,power=330,kol_proc=2,pixel=12,height=150,width=90,depth=20 },
                new Phone {Number = 9, Brand="Apple",power=370,kol_proc=2,pixel=17,height=150,width=90,depth=20  }
            };

            List<PhonePost> phonesdata = new List<PhonePost>();


            var phoneGroups = from phone in  phones
                             group phone by phone.Brand;

            int i = 0;
            int n = 0;
            int kol = 0;

            foreach (IGrouping<string, Phone> group in phoneGroups)
            {


                phonesdata.Add(new PhonePost {});

                foreach (Phone c in group)
                {
                    phonesdata[i].Brand = c.Brand;
                    phonesdata[i].height = phonesdata[i].height+ c.height;
                    phonesdata[i].width = phonesdata[i].width+ c.width;
                    phonesdata[i].depth = phonesdata[i].depth+c.depth;
                    phonesdata[i].kol_proc = phonesdata[i].kol_proc+c.kol_proc;
                    phonesdata[i].pixel = phonesdata[i].pixel+ c.pixel;
                    phonesdata[i].power = phonesdata[i].power+c.power;
                    kol++;
                }


                phonesdata[i].Number = i;
                phonesdata[i].height = phonesdata[i].height / kol;
                phonesdata[i].width = phonesdata[i].width / kol;
                phonesdata[i].depth = phonesdata[i].depth  / kol;
                phonesdata[i].kol_proc = phonesdata[i].kol_proc / kol;
                phonesdata[i].pixel = phonesdata[i].pixel / kol;
                phonesdata[i].power = phonesdata[i].power / kol;

                i++;
                n = i;
            }

            int X1=100;
            int X2=12;
            int X3=34;
            int X4=45;
            int X5=56;
            int X6=23;
            int[] sum = new int[10];
            int MAX = 0;
            string type = "";

            for (i = 0; i < n; i++)
            {
                sum[i] = 2 * (phonesdata[i].power * X1 + phonesdata[i].kol_proc * X2 + phonesdata[i].height * X3 + phonesdata[i].width * X4 + phonesdata[i].depth * X5 + phonesdata[i].pixel * X6) - (phonesdata[i].height * phonesdata[i].height+ phonesdata[i].depth * phonesdata[i].depth+phonesdata[i].kol_proc * phonesdata[i].kol_proc+phonesdata[i].power * phonesdata[i].power+ phonesdata[i].pixel * phonesdata[i].pixel+phonesdata[i].width * phonesdata[i].width);
            }

            for (i = 0; i < n; i++)
            {
                if (MAX < sum[i])
                {
                    type = phonesdata[i].Brand;
                }
            }

            Console.WriteLine();



            List<Phone> phones1 = new List<Phone>
            {
                new Phone {Number = 0, Brand="Microsoft",power=300,kol_proc=2,pixel=12,height=150,width=90,depth=20 },
                new Phone {Number = 1, Brand="Microsoft",power=320,kol_proc=2,pixel=15,height=150,width=90,depth=20 },
                new Phone {Number = 3, Brand="Microsoft",power=100,kol_proc=2,pixel=13,height=124,width=90,depth=20  },
                new Phone {Number = 1, Brand="Microsoft",power=320,kol_proc=2,pixel=15,height=150,width=90,depth=20 },
                new Phone {Number = 3, Brand="Apple",power=100,kol_proc=2,pixel=13,height=124,width=90,depth=20  },
          

            };

            int W1 = 0;
            int W2 = 0;
            int W3 = 0;


            int D = 0;
            int E = 0;


            for(i = 1; i < 4; i++)
            {
                if (phones1[i].Brand!= phones1[i+1].Brand && D<0)
                {
                    W1 = phones1[i].height;
                    W2 = phones1[i].width;
                    W3 = phones1[i].depth;
                    D =(W1-phones1[i-1].height)* phones1[i].height + (W2-phones1[i].width)*phones1[i].width + (W3-phones1[i].depth)*phones1[i].depth;
                    E = 0;   
                }

                else
                {
                    W1 = phones1[i - 1].height;
                    W2 = phones1[i - 1].width;
                    W3 = phones1[i - 1].depth;
                    D = W1 * phones1[i].height + W2 * phones1[i].width + W3 * phones1[i].depth;
                    E++;
                }
            }

            int x1 = 22;
            int x2 = 12;
            int x3 = 13;

            D = W1 *x1+ W2 *x2 + W3 *x3;

            if (D > 0)
            {
                
            }
            else
            {

            }



        }
    }
}
