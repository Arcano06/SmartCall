
namespace SmartCall
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            LB_FH = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            BT_Tasks = new Button();
            txtSenha = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            LB_TT = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            PI_FH = new PictureBox();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel13 = new Panel();
            panel12 = new Panel();
            label8 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            panel11 = new Panel();
            panel10 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PI_FH).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(LB_FH);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 700);
            panel1.TabIndex = 0;
            panel1.MouseDown += Formulario_MouseDown_Para_Arrastar;
            // 
            // LB_FH
            // 
            LB_FH.AutoSize = true;
            LB_FH.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_FH.ForeColor = Color.Crimson;
            LB_FH.Location = new Point(318, 9);
            LB_FH.Name = "LB_FH";
            LB_FH.Size = new Size(26, 25);
            LB_FH.TabIndex = 10;
            LB_FH.Text = "X";
            LB_FH.Click += LB_FH_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(BT_Tasks);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(LB_TT);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 600);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(39, 411);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 4);
            panel5.TabIndex = 13;
            // 
            // BT_Tasks
            // 
            BT_Tasks.BackColor = Color.DimGray;
            BT_Tasks.FlatAppearance.BorderColor = Color.Black;
            BT_Tasks.FlatStyle = FlatStyle.Flat;
            BT_Tasks.ForeColor = SystemColors.ControlLightLight;
            BT_Tasks.Location = new Point(58, 446);
            BT_Tasks.Name = "BT_Tasks";
            BT_Tasks.Size = new Size(162, 49);
            BT_Tasks.TabIndex = 7;
            BT_Tasks.Text = "Login";
            BT_Tasks.UseVisualStyleBackColor = false;
            BT_Tasks.Click += BT_Tasks_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.GrayText;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(39, 395);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(200, 20);
            txtSenha.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 374);
            label6.Name = "label6";
            label6.Size = new Size(58, 18);
            label6.TabIndex = 12;
            label6.Text = "Senha";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(39, 333);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 4);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(67, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 145);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LB_TT
            // 
            LB_TT.AutoSize = true;
            LB_TT.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_TT.ForeColor = SystemColors.ButtonHighlight;
            LB_TT.Location = new Point(3, 33);
            LB_TT.Name = "LB_TT";
            LB_TT.Size = new Size(180, 25);
            LB_TT.TabIndex = 1;
            LB_TT.Text = "SmartCall Login";
            LB_TT.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.GrayText;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(39, 317);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 20);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 296);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            label2.Click += label2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Navy;
            panel6.Controls.Add(PI_FH);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(350, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(854, 35);
            panel6.TabIndex = 1;
            panel6.MouseDown += Formulario_MouseDown_Para_Arrastar;
            // 
            // PI_FH
            // 
            PI_FH.BackColor = Color.DarkBlue;
            PI_FH.Dock = DockStyle.Right;
            PI_FH.Image = (Image)resources.GetObject("PI_FH.Image");
            PI_FH.Location = new Point(827, 0);
            PI_FH.Name = "PI_FH";
            PI_FH.Size = new Size(27, 35);
            PI_FH.SizeMode = PictureBoxSizeMode.Zoom;
            PI_FH.TabIndex = 8;
            PI_FH.TabStop = false;
            PI_FH.Click += PI_FH_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(350, 35);
            panel7.Name = "panel7";
            panel7.Size = new Size(854, 262);
            panel7.TabIndex = 2;
            panel7.MouseDown += Formulario_MouseDown_Para_Arrastar;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(436, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 247);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += Formulario_MouseDown_Para_Arrastar;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(102, 83);
            label4.Name = "label4";
            label4.Size = new Size(115, 18);
            label4.TabIndex = 3;
            label4.Text = "UI User VS/: 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(97, 48);
            label3.Name = "label3";
            label3.Size = new Size(132, 35);
            label3.TabIndex = 2;
            label3.Text = "SmartCall";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(23, 23, 23);
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(pictureBox8);
            panel8.Controls.Add(pictureBox7);
            panel8.Controls.Add(panel13);
            panel8.Controls.Add(panel12);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(350, 297);
            panel8.Name = "panel8";
            panel8.Size = new Size(854, 35);
            panel8.TabIndex = 3;
            panel8.Paint += panel8_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(23, 23, 25);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(399, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(706, 8);
            label10.Name = "label10";
            label10.Size = new Size(68, 18);
            label10.TabIndex = 10;
            label10.Text = "Deletar";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(575, 9);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 13;
            label9.Text = "Editar";
            label9.Click += label9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(23, 23, 25);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(670, -1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(23, 23, 25);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(539, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Navy;
            panel13.Location = new Point(653, -2);
            panel13.Name = "panel13";
            panel13.Size = new Size(5, 34);
            panel13.TabIndex = 11;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Navy;
            panel12.Location = new Point(522, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(5, 34);
            panel12.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(440, 10);
            label8.Name = "label8";
            label8.Size = new Size(83, 18);
            label8.TabIndex = 10;
            label8.Text = "Adicionar";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(309, 9);
            label7.Name = "label7";
            label7.Size = new Size(70, 18);
            label7.TabIndex = 4;
            label7.Text = "Usuário";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(23, 23, 25);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(273, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Navy;
            panel11.Location = new Point(387, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(5, 34);
            panel11.TabIndex = 11;
            panel11.Paint += panel11_Paint;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Navy;
            panel10.Location = new Point(256, -1);
            panel10.Name = "panel10";
            panel10.Size = new Size(5, 34);
            panel10.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1204, 700);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            MouseDown += Formulario_MouseDown_Para_Arrastar;
            Resize += Login_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PI_FH).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        private void Login_Load(object sender, EventArgs e)
        {         
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private Panel panel1;
        private Label LB_TT;
        private TextBox txtUsuario;
        private Label label2;
        private PictureBox pictureBox1;
        private Button BT_Tasks;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtSenha;
        private Label label6;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox PI_FH;
        private Panel panel10;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label8;
        private Panel panel11;
        private Label label9;
        private PictureBox pictureBox7;
        private Panel panel12;
        private Label label10;
        private PictureBox pictureBox8;
        private Panel panel13;
        private PictureBox pictureBox6;
        private Label LB_FH;
    }
}
