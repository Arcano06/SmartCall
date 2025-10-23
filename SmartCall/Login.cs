using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SmartCall
{
    public partial class Login : Form
    {
        private Timer Update = new Timer();
        private Timer Update2 = new Timer();
        private bool Scala1, Scala2;
        private int _Font = 350;
        public Login()
        {
            InitializeComponent();
            Scala1 = false;
            Scala2 = false;
            Update.Enabled = true;
            Update.Tick += Update_Tick;
            Update.Start();
            //Update2
            Update2.Interval = 1;
            Update2.Tick += Update2_Tick;
            this.Size = new Size(_Font, 700);
        }

        private void Update2_Tick(object? sender, EventArgs e)
        {
            F_Scala();
        }

        private void Update_Tick(object? sender, EventArgs e)
        {
            F_LB_TT();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BT_Tasks_Click(object sender, EventArgs e)
        {
                Scala1 = true;
                Update2.Enabled = true;
                Update2.Start();           
        }

        private void PI_FH_Click(object sender, EventArgs e)
        {
            Scala2 = true;
            Update2.Enabled = true;
            Update2.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Usuário";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LB_TT.Text = " Editar Usuário";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LB_TT.Text = "Eliminar Usuário";
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            LB_TT.Text = "Novo Usuário";
        }



        public void F_LB_TT()
        {
            switch (LB_TT.Text)
            {
                case "Login":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Logar";
                    break;

                case " Editar Usuário":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Atualizar";
                    break;

                case "Eliminar Usuário":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Deletar";
                    break;

                case "Novo Usuário":
                    BT_Tasks.Show();
                    BT_Tasks.Text = "Adicionar";
                    break;

                case "Usuário":
                    BT_Tasks.Hide();
                    BT_Tasks.Text = "";
                    break;
            }
        }

        public void F_Scala()
        {
            if (Scala1)
            {
                if (_Font < 1204)
                {
                    this.CenterToScreen();
                    _Font += 10;
                    if (_Font >= 1204)
                    {
                        _Font = 1204;
                    }

                    this.Size = new Size(_Font, 700);
                }
                else
                {
                    Scala1 = false;
                    Update2.Enabled = false;
                    Update2.Start();
                    LB_TT.Text = "Usuário";
                    LB_TT.Hide();
                }
            }

            ///Scala --
            ///


            if (Scala2)
            {
                if (_Font > 350)
                {
                    this.CenterToScreen();
                    _Font -= 10;
                    if (_Font <= 350)
                    {
                        _Font = 350;
                    }

                    this.Size = new Size(_Font, 700);  
                    if (_Font <= 350)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Scala2 = false;
                    Update2.Enabled = false;
                    Update2.Start();
                    LB_TT.Text = "Usuário";
                    LB_TT.Hide();
                }
            }

        }

        private void LB_FH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
