using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haunted_House_Adventure_Game
{
    public partial class Form1 : Form
    {
        int scene = 1;
        Random randGen = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int randNum;
            randNum = randGen.Next(1, 101);
            if (e.KeyCode == Keys.M)
            {
                if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 99;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 11)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 9)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if(scene == 21)
                {
                    if(randNum <= 41)
                    {
                        scene = 24;
                    }
                    else
                    {
                        scene = 22;

                    }
                }
                else if(scene == 24)
                {
                    scene = 26;
                }
                else if(scene == 26)
                {
                    scene = 99;
                }
                else if(scene == 25)
                {
                    scene = 27;
                }
                else if (scene == 27)
                {
                    scene = 99;
                }
                else if (scene == 22)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 4)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 99;
                }
                else if (scene == 13)
                {
                    scene = 99;
                }
                else if (scene == 23)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                else if(scene == 16)
                {
                    scene = 99;
                }
                else if(scene == 15)
                {
                    scene = 99;
                }
                else if(scene == 6)
                {
                    scene = 99;
                }
                else if(scene == 8)
                {
                    scene = 99;
                }
                else if(scene == 18)
                {
                    scene = 23;
                }
                else if(scene == 99)
                {
                    scene = 1;
                }

            }
            else if (e.KeyCode == Keys.B)
            {
                if(scene == 1)
                {
                    scene = 2;
                }
                else if(scene == 2)
                {
                    scene = 6;
                }
                else if(scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 5)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
                else if (scene == 17)
                {
                    scene = 21;
                }
                else if (scene == 24)
                {
                    scene = 25;
                }
                else if (scene == 99)
                {
                    Application.Exit();
                }
            }
            else if (e.KeyCode == Keys.C)
            {
                if(scene == 5)
                {
                    scene = 8;
                }
            }

            switch (scene)
            {
                case 1:
                    labelMessage.Text = "Your friends dared you to enter a haunted house. Will you accept? ";
                    labelRed.Text = "Yes";
                    labelBlue.Text = "No";
                    labelYellow.Text = "";
                    break;
                case 2:
                    labelMessage.Text = "You are called a scaredy cat and they offer $30. Will you take the money and do the dare?";
                    labelRed.Text = "Take money and do it";
                    labelBlue.Text = "No";
                    labelYellow.Text = "";
                    break;
                case 3:
                    labelMessage.Text = "You approach the front door and it doesn't open, you have to find another way in. Do you...";
                    labelRed.Text = "Try the back door";
                    labelBlue.Text = "Go through a window";
                    labelYellow.Text = "";
                    break;
                case 4:
                    labelMessage.Text = "The window was broken and you cut yourself on glass. You are taken to the hospital and get 2 stitches. Game over.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 5:
                    labelMessage.Text = "The back door is unlocked, you walk right in. There is a door on your left, your right, and in front of you. Which do you go through?";
                    labelRed.Text = "Go Right";
                    labelBlue.Text = "Go Left";
                    labelYellow.Text = "Go Straight";
                    break;
                   
                case 6:
                    labelMessage.Text = "You refuse. Now you have to live with being called a scaredy cat forever.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 7:
                    labelMessage.Text = "Through the right door, there is a living room. You enter and see a staircase upwards and another room. ";
                    labelRed.Text = "Go Upstairs";
                    labelBlue.Text = "Go into the other room";
                    labelYellow.Text = "";
                    break;
                case 8:
                    labelMessage.Text = "Going straight leads straight into a pit. You die from the fall.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 9:
                    labelMessage.Text = "You enter the living room, you find a staircase to the basement or you can stay and look around.";
                    labelRed.Text = "Go downstairs";
                    labelBlue.Text = "Stay";
                    labelYellow.Text = "";
                    break;
                case 10:
                    labelMessage.Text = "Going upstairs leads to the attic.";
                    labelRed.Text = "Get nervous and leave";
                    labelBlue.Text = "Enter the attic";
                    labelYellow.Text = "";
                    break;
                case 11:
                    labelMessage.Text = "You enter the other room and find a big old chest.";
                    labelRed.Text = "Open it";
                    labelBlue.Text = "Leave it";
                    labelYellow.Text = "";
                    break;
                case 12:
                    labelMessage.Text = "You leave the house safely, good job. But it was just an attic, why so scared?";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 13:
                    labelMessage.Text = "You fall through a faulty floor and are left dead. Bet you though the attic would be safe, huh?";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 14:
                    labelMessage.Text = "You open the chest and find it full of gold bars. You take these bars out of the house with the help of your friends. You're RICH!";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 15:
                    labelMessage.Text = "7 days later a mafia boss knocks on your door telling you to hand it over. You are no longer rich.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 16:
                    labelMessage.Text = "You walk out of the house unscathed. Good job, but you're still a scaredy cat.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 17:
                    labelMessage.Text = "You go downstairs and find a sleeping ogre.";
                    labelRed.Text = "Run away from the ogre";
                    labelBlue.Text = "Poke it";
                    labelYellow.Text = "";
                    break;
                case 18:
                    labelMessage.Text = "You stay and find a talking doll sitting on the couch.";
                    labelRed.Text = "Run";
                    labelBlue.Text = "Throw it as far as possible";
                    labelYellow.Text = "";
                    break;
                case 19:
                    labelMessage.Text = "You run all the way home. Maybe he was a nice guy, should've given him a chance.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 20:
                    labelMessage.Text = "The doll doas a spell and switches bodies with you. Then he, the doll walks out of the house, and you sit unable to move forever. Bad choice.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 21:
                    labelMessage.Text = "You poke the ogre and it starts chasing you. You run....";
                    labelRed.Text = "Hopefully you can outrun him...";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 22:
                    labelMessage.Text = "The ogre eats you.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 23:
                    labelMessage.Text = "You run and escape successfully.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 24:
                    labelMessage.Text = "You find a hiding place for a second.";
                    labelRed.Text = "Run again";
                    labelBlue.Text = "Stay hiding";
                    labelYellow.Text = "";
                    break;
                case 25:
                    labelMessage.Text = "Mr Ogre finds you and you sit and have a nice conversation.";
                    labelRed.Text = "Turns out Mr Ogre was a nice guy.";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 26:
                    labelMessage.Text = "You successfully get away.";
                    labelRed.Text = "Continue";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 27:
                    labelMessage.Text = "After hours, you and him say goodbye. You and him exchange phone numbers and you get on your way.";
                    labelRed.Text = "Good job, you got the best ending. Enjoy your date with the ogre.";
                    labelBlue.Text = "";
                    labelYellow.Text = "";
                    break;
                case 99:
                    labelMessage.Text = "Thank you for playing...";
                    labelRed.Text = "Play Again?";
                    labelBlue.Text = "Exit";
                    labelYellow.Text = "";
                    break;
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
