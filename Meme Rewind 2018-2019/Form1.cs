/// created by : Brendan Burdett
/// date       : 29/10/19
/// description: a text adventure focused on memes around 2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Meme_Rewind_2018_2019
{
    public partial class Form1 : Form
    {
        //dec of vars, sound player and random num
        int scene = 0, randChance = 0;
        SoundPlayer deWay = new SoundPlayer(Properties.Resources.do_you_know_the_way);
        Random ranGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //display initial message and options
            outputMain.Text = "You suddenly awake on a sidewalk in a suburban neighborhood where you spot a man dressed in all white";
            buttBlue.Text = "north";
            buttRed.Text = "south";
            buttYell.Text = "";     
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V)       //yellow button press
            {
                switch (scene)
                {

                    //chance scenes
                    case 8:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 90)
                        {
                            scene = 6;
                        }
                        else
                        {
                            scene = 7;
                        }
                        break;

                    case 14:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 80)
                        {
                            scene = 12;
                        }
                        else
                        {
                            scene = 29;
                        }
                        break;

                    case 15:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 99)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 17;
                        }
                        break;

                    case 9:
                        scene = 5;
                        break;

                    case 10:
                        scene = 4;
                        break;

                    case 11:
                        scene = 3;
                        break;

                    case 22:
                        scene = 29;
                        break;

                    case 25: 
                        scene = 29;
                        break;

                    case 27:  
                        scene = 29;
                        break;

                    case 28:  
                        scene = 29;
                        break;

                    //play agains
                    case 2:
                        scene = 34;
                        break;

                    case 3:
                        scene = 34;
                        break;

                    case 4:
                        scene = 34;
                        break;

                    case 5:
                        scene = 34;
                        break;

                    case 6:
                        scene = 34;
                        break;

                    case 16:
                        scene = 34;
                        break;

                    case 17:
                        scene = 34;
                        break;

                    case 18:
                        scene = 34;
                        break;

                    case 26:
                        scene = 34;
                        break;

                    case 30:
                        scene = 34;
                        break;

                    case 33:
                        scene = 34;
                        break;

                    case 34:
                        scene = 0;
                        break;

                    default:
                        break;
                }
            }
            else if (e.KeyCode == Keys.C)  //blue button press
            {
                switch (scene)
                {
                    case 0:  //start scene  
                        scene = 1;
                        break;

                    case 1:
                        scene = 2;
                        break;

                    case 7:
                        scene = 26;
                        break;

                        //chance programs
                    case 8:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 90)
                        {
                            scene = 6;
                        }
                        else
                        {
                            scene = 7;
                        }
                        break;

                    case 14:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 80)
                        {
                            scene = 12;
                        }
                        else
                        {
                            scene = 29;
                        }
                        break;

                    case 15:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 99)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 17;
                        }
                        break;

                    case 9:
                        scene = 8;
                        break;

                    case 10:
                        scene = 9;
                        break;

                    case 11:
                        scene = 10;
                        break;

                    case 12:
                        scene = 19;
                        break;

                    case 13:
                        scene = 14;
                        break;

                    case 20:
                        scene = 22;
                        break;

                    case 23:
                        scene = 27;
                        break;

                    case 24:
                        scene = 28;
                        break;

                    case 29:
                        scene = 31;
                        break;

                    case 31:
                        scene = 33;
                        break;

                    case 22:
                        scene = 29;
                        break;

                    case 25:
                        scene = 29;
                        break;

                    case 27:
                        scene = 29;
                        break;

                    case 28:
                        scene = 29;
                        break;

                        //play agains
                    case 2:
                        scene = 34;
                        break;

                    case 3:
                        scene = 34;
                        break;

                    case 4:
                        scene = 34;
                        break;

                    case 5:
                        scene = 34;
                        break;

                    case 6:
                        scene = 34;
                        break;

                    case 16:
                        scene = 34;
                        break;

                    case 17:
                        scene = 34;
                        break;

                    case 18:
                        scene = 34;
                        break;

                    case 26:
                        scene = 34;
                        break;

                    case 30:
                        scene = 34;
                        break;

                    case 33:
                        scene = 34;
                        break;

                    case 34:
                        scene = 0;
                        break;
                    default:
                        break;
                }
            }
            else if (e.KeyCode == Keys.X)  //red button press
            {
                switch (scene)
                {
                    case 0:  
                        scene = 13;
                        break;

                    case 1:
                        scene = 11;
                        break;

                    case 7:
                        scene = 23;
                        break;

                        //chance scenes
                    case 8:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 90)
                        {
                            scene = 6;
                        }
                        else
                        {
                            scene = 7;
                        }
                        break;

                    case 14:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 80)
                        {
                            scene = 12;
                        }
                        else
                        {
                            scene = 29;
                        }
                        break;

                    case 15:
                        randChance = ranGen.Next(1, 101);
                        if (randChance > 99)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 17;
                        }
                        break;

                    case 10:
                        scene = 25;
                        break;

                    case 12:
                        scene = 20;
                        break;

                    case 13:
                        scene = 15;
                        break;

                    case 20:
                        scene = 21;
                        break;

                    case 23:
                        scene = 24;
                        break;

                    case 24:
                        scene = 28;
                        break;

                    case 29:
                        scene = 30;
                        break;

                    case 31:
                        scene = 32;
                        break;

                    case 22:
                        scene = 29;
                        break;

                    case 25:
                        scene = 29;
                        break;

                    case 27:
                        scene = 29;
                        break;

                    case 28:
                        scene = 29;
                        break;
                        
                        //play agains
                    case 2:
                        scene = 34;
                        break;

                    case 3:
                        scene = 34;
                        break;

                    case 4:
                        scene = 34;
                        break;

                    case 5:
                        scene = 34;
                        break;

                    case 6:
                        scene = 34;
                        break;

                    case 16:
                        scene = 34;
                        break;

                    case 17:
                        scene = 34;
                        break;

                    case 18:
                        scene = 34;
                        break;

                    case 26:
                        scene = 34;
                        break;

                    case 30:
                        scene = 34;
                        break;

                    case 33:
                        scene = 34;
                        break;

                    case 34:
                        scene = 0;
                        break;

                    default:
                        break;
                }
            }
            switch (scene)
            {
                // scene to be displayed
                case 0:
                    outputMain.Text = "You suddenly awake on a sidewalk in a suburban neighborhood where you spot a man dressed in all white";
                    buttBlue.Text = "approach the man";
                    buttRed.Text = "Flee";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.youknow;
                    break;

                case 1:
                    outputMain.Text = "\"you Know I had To Do It To Em\" says the man. suddenly the side walk cracks and you fall into a sink hole. " +
                        "when you come to you see a strange goat woman wearing a purple dress \"my names Toriel, dont be scared\"";
                    buttBlue.Text = "attack her";
                    buttRed.Text = "take her hand";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.toriel;
                    break;

                case 2:
                    outputMain.Text = "NO HURTING MAMA TORIEL!";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.boom;
                    break;

                case 3:
                    outputMain.Text = "Mama Toriel shows you to your room and you live happily ever after learning from her of the underworld";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.underworld;
                    break;

                case 4:
                    outputMain.Text = "\"whos joe\" you ask. Joe Mama ";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.joe;
                    break;

                case 5:
                    outputMain.Text = "as you sprint forward you notice a door reading \"Exit\" as you burst through the door you fall down into a pit of alligators with a disco ball ";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.aligator;
                    break;

                case 6:
                    outputMain.Text = "Stumble forwards landing in the mouth of a giant dragon just as it bites down";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.mouth;
                    break;

                case 7:
                    outputMain.Text = "you fall through the floor  getting a glimpse of amassive creature before you fall through the floor seeing no more ground." +
                        " as you fall you land in a small red plane knocking a dog out of the plane and taking it over ";
                    buttBlue.Text = "save the dog";
                    buttRed.Text = "try and find your way back to the dragon";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.planedog;
                    break;

                case 8:
                    outputMain.Text = "as you break through the wall you";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    break;

                case 9:
                    outputMain.Text = "As you enter the hall suddenly a group of characters appear blocking the hall";
                    buttBlue.Text = "break through the weak wall";
                    buttRed.Text = "";
                    buttYell.Text = "dart past them";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.boys;
                    break;

                case 10:
                    outputMain.Text = "Mama Toriel Is heart broken as you leave the house and enter the underground there" +
                        " is a 3 way split to the south you hear what sounds like muffled heavy metal music. to the north " +
                        "you some one calling out for \"Joe\" to the west there is nothing but a hall";
                    buttBlue.Text = "the hall";
                    buttRed.Text = "follow the metal music";
                    buttYell.Text = "try and find Joe";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.hall;
                    break;

                case 11:
                    outputMain.Text = "She takes you back to her house where she give you some cinnamon, butterscotch pie.";
                    buttBlue.Text = "tell her shes very nice but you must leave";
                    buttRed.Text = "";
                    buttYell.Text = "stay with her";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.pie;
                    break;

                case 12:
                    outputMain.Text = "as you fall through you end up in a desert. stumbling to your feet suddenly a man darts " +
                        "past you with his arms behind his back. a roar is heard in the distance and as you look back you see a " +
                        "horde of trucks and runners closing in on you. over your shoulder a massive shell flys past landing just " +
                        "short of the horde causing the dirt to be thrown into the air. ";
                    buttBlue.Text = "run for the base";
                    buttRed.Text = "run for cover in a nearby shell crater";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.desert;
                    break;

                case 13:
                    outputMain.Text = "as you flee from the man in white he stares at you before you lose sight of him after ducking " +
                        "between buildings suddenly you hear a small voice \"do you know de way?\" it says";
                    buttBlue.Text = "tell him you know the way";
                    buttRed.Text = "tell him you do not know the way";
                    buttYell.Text = "";
                    deWay.Play();
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.deway;
                    break;

                case 14:
                    outputMain.Text = "as you respond \"yes\" the red man stares at you before a swarm of them suddenly pour out from " +
                        "behind the buildings.you sprint to try and escape. as you run you stumble into a portal";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    deWay.Play();
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.dewayswarm;
                    break;

                case 15:
                    outputMain.Text = "you tell the little creature no. suddenly he begins to bloat, growing bigger and bigger until suddenly " +
                        "he burst blinding you. as you come to you realize your in a gorilla habitat. a man far above out of the enclosure is " +
                        "holding a gun pointed in your direction. a tear runs down his face as he says \"Not again... not this time\" ";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.harambe;
                    break;

                case 16:
                    outputMain.Text = "as you awaken you realize your in the town square. the president has decreed that death shall be your" +
                        " punishment for nearly having harambe II killed";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.firsttime;
                    break;

                case 17:
                    outputMain.Text = "as he squeezes the trigger the bullet strikes you ending your story";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.harambegun;
                    break;

                case 18:
                    outputMain.Text = "you fail to outrun the red midgets and the swarm consumes you";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.dewayswarm;
                    break;

                case 19:
                    outputMain.Text = "as you sprint for the base suddenly a lot of flashes are seen from it as the ground around you erupts with" +
                        " artillery fire.the horde reaches you as shells send runners and trucks flying.the blasts knock you over as one man near " +
                        "you is struck with shrapnel causing him to fall. a man runs over with a case of monster energy and gives the man some. " +
                        "suddenly he stands up and charges again. a shell strikes your leg ending the charge for you";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.area51;
                    break;

                case 20:
                    outputMain.Text = "as you sprint for the crater you quickly realize your not fast enough. you hear some loud music as an alien" +
                        " named Howard grabs you and pulls you into the crater.but not before a piece of shrapnel rips through your leg. you pass out " +
                        "from blood loss and when you come to there is a weird alien goo around your leg that slowly flops off revealing your fully " +
                        "healed leg. as you craw out of the crater there is smoke everywhere the previously flat desert is scattered with remains and craters.";
                    buttBlue.Text = "aproach the base";
                    buttRed.Text = "explore the wrecks";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.desert;
                    break;

                case 21:
                    outputMain.Text = "as you explore the flaming wrecks you hear the loud groaning of metal breaking apart as you turn around you" +
                        " watch as a massive AC 130 dumping flares and falling to the ground in a flaming wreck right onto you.";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.ac130;
                    break;

                case 22:
                    outputMain.Text = "once in the base you explore finding what a appears to be cookie monster. he has a gun and forces you through" +
                        " a near by portal \"You Shall be sacrificed to the great dragon! NOM NOM NOM!\" he says as you enter the portal.";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.cookie;
                    break;

                case 23:
                    outputMain.Text = "as you try and find your way back up you fail and instead end up following an odd song about chicken and rice and peace.";
                    buttBlue.Text = "aproach the odd sound";
                    buttRed.Text = "avoid the song";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.rice;
                    break;

                case 24:
                    outputMain.Text = "as you approach you see a small robot in a very convincing costume singing about how peace is better " +
                        "than chicken and rice. as you approach the being he presents him self as GIR";
                    buttBlue.Text = "leave";
                    buttRed.Text = "whats gir stand for?";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.gir;
                    break;

                case 25:
                    outputMain.Text = "there is a small helmet on a ledge that draws you in. as you place the helmet on heavy metal music " +
                        "begins blasting  and you lose consciousness. when you come to you are covered in bits and pieces of demons, in " +
                        "front of you is Satan him self. he is dead with a large hole in his chest. you quickly remove the helmet and stumble" +
                        " forwards tripping over a defeated demon and falling into a portal.";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.doom;
                    break;

                case 26:
                    outputMain.Text = "you manage to dive down and save the strange dog he is not grateful and throws you out of his plane";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.planedog;
                    break;

                case 27:
                    outputMain.Text = "as you run away you look back and suddenly hear a thunderous roar causing you to tumble and fall down" +
                        " a small hill into a portal";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.portal;
                    break;

                case 28:
                    outputMain.Text = "as you leave GIR stumbles around and knocks over a bucket causing a series of things to tumble and " +
                        "finally causing a portal to open below you";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.portal;
                    break;

                case 29:
                    outputMain.Text = "you stumble out of the portal and end up on the floor of a massive cavern. in the distance you hear a " +
                        "loud thumping drawing closer, but in front of you is a wizard";
                    buttBlue.Text = "aproach the wizard";
                    buttRed.Text = "fid the source of the thumping";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.wizard;
                    break;

                case 30:
                    outputMain.Text = "as you walk towards the sound you quickly realize the cavern is far larger than you thought and you may not" +
                        " be able to make it across... this turns out to be true and you perish";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.ded;
                    break;

                case 31:
                    outputMain.Text = "as you approach the wizard he turns around and says  \"AH! it is you hero! you must slay the dragon and  save us!\"" +
                        "you look at the wizard shocked as suddenly a dragon as tall as a sky scraper comes around the massive cave wall. as the creature" +
                        " comes around the thick massive cave walls you nearly fall from the tremors its steps cause. the wizard looks at you and asks";
                    buttBlue.Text = "ask for the grand holy sword";
                    buttRed.Text = "whats endgame?";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.wizard;
                    break;

                case 32:
                    outputMain.Text = "you question the wizard \"endgame?\" you ask. the wizard nods and suddenly portals begin to open behind you. tons of" +
                        " creatures pour out of them including the little red guys, a gorilla named harambe, the doom guy, Howard the alien, and then entire " +
                        "Area 51 attack force now loaded with there high tech alien weaponry. soon after the battle is won.";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.endgame;
                    break;

                case 33:
                    outputMain.Text = "you pick the holy sword and then proceed to charge the dragon. as the dragon raises its foot you quickly relize maybe " +
                        "the sword wasnt a good choice. the dragon stomps on you and your small sword.";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    pictureBoxMain.Image = Meme_Rewind_2018_2019.Properties.Resources.stomp;
                    break;

                case 34:
                    outputMain.Text = "to play again click any button";
                    buttBlue.Text = "";
                    buttRed.Text = "";
                    buttYell.Text = "";
                    break;

                default:
                    break;
            }
        }
    }
}
