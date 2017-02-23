using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria_Progra
{
    public partial class Form1 : Form
    {
       
        PictureBox[,] memory1 = new PictureBox[6, 6]; //This matrix is with images
        int[,] logic = new int[6, 6];  //This matrix is with numbers
        
        Control m_control;
        int cont = 0;
        int cont1 = 0; 
        int cont2 = 0;


        int positionIFirstImage= 0;
        int positionKFirstImage = 0;

        int positionISecondImage = 0;
        int positionKSecondImage = 0;


        bool playerSearch = false;  //True==FirstPlayer, False==SecondPlayer

        int point1 = 0; //Accumulated points of first player
        int point2 = 0;  //Accumulated points of second player    

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            label5.Visible = false; 
        }


        //Creation of memory
        public void MakeMemory()
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < memory1.GetLength(0); i++)
            {
                for (int k = 0; k < memory1.GetLength(1); k++)
                {
                    memory1[i, k] = new PictureBox();
                    memory1[i, k].BackgroundImage = global::Memoria_Progra.Properties.Resources.dddd;
                    memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                    memory1[i, k].BackColor = System.Drawing.Color.Transparent;
                    memory1[i, k].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    memory1[i, k].Location = new System.Drawing.Point(x, y);
                    memory1[i, k].Name = "";
                    memory1[i, k].Size = new System.Drawing.Size(100, 100);
                    memory1[i, k].TabIndex = 2;
                    memory1[i, k].TabStop = false;
                    memory1[i, k].Visible= true;
                    memory1[i, k].Enabled= true;
                    memory1[i, k].Click += new System.EventHandler(poner_imagen_click); //OnClick in the images
                    this.Controls.Add(memory1[i, k]); //Get the properties and then can to be display in all images of memory1

                    x = x + 100;
                }
                x = 10;
                y = y + 100;
            }
        }    

          
        public void poner_imagen_click(object sender, EventArgs e)
        {
            // when the user  touch the image

            m_control = (Control)sender; //Get position of image

           // if (e.Button.ToString() == "Right")
            {
                for (int i = 0; i < memory1.GetLength(0); i++)
                {
                    for (int k = 0; k < memory1.GetLength(1); k++)
                    {
                        if (memory1[i, k] == m_control)
                        {
                            if (logic[i, k] == 1)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.jean;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            if (logic[i, k] == 2)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.exportaciones;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                            
                            }
                            if (logic[i, k] == 3)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.tecnologia_1;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            if (logic[i, k] == 4)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources._59722_405808282845117_306676601_n;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                             }
                            if (logic[i, k] == 5)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources._10463944_921920514488013_3688029206722660249_n;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            if (logic[i, k] == 6)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.descarga;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            if (logic[i, k] == 7)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.images__1_;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                             }
                            if (logic[i, k] == 8)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.diamantesuniversogran;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                              
                            }
                            if (logic[i, k] == 9)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.QQ截图20131009153934;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                              
                            }
                            if (logic[i, k] == 10)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.images__11_;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                             
                            }
                            if (logic[i, k] == 11)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.images__5_;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                                
                            }
                            if (logic[i, k] == 12)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.EVOLUTION;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                              
                                                                                         
                            }
                            if (logic[i, k] == 13)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.man;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;

                             }
                            if (logic[i, k] == 14)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.bks;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                               
                            }
                            if (logic[i, k] == 15)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.bb;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                            
                            }
                            if (logic[i, k] == 16)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.mono;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                                                             
                            }
                            if (logic[i, k] == 17)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.xz;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;

                             }
                            if (logic[i, k] == 18)
                            {
                                memory1[i, k].BackgroundImage = Properties.Resources.cc;
                                memory1[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            

                            if (cont1 == 0)
                            {
                                   //Get first position
                                    positionIFirstImage = i;
                                    positionKFirstImage = k;

                                   //Get first number
                                    cont1 = logic[i, k];
                                    memory1[i, k].Enabled = false;
                                break;
                            }
                            else
                               if(cont2==0 )
                                {
                                    //Get first position
                                    positionISecondImage = i;
                                    positionKSecondImage = k;

                                    //Get second number
                                    cont2 = logic[i, k];
                                        break;
                                        
                                }                                                 
                        }
                       
                    }
                }
                if(cont1!=0 && cont2!=0)
                {
                    if (cont1 == cont2 ) //Verify if the number are equals
                    {
                        GetPoints(playerSearch);

                        cont1 = 0; //start with other images
                        cont2 = 0; // start with other images

                        if (GameFinished())
                        {
                            WinningPlayer();
                            //button1.Enabled = true;
                            //button1.Visible = true;
                        }
                    }
                    else
                    {
                        if (playerSearch == false)
                        {
                            playerSearch = true; //Turn on second player                           

                           
                            EnableImages(positionIFirstImage, positionKFirstImage);
                            EnableImages(positionISecondImage, positionKSecondImage);

                            Flip(positionIFirstImage, positionKFirstImage); //here the image  hide
                            Flip(positionISecondImage, positionKSecondImage);//here the image hide

                            cont1 = 0; //start with other images
                            cont2 = 0; // start with other images
                        }
                        else 
                        {
                            playerSearch = false; //Turn on first player                          

                            
                            EnableImages(positionIFirstImage, positionKFirstImage);
                            EnableImages(positionISecondImage, positionKSecondImage);

                            Flip(positionIFirstImage, positionKFirstImage);//here the image  hide
                            Flip(positionISecondImage, positionKSecondImage);//here the image  hide

                            cont1 = 0; //start with other images
                            cont2 = 0; // start with other images
                        }
                            
                    }
                    
                }
                    
            }    
        }
        private void GetPoints(bool player)
        {
            //If player==false is the point1
            //If player==true is the point2

            if(player==false)
            {
                point1++; //The score of first Player increases
                MessageBox.Show("Good Job first player, you can play again!");

                DeleteImages(positionIFirstImage,positionKFirstImage);
                DeleteImages(positionISecondImage, positionKSecondImage);

                label3.Text = point1.ToString();
            }
            else
            {
                point2++; //The score of second Player increases
                MessageBox.Show("Good Job second player, you can play again!");

                DeleteImages(positionIFirstImage, positionKFirstImage);
                DeleteImages(positionISecondImage, positionKSecondImage);

                label4.Text = point2.ToString();
            }            
        }
           //Game
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;            
            button1.Visible = false;
            ButtonBlock();
            MakeMemory();
            RandomOrder();

        }
        public void RandomOrder()
        {
            //Here can to display the RandomOrder in the memory and also for logic part
            Random random = new Random();
            int x = 1;
            int y = 1;
            int f, c;

            while (cont < 18)
            {
                f = random.Next(6);
                c = random.Next(6);
                if (logic[f, c] == 0)
                {
                    logic[f, c] = x;
                    x++;
                    cont++;
                }
            }
            cont = 0;
            while (cont < 18)
            {
                f = random.Next(6);
                c = random.Next(6);
                if (logic[f, c] == 0)
                {
                    logic[f, c] = y;
                    y++;
                    cont++;
                }
            }
            //note the mouse event can to detect of click
        }
        private void Flip(int x,int y)
        {

            //Original status the images
            for (int i = 0; i < memory1.GetLength(0); i++)
            {
                if(i==x)
                for (int k = 0; k < memory1.GetLength(1); k++)
                {
                    if(k==y)
                    memory1[i, k].BackgroundImage = Properties.Resources.dddd;
                }

            }
        }
        public void DeleteImages(int x,int y)
        {
            //Delete Images that are good

            for (int i = 0; i < memory1.GetLength(0); i++)
            {
                if(i==x)
                for (int k = 0; k < memory1.GetLength(1); k++)
                {
                    if(k==y)
                    {
                        memory1[i, k].Visible = false;
                        
                    }
                }
            }
        }
        private bool GameFinished()
        {
            //In this method we are going to verify if the game finished

            for (int i = 0; i < memory1.GetLength(0); i++)
            {               
                for (int k = 0; k < memory1.GetLength(1); k++)
                {
                   if (memory1[i, k].Visible != false)
                    {
                        return false;
                    }                        
                }
            }
            return true;
        }

        private void WinningPlayer()
        {
            //In this method we can to estimate  who is the winner
            

            if(point1 > point2)
              label5.Text = "Player 1 is the winner!";
            

            if(point2 > point1)
               label5.Text = "Player 2 is the winner!";
            

            if(point1==point2)
                label5.Text = "Equal score!";

            label5.Visible = true;
        }


        public void EnableImages(int x, int y)
        {
            //Original status the images that are  Disabled

            for (int i = 0; i <memory1.GetLength(0); i++)
            {
                if(i==x)
                for (int k = 0; k <memory1.GetLength(1); k++)
                {
                    if(k==y)
                    memory1[i, k].Enabled = true;   
                }
            }
        }

        public void ButtonBlock()
        {
            button1.Visible = false;
            button1.Enabled = false;
        }   

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   



