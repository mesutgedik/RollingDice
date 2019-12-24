using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollingDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x=0, y=0;
        int counter = 0;
        int sum1=0, sum2=0;
        int[] sum = new int[10];

        Image[] DiceSurface =
        {
            Properties.Resources.dice1, // resimleri arraye attık.
            Properties.Resources.dice2,
            Properties.Resources.dice3,
            Properties.Resources.dice4,
            Properties.Resources.dice5,
            Properties.Resources.dice6
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            lblWhichPlayer.Text = "PLAYER1 TURN";

        }

        private void rollDice()
        {
            
            Random rnd = new Random();
            for(int i = 0; i < 7; i++)// zarı 6 kere çevirerek random bir zar değeri aldık
            {
                x = rnd.Next(0, 6);
                y = rnd.Next(0, 6);
                System.Threading.Thread.Sleep(100);
                PcBox1.Image = DiceSurface[x]; // her gelen x değeri için yüzeyin resmini değiştir.
                PcBox2.Image = DiceSurface[y]; // her gelen y değeri için yüzeyin resmini değiştir.
                PcBox1.Refresh(); // resimler hemen güncellensin diye refresliyoruz
                PcBox2.Refresh(); //resimler hemen güncellensin diye refresliyoruz
            }
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            
            if (counter < 5) // ilk 5 atışın ilk kullanıcı için olsunu denetliyoruz
            {
                
                rollDice(); // zarları karıştır ve yeni değerler getir.
                sum[counter] = x + y + 2; // sum[counter] bize o andaki çıkan 2 zarın değerleri toplamını o anki adresinde tutuyor.
                listBox1.Items.Insert(0, sum[counter] ); // insert işleminde listboxa yeni değer eklemiş oluyoruz.
                listBox1.Refresh(); // atama yapıldıktan hemen sonra listboxı yeniden yüklemek için kullanıyoruz.
                counter++; // roll sayısını tutmak için
                if (counter == 5)
                {
                    lblWhichPlayer.Text = "PLAYER2 TURN";
                }


            }
            else if (counter < 10)// son 5 atışın ikinci kullanıcı için olsunu denetliyoruz
            {
              
                
                rollDice();
                sum[counter] = x + y + 2;
                listBox2.Items.Insert(0, sum[counter]);
                listBox2.Refresh();
                if (counter == 9) // yani toplamda 10 tane zar atılmış ve oyun bitmiş demektir.
                {
                    System.Threading.Thread.Sleep(200); // son gelen değeri görebilmek için 1 snyenin 5 te biri kadar bekliyoruz
                    gameFinished(); // oyunu bitir fonksiyonu
                }
                else
                {
                    counter++;
                }
                
             
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                item.Visible = true; // bütün contolleri görünür yap
            }
            Visible_Change();
            sum1 = 0;
            sum2 = 0;
            lblWhichPlayer.Text = "PLAYER1 TURN";

        }

        private void gameFinished() 
        {
            counter = 0;
            foreach(Control item in Controls)
            {
                item.Visible = false; // bütün controlleri görünmez yapıyor.
            }

            for (int i = 0; i < 5; i++)
            {
                sum1 += sum[i]; // player1 in toplam puanını hesapladıgımız kısım

            }
            
           for(int i = 5; i < 10; i++)
            {
                sum2 += sum[i];// player2 in toplam puanını hesapladıgımız kısım
            }
            label3.Text = sum1.ToString(); // player1in değerini label3 e yazdırıyoruz.
            label4.Text = sum2.ToString();// player2in değerini label4 e yazdırıyoruz.

            if (sum1 < sum2)
            {
                lblWinner.Text = "WINNER IS PLAYER2";
                
            }
            else if (sum1 > sum2)
            {
                lblWinner.Text = "WINNER IS PLAYER1";
                
            }
            else
            {
                lblWinner.Text = "SCORLESS GAME";
                
            }
            Visible_Change();
            listBox1.Items.Clear(); // listbox itemlerni temizliyoruz.
            listBox2.Items.Clear();

        }
        private void Visible_Change() // görünür ya da görünmez yapmak için kullandık.
        {
            if (lblWinner.Visible == false)
            {
                lblWinner.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btnNewGame.Visible = true;
                btnQuit.Visible = true;
            }
            else // new game dersem bu kısım devreye giriyor. Çünkü if koşulundaki lblwinner görünür modda oldugundan, if koşuluna girmiyor bu nedenlede else komutu çalışıypr.
            {
                lblWinner.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                btnNewGame.Visible = false;
                btnQuit.Visible = false;
            }
            
        }
   
    }
}
