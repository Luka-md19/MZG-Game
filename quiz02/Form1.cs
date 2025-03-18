using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz02
{
    public partial class Form1 : Form
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPlayer1.Text) || string.IsNullOrWhiteSpace(txtPlayer2.Text))
                {
                    MessageBox.Show("Please enter both player names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidPlayerName(txtPlayer1.Text) || !IsValidPlayerName(txtPlayer2.Text))
                {
                    MessageBox.Show("Player names can only contain letters, numbers, and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPlayer1.Text.Length > 20 || txtPlayer2.Text.Length > 20)
                {
                    MessageBox.Show("Player names cannot exceed 20 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Name1 = txtPlayer1.Text;
                this.Name2 = txtPlayer2.Text;
                
                    
                    MessageBox.Show("Player information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
            private bool IsValidPlayerName(string name)
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9\s]+$");
                return regex.IsMatch(name);
            }

        private void ldGame_Click(object sender, EventArgs e)
        {
          
                try
                {
                if (string.IsNullOrEmpty(this.Name1) || string.IsNullOrEmpty(this.Name2))
                    throw new Exception ("please enter players name");

                string[] lines = File.ReadAllLines("data.txt");

                    if (lines.Length != 2)
                    {
                        MessageBox.Show("Invalid data file. Please create a new game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    txtPlayer1.Text = lines[0];
                    txtPlayer2.Text = lines[1];
                    txtPlayer1.ReadOnly = true;
                    txtPlayer2.ReadOnly = true;
                    txtLoad1.Text = this.Name1;
                    txtLoad2.Text = this.Name2;
                    
                    grbSimulator.Visible = true;
                    txtScore1.Text = "1";
                    txtScore2.Text = "10";
                    txtLoad1.Text = this.Name1;
                    txtLoad2.Text = this.Name2;
                lblResult.Text = "Waiting for player 1 to start...";

            }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Data file not found. Please create a new game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading player information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }

        private void StrtSimulator_Click(object sender, EventArgs e)
        {
            
                try
                {
                if (string.IsNullOrWhiteSpace(txtPlayer1.Text) || string.IsNullOrWhiteSpace(txtPlayer2.Text))
                {
                    MessageBox.Show("Please load player names first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines("data.txt");

                    
                    if (lines.Length != 2)
                    {
                        MessageBox.Show("Invalid data file. Please create a new game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        
                        grbSimulator.Visible = false;

                        
                        btnCreateGame.Enabled = false;
                        btnLoadGame.Enabled = false;

                        return;
                    }

                 
                    txtPlayer1.Text = lines[0];
                    txtPlayer2.Text = lines[1];
                    txtPlayer1.ReadOnly = true;
                    txtPlayer2.ReadOnly = true;

                  
                    grbSimulator.Visible = true;
                    txtScore1.Text = "1";
                    txtScore2.Text = "10";
                txtLoad1.Text = this.Name1;
                txtLoad2.Text = this.Name2;
                lblResult.Text = "Waiting for player 1 to start...";
                    
                    int countdown = 10;
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, evt) =>
                    {
                        lblResult.Text = "Playing " + countdown.ToString();
                        countdown--;
                        if (countdown < 0)
                        {
                            
                            timer.Stop();

                            
                            Random rand = new Random();
                            int score1 = rand.Next(16);
                            int score2 = rand.Next(16);
                            txtScore1.Text = score1.ToString();
                            txtScore2.Text = score2.ToString();
                            if (score1 > score2)
                            {
                                lblResult.Text = "Result " + txtPlayer1.Text + " wins";
                            }
                            else if (score2 > score1)
                            {
                                lblResult.Text = "Result " + txtPlayer2.Text + " wins";
                            }
                            else
                            {
                                lblResult.Text = "Result Tie";
                            }

                           
                            btnCreateGame.Enabled = true;
                            btnLoadGame.Enabled = truee;
                        }
                    };
                    timer.Start();

                    
                    btnCreateGame.Enabled = false;
                    btnLoadGame.Enabled = false;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Data file not found. Please create a new game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                    grbSimulator.Visible = false;

                    
                    btnCreateGame.Enabled = true;
                    btnLoadGame.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading player information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   
                    grbSimulator.Visible = false;

                  
                    btnCreateGame.Enabled = true;
                    btnLoadGame.Enabled = true;
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
   

