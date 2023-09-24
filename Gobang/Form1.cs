using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8_2
{
    public partial class Form1 : Form
    {

        int p1_role = 0;        //0:warrior , 1:witcher, 2:archer
        int p2_role = 0;
        int turn = 0;       //0:p1開始 , 1:p2開始
        int winner = 0;


        
        Chess[] chesses = new Chess[361];

        Character player1;
        Character player2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            rbtn_p1_warrior.Checked = true;
            rbtn_p2_warrior.Checked = true;

            lbl_p1_role.Text = "P1: 戰士";
            lbl_p2_role.Text = "P2: 戰士";

            p1_role = 0;
            p2_role = 0;

            rbtn_p1_warrior.Text = "戰士";
            rbtn_p1_witcher.Text = "法師";
            rbtn_p1_archer.Text = "弓箭手";

            rbtn_p2_warrior.Text = "戰士";
            rbtn_p2_witcher.Text = "法師";
            rbtn_p2_archer.Text = "弓箭手";

            btn_start.Text = "開始遊戲";

            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
                

        }
        private void rbtn_p1_warrior_CheckedChanged(object sender, EventArgs e)
        {
            p1_role = 0;
            lbl_p1_role.Text = "P1: 戰士";
        }

        private void rbtn_p1_witcher_CheckedChanged(object sender, EventArgs e)
        {
            p1_role = 1;
            lbl_p1_role.Text = "P1: 法師";
        }

        private void rbtn_p1_archer_CheckedChanged(object sender, EventArgs e)
        {
            p1_role = 2;
            lbl_p1_role.Text = "P1: 弓箭手";
        }

        private void rbtn_p2_warrior_CheckedChanged(object sender, EventArgs e)
        {
            p2_role = 0;
            lbl_p2_role.Text = "P2: 戰士";
        }

        private void rbtn_p2_witcher_CheckedChanged(object sender, EventArgs e)
        {
            p2_role = 1;
            lbl_p2_role.Text = "P2: 法師";
        }

        private void rbtn_p2_archer_CheckedChanged(object sender, EventArgs e)
        {
            p2_role = 2;
            lbl_p2_role.Text = "P2: 弓箭手";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            turn = 0;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel5.Size = new Size(399, 399);
            
            int i = 0, j = 0;
            for (i = 0; i < 19; i++)
            {
                for (j = 0; j < 19; j++)
                {
                    int index = j + i * 19;
                    chesses[index] = new Chess();
                    chesses[index].SetBounds(panel5.Width / 19 * j, panel5.Height / 19 * i, panel5.Width / 19, panel5.Height / 19);
                    chesses[index].BackColor = Color.White;
                    chesses[index].index = index;
                    
                    this.chesses[index].Click += new System.EventHandler(this.chesses_Click);
                    panel5.Controls.Add(chesses[index]);

                }
            }

            if (p1_role == 0)
                create_warrior_p1();
            else if (p1_role == 1)
                create_witcher_p1();
            else if (p1_role == 2)
                create_archer_p1();

            if (p2_role == 0)
                create_warrior_p2();
            else if (p2_role == 1)
                create_witcher_p2();
            else if (p2_role == 2)
                create_archer_p2();


            
            btn_start.Visible = false;

            player2.chessD.quantity += 1;
            render();

        }


        private void chesses_Click(object sender, EventArgs e)
        {
            Chess btn = (Chess)sender;


            //p1的回合
            if(turn == 0)
            {
                //不能覆蓋掉其他棋子
                if(player1.cur_chess != 3)
                {
                    if(btn.BackColor == Color.White)
                    {
                        btn.BackColor = player1.color;

                        //表示是橫向棋子
                        if(player1.cur_chess == 1)
                        {
                            player1.chessB.quantity -= 1;
                            if (btn.index%19 < 18)
                            {
                                if(chesses[btn.index+1].BackColor == Color.White)
                                {
                                    chesses[btn.index + 1].BackColor = player1.color;
                                }
                            }
                            
                        }
                        //表示是縱向棋子
                        else if(player1.cur_chess == 2)
                        {
                            player1.chessC.quantity -= 1;
                            if (btn.index/19 < 18)
                            {
                                if (chesses[btn.index + 19].BackColor == Color.White)
                                {
                                    chesses[btn.index+19].BackColor = player1.color;
                                }
                                
                            }
                        }


                        check_vertical(btn.index, 1);
                        check_horizontal(btn.index, 1);
                       
                        check_leftup(btn.index, 1);
                        check_rightup(btn.index, 1);

                        turn = 1;
                        render();
                    }
                }
                //可以覆蓋掉對方的棋子
                else if(player1.cur_chess == 3 && btn.BackColor != player1.color)
                {
                    player1.chessD.quantity -= 1;
                    btn.BackColor = player1.color;

                    check_vertical(btn.index, 1);
                    check_horizontal(btn.index, 1);

                    check_leftup(btn.index, 1);
                    check_rightup(btn.index, 1);


                    turn = 1;
                    render();
                }

                

            }
            //p2 的回合
            else
            {
                //不能覆蓋掉其他棋子
                if (player2.cur_chess != 3)
                {
                    if (btn.BackColor == Color.White)
                    {
                        btn.BackColor = player2.color;

                        //表示是橫向棋子
                        if (player2.cur_chess == 1)
                        {
                            player2.chessB.quantity -= 1;
                            if (btn.index % 19 < 18)
                            {
                                if (chesses[btn.index + 1].BackColor == Color.White)
                                {
                                    chesses[btn.index + 1].BackColor = player2.color;
                                }
                            }
                        }
                        //表示是縱向棋子
                        else if (player2.cur_chess == 2)
                        {
                            player2.chessC.quantity -= 1;
                            if (btn.index / 19 < 18)
                            {
                                if (chesses[btn.index + 19].BackColor == Color.White)
                                {
                                    chesses[btn.index + 19].BackColor = player2.color;
                                }

                            }
                        }

                        check_vertical(btn.index, 2);               
                        check_horizontal(btn.index, 2);
                       
                        check_leftup(btn.index, 2);
                        check_rightup(btn.index, 2);


                        turn = 0;
                        render();
                    }
                }
                //可以覆蓋掉對方的棋子
                else if (player2.cur_chess == 3 && btn.BackColor != player2.color)
                {
                    player2.chessD.quantity -= 1;
                    btn.BackColor = player2.color;

                    check_vertical(btn.index, 2);
                    check_horizontal(btn.index, 2);

                    check_leftup(btn.index, 2);   
                    check_rightup(btn.index, 2);
                   

                    turn = 0;
                    render();
                }
            }

        }
        private void create_warrior_p1()
        {
            player1 = new Warrior();
            player1.color = Color.DeepSkyBlue;
        }
        private void create_witcher_p1()
        {
            player1 = new Witcher();
            player1.color = Color.DarkBlue;
        }
        private void create_archer_p1()
        {
            player1 = new Archer();
            player1.color = Color.BlueViolet;
        }

        private void create_warrior_p2()
        {
            player2 = new Warrior();
            player2.color = Color.Orange;
        }
        private void create_witcher_p2()
        {
            player2 = new Witcher();
            player2.color = Color.DarkOrange;
        }
        private void create_archer_p2()
        {
            player2 = new Archer();
            player2.color = Color.OrangeRed;
        }

        private void render()
        {
            

            if (winner != 0)
            {
                
                end_game();
            }
            rbtn_p1_chessA.Checked = true;      
            rbtn_p2_chessA.Checked = true;

            player1.cur_chess = 0;
            player2.cur_chess = 0;

            


            if(turn == 0)
            {
                rbtn_p2_chessA.Enabled = false;
                rbtn_p2_chessB.Enabled = false;
                rbtn_p2_chessC.Enabled = false;
                rbtn_p2_chessD.Enabled = false;

                rbtn_p1_chessA.Enabled = true;
                rbtn_p1_chessB.Enabled = true;
                rbtn_p1_chessC.Enabled = true;
                rbtn_p1_chessD.Enabled = true;
            }
            else
            {
                rbtn_p1_chessA.Enabled = false;
                rbtn_p1_chessB.Enabled = false;
                rbtn_p1_chessC.Enabled = false;
                rbtn_p1_chessD.Enabled = false;

                rbtn_p2_chessA.Enabled = true;
                rbtn_p2_chessB.Enabled = true;
                rbtn_p2_chessC.Enabled = true;
                rbtn_p2_chessD.Enabled = true;
            }

            rbtn_p1_chessA.Text = "普通棋子";
            rbtn_p1_chessB.Text = "橫向棋子: " + Convert.ToString(player1.chessB.quantity);
            rbtn_p1_chessC.Text = "縱向棋子: " + Convert.ToString(player1.chessC.quantity);
            rbtn_p1_chessD.Text = "覆蓋棋子: " + Convert.ToString(player1.chessD.quantity);

            rbtn_p2_chessA.Text = "普通棋子";
            rbtn_p2_chessB.Text = "橫向棋子: " + Convert.ToString(player2.chessB.quantity);
            rbtn_p2_chessC.Text = "縱向棋子: " + Convert.ToString(player2.chessC.quantity);
            rbtn_p2_chessD.Text = "覆蓋棋子: " + Convert.ToString(player2.chessD.quantity);

            if (player1.chessB.quantity == 0)
                rbtn_p1_chessB.Enabled = false;
            if (player1.chessC.quantity == 0)
                rbtn_p1_chessC.Enabled = false;
            if (player1.chessD.quantity == 0)
                rbtn_p1_chessD.Enabled = false;

            if (player2.chessB.quantity == 0)
                rbtn_p2_chessB.Enabled = false;
            if (player2.chessC.quantity == 0)
                rbtn_p2_chessC.Enabled = false;
            if (player2.chessD.quantity == 0)
                rbtn_p2_chessD.Enabled = false;
        }

        private void rbtn_p1_chessA_CheckedChanged(object sender, EventArgs e)
        {
            player1.cur_chess = 0;
        }

        private void rbtn_p1_chessB_CheckedChanged(object sender, EventArgs e)
        {
            player1.cur_chess = 1;
        }

        private void rbtn_p1_chessC_CheckedChanged(object sender, EventArgs e)
        {
            player1.cur_chess = 2;
        }

        private void rbtn_p1_chessD_CheckedChanged(object sender, EventArgs e)
        {
            player1.cur_chess = 3;
        }

        private void rbtn_p2_chessA_CheckedChanged(object sender, EventArgs e)
        {
            player2.cur_chess = 0;
        }

        private void rbtn_p2_chessB_CheckedChanged(object sender, EventArgs e)
        {
            player2.cur_chess = 1;
        }

        private void rbtn_p2_chessC_CheckedChanged(object sender, EventArgs e)
        {
            player2.cur_chess = 2;
        }

        private void rbtn_p2_chessD_CheckedChanged(object sender, EventArgs e)
        {
            player2.cur_chess = 3;
        }
         

        private void end_game()
        {
            MessageBox.Show("遊戲結束, 勝利:" + Convert.ToString(winner), "", MessageBoxButtons.OK);
            System.Environment.Exit(System.Environment.ExitCode);
        }

        public void check_vertical(int index, int player)
        {
            int count = 1;
            int i = 1;
            

            if(player == 1)
            {
                //trace up
                while (index-19*i >= 0)
                {
                    if(chesses[index - 19*i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if(count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                i = 1;
                //trace down
                while (index + 19 *i <= 360)
                {
                    if (chesses[index + 19 * i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                while (index - 19 *i >= 0)
                {
                    if (chesses[index - 19 * i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                i = 1;
                while (index + 19 * i <= 360)
                {
                    if (chesses[index + 19 *i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            

        } 

        public void check_horizontal(int index, int player)
        {
            int count = 1;
            int i = 1;
            

            if (player == 1)
            {
                //trace right
                while ((index + i)%19 <=18 )
                {
                    if (chesses[index+i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                i = 1;

                //trace left
                while ((index-i)%19 >= 0)
                {
                    if (chesses[index -i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                while ((index + i) % 19 <= 18)
                {
                    if (chesses[index+i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                i = 1;
                while ((index - i) % 19 >= 0)
                {
                    if (chesses[index -i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }


        public void check_leftup(int index, int player)
        {
            int count = 1;
            int i = 1;
          

            if (player == 1)
            {
                //trace leftup
                while (index - 19*i - i >= 0)
                {
                    if (chesses[ index-19*i - i ].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                i = 1;

                //trace rightdown
                while (index + 19*i + i <= 360)
                {
                    if (chesses[index + 19*i + i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                while (index - 19*i - i >= 0)
                {
                    if (chesses[index - 19*i - i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                i = 1;
                while (index + 19*i + i <= 360)
                {
                    if (chesses[index + 19*i + i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void check_rightup(int index, int player)
        {
            int count = 1;
            int i = 1;
      
            if (player == 1)
            {
                //trace rightup
                while (index - 19 * i + i >= 0)
                {
                    if (chesses[index - 19 * i + i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                i = 1;

                //trace leftdown
                while (index + 19 * i - i <= 360)
                {
                    if (chesses[index + 19 * i - i].BackColor == player1.color)
                    {
                        count++;
                        i++;
                        if (count == 5)
                        {
                            winner = 1;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                while (index - 19 * i + i >= 0)
                {
                    if (chesses[index - 19 * i + i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                i = 1;
                while (index + 19 * i - i <= 360)
                {
                    if (chesses[index + 19 * i - i].BackColor == player2.color)
                    {
                        count++;
                        i++;

                        if (count == 5)
                        {
                            winner = 2;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

    }


    class Character
    {
        public int cur_chess;      //0: chessA, 1:chessB, 2:chessC, 3:chessD
        public Chess_A chessA = new Chess_A();
        public Chess_B chessB = new Chess_B();
        public Chess_C chessC = new Chess_C();
        public Chess_D chessD = new Chess_D();

        public System.Drawing.Color color;
    }

    class Warrior:Character
    {
        public Warrior()
        {
            chessA.quantity = 9999;
            chessB.quantity = 0;
            chessC.quantity = 0;
            chessD.quantity = 5;

        }

    }

    class Witcher : Character
    {

        public Witcher()
        {
            chessA.quantity = 9999;
            chessB.quantity = 1;
            chessC.quantity = 2;
            chessD.quantity = 2;
        }
    }

    class Archer : Character
    {

        public Archer()
        {
            chessA.quantity = 9999;
            chessB.quantity = 1;
            chessC.quantity = 1;
            chessD.quantity = 3;
        }
    }

    class Chess: System.Windows.Forms.Button
    {
        public int index;
  
    }


    class Chess_A:Chess
    {
        public int quantity;

    }

    class Chess_B:Chess
    {
        public int quantity;
    }

    class Chess_C:Chess
    {
        public int quantity;
    }
    class Chess_D : Chess
    {
        public int quantity;
    }
}
