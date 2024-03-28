using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

// 27th March 2024
//Find the lost Relic 
//Ayush Patel

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //The page you start with
        int page = 1;

        //Different Sounds used throught the story
        new SoundPlayer introSound = new SoundPlayer(Properties.Resources.journeySound);
        new SoundPlayer journeySound = new SoundPlayer(Properties.Resources.Menu_Screen_Sound);
        new SoundPlayer villageSound = new SoundPlayer(Properties.Resources.medieval_village_atmosphere);
        new SoundPlayer blacksmithWorkshop = new SoundPlayer(Properties.Resources.blacksmithWorkshop);
        new SoundPlayer monsterScream = new SoundPlayer(Properties.Resources.monsterScream);
        new SoundPlayer monsterLurkingBehind = new SoundPlayer(Properties.Resources.monsterLurkingBehind);
        new SoundPlayer rustlingLeaves = new SoundPlayer(Properties.Resources.rustlingLeaves);
        new SoundPlayer death = new SoundPlayer(Properties.Resources.death);
        new SoundPlayer running = new SoundPlayer(Properties.Resources.running);
        new SoundPlayer night = new SoundPlayer(Properties.Resources.nightTime);
        new SoundPlayer hungry = new SoundPlayer(Properties.Resources.hungry);
        new SoundPlayer monsterDeath = new SoundPlayer(Properties.Resources.MonsterDeath);
        new SoundPlayer winSound = new SoundPlayer(Properties.Resources.winSound);

        //Create a random generator
        Random randGen = new Random();

        
        public Form1()
        {
            InitializeComponent();
            //Menu/Starting page setup
            introSound.Play();
            outputLabel.Visible = false;
            mainPictureBox.Visible = false;
            option1Button.Visible = false;
            option2Button.Visible = false;
            option1Label.Visible = false;
            option2Label.Visible = false;   
            option3Label.Visible = false;
            option3Button.Visible = false; 
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //story/Main game setup
            mainPictureBox.Visible = true;
            outputLabel.Visible = true;
            option1Button.Visible = true;
            option1Label.Visible = true;
            option2Button.Visible = true;
            option2Label.Visible = true;
            option3Button.Visible = false;
            option3Label.Visible = false;

            titleImage.Visible = false;
            titleLabel.Visible = false;
            playButton.Visible = false;
            introSound.Stop();
            displayPage(); 

        }
        private void displayPage()
        {
            //different pages
            switch (page)
            {
                case 1:
                    outputLabel.Text = "The king has picked you to go on a journey to find a relic. Do you want to meet the village elder or meet the blacksmith?";
                    option1Label.Text = "Meet elder";
                    option2Label.Text = "Meet blacksmith";
                    mainPictureBox.Image = Properties.Resources.page1;
                    journeySound.Play();
                    break;
                case 2:
                    outputLabel.Text = "You recieve a map for the journey. Do you want to leave for the journey or visit the blacksmith?";
                    option1Label.Text = "Go on journey";
                    option2Label.Text = "Visit blacksmith";
                    mainPictureBox.Image = Properties.Resources.page2;
                    villageSound.Play();
                    break;
                case 3:
                    outputLabel.Text = "You recieved a 1 time use potion to kill the monster defending the relic, and you also got suited up to fight and are looking scary. Do you ask the village elder for relic locations or leave for the journey?";
                    option1Label.Text = "ask for location";
                    option2Label.Text = "leave for journey";
                    mainPictureBox.Image = Properties.Resources.page3;
                    blacksmithWorkshop.Play();
                    break;
                case 4:
                    outputLabel.Text = "You encountered a monster. Do you want to fight the monster or run away?";
                    option1Label.Text = "Fight";
                    option2Label.Text = "Run";
                    mainPictureBox.Image = Properties.Resources.page4;
                    monsterScream.Play();
                    break;
                case 5:
                    outputLabel.Text = "You recieved a 1 time use potion to kill the monster defending the relic, you suited up in a very powerful armor, and have tools to fight with. On your journey you hear rustling in the bushes. Do you Investigate the noise or retreat?";
                    option1Label.Text = "Investigate";
                    option2Label.Text = "Retreat";
                    mainPictureBox.Image = Properties.Resources.page3;
                    rustlingLeaves.Play();                    
                    break;
                case 6:
                    outputLabel.Text = "You tried acting brave but you didn't have any tools to defeat the monster and you died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.page6;
                    death.Play();

                    break;
                case 7:
                    outputLabel.Text = "You ran away and were unable to do the task the king hires someone else for the job. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.page7;
                    running.Play();
                    break;
                case 8:
                    outputLabel.Text = "You died while attempting to run away. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.page6;
                    death.Play();
                    break;
                case 9:
                    outputLabel.Text = "It was a harmless animal. It's getting dark. Do you make shelter or keep going to find relic before night fall?";
                    option1Label.Text = "Make shelter";
                    option2Label.Text = "Find relic";
                    mainPictureBox.Image = Properties.Resources.page5;
                    night.Play();
                    break;
                case 10:
                    outputLabel.Text = "You ran away and were unable to do the task and the king killed you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.page7;
                    death.Play();

                    break;
                case 11:
                    outputLabel.Text = "You successfully made a temporary shelter for the night. You are hungry when you wake up.Do you go hunting or keep going to find the relic";
                    option1Label.Text = "Go hunting";
                    option2Label.Text = "Find relic";
                    mainPictureBox.Image = Properties.Resources.page11;
                    hungry.Play();

                    break;
                case 12:
                    outputLabel.Text = "It got too dark and you couldn't see your path you fell in a pit and died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.thorn_bushpit;
                    death.Play();
                    break;
                case 13:
                    outputLabel.Text = "You stumble upon a deer. Eat it raw so you can go back fast or cook it and eat it?";
                    option1Label.Text = "Eat it raw";
                    option2Label.Text = "Cook it";
                    mainPictureBox.Image = Properties.Resources.page14;
                    villageSound.Play();
                    break;
                case 14:
                    outputLabel.Text = "You found the cave with the relic. Do you enter the cave or make a torch";
                    option1Label.Text = "Enter the cave";
                    option2Label.Text = "Make a torch";
                    mainPictureBox.Image = Properties.Resources.cave_entrance;
                    monsterScream.Play();

                    break;
                case 15:
                    outputLabel.Text = "You suffered food poisioning and died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.food_poisioning;
                    death.Play();  
                    break;
                case 16:
                    outputLabel.Text = "While you were cooking a moster attacked you from the back and you died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.monster_lurking;
                    death.Play();
                    break;
                case 17:
                    outputLabel.Text = "You entered the cave and encounter the monster lurking behind you. Do you use the potion to kill the monster or use sword becuase this might not be the strongest monster there or do you run past this monster?";
                    option1Label.Text = "Use potion";
                    option2Label.Text = "Use sword";
                    mainPictureBox.Image = Properties.Resources.monster_lurking;
                    monsterScream.Play();
                    break;
                case 18:
                    outputLabel.Text = "You went to find resources for a torch. While trying to wood the tree fell on you and you died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.dead;
                    death.Play();
                    break;
                case 19:
                    outputLabel.Text = "The monster dies and you see a glowing light coming from the relic. You retrive it and give it to the king. Do you tell the king to pay you or request him to hire you for most jobs like this?";
                    option1Label.Text = "Ask for money";
                    option2Label.Text = "Ask for job";
                    mainPictureBox.Image = Properties.Resources.menuImage;
                    monsterDeath.Play();
                    break;
                case 20:
                    outputLabel.Text = "There was 20 foot fall ahead and you died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.thorn_bushpit;
                    death.Play();
                    break;
                case 21:
                    outputLabel.Text = "You didn't have enough energy to strike the monster and it ended up killing you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.Final_boss_fight;
                    death.Play();
                    break;
                case 22:
                    outputLabel.Text = "The king became evil after possing the power of the relic and kills you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.evil_king;
                    death.Play();
                    break;
                case 23:
                    outputLabel.Text = "The king hires you and rewards you for this task. Congrats!!! You did it. Do you want to play again and try a different journey?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.Congrats_you_won;
                    winSound.Play();
                    break;
                case 24:
                    outputLabel.Text = "They got scared from you and ran away you failed the mission. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.village_elder_running_away;
                    running.Play();
                    break;
                case 25:
                    outputLabel.Text = "You set out for the journey and spent years searching but you gave up and the king killed you for returning empty handed. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    mainPictureBox.Image = Properties.Resources.food_poisioning;
                    death.Play();
                    break;
                case 26:
                    outputLabel.Text = "Thank you for playing.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Thread.Sleep(2000);
                    Refresh();
                    Application.Exit();
                    break;



            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
                journeySound.Stop();
            }
            else if (page == 2)
            {
                page = 4;
                villageSound.Stop();
            }
            else if (page == 3)
            {
                page = 24;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 9;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 17;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }

            displayPage();

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1) 
            {
                page = 3;
                journeySound.Stop();
            }

            else if (page == 2)
            {
                page = 5;
                villageSound.Stop();
            }
            else if (page == 3)
            {
                page = 25;
            }
            // Have to code the process here
            else if (page == 4)
            {
                int randValue = randGen.Next(1, 101);
                if (randValue < 30)
                {
                    page = 7;
                }
                else
                {
                    page = 8;
                }
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 26;
            }
            else if (page == 7)
            {
                page = 26;
            }
            else if (page == 8)
            {
                page = 26;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 26;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 26;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 26;
            }
            else if (page == 16)
            {
                page = 26;
            }
            else if (page == 17)
            {
                page = 21;
            }
            else if (page == 18)
            {
                page = 26;
            }
            else if (page == 19)
            {
                page = 23;
            }
            else if (page == 20)
            {
                page = 26;
            }
            else if (page == 21)
            {
                page = 26;
            }
            else if (page == 22)
            {
                page = 26;
            }
            else if (page == 23)
            {
                page = 26;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 25)
            {
                page = 26;
            }
            displayPage();
        }


    }
}