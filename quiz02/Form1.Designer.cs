namespace quiz02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.txtLoad2 = new System.Windows.Forms.TextBox();
            this.txtLoad1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbSimulator = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.StrtSimulator = new System.Windows.Forms.Button();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbSimulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obaida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateGame);
            this.groupBox1.Controls.Add(this.txtPlayer2);
            this.groupBox1.Controls.Add(this.txtPlayer1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creating Game";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnCreateGame.Location = new System.Drawing.Point(219, 148);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(185, 31);
            this.btnCreateGame.TabIndex = 4;
            this.btnCreateGame.Text = "Create Gmae";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(136, 77);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(281, 32);
            this.txtPlayer2.TabIndex = 3;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(136, 30);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(281, 32);
            this.txtPlayer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadGame);
            this.groupBox2.Controls.Add(this.txtLoad2);
            this.groupBox2.Controls.Add(this.txtLoad1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loading Game";
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnLoadGame.Location = new System.Drawing.Point(219, 26);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(185, 31);
            this.btnLoadGame.TabIndex = 4;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.ldGame_Click);
            // 
            // txtLoad2
            // 
            this.txtLoad2.Location = new System.Drawing.Point(144, 105);
            this.txtLoad2.Name = "txtLoad2";
            this.txtLoad2.Size = new System.Drawing.Size(289, 32);
            this.txtLoad2.TabIndex = 3;
            // 
            // txtLoad1
            // 
            this.txtLoad1.Location = new System.Drawing.Point(144, 62);
            this.txtLoad1.Name = "txtLoad1";
            this.txtLoad1.Size = new System.Drawing.Size(289, 32);
            this.txtLoad1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 2\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player 1 ";
            // 
            // grbSimulator
            // 
            this.grbSimulator.Controls.Add(this.lblResult);
            this.grbSimulator.Controls.Add(this.StrtSimulator);
            this.grbSimulator.Controls.Add(this.txtScore2);
            this.grbSimulator.Controls.Add(this.txtScore1);
            this.grbSimulator.Controls.Add(this.label5);
            this.grbSimulator.Controls.Add(this.label6);
            this.grbSimulator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSimulator.Location = new System.Drawing.Point(12, 389);
            this.grbSimulator.Name = "grbSimulator";
            this.grbSimulator.Size = new System.Drawing.Size(450, 294);
            this.grbSimulator.TabIndex = 4;
            this.grbSimulator.TabStop = false;
            this.grbSimulator.Text = "Simulator";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(201, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 99);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StrtSimulator
            // 
            this.StrtSimulator.Font = new System.Drawing.Font("Tahoma", 8F);
            this.StrtSimulator.Location = new System.Drawing.Point(248, 26);
            this.StrtSimulator.Name = "StrtSimulator";
            this.StrtSimulator.Size = new System.Drawing.Size(185, 31);
            this.StrtSimulator.TabIndex = 4;
            this.StrtSimulator.Text = "Start Simulator";
            this.StrtSimulator.UseVisualStyleBackColor = true;
            this.StrtSimulator.Click += new System.EventHandler(this.StrtSimulator_Click);
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(356, 121);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(61, 32);
            this.txtScore2.TabIndex = 3;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(356, 78);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(61, 32);
            this.txtScore1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Score 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Score 1 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 695);
            this.Controls.Add(this.grbSimulator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MZG Game Simulator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbSimulator.ResumeLayout(false);
            this.grbSimulator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.TextBox txtLoad2;
        private System.Windows.Forms.TextBox txtLoad1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbSimulator;
        private System.Windows.Forms.Button StrtSimulator;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResult;
    }
}

