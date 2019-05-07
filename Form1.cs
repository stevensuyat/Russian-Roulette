using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Form1 : Form
    {
        GamePlay GP = new GamePlay();

        public Form1()
        {
            InitializeComponent();
            //disable throw and dodge buttons
            btnThrow.Enabled = false;
            btnDodge.Enabled = false;
        }

        private void Victory()
        {
            //play sound on victory
            SoundPlayer victory = new SoundPlayer(Resource1.victory);
            victory.Play();
            //display image on victory
            pbResult.Image = Resource1.win;
        }

        private void Defeat()
        {
            //play sound on defeat
            SoundPlayer defeat = new SoundPlayer(Resource1.defeat);
            defeat.Play();
            //display image on defeat
            pbResult.Image = Resource1.paint;
        }


        private void BtnLoadBalloons_Click(object sender, EventArgs e)
        {
            StartGame(); 
        }

        private void BtnThrow_Click(object sender, EventArgs e)
        {
            ThrowBalloon();
        }

        private void BtnDodge_Click(object sender, EventArgs e)
        {
            DodgeBalloon();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }



        public void StartGame()
        {
            //enable throw and dodge buttons
            btnThrow.Enabled = true;
            btnDodge.Enabled = true;

            //generate random number for balloons
            GP.BalloonsLoaded = GP.RndNumGen();
            GP.BalloonsLeft = GP.RndNumGen();
            GP.PaintBalloon = GP.PaintBalloonGen();


            //set amount of dodges
            GP.DdgBalloon = 2;

            //display game info
            lblBalloonsLoaded.Text = "Water Balloons Loaded: " + GP.BalloonsLoaded;
            lblBalloonsLeft.Text = "Water Balloons Left: " + GP.BalloonsLeft;
            lblDodgesLeft.Text = "Dodges Left: " + GP.DdgBalloon;
            lblWinLoss.Text = "Wins / Losses: " + GP.Wins + "/" + GP.Losses;
            lblResult.Text = "";
            //clears image on picture box
            pbResult.Image = null;
        }

        private void ThrowBalloon()
        {
            //balloons left countdown
            if (GP.BalloonsLeft == GP.PaintBalloon)
            {
                lblResult.Text = "YOU LOSE!";
                Defeat();
                GP.Losses++;
                btnThrow.Enabled = false;
                btnDodge.Enabled = false;
            }
            else if (GP.BalloonsLeft == 1)
            {
                lblResult.Text = "YOU WIN!";
                Victory();
                GP.Wins++;
                btnThrow.Enabled = false;
                btnDodge.Enabled = false;
            }
            else if (GP.BalloonsLeft != GP.PaintBalloon || GP.BalloonsLeft != 0)
            {
                GP.BalloonsLeft--;
            }


            //display game info
            lblBalloonsLoaded.Text = "Water Balloons Loaded: " + GP.BalloonsLoaded;
            lblBalloonsLeft.Text = "Water Balloons Left: " + GP.BalloonsLeft;
            lblDodgesLeft.Text = "Dodges Left: " + GP.DdgBalloon;
            lblWinLoss.Text = "Wins / Losses: " + GP.Wins + "/" + GP.Losses;
        }

        private void DodgeBalloon()
        {
            //balloons left countdown
            //when balloons left = 1, next click = win
            if (GP.BalloonsLeft == 1)
            {
                lblResult.Text = "YOU WIN!";
                //runs victory method
                Victory();
                GP.Wins++;
                btnThrow.Enabled = false;
                btnDodge.Enabled = false;
            }
            else if (GP.DdgBalloon == 0)
            {
                lblDodgesLeft.Text = "Dodges Left: " + GP.DdgBalloon;
                btnDodge.Enabled = false;
            }
            else if (GP.BalloonsLeft != 0 || GP.DdgBalloon != 0)
            {
                GP.BalloonsLeft--;
                GP.DdgBalloon--;
            }


            //display game info
            lblBalloonsLoaded.Text = "Water Balloons Loaded: " + GP.BalloonsLoaded;
            lblBalloonsLeft.Text = "Water Balloons Left: " + GP.BalloonsLeft;
            lblDodgesLeft.Text = "Dodges Left: " + GP.DdgBalloon;
            lblWinLoss.Text = "Wins / Losses: " + GP.Wins + "/" + GP.Losses;
        }

        private void ResetGame()
        {
            lblBalloonsLoaded.Text = "Water Balloons Loaded: ";
            lblBalloonsLeft.Text = "Water Balloons Left: ";
            lblDodgesLeft.Text = "Dodges Left: ";
            lblWinLoss.Text = "Wins / Losses:";
            lblResult.Text = "";
            GP.Wins = 0;
            GP.Losses = 0;
            pbResult.Image = null;

            btnThrow.Enabled = false;
            btnDodge.Enabled = false;
        }
    }
}

//turn btnclicks into methods
//insert 2 imgs and 2 sounds