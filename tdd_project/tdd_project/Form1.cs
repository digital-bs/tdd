using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tdd_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GameHandler game;
        public void enterNamesVisible(bool visible)
        {
            textBoxName1.Visible = visible;
            textBoxName2.Visible = visible;
            labelName1.Visible = visible;
            labelName2.Visible = visible;
            labelNames.Visible = visible;
            buttonStart.Visible = visible;
            buttonStartForm.Visible = !visible;
            buttonEnter.Visible = !visible;
            labelNamePlayer1.Visible = !visible;
            labelNamePlayer2.Visible = !visible;
            labelPointsPlayer1.Visible = !visible;
            labelPointsPlayer2.Visible = !visible;
            labelWhoseMove.Visible = !visible;
            textBoxActualCity.Visible = !visible;
            textBoxNewCity.Visible = !visible;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName1.Text) || String.IsNullOrWhiteSpace(textBoxName2.Text))
                return;                
            enterNamesVisible(false);
            game = new GameHandler(textBoxName1.Text, textBoxName2.Text);
            labelNamePlayer1.Text = textBoxName1.Text;
            labelNamePlayer2.Text = textBoxName2.Text;
            game.loadGame();
            textBoxActualCity.Text = game.get_actualCity();
        }

        private void buttonStartForm_Click(object sender, EventArgs e)
        {
            enterNamesVisible(true);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            game.enterCity(textBoxNewCity.Text);
            textBoxActualCity.Text = game.get_actualCity();
            textBoxNewCity.Text = "";
            labelPointsPlayer1.Text = "Очков : " + game.player1.getPoints();
            labelPointsPlayer2.Text = "Очков : " + game.player2.getPoints();
            if (game.numberOfPlayer)
                labelWhoseMove.Text = "Ходит игрок 1";
            else
                labelWhoseMove.Text = "Ходит игрок 2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterNamesVisible(true);
        }

        private void textBoxNewCity_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
