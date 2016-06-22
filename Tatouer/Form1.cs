using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatouer
{
    public partial class Form1 : Form
    {
        Image image,image2;
        Dictionary<string, Color> conversion= new Dictionary<string, Color>();
        Dictionary<int, Color> espace = new Dictionary<int, Color>();

        public Form1()
        {
            InitializeComponent();
            //remplissage de tableau de conversion d'alphabet en couleur 
            conversion.Add("a", Color.DarkGreen);
            conversion.Add("b", Color.YellowGreen);
            conversion.Add("c", Color.Azure);
            conversion.Add("d", Color.Beige);
            conversion.Add("e", Color.Black);
            conversion.Add("f", Color.Blue);
            conversion.Add("g", Color.Brown);
            conversion.Add("h", Color.Cyan);
            conversion.Add("i", Color.Gold);
            conversion.Add("j", Color.Gray);
            conversion.Add("k", Color.Green);
            conversion.Add("l", Color.Lavender);
            conversion.Add("m", Color.Magenta);
            conversion.Add("n", Color.Maroon);
            conversion.Add("o", Color.Navy);
            conversion.Add("p", Color.Orange);
            conversion.Add("q", Color.Orchid);
            conversion.Add("r", Color.Peru);
            conversion.Add("s", Color.Pink);
            conversion.Add("t", Color.Plum);
            conversion.Add("u", Color.Purple);
            conversion.Add("v", Color.Salmon);
            conversion.Add("w", Color.Tan);
            conversion.Add("x", Color.Violet);
            conversion.Add("y", Color.Wheat);
            conversion.Add("z", Color.Yellow);
            conversion.Add(" ", Color.Red);
            //remplissage tableau pour les espace entre deux alphabets(espace max=30) 
            //cette valeur sera stocké dans le pixel(299,199)
            espace.Add(5, Color.Red);
            espace.Add(10, Color.Green);
            espace.Add(15, Color.Blue);
            espace.Add(20, Color.Yellow);
            espace.Add(25, Color.Gray);
            espace.Add(30, Color.Black);
           
        }

        private void Ouvrirbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }


        }

        private void tatouerbtn_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Bitmap bit;
                bit = new Bitmap(image);
                //recuperation text
               String txt=textarea.Text;
                String c="";
                Color j;
                int x=0, y=0;
                //ajout des pixels au bitmap 
                for (int i = 0; i < txt.Length; i++)
                {
                    c = txt[i] + "";
                   j=conversion[c];
               bit.SetPixel(x,y,j);
               x += 10;
               if (x >= 300)
               { y += 10; x = 0; }
               if (y >= 200)
                   break;
                }
                //definition pixel qui concerne l'espace
                bit.SetPixel(299, 199, espace[10]);

                //affichage image dans le picturebox
                Image image1 = bit;
                pictureBox1.Image = image1;
            }
            else
                MessageBox.Show("Ajouter une image", "Tatouage");
            
                
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "unknown.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void ouvrirbtn2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image2 = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = image2;
            }

        }
    
        private void extrairebtn_Click(object sender, EventArgs e)
        {
            if (image2 != null)
            {
                Bitmap bit;
                bit = new Bitmap(image2);
                //recuperation text d'apres l'image tatouee
                String txt="";
                //recuperation du valeur de l'espace entre 2 caractere 
                Color cc=bit.GetPixel(299, 199);
                int pas=0;
               
                String liste_alphabet = "abcdefghijklmnopqrstuvwxyz ";
                for (int i = 5; i <= 30; i += 5)
                {

                 
                    if (espace[i].ToArgb() == cc.ToArgb())
                    {
                        pas = i;
                        break;
                    }
                }
            
                //recuperation des pixels du bitmap 
                for (int i = 0; i <200; i+=pas)
                {
                    for(int z=0;z<300;z+=pas)
                    {
                        //textarea2.Text += i + "-"+z+"/";
                        cc = bit.GetPixel(z, i);
                        
                        //si couleur blanc on sort parce que c'est la fin de la chaine
                        if(cc.ToArgb()==Color.White.ToArgb())
                            break;
                           
                    for (int k = 0; k < liste_alphabet.Length; k++)
                    {
                        
                        if (conversion[liste_alphabet[k]+""].ToArgb() == cc.ToArgb())
                        {
                            txt = txt + liste_alphabet[k];
                            break;
                        }
                    }
                    }
                }
                textarea2.Text = txt;
                
           }
            else
                MessageBox.Show("Ajouter une image", "Tatouage");
        }
    }
}
