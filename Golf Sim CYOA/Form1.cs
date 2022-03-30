using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_Sim_CYOA
{
    public partial class Form1 : Form
    {
        //establish global variable
        int page = 1;
        int save = 1;
        int club = 0;
        Random random = new Random();
        int chance;
        
        public Form1()
        {
            InitializeComponent();

          
        }

        private void option01_Click(object sender, EventArgs e)
        {
            //check current page and go to result of choosing option 01

            if(page == 1)
            {
                page = 2;
                
            }
            else if(page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
                //define variable
                club = 1;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6 && club == 1)
            {
                page = 7;
            }
            else if (page == 6 && club == 2)
            {
                page = 7;
            }
            else if (page == 6 && club == 3)
            {
                page = 8;
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
                page = 1;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16 && club == 1)
            {
                page = 25;
            }
            else if (page == 16 && club == 2)
            {
                page = 17;
            }
            else if (page == 16 && club == 3)
            {
                page = 26;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 1;
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
                page = 11;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 1;
            }

            //show title label when necessary
            if (page == 1)
            {
                titleLabel.Visible = true;
            }
            else
            {
                titleLabel.Visible = false;
                option02.Visible = true;
            }

            //show corresponding page
            DisplayPage();
        }

        private void option02_Click(object sender, EventArgs e)
        {
            //check current page and go to result of choosing option 01

            if (page == 1)
            {
                page = save;
                
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
                //define variable
                club = 2;
            }
            else if (page == 4)
            {
                page = 11;
            }
            else if (page == 5)
            {
                page = 14;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                Application.Exit();
            }
            else if (page == 8)
            {
                Application.Exit();
            }
            else if (page == 9)
            {
                Application.Exit();
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                Application.Exit();
            }
            else if (page == 12)
            {
                Application.Exit();
            }
            else if (page == 13)
            {
                Application.Exit();
            }
            else if (page == 14)
            {
                Application.Exit();
            }
            else if (page == 15)
            {
                Application.Exit();
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                Application.Exit();
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                Application.Exit();
            }
            else if (page == 20)
            {
                Application.Exit();
            }
            else if (page == 21)
            {
                Application.Exit();
            }
            else if (page == 22)
            {
                Application.Exit();
            }
            else if (page == 23)
            {
                Application.Exit();
            }
            else if (page == 24)
            {
                page = 12;
            }
            else if (page == 25)
            {
                Application.Exit();
            }
            else if (page == 26)
            {
                Application.Exit();
            }

            //show title label when necessary
            if (page == 1)
            {
                titleLabel.Visible = true;
            }
            else
            {
                titleLabel.Visible = false;
                option02.Visible = true;
            }

            //show corresponding page
            DisplayPage();
        }

        private void option03_Click(object sender, EventArgs e)
        {
            //check current page and go to result of choosing option 01

            if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
                //define club variable
                club = 3;
            }
            else if (page == 4)
            {
                page = 16;
            }
            else if (page == 5)
            {
                page = 15;
            }
            else if (page == 6)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 16)
            {
                //do chance decision
                chance = random.Next(1, 6);

                if (chance == 5)
                {
                    page = 23;
                }
                else
                {
                    page = 24;
                }
            }
            else if (page == 18)
            {
                //do chance decision
                chance = random.Next(1, 6);

                if (chance == 5)
                {
                    page = 21;
                }
                else
                {
                    page = 22;
                }
            }
            else if (page == 24)
            {
                page = 13;
            }

            //show title label when necessary
            if(page == 1)
            {
                titleLabel.Visible = true;
            }
            else
            {
                titleLabel.Visible = false;
                option02.Visible = true;
            }

            //show corresponding page
            DisplayPage();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //define save variable
            save = page;
        }

        public void DisplayPage()
        {
            switch(page)
            {
                case 1:
                    outputLabel.Text = "";
                    option01.Text = "START NEW GAME";
                    if(save == 1)
                    {
                        option02.Visible = false;
                    }
                    else
                    {
                        option02.Visible = true;
                        option02.Text = "LOAD SAVE GAME";
                    }
                    option03.Visible = false;
                    pictureBox.Visible = false;
                    break;
                case 2:
                    outputLabel.Text = "You are out for a night of golfing with your pals, you feel a cool breeze on your face.This shot has the potential to win the game, almost.";
                    option01.Text = "Tilt left";
                    option02.Text = "Tilt right";
                    option03.Text = "Hammer it";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.golfing;
                    break;
                case 3:
                    outputLabel.Text = "You miss. You go home after quenching your thirst, you still can't part with your trusty club, your...";
                    option01.Text = "7 iron";
                    option02.Text = "Putter";
                    option03.Text = "Driver";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.club;
                    break;
                case 4:
                    outputLabel.Text = "You waltz into your kitchen with your club in hand, your wife is there. You quickly hide your club behind your back.'My parents said they wished you were there, too bad you had that business meeting.' You sense her anger, you quickly respond.";
                    option01.Text = "Yeah, it's a darn shame.";
                    option02.Text = "I was golfing, you bumbling idiot";
                    option03.Text = "Don't criticize me woman!";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 5:
                    outputLabel.Text = "'Darn shame indeed' she says, 'Well guess it can't be helped,' you respond. 'Say, who wears golfing shoes to a business meeting?' she asks, you say:";
                    option01.Text = "It's the latest fashion trend you know.";
                    option02.Text = "FUS ROH DAH!";
                    option03.Text = "*grunt like a caveman*";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 6:
                    outputLabel.Text = "'Oh really?' she says, 'And uh, what's that behind your back?' 'Darn,' you think, 'she noticed.' You need to do something with the club.";
                    option01.Text = "Hold in cheeks.";
                    option02.Text = "Throw club";
                    option03.Text = "Show the club";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.club;
                    break;
                case 7:
                    outputLabel.Text = "You slide the club in between your cheeks and clench, hard. The club is heavy, but you've got experience, thank the lord it wasn't your driver though. Your wife is clear of suspicion, you side shuffle to the doorway just as you always do. You have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.golfing;
                    break;
                case 8:
                    outputLabel.Text = "You slide the club in between your cheeks and clench, hard. It doesn't matter, the club slips out and drops to the ground. 'What's that!?' your wife screams, it's over you can't play this one off, you have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 9:
                    outputLabel.Text = "You throw the golf club about as well as you hit golf balls, needless to say it bounces off the wall and lands in between the two of you, that was too suspicious to play off, you have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 10:
                    outputLabel.Text = "You pull out the golf club, you have accepted defeat. 'What's that?' she asks. 'Wait' you think, 'she doesn't know what golf is?' You decide to say:";
                    option01.Text = "It's a golf club, idiot.";
                    option02.Text = "A gift for your dad!";
                    option03.Text = "*scream like an insolent child*";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 11:
                    outputLabel.Text = "Your wife knows you were golfing, she gets mad and bans golfing; she also gets a dog tracker puts it in you, you have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_sitting;
                    break;
                case 12:
                    outputLabel.Text = "She is suspicious and decides to send a picture to her father asking what it is, you think it's over, you have lost. Until her father says 'Oh cool, a hockey stick!' You thank the lord, a fellow golfer has saved you, you have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.golfing;
                    break;
                case 13:
                    outputLabel.Text = "'You can't sweet talk me!' your wife says. 'that's got to be a golf club!' She has figured you out, you have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_sitting;
                    break;
                case 14:
                    outputLabel.Text = "You scream the ancient words at your wife, she is overcome by it's power and gets thrown into the neighbors yard. Your neighbors discover her body, you have lost, next time try to do the deed more subtly.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.skyrim;
                    break;
                case 15:
                    outputLabel.Text = "You grunt unknowledgeable garble. 'Oh good,' your wife says, 'I thought something was off, but it's just the same old you.' All suspicion has been erased, you have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.golfing;
                    break;
                case 16:
                    outputLabel.Text = "You yell angrily at your wife, she tears up. Now you've done it. You say to her 'I'm sorry, ...";
                    option01.Text = "I didn't know I married a crybaby.";
                    option02.Text = "I've had a long day.";
                    option03.Text = "not! *breaks it down*";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 17:
                    outputLabel.Text = "Your wife gets angry at your comment, she divorces you the next day, no one stops you from golfing anymore. However, to humiliate you she decides to take everything on you the time, including your putter, the one club you have no extras of. Your short game suffers, you have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.club;
                    break;
                case 18:
                    outputLabel.Text = "You say the words, they come out miserably. You don't feel like your comforting her, but more yourself. Your eyes begin to swell, but you can't cry, your the one who did this to her. She falls to the ground, her knees weak, you sit down with her. 'I'm sorry,' you say again, but you can't put any soul into it.";
                    option01.Text = "Show club";
                    option02.Text = "Let it all out.";
                    option03.Text = "Jump out the window.";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.kitchen;
                    break;
                case 19:
                    outputLabel.Text = "You show your wife the club, she looks at you in curiosity. 'What's that?' she asks, tears streaming down her face. 'It's a golf club,' you reply, 'truth is, I was golfing, not at business.But I don't want there to be any more lies between us, I can't bare to see you like this.' Your wife smiles, she's angry you can tell, but she is overcome with your sincerity. You go to couples counseling the next day, you never touch a golf club again in your life, you and your wife live happily. You have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_sitting;
                    break;
                case 20:
                    outputLabel.Text = "You defecate in your trousers, its warm. Your wife smells it and stops crying, she is too overwhelmed by the stench. 'What is that!?' she screams, you just grin. She insults you as you take a seat on your recliner, she is so mad she throws your clubs in the trash compactor while you are stuck to your chair. You have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_sitting;
                    break;
                case 21:
                    outputLabel.Text = "You jump through the window, you land in the front yard and run down the street. You have escaped flawlessly as your wife cries on the kitchen floor, you have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_running;
                    break;
                case 22:
                    outputLabel.Text = "Your wife sees you jump into the wall next to the window, your head is stuck in the drywall. She knows what you were doing, she turns on the stove and walk out of the house. As your oxygen runs out and your consciousness fades, you you hear the sirens in the distance, they're too far. You have lost.";
                    option01.Text = "TRY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.house_burning;
                    break;
                case 23:
                    outputLabel.Text = "Your wife begins to chuckle, she can't stay mad at you. She begins to beatbox while you break dance, your love is reignited., you have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_dancing;
                    break;
                case 24:
                    outputLabel.Text = "You hurt yourself break dancing, your golf club drops to the floor in front of her. 'What's that?' she says, teary eyed.";
                    option01.Text = "It's a golf club, idiot.";
                    option02.Text = "A gift for your dad!";
                    option03.Text = "*scream like an insolent child*";
                    option03.Visible = true;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.man_dancing;
                    break;
                case 25:
                    outputLabel.Text = "Your wife gets angry at your comment, she divorces you the next day, no one stops you from golfing anymore. However, to humiliate you she decides to take everything on you the time, including your 7 iron. However, luckily you have extras, you have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.club;
                    break;
                case 26:
                    outputLabel.Text = "Your wife gets angry at your comment, she divorces you the next day, no one stops you from golfing anymore. However, to humiliate you she decides to take everything on you the time, including your driver. However, luckily you have extras, you have won.";
                    option01.Text = "PLAY AGAIN";
                    option02.Text = "QUIT";
                    option03.Text = "";
                    option03.Visible = false;
                    pictureBox.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.club;
                    break;
            }
        }
    }
}
