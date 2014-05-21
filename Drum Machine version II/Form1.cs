using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace Drum_Machine_version_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // selects BD and bank1 whan the program starts
            //
            panel_Bank1.BackgroundImage = Properties.Resources.btnOn909;
            panel_BD.BackgroundImage = Properties.Resources.btnOn909;


            // initializes the steps panel array
            // used for looping through and setting the lights
            // on or off depending on what step is programed
            //
            arraySteps[0] = panel1;
            arraySteps[1] = panel2;
            arraySteps[2] = panel3;
            arraySteps[3] = panel4;
            arraySteps[4] = panel5;
            arraySteps[5] = panel6;
            arraySteps[6] = panel7;
            arraySteps[7] = panel8;
            arraySteps[8] = panel9;
            arraySteps[9] = panel10;
            arraySteps[10] = panel11;
            arraySteps[11] = panel12;
            arraySteps[12] = panel13;
            arraySteps[13] = panel14;
            arraySteps[14] = panel15;
            arraySteps[15] = panel16;


            // setting the initial bools for the drum selects
            //
            CountBD = true;
            CountSD = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountCH = false;

            // bool for bank selects
            //
            CountBank1 = true;
            CountBank2 = false;


            // initializing the sound players
            //
            engine_BD = new ISoundEngine();
            engine_SD = new ISoundEngine();
            engine_LT = new ISoundEngine();
            engine_MT = new ISoundEngine();
            engine_HT = new ISoundEngine();
            engine_RS = new ISoundEngine();
            engine_CP = new ISoundEngine();
            engine_CB = new ISoundEngine();
            engine_CY = new ISoundEngine();
            engine_OH = new ISoundEngine();
            engine_CH = new ISoundEngine();


            // hides all the lights on startup 
            // (seperate panels to the actual switches)
            //
            light1.Hide();
            light2.Hide();
            light3.Hide();
            light4.Hide();
            light5.Hide();
            light6.Hide();
            light7.Hide();
            light8.Hide();
            light9.Hide();
            light10.Hide();
            light11.Hide();
            light12.Hide();
            light13.Hide();
            light14.Hide();
            light15.Hide();
            light16.Hide();
        }


        // BD = bass drum
        // SD = snare drum
        // LT = low tom
        // MT = mid tom
        // HT = high tom
        // RS = rim shot
        // CP = clap
        // CB = cowbell
        // CY = cymbal
        // OH = open hat
        // CH = hihat 



        #region VARS

        // vars


        // declaring the sound players
        //
        ISoundEngine engine_BD;
        ISoundEngine engine_SD;
        ISoundEngine engine_LT;
        ISoundEngine engine_MT;
        ISoundEngine engine_HT;
        ISoundEngine engine_CP;
        ISoundEngine engine_RS;
        ISoundEngine engine_CB;
        ISoundEngine engine_CY;
        ISoundEngine engine_OH;
        ISoundEngine engine_CH;



        // sound paths to be used in the players
        //
        string path_BDshort = @"C:\Program Files\NORDrum 909\sounds\909 warm kick.wav";
        string path_BDLong = @"C:\Program Files\NORDrum 909\sounds\909 tape kick 2.wav";

        string path_SDLow = @"C:\Program Files\NORDrum 909\sounds\909 tape snare long.wav";
        string path_SDHigh = @"C:\Program Files\NORDrum 909\sounds\909 snare short.wav";

        string path_LT = @"C:\Program Files\NORDrum 909\sounds\909ltom.wav";
        string path_LC = @"C:\Program Files\NORDrum 909\sounds\909 tape lowtom.wav";

        string path_MT = @"C:\Program Files\NORDrum 909\sounds\909mtom.wav";
        string path_MC = @"C:\Program Files\NORDrum 909\sounds\909 tape midtom.wav";

        string path_HC = @"C:\Program Files\NORDrum 909\sounds\909 tape hitom.wav";
        string path_HT = @"C:\Program Files\NORDrum 909\sounds\909hitom.wav";

        string path_RS = @"C:\Program Files\NORDrum 909\sounds\909rim.wav";
        string path_CL = @"";

        string path_CP = @"C:\Program Files\NORDrum 909\sounds\909clap.wav";
        string path_MA = @"C:\Program Files\NORDrum 909\sounds\909 tape clap.wav";

        string path_CB = @"C:\Program Files\NORDrum 909\sounds\909hat.wav";

        string path_CYShort = @"C:\Program Files\NORDrum 909\sounds\909hat2.wav";
        string path_CYLong = @"C:\Program Files\NORDrum 909\sounds\909 tape openhat.wav";

        string path_OHLong = @"C:\Program Files\NORDrum 909\sounds\909 tape ride.wav";
        string path_OHShort = @"C:\Program Files\NORDrum 909\sounds\909ride.wav";

        string path_CH = @"C:\Program Files\NORDrum 909\sounds\909crash.wav";
            



        // declaring panel array for steps
        //
        Panel[] arraySteps = new Panel[16];


        // bool arrays for each drum sound, used to
        // set which steps are programmed for each drum
        // sound, used as memory
        //
        bool[] BDArray = new bool[16];
        bool[] BDArray2 = new bool[16];

        bool[] SDArray = new bool[16];
        bool[] SDArray2 = new bool[16];

        bool[] LTArray = new bool[16];
        bool[] LTArray2 = new bool[16];

        bool[] MTArray = new bool[16];
        bool[] MTArray2 = new bool[16];

        bool[] HTArray = new bool[16];
        bool[] HTArray2 = new bool[16];

        bool[] RSArray = new bool[16];
        bool[] RSArray2 = new bool[16];

        bool[] CPArray = new bool[16];
        bool[] CPArray2 = new bool[16];

        bool[] CBArray = new bool[16];
        bool[] CBArray2 = new bool[16];

        bool[] CYArray = new bool[16];
        bool[] CYArray2 = new bool[16];

        bool[] OHArray = new bool[16];
        bool[] OHArray2 = new bool[16];

        bool[] CHArray = new bool[16];
        bool[] CHArray2 = new bool[16];


        // bools for the drum selects
        // used to let the program know which drum
        // is selected
        bool CountBD = true;
        bool CountSD = true;
        bool CountLT = true;
        bool CountMT = true;
        bool CountHT = true;
        bool CountRS = true;
        bool CountCP = true;
        bool CountCB = true;
        bool CountCY = true;
        bool CountOH = true;
        bool CountCH = true;


        // bools for banks
        //
        bool CountBank1 = true;
        bool CountBank2 = true;


        // bool for fill switch
        //
        bool CountFill = false;


        // bool for start stop button
        //
        bool StartStopBtn = true;


        // bool used so program can tell when
        // a full bar has looped
        //
        bool fillooper = true;


        // bools used for mute switches
        //
        bool BDmute = false;
        bool SDmute = false;
        bool LTmute = false;
        bool MTmute = false;
        bool HTmute = false;
        bool RSmute = false;
        bool CPmute = false;
        bool CBmute = false;
        bool CYmute = false;
        bool OHmute = false;
        bool CHmute = false;


        // bools used for toggle switches
        //
        bool togBD = true;
        bool togSD = true;
        bool togLT = true;
        bool togMT = true;
        bool togHT = true;
        bool togRS = true;
        bool togCP = true;
        bool togCY = true;
        bool togOH = true;


        // step counts, used for mod 2 on off set up
        //
        int step1 = 2;
        int step2 = 2;
        int step3 = 2;
        int step4 = 2;
        int step5 = 2;
        int step6 = 2;
        int step7 = 2;
        int step8 = 2;
        int step9 = 2;
        int step10 = 2;
        int step11 = 2;
        int step12 = 2;
        int step13 = 2;
        int step14 = 2;
        int step15 = 2;
        int step16 = 2;


        // sequencer vars
        //
        int Clock = 0;
        int tempo = 125;
        bool stop = false;



        #endregion





        #region DRUM SELECT BUTTONS


        // clicks for drum selects, when clicked you can program that particualer
        // drum into the sequencer
        //
        // BD
        private void panel_BD_MouseClick(object sender, MouseEventArgs e)
        {

            // when clicked sets BD bool to true and the rest to false
            //
            CountBD = true;

            CountSD = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountCH = false;


            // sets background image of the button to the 'on button'
            // sets the rest to off
            //
            panel_BD.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;


                // loops through the array
                //
                for (int x = 0; x < arraySteps.Length; x++)
                {
                    // if bank 1 is selected then check if the kick array at
                    // the loop position is either true or false and set the button
                    // accordingly. sets the lights on each step switch to match
                    // the programed sequence for the particular drum
                    //
                    if (CountBank1 == true)
                    {
                        // if the bool at the particular step (position of loop)
                        // equals true then turn the light on 'else' turn them off
                        // 
                        if (BDArray[x] == true)
                        {
                            // ifs used to allow for the different step switch colours
                            //
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                        }
                        else
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                        }
                    }

                    // same setup only for bank 2 and kickarray2
                    //
                    if (CountBank2 == true)
                    {
                        if (BDArray2[x] == true)
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                        }
                        else
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                        }
                    }
                }
           
        }

        // SD, the rest of the drums are the exact same set up only using their own arrays
        //
        private void panel_SD_MouseClick(object sender, MouseEventArgs e)
        {

            CountSD = true;

            CountBD = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountCH = false;

            panel_SD.BackgroundImage = Properties.Resources.btnOn909;

            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CountBank1 == true)
                    {
                        if (SDArray[x] == true)
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                        }
                        else
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                        }
                    }


                    if (CountBank2 == true)
                    {
                        if (SDArray2[x] == true)
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                        }
                        else
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                        }
                    }
                }

        }



        // CH
        private void panel_CH_MouseClick(object sender, MouseEventArgs e)
        {

            CountCH = true;

            CountBD = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;


            panel_CH.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (CHArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (CHArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }



        // LT
        private void panel_LT_MouseClick(object sender, MouseEventArgs e)
        {
            CountLT = true;

            CountBD = false;
            CountCH = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;


            panel_LT.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (LTArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (LTArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }

        // MT
        private void panel_MT_MouseClick(object sender, MouseEventArgs e)
        {

            CountMT = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;


            panel_MT.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;


            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (MTArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (MTArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }

        // HT
        private void panel_HT_MouseClick(object sender, MouseEventArgs e)
        {
            CountHT = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountMT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;


            panel_HT.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (HTArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (HTArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }


        // RS
        private void panel_RS_MouseClick(object sender, MouseEventArgs e)
        {
            CountRS = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;


            panel_RS.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (RSArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (RSArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }

        // CP
        private void panel_CP_MouseClick(object sender, MouseEventArgs e)
        {
            CountCP = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCB = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;



            panel_CP.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (CPArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (CPArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }


        // CB
        private void panel_CB_MouseClick(object sender, MouseEventArgs e)
        {
            CountCB = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCY = false;
            CountOH = false;
            CountSD = false;


            panel_CB.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (CBArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (CBArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }

        // CY
        private void panel_CY_MouseClick(object sender, MouseEventArgs e)
        {
            CountCY = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountOH = false;
            CountSD = false;



            panel_CY.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_OH.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;


            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (CYArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (CYArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }

        // OH
        private void panel_OH_MouseClick(object sender, MouseEventArgs e)
        {

            CountOH = true;

            CountBD = false;
            CountCH = false;
            CountLT = false;
            CountMT = false;
            CountHT = false;
            CountRS = false;
            CountCP = false;
            CountCB = false;
            CountCY = false;
            CountSD = false;



            panel_OH.BackgroundImage = Properties.Resources.btnOn909;

            panel_SD.BackgroundImage = Properties.Resources.btnOff909;
            panel_LT.BackgroundImage = Properties.Resources.btnOff909;
            panel_MT.BackgroundImage = Properties.Resources.btnOff909;
            panel_HT.BackgroundImage = Properties.Resources.btnOff909;
            panel_RS.BackgroundImage = Properties.Resources.btnOff909;
            panel_CP.BackgroundImage = Properties.Resources.btnOff909;
            panel_CB.BackgroundImage = Properties.Resources.btnOff909;
            panel_CY.BackgroundImage = Properties.Resources.btnOff909;
            panel_BD.BackgroundImage = Properties.Resources.btnOff909;
            panel_CH.BackgroundImage = Properties.Resources.btnOff909;



            for (int x = 0; x < arraySteps.Length; x++)
            {

                if (CountBank1 == true)
                {
                    if (OHArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }


                if (CountBank2 == true)
                {
                    if (OHArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }
                }
            }
        }



        // bank 1, when selected turns on the first memory bank
        // and sets the step lights to whatever drum is selected
        //
        private void panel_Bank1_MouseClick(object sender, MouseEventArgs e)
        {

            // lets the program know what bank is selected
            //
            CountBank1 = true;
            CountBank2 = false;

            // sets the buttons on or off
            //
            panel_Bank1.BackgroundImage = Properties.Resources.btnOn909;
            panel_Bank2.BackgroundImage = Properties.Resources.btnOff909;


            // if the BD is slected then loops through its array and turns on the step
            // lights accordinly. same as above.
            //
            if (CountBD == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                        if (BDArray[x] == true)
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                            }
                        }
                        else
                        {
                            if (x < 4)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 3 && x < 8)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 7 && x < 12)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                            if (x > 11)
                            {
                                arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                            }
                        }

                }
            }

            // same set up for the rest of the drums
            //
            if (CountSD == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (SDArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountLT == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (LTArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountMT == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (MTArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountHT == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (HTArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountRS == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (RSArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCP == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CPArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCB == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CBArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCY == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CYArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountOH == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (OHArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCH == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CHArray[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }
    
        }


        // same set up as bank 1 only for bank 2
        //
        private void panel_Bank2_MouseClick(object sender, MouseEventArgs e)
        {
            CountBank2 = true;
            CountBank1 = false;

            panel_Bank2.BackgroundImage = Properties.Resources.btnOn909;
            panel_Bank1.BackgroundImage = Properties.Resources.btnOff909;



            if (CountBD == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (BDArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountSD == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (SDArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountLT == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (LTArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountMT == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (MTArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountHT == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (HTArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountRS == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (RSArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCP == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CPArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCB == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CBArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCY == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CYArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountOH == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (OHArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }

            if (CountCH == true)
            {
                for (int x = 0; x < arraySteps.Length; x++)
                {

                    if (CHArray2[x] == true)
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOn909;
                        }
                    }
                    else
                    {
                        if (x < 4)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 3 && x < 8)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 7 && x < 12)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                        if (x > 11)
                        {
                            arraySteps[x].BackgroundImage = Properties.Resources.btnOff909;
                        }
                    }

                }
            }
        }


        /////////////// unused
        // LT
        private void panel_LT_Paint(object sender, PaintEventArgs e)
        {

        }

        // MT
        private void panel_MT_Paint(object sender, PaintEventArgs e)
        {

        }

        // HT
        private void panel_HT_Paint(object sender, PaintEventArgs e)
        {

        }

        // RS
        private void panel_RS_Paint(object sender, PaintEventArgs e)
        {

        }

        // CP
        private void panel_CP_Paint(object sender, PaintEventArgs e)
        {

        }

        // CB
        private void panel_CB_Paint(object sender, PaintEventArgs e)
        {

        }

        // CY
        private void panel_CY_Paint(object sender, PaintEventArgs e)
        {

        }

        // OH
        private void panel_OH_Paint(object sender, PaintEventArgs e)
        {

        }


        #endregion





        #region STEP BUTTONS


        // step clicks, when a step is clicked, the selected drum is programed to that step in
        // the sequence
        //
        private void panel1_MouseClick(object sender, MouseEventArgs e) //////////////////////////////// STEP 1
        {

            // click on, if the step1 counter mod 2 = 0 then program is allow in
            // every click adds 1 to step1, used to turn on or off. true/false/true/false....
            //
            if (step1 % 2 == 0) 
            {

                // turns to button on
                //
                panel1.BackgroundImage = Properties.Resources.btnOn909;


                // if the kick drum is selected
                //
                if (CountBD == true)
                {

                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    // (programming the sequence memory)
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[0] = true;
                    }
                }

                // same set up for the rest of the drums
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[0] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[0] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[0] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[0] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[0] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[0] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[0] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[0] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[0] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[0] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[0] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel1.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[0] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[0] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[0] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[0] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[0] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[0] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[0] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[0] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[0] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[0] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[0] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[0] = false;
                    }
                }

            }

            // increments the counter
            //
            step1++;
        }


        // exact set up for the rest of the steps only relates to eacg seperate step
        //
        private void panel2_MouseClick(object sender, MouseEventArgs e) //////////////////// STEP 2
        {
            if (step2 % 2 == 0) // click on
            {
                panel2.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[1] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[1] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[1] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[1] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[1] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[1] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[1] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[1] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[1] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[1] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[1] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[1] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel2.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[1] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[1] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[1] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[1] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[1] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[1] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[1] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[1] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[1] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[1] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[1] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[1] = false;
                    }
                }

            }

            step2++;
        }



        private void panel3_MouseClick(object sender, MouseEventArgs e) ///////////////////////// STEP 3
        {
            if (step3 % 2 == 0) // click on
            {
                panel3.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[2] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[2] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[2] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[2] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[2] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[2] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[2] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[2] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[2] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[2] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[2] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[2] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel3.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[2] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[2] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[2] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[2] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[2] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[2] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[2] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[2] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[2] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[2] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[2] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[2] = false;
                    }
                }

            }

            step3++;
        }



        private void panel4_MouseClick(object sender, MouseEventArgs e) /////////////////////// STEP 4
        {
            if (step4 % 2 == 0) // click on
            {
                panel4.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[3] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[3] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[3] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[3] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[3] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[3] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[3] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[3] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[3] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[3] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[3] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[3] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel4.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[3] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[3] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[3] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[3] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[3] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[3] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[3] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[3] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[3] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[3] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[3] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[3] = false;
                    }
                }

            }

            step4++;
        }


        private void panel5_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 5
        {
            if (step5 % 2 == 0) // click on
            {
                panel5.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[4] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[4] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[4] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[4] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[4] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[4] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[4] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[4] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[4] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[4] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[4] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[4] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel5.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[4] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[4] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[4] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[4] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[4] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[4] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[4] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[4] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[4] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[4] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[4] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[4] = false;
                    }
                }

            }

            step5++;
        }


        private void panel6_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 6
        {
            if (step6 % 2 == 0) // click on
            {
                panel6.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[5] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[5] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[5] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[5] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[5] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[5] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[5] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[5] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[5] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[5] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[5] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[5] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel6.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[5] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[5] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[5] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[5] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[5] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[5] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[5] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[5] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[5] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[5] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[5] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[5] = false;
                    }
                }

            }

            step6++;
        }


        private void panel7_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 7
        {
            if (step7 % 2 == 0) // click on
            {
                panel7.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[6] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[6] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[6] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[6] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[6] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[6] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[6] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[6] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[6] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[6] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[6] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[6] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel7.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[6] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[6] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[6] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[6] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[6] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[6] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[6] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[6] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[6] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[6] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[6] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[6] = false;
                    }
                }

            }

            step7++;
        }


        private void panel8_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 8
        {
            if (step8 % 2 == 0) // click on
            {
                panel8.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[7] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[7] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[7] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[7] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[7] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[7] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[7] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[7] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[7] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[7] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[7] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[7] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel8.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[7] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[7] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[7] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[7] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[7] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[7] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[7] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[7] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[7] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[7] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[7] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[7] = false;
                    }
                }

            }

            step8++;
        }



        

        private void panel9_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 9
        {
            if (step9 % 2 == 0) // click on
            {
                panel9.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[8] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[8] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[8] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[8] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[8] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[8] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[8] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[8] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[8] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[8] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[8] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[8] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel9.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[8] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[8] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[8] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[8] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[8] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[8] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[8] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[8] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[8] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[8] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[8] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[8] = false;
                    }
                }

            }

            step9++;
        }


        private void panel10_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 10
        {
            if (step10 % 2 == 0) // click on
            {
                panel10.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[9] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[9] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[9] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[9] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[9] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[9] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[9] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[9] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[9] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[9] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[9] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[9] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel10.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[9] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[9] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[9] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[9] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[9] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[9] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[9] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[9] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[9] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[9] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[9] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[9] = false;
                    }
                }

            }

            step10++;
        }


        private void panel11_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 11
        {
            if (step11 % 2 == 0) // click on
            {
                panel11.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[10] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[10] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[10] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[10] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[10] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[10] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[10] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[10] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[10] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[10] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[10] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[10] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel11.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[10] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[10] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[10] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[10] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[10] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[10] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[10] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[10] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[10] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[10] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[10] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[10] = false;
                    }
                }

            }

            step11++;
        }


        private void panel12_MouseClick(object sender, MouseEventArgs e) ////////////////////////////// STEP 12
        {
            if (step12 % 2 == 0) // click on
            {
                panel12.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[11] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[11] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[11] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[11] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[11] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[11] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[11] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[11] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[11] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[11] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[11] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[11] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel12.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[11] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[11] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[11] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[11] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[11] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[11] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[11] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[11] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[11] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[11] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[11] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[11] = false;
                    }
                }

            }

            step12++;
        }


        private void panel13_MouseClick(object sender, MouseEventArgs e) /////////////////////////// STEP 13
        {
            if (step13 % 2 == 0) // click on
            {
                panel13.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[12] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[12] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[12] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[12] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[12] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[12] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[12] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[12] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[12] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[12] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[12] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[12] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel13.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[12] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[12] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[12] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[12] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[12] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[12] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[12] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[12] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[12] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[12] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[12] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[12] = false;
                    }
                }

            }

            step13++;
        }


        private void panel14_MouseClick(object sender, MouseEventArgs e) /////////////////////////// STEP 14
        {
            if (step14 % 2 == 0) // click on
            {
                panel14.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[13] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[13] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[13] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[13] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[13] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[13] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[13] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[13] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[13] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[13] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[13] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[13] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel14.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[13] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[13] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[13] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[13] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[13] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[13] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[13] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[13] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[13] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[13] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[13] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[13] = false;
                    }
                }

            }

            step14++;
        }


        private void panel15_MouseClick(object sender, MouseEventArgs e) /////////////////////////// STEP 15
        {
            if (step15 % 2 == 0) // click on
            {
                panel15.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[14] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[14] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[14] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[14] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[14] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[14] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[14] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[14] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[14] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[14] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[14] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[14] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel15.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[14] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[14] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[14] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[14] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[14] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[14] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[14] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[14] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[14] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[14] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[14] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[14] = false;
                    }
                }

            }

            step15++;
        }


        private void panel16_MouseClick(object sender, MouseEventArgs e) /////////////////////////// STEP 16
        {
            if (step16 % 2 == 0) // click on
            {
                panel16.BackgroundImage = Properties.Resources.btnOn909;

                // if the kick drum is selected
                //
                if (CountBD == true)
                {
                    // sets the kick array to true or false at the position
                    // of the particular step, depends on what bank is selected
                    //
                    if (CountBank1 == true)
                    {
                        BDArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[15] = true;
                    }
                }

                // same set up for snare
                //
                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[15] = true;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[15] = true;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[15] = true;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[15] = true;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[15] = true;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[15] = true;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[15] = true;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[15] = true;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[15] = true;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[15] = true;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[15] = true;
                    }
                }

            }
            else // click off, same thing only sets arrays to false
            {
                panel16.BackgroundImage = Properties.Resources.btnOff909;

                if (CountBD == true)
                {
                    if (CountBank1 == true)
                    {
                        BDArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        BDArray2[15] = false;
                    }
                }

                if (CountSD == true)
                {
                    if (CountBank1 == true)
                    {
                        SDArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        SDArray2[15] = false;
                    }
                }


                // LT
                if (CountLT == true)
                {
                    if (CountBank1 == true)
                    {
                        LTArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        LTArray2[15] = false;
                    }
                }


                // MT
                if (CountMT == true)
                {
                    if (CountBank1 == true)
                    {
                        MTArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        MTArray2[15] = false;
                    }
                }


                // HT
                if (CountHT == true)
                {
                    if (CountBank1 == true)
                    {
                        HTArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        HTArray2[15] = false;
                    }
                }


                // RS
                if (CountRS == true)
                {
                    if (CountBank1 == true)
                    {
                        RSArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        RSArray2[15] = false;
                    }
                }


                // CP
                if (CountCP == true)
                {
                    if (CountBank1 == true)
                    {
                        CPArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CPArray2[15] = false;
                    }
                }


                // CB
                if (CountCB == true)
                {
                    if (CountBank1 == true)
                    {
                        CBArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CBArray2[15] = false;
                    }
                }


                // CY
                if (CountCY == true)
                {
                    if (CountBank1 == true)
                    {
                        CYArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CYArray2[15] = false;
                    }
                }


                // OH
                if (CountOH == true)
                {
                    if (CountBank1 == true)
                    {
                        OHArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        OHArray2[15] = false;
                    }
                }


                // CH
                if (CountCH == true)
                {
                    if (CountBank1 == true)
                    {
                        CHArray[15] = false;
                    }
                    if (CountBank2 == true)
                    {
                        CHArray2[15] = false;
                    }
                }

            }

            step16++;
        }

        #endregion





        #region TOGGLE SWITCHES

        // toggle switches, used to change drum sounds/players
        //
        // BD
        private void ToggleBD_MouseClick(object sender, MouseEventArgs e)
        {
            // used for switching on and off with on click event
            // and lets the program know what state the switch is in
            //
            if (togBD == true)
            {
                ToggleBD.BackgroundImage = Properties.Resources.switchDown;
                togBD = false;
            }
            else
            {
                ToggleBD.BackgroundImage = Properties.Resources.switchUp;
                togBD = true;
            }
        }

        // SD, same set up for the rest of the switches
        //
        private void ToggleSD_MouseClick(object sender, MouseEventArgs e)
        {
            if (togSD == true)
            {
                ToggleSD.BackgroundImage = Properties.Resources.switchDown;
                togSD = false;
            }
            else
            {
                ToggleSD.BackgroundImage = Properties.Resources.switchUp;
                togSD = true;
            }
        }

        // LT
        private void ToggleLT_MouseClick(object sender, MouseEventArgs e)
        {
            if (togLT == true)
            {
                ToggleLT.BackgroundImage = Properties.Resources.switchDown;
                togLT = false;
            }
            else
            {
                ToggleLT.BackgroundImage = Properties.Resources.switchUp;
                togLT = true;
            }
        }

        // MT
        private void ToggleMT_MouseClick(object sender, MouseEventArgs e)
        {
            if (togMT == true)
            {
                ToggleMT.BackgroundImage = Properties.Resources.switchDown;
                togMT = false;
            }
            else
            {
                ToggleMT.BackgroundImage = Properties.Resources.switchUp;
                togMT = true;
            }
        }

        // HT
        private void ToggleHT_MouseClick(object sender, MouseEventArgs e)
        {
            if (togHT == true)
            {
                ToggleHT.BackgroundImage = Properties.Resources.switchDown;
                togHT = false;
            }
            else
            {
                ToggleHT.BackgroundImage = Properties.Resources.switchUp;
                togHT = true;
            }
        }

        // RS
        private void ToggleRS_MouseClick(object sender, MouseEventArgs e)
        {
            if (togRS == true)
            {
                //ToggleRS.BackgroundImage = Properties.Resources.switchDown;
                togRS = false;
            }
            else
            {
                //ToggleRS.BackgroundImage = Properties.Resources.switchUp;
                togRS = true;
            }
        }

        // CP
        private void ToggleCP_MouseClick(object sender, MouseEventArgs e)
        {
            if (togCP == true)
            {
                ToggleCP.BackgroundImage = Properties.Resources.switchDown;
                togCP = false;
            }
            else
            {
                ToggleCP.BackgroundImage = Properties.Resources.switchUp;
                togCP = true;
            }
        }

        // CY
        private void ToggleCY_MouseClick(object sender, MouseEventArgs e)
        {
            if (togCY == true)
            {
                ToggleCY.BackgroundImage = Properties.Resources.switchDown;
                togCY = false;
            }
            else
            {
                ToggleCY.BackgroundImage = Properties.Resources.switchUp;
                togCY = true;
            }
        }

        // OH
        private void ToggleOH_MouseClick(object sender, MouseEventArgs e)
        {
            if (togOH == true)
            {
                ToggleOH.BackgroundImage = Properties.Resources.switchDown;
                togOH = false;
            }
            else
            {
                ToggleOH.BackgroundImage = Properties.Resources.switchUp;
                togOH = true;
            }
        }

        #endregion




        #region BGW SEQUENCER


        // start stop button, starts the sequencer BGW
        //
        private void panel_StartStop_MouseClick(object sender, MouseEventArgs e)
        {
            // if/else/bool set up to allow on and off with one click event
            //
            if (StartStopBtn == true)
            {

                // button on image
                //
                panel_StartStop.BackgroundImage = Properties.Resources.btnStartStop_ON;

                // when clicked on the clock is reset
                //
                Clock = 0;

                // stop bool set to false to sequence loop is able to run
                //
                stop = false;

                // trys to run the BGWs for the lights and the sequencer
                //
                try
                {
                    BGW_Sequencer.RunWorkerAsync();
                    BGW_Lights.RunWorkerAsync();
                }
                catch
                {
                }

                // bool set to false to let the program know that the button is on
                //
                StartStopBtn = false;
            }
            else
            {
                // when clicked of sets stop to true to exit the sequencer loop
                // and lets the program know the button is off
                //
                stop = true;
                StartStopBtn = true;

                // button off image
                //
                panel_StartStop.BackgroundImage = Properties.Resources.btnStartStop;
            }
        }




        // BGW for the sequencer timing Lights
        // 
        private void BGW_Lights_DoWork(object sender, DoWorkEventArgs e)
        {
            // while stop is not true
            //
            while (stop != true)
            {

                // sleep allows for the tempo, creates a gap of time between each step
                //
                System.Threading.Thread.Sleep(tempo);


                // if statements used to turn the lights on at the particular step
                //
                if (Clock == 1)
                {
                    // invokes needed to stop cross thread errors
                    //
                    this.Invoke(new Action(() =>
                    {
                        // shows current light
                        // hides previous light
                        //
                        light1.Show();
                        light16.Hide();
                    }));
                }

                // same set up for rest of steps
                //
                if (Clock == 2)
                {
                    this.Invoke(new Action(() =>
                    {
                        light2.Show();
                        light1.Hide();
                    }));
                }

                if (Clock == 3)
                {
                    this.Invoke(new Action(() =>
                    {
                        light3.Show();
                        light2.Hide();
                    }));
                }

                if (Clock == 4)
                {
                    this.Invoke(new Action(() =>
                    {
                        light4.Show();
                        light3.Hide();
                    }));
                }

                if (Clock == 5)
                {
                    this.Invoke(new Action(() =>
                    {
                        light5.Show();
                        light4.Hide();
                    }));
                }

                if (Clock == 6)
                {
                    this.Invoke(new Action(() =>
                    {
                        light6.Show();
                        light5.Hide();
                    }));
                }

                if (Clock == 7)
                {
                    this.Invoke(new Action(() =>
                    {
                        light7.Show();
                        light6.Hide();
                    }));
                }

                if (Clock == 8)
                {
                    this.Invoke(new Action(() =>
                    {
                        light8.Show();
                        light7.Hide();
                    }));
                }

                if (Clock == 9)
                {
                    this.Invoke(new Action(() =>
                    {
                        light9.Show();
                        light8.Hide();
                    }));
                }

                if (Clock == 10)
                {
                    this.Invoke(new Action(() =>
                    {
                        light10.Show();
                        light9.Hide();
                    }));
                }

                if (Clock == 11)
                {
                    this.Invoke(new Action(() =>
                    {
                        light11.Show();
                        light10.Hide();
                    }));
                }

                if (Clock == 12)
                {
                    this.Invoke(new Action(() =>
                    {
                        light12.Show();
                        light11.Hide();
                    }));
                }

                if (Clock == 13)
                {
                    this.Invoke(new Action(() =>
                    {
                        light13.Show();
                        light12.Hide();
                    }));
                }

                if (Clock == 14)
                {
                    this.Invoke(new Action(() =>
                    {
                        light14.Show();
                        light13.Hide();
                    }));
                }

                if (Clock == 15)
                {
                    this.Invoke(new Action(() =>
                    {
                        light15.Show();
                        light14.Hide();
                    }));
                }

                if (Clock == 16)
                {
                    this.Invoke(new Action(() =>
                    {
                        light16.Show();
                        light15.Hide();
                    }));
                }
            }

            // when the sequencer is stopped then all lights are turned off
            //
            this.Invoke(new Action(() =>
                {
                    light1.Hide();
                    light2.Hide();
                    light3.Hide();
                    light4.Hide();
                    light5.Hide();
                    light6.Hide();
                    light7.Hide();
                    light8.Hide();
                    light9.Hide();
                    light10.Hide();
                    light11.Hide();
                    light12.Hide();
                    light13.Hide();
                    light14.Hide();
                    light15.Hide();
                    light16.Hide();
                }));
        }




        // BGW Sequencer, plays the drum player BGWs based on the bool arrays
        // for the particular drums
        //
        private void BGW_Sequencer_DoWork(object sender, DoWorkEventArgs e)
        {
            // resets to true every time the sequencer is started
            //
            fillooper = true;

            // stays looping until startstop button is switched off
            //
            while (stop != true)
            {

                // sleep used to create time gap between each step
                // i.e. tempo
                //
                System.Threading.Thread.Sleep(tempo);

                // increments the clock, used to tell what step sequencer is on
                //
                Clock++;

                // used to reset the clock every 16 steps (1 - 17)
                //
                if (Clock == 17)
                {
                    Clock = 1;

                    // if fill is on switches the fill loop bool between true
                    // and false every 1 bar, then switches between banks based
                    // on the bool value
                    //
                    if (CountFill == true)
                    {
                        if (fillooper == true)
                        {
                            fillooper = false;
                        }
                        else
                        {
                            fillooper = true;
                        }

                        if (fillooper == true)
                        {
                            // calls the click events for the bank select
                            //
                            panel_Bank1_MouseClick(null, null);
                        }

                        if (fillooper == false)
                        {
                            panel_Bank2_MouseClick(null, null);
                        }
                    }
                }


                // checks current step and runs BGW players
                // BD
                // if BD is not muted
                //
                if (BDmute == false)
                {

                try
                {
                    // if clock is at first step then program is allowed in
                    // 
                    if (Clock == 1)
                    {
                        // ifs used to check which bank is selected
                        //
                        if (CountBank1 == true)
                        {
                            // checks if the bool for BD is true
                            // if it is then the BGW player for that drum
                            // is triggered and the drum is played
                            //
                            if (BDArray[0] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        // same for bank 2 with BDArray2
                        //
                        if (CountBank2 == true)
                        {
                            if (BDArray2[0] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    // same set up for the rest of the steps
                    //
                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[1] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[1] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[2] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[2] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[3] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[3] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[4] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[4] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[5] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[5] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[6] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[6] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[7] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[7] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[8] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[8] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[9] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[9] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[10] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[10] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[11] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[11] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[12] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[12] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[13] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[13] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[14] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[14] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (BDArray[15] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (BDArray2[15] == true)
                            {
                                BGW_BDplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }




                // SD, repated again for the rest of the drums
                //
                if (SDmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[0] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[0] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[1] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[1] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[2] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[2] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[3] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[3] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[4] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[4] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[5] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[5] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[6] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[6] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[7] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[7] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[8] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[8] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[9] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[9] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[10] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[10] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[11] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[11] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[12] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[12] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[13] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[13] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[14] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[14] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (SDArray[15] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (SDArray2[15] == true)
                            {
                                BGW_SDplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }




                // LT
                if (LTmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[0] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[0] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[1] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[1] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[2] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[2] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[3] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[3] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[4] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[4] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[5] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[5] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[6] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[6] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[7] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[7] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[8] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[8] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[9] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[9] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[10] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[10] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[11] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[11] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[12] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[12] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[13] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[13] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[14] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[14] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (LTArray[15] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (LTArray2[15] == true)
                            {
                                BGW_LT.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }



                // MT
                if (MTmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[0] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[0] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[1] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[1] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[2] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[2] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[3] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[3] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[4] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[4] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[5] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[5] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[6] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[6] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[7] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[7] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[8] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[8] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[9] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[9] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[10] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[10] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[11] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[11] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[12] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[12] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[13] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[13] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[14] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[14] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (MTArray[15] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (MTArray2[15] == true)
                            {
                                BGW_MT.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }





                // HT
                if (HTmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[0] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[0] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[1] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[1] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[2] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[2] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[3] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[3] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[4] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[4] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[5] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[5] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[6] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[6] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[7] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[7] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[8] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[8] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[9] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[9] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[10] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[10] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[11] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[11] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[12] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[12] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[13] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[13] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[14] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[14] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (HTArray[15] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (HTArray2[15] == true)
                            {
                                BGW_HT.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }




                // RS
                if (RSmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[0] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[0] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[1] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[1] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[2] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[2] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[3] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[3] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[4] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[4] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[5] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[5] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[6] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[6] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[7] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[7] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[8] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[8] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[9] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[9] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[10] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[10] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[11] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[11] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[12] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[12] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[13] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[13] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[14] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[14] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (RSArray[15] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (RSArray2[15] == true)
                            {
                                BGW_RSplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }




                // CP
                if (CPmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[0] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[0] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[1] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[1] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[2] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[2] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[3] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[3] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[4] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[4] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[5] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[5] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[6] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[6] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[7] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[7] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[8] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[8] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[9] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[9] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[10] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[10] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[11] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[11] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[12] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[12] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[13] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[13] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[14] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[14] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (CPArray[15] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CPArray2[15] == true)
                            {
                                BGW_CPplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }





                // CB
                if (CBmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[0] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[0] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[1] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[1] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[2] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[2] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[3] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[3] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[4] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[4] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[5] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[5] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[6] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[6] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[7] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[7] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[8] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[8] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[9] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[9] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[10] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[10] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[11] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[11] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[12] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[12] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[13] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[13] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[14] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[14] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (CBArray[15] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CBArray2[15] == true)
                            {
                                BGW_CBplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }




                // CY
                if (CYmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[0] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[0] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[1] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[1] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[2] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[2] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[3] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[3] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[4] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[4] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[5] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[5] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[6] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[6] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[7] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[7] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[8] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[8] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[9] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[9] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[10] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[10] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[11] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[11] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[12] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[12] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[13] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[13] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[14] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[14] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (CYArray[15] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CYArray2[15] == true)
                            {
                                BGW_CYplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }




                // OH
                if (OHmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[0] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[0] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[1] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[1] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[2] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[2] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[3] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[3] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[4] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[4] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[5] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[5] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[6] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[6] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[7] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[7] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[8] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[8] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[9] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[9] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[10] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[10] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[11] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[11] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[12] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[12] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[13] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[13] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[14] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[14] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (OHArray[15] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (OHArray2[15] == true)
                            {
                                BGW_OHplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }



                // CH
                if (CHmute == false)
                {

                try
                {
                    if (Clock == 1)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[0] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[0] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 2)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[1] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[1] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 3)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[2] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[2] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 4)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[3] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[3] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 5)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[4] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[4] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 6)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[5] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[5] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 7)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[6] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[6] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 8)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[7] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[7] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 9)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[8] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[8] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 10)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[9] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[9] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 11)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[10] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[10] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 12)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[11] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[11] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 13)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[12] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[12] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 14)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[13] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[13] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 15)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[14] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[14] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }


                    if (Clock == 16)
                    {
                        if (CountBank1 == true)
                        {
                            if (CHArray[15] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }

                        if (CountBank2 == true)
                        {
                            if (CHArray2[15] == true)
                            {
                                BGW_CHplay.RunWorkerAsync();
                            }
                        }
                    }

                }
                catch
                {
                }

                }

                
            }
        }


        #endregion





        #region BGW PLAYERS

        // BGW Players, plays the drum sounds when triggered
        //
        // BD
        //
        private void BGW_BDplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // toggle bools used to switch between drum sounds
                // can have two BD's
                //
                if (togBD == true)
                {
                    engine_BD.Play2D(path_BDshort);
                }

                if (togBD == false)
                {
                    engine_BD.Play2D(path_BDLong);
                }
            }
            catch
            {
            }
        }


        // SD, same set up for the rest of the BGW players
        //
        private void BGW_SDplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togSD == true)
                {
                    engine_SD.Play2D(path_SDLow);
                }

                if (togSD == false)
                {
                    engine_SD.Play2D(path_SDHigh);
                }
            }
            catch
            {
            }
        }

        // LT
        private void BGW_LT_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togLT == true)
                {
                    engine_LT.Play2D(path_LT);
                }

                if (togLT == false)
                {
                    engine_LT.Play2D(path_LC);
                }
            }
            catch
            {
            }
        }

        // MT
        private void BGW_MT_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togMT == true)
                {
                    engine_MT.Play2D(path_MT);
                }

                if (togMT == false)
                {
                    engine_MT.Play2D(path_MC);
                }
            }
            catch
            {
            }
        }

        // HT
        private void BGW_HT_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togHT == true)
                {
                    engine_HT.Play2D(path_HT);
                }

                if (togHT == false)
                {
                    engine_HT.Play2D(path_HC);
                }
            }
            catch
            {
            }
        }

        // RS
        private void BGW_RSplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togRS == true)
                {
                    engine_RS.Play2D(path_RS);
                }

                if (togRS == false)
                {
                    engine_RS.Play2D(path_CL);
                }
            }
            catch
            {
            }
        }

        // CP
        private void BGW_CPplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togCP == true)
                {
                    engine_CP.Play2D(path_CP);
                }

                if (togCP == false)
                {
                    engine_CP.Play2D(path_MA);
                }
            }
            catch
            {
            }
        }

        // CB
        private void BGW_CBplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                    engine_CB.Play2D(path_CB);
            }
            catch
            {
            }
        }

        // CY
        private void BGW_CYplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togCY == true)
                {
                    engine_CY.Play2D(path_CYShort);
                }

                if (togCY == false)
                {
                    engine_CY.Play2D(path_CYLong);
                }
            }
            catch
            {
            }
        }

        // OH
        private void BGW_OHplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (togOH == true)
                {
                    engine_OH.Play2D(path_OHShort);
                }

                if (togOH == false)
                {
                    engine_OH.Play2D(path_OHLong);
                }
            }
            catch
            {
            }
        }

        // CH
        private void BGW_CHplay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                engine_CH.Play2D(path_CH);
            }
            catch
            {
            }
        }


        #endregion




        #region MUTE BUTTONS

        // mute buttons, stops the players from playing the drums when eneables
        // works for individual drums
        //
        private void muteBD_MouseClick(object sender, MouseEventArgs e)
        {
            // sets the bool to true or false for on and off
            //
            if (BDmute == false)
            {
                BDmute = true;
                muteBD.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                BDmute = false;
                muteBD.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        // same set up for the rest of the drum mutes
        //
        private void muteSD_MouseClick(object sender, MouseEventArgs e)
        {
            if (SDmute == false)
            {
                SDmute = true;
                muteSD.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                SDmute = false;
                muteSD.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteLT_MouseClick(object sender, MouseEventArgs e)
        {
            if (LTmute == false)
            {
                LTmute = true;
                muteLT.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                LTmute = false;
                muteLT.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteMT_MouseClick(object sender, MouseEventArgs e)
        {
            if (MTmute == false)
            {
                MTmute = true;
                muteMT.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                MTmute = false;
                muteMT.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteHT_MouseClick(object sender, MouseEventArgs e)
        {
            if (HTmute == false)
            {
                HTmute = true;
                muteHT.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                HTmute = false;
                muteHT.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteRS_MouseClick(object sender, MouseEventArgs e)
        {
            if (RSmute == false)
            {
                RSmute = true;
                muteRS.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                RSmute = false;
                muteRS.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteCP_MouseClick(object sender, MouseEventArgs e)
        {
            if (CPmute == false)
            {
                CPmute = true;
                muteCP.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                CPmute = false;
                muteCP.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteCB_MouseClick(object sender, MouseEventArgs e)
        {
            if (CBmute == false)
            {
                CBmute = true;
                muteCB.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                CBmute = false;
                muteCB.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteCY_MouseClick(object sender, MouseEventArgs e)
        {
            if (CYmute == false)
            {
                CYmute = true;
                muteCY.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                CYmute = false;
                muteCY.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteOH_MouseClick(object sender, MouseEventArgs e)
        {
            if (OHmute == false)
            {
                OHmute = true;
                muteOH.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                OHmute = false;
                muteOH.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }

        private void muteCH_MouseClick(object sender, MouseEventArgs e)
        {
            if (CHmute == false)
            {
                CHmute = true;
                muteCH.BackgroundImage = Properties.Resources.btnOnblack;
            }
            else
            {
                CHmute = false;
                muteCH.BackgroundImage = Properties.Resources.btnOffblack;
            }
        }


        #endregion




        #region TEMPO AND VOLUME BUTTONS



        // fill click, when clicked turns the fill option on or off
        // sets the bools accordingly
        //
        private void panel_Fill_MouseClick(object sender, MouseEventArgs e)
        {
            if (CountFill == false)
            {
                panel_Fill.BackgroundImage = Properties.Resources.btnOn909;
                CountFill = true;
            }
            else
            {
                panel_Fill.BackgroundImage = Properties.Resources.btnOff909;
                CountFill = false;
                panel_Bank1_MouseClick(null, null);
            }
        }




        // tempo up and down
        //
        private void panel_TempDwn_MouseClick(object sender, MouseEventArgs e)
        {
            // allows tempo to be lowered within the specified limit
            //
            if (tempo < 400)
            {
                tempo += 3;
            }
        }

        // mouse up and down event used to change the button images to on or off
        //
        private void panel_TempDwn_MouseDown(object sender, MouseEventArgs e)
        {
            panel_TempDwn.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_TempDwn_MouseUp(object sender, MouseEventArgs e)
        {
            panel_TempDwn.BackgroundImage = Properties.Resources.btnOff909;
        }


        private void panel_TempUp_MouseClick(object sender, MouseEventArgs e)
        {

            // allows tempo to be increase within its limit
            //
            if (tempo > 70)
            {
                tempo -= 3;
            }
        }

        // buttons on or off
        //
        private void panel_TempUp_MouseDown(object sender, MouseEventArgs e)
        {
            panel_TempUp.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_TempUp_MouseUp(object sender, MouseEventArgs e)
        {
            panel_TempUp.BackgroundImage = Properties.Resources.btnOff909;
        }



        // form closing, stops sequencer before closing
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StartStopBtn == false)
            {
                panel_StartStop_MouseClick(null, null);
            }
        }



        

        // Volume buttons
        //
        // BD up
        //
        // mouse up and down event for changing button images
        //
        private void panel_VolUpBD_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpBD.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpBD_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpBD.BackgroundImage = Properties.Resources.btnOff909;
        }
        
        // click event for changing volume
        //
        private void panel_VolUpBD_MouseClick(object sender, MouseEventArgs e)
        {
            // increases volume within limits
            //
            if (engine_BD.SoundVolume < 0.8f)
            {
                engine_BD.SoundVolume += 0.05f;
            }
        }

        // BD down
        //
        private void panel_VolDwnBD_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnBD.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnBD_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnBD.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnBD_MouseClick(object sender, MouseEventArgs e)
        {
            // decreases volume within limits
            //
            if (engine_BD.SoundVolume > 0.2f)
            {
                engine_BD.SoundVolume -= 0.05f;
            }
        }


        // SD, same set up for rest of drum volumes
        //
        private void panel_VolUpSD_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpSD.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpSD_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpSD.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpSD_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_SD.SoundVolume < 0.8f)
            {
                engine_SD.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnSD_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnSD.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnSD_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnSD.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnSD_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_SD.SoundVolume > 0.2f)
            {
                engine_SD.SoundVolume -= 0.05f;
            }
        }


        // LT
        //
        private void panel_VolUpLT_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpLT.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpLT_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpLT.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpLT_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_LT.SoundVolume < 0.8f)
            {
                engine_LT.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnLT_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnLT.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnLT_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnLT.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnLT_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_LT.SoundVolume > 0.2f)
            {
                engine_LT.SoundVolume -= 0.05f;
            }
        }


        // MT
        //
        private void panel_VolUpMT_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpMT.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpMT_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpMT.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpMT_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_MT.SoundVolume < 0.8f)
            {
                engine_MT.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnMT_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnMT.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnMT_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnMT.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnMT_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_MT.SoundVolume > 0.2f)
            {
                engine_MT.SoundVolume -= 0.05f;
            }
        }


        // HT
        //
        private void panel_VolUpHT_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpHT.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpHT_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpHT.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpHT_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_HT.SoundVolume < 0.8f)
            {
                engine_HT.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnHT_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnHT.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnHT_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnHT.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnHT_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_HT.SoundVolume > 0.2f)
            {
                engine_HT.SoundVolume -= 0.05f;
            }
        }


        // RS
        //
        private void panel_VolUpRS_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpRS.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpRS_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpRS.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpRS_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_RS.SoundVolume < 0.8f)
            {
                engine_RS.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnRS_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnRS.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnRS_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnRS.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnRS_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_RS.SoundVolume > 0.2f)
            {
                engine_RS.SoundVolume -= 0.05f;
            }
        }


        // CP
        //
        private void panel_VolUpCP_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpCP.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpCP_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpCP.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpCP_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CP.SoundVolume < 0.8f)
            {
                engine_CP.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnCP_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnCP.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnCP_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnCP.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnCP_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CP.SoundVolume > 0.2f)
            {
                engine_CP.SoundVolume -= 0.05f;
            }
        }


        // CB
        //
        private void panel_VolUpCB_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpCB.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpCB_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpCB.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpCB_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CB.SoundVolume < 0.8f)
            {
                engine_CB.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnCB_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnCB.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnCB_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnCB.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnCB_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CB.SoundVolume > 0.2f)
            {
                engine_CB.SoundVolume -= 0.05f;
            }
        }


        // CY
        //
        private void panel_VolUpCY_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpCY.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpCY_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpCY.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpCY_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CY.SoundVolume < 0.8f)
            {
                engine_CY.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnCY_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnCY.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnCY_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnCY.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnCY_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CY.SoundVolume > 0.2f)
            {
                engine_CY.SoundVolume -= 0.05f;
            }
        }


        // OH
        private void panel_VolUpOH_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpOH.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpOH_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpOH.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpOH_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_OH.SoundVolume < 0.8f)
            {
                engine_OH.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnOH_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnOH.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnOH_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnOH.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnOH_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_OH.SoundVolume > 0.2f)
            {
                engine_OH.SoundVolume -= 0.05f;
            }
        }


        // CH
        //
        private void panel_VolUpCH_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolUpCH.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolUpCH_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolUpCH.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolUpCH_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CH.SoundVolume < 0.8f)
            {
                engine_CH.SoundVolume += 0.05f;
            }
        }

        private void panel_VolDwnCH_MouseDown(object sender, MouseEventArgs e)
        {
            panel_VolDwnCH.BackgroundImage = Properties.Resources.btnOn909;
        }

        private void panel_VolDwnCH_MouseUp(object sender, MouseEventArgs e)
        {
            panel_VolDwnCH.BackgroundImage = Properties.Resources.btnOff909;
        }

        private void panel_VolDwnCH_MouseClick(object sender, MouseEventArgs e)
        {
            if (engine_CH.SoundVolume > 0.2f)
            {
                engine_CH.SoundVolume -= 0.05f;
            }
        }


        #endregion




        #region KEY PRESSES


        // key press for controls, mutes, and players
        //
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // start stop
            //
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                panel_StartStop_MouseClick(null, null);
            }

            // mutes
            //
            if (e.KeyChar == '1')
            {
                muteBD_MouseClick(null, null);
            }

            if (e.KeyChar == '2')
            {
                muteSD_MouseClick(null, null);
            }

            if (e.KeyChar == '3')
            {
                muteLT_MouseClick(null, null);
            }

            if (e.KeyChar == '4')
            {
                muteMT_MouseClick(null, null);
            }

            if (e.KeyChar == '5')
            {
                muteHT_MouseClick(null, null);
            }

            if (e.KeyChar == '6')
            {
                muteRS_MouseClick(null, null);
            }

            if (e.KeyChar == '7')
            {
                muteCP_MouseClick(null, null);
            }

            if (e.KeyChar == '8')
            {
                muteCB_MouseClick(null, null);
            }

            if (e.KeyChar == '9')
            {
                muteCY_MouseClick(null, null);
            }

            if (e.KeyChar == '0')
            {
                muteOH_MouseClick(null, null);
            }

            if (e.KeyChar == '-')
            {
                muteCH_MouseClick(null, null);
            }


            // play sounds
            //
            try
            {
                if (e.KeyChar == 'a')
                {
                    BGW_BDplay.RunWorkerAsync();
                }

                if (e.KeyChar == 's')
                {
                    BGW_SDplay.RunWorkerAsync();
                }

                if (e.KeyChar == 'd')
                {
                    BGW_LT.RunWorkerAsync();
                }

                if (e.KeyChar == 'f')
                {
                    BGW_MT.RunWorkerAsync();
                }

                if (e.KeyChar == 'g')
                {
                    BGW_HT.RunWorkerAsync();
                }

                if (e.KeyChar == 'h')
                {
                    BGW_RSplay.RunWorkerAsync();
                }

                if (e.KeyChar == 'j')
                {
                    BGW_CPplay.RunWorkerAsync();
                }

                if (e.KeyChar == 'k')
                {
                    BGW_CBplay.RunWorkerAsync();
                }

                if (e.KeyChar == 'l')
                {
                    BGW_CYplay.RunWorkerAsync();
                }

                if (e.KeyChar == ';')
                {
                    BGW_OHplay.RunWorkerAsync();
                }

                if (e.KeyChar == '#')
                {
                    BGW_CHplay.RunWorkerAsync();
                }
            }
            catch
            {
            }


            // toggle switches
            //
            if (e.KeyChar == 'q')
            {
                ToggleBD_MouseClick(null, null);
            }

            if (e.KeyChar == 'w')
            {
                ToggleSD_MouseClick(null, null);
            }

            if (e.KeyChar == 'e')
            {
                ToggleLT_MouseClick(null, null);
            }

            if (e.KeyChar == 'r')
            {
                ToggleMT_MouseClick(null, null);
            }

            if (e.KeyChar == 't')
            {
                ToggleHT_MouseClick(null, null);
            }

            if (e.KeyChar == 'y')
            {
                ToggleRS_MouseClick(null, null);
            }

            if (e.KeyChar == 'u')
            {
                ToggleCP_MouseClick(null, null);
            }

            if (e.KeyChar == 'o')
            {
                ToggleCY_MouseClick(null, null);
            }

            if (e.KeyChar == 'p')
            {
                ToggleOH_MouseClick(null, null);
            }



            // controls
            //
            if (e.KeyChar == 'z')
            {
                panel_TempDwn_MouseClick(null, null);
            }
            
            if (e.KeyChar == 'x')
            {
                panel_TempUp_MouseClick(null, null);
            }

            if (e.KeyChar == 'c')
            {
                panel_Bank1_MouseClick(null, null);
            }

            if (e.KeyChar == 'v')
            {
                panel_Bank2_MouseClick(null, null);
            }

            if (e.KeyChar == 'b')
            {
                panel_Fill_MouseClick(null, null);
            }

        }


        #endregion


        





    }
}
