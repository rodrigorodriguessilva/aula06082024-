namespace VELHA
{
    public partial class Form1 : Form
    {
        public string usuario;
        public int contador;
        public Form1()
        {
            InitializeComponent();
        }

        public void trocar_usuaraio()
        {
            if (usuario == "O")
                usuario = "X";
            else
                usuario = "O";

        }
        public void verifica_vencedor()
        {
            if (btn_1.Text == btn_2.Text && btn_2.Text == btn_3.Text && btn_1.Text != "")
            {
                btn_1.BackColor = Color.Green;
                btn_2.BackColor = Color.Green;
                btn_3.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }

            if (btn_4.Text == btn_5.Text && btn_5.Text == btn_6.Text && btn_4.Text != "")
            {
                btn_4.BackColor = Color.Green;
                btn_5.BackColor = Color.Green;
                btn_6.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }

            if (btn_7.Text == btn_8.Text && btn_8.Text == btn_9.Text && btn_9.Text != "")
            {
                btn_7.BackColor = Color.Green;
                btn_8.BackColor = Color.Green;
                btn_9.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }

            if (btn_1.Text == btn_4.Text && btn_4.Text == btn_7.Text && btn_7.Text != "")
            {
                btn_1.BackColor = Color.Green;
                btn_4.BackColor = Color.Green;
                btn_7.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }

            if (btn_2.Text == btn_5.Text && btn_5.Text == btn_8.Text && btn_8.Text != "")
            {
                btn_2.BackColor = Color.Green;
                btn_5.BackColor = Color.Green;
                btn_8.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }

            if (btn_3.Text == btn_6.Text && btn_6.Text == btn_9.Text && btn_9.Text != "")
            {
                btn_3.BackColor = Color.Green;
                btn_6.BackColor = Color.Green;
                btn_9.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }


            if (btn_1.Text == btn_5.Text && btn_5.Text == btn_9.Text && btn_9.Text != "")
            {
                btn_1.BackColor = Color.Green;
                btn_5.BackColor = Color.Green;
                btn_9.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }


            if (btn_3.Text == btn_5.Text && btn_5.Text == btn_7.Text && btn_7.Text != "")
            {
                btn_3.BackColor = Color.Green;
                btn_5.BackColor = Color.Green;
                btn_7.BackColor = Color.Green;
                MessageBox.Show("Jogador " + usuario + " venceu");
                novojogo();
            }

            if (btn_1.Text != "" &&
                btn_2.Text != "" &&
                btn_3.Text != "" &&
                btn_4.Text != "" &&
                btn_5.Text != "" &&
                btn_6.Text != "" &&
                btn_7.Text != "" &&
                btn_8.Text != "" &&
                btn_9.Text != "")
            {


                btn_1.BackColor = Color.Red;
                btn_2.BackColor = Color.Red;
                btn_3.BackColor = Color.Red;
                btn_4.BackColor = Color.Red;
                btn_5.BackColor = Color.Red;
                btn_6.BackColor = Color.Red;
                btn_7.BackColor = Color.Red;
                btn_8.BackColor = Color.Red;
                btn_9.BackColor = Color.Red;
                MessageBox.Show(" IIIIIHHHH DEU VELHA");
                novojogo();
            }


        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Text = usuario;
            btn_1.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_2.Text = usuario;
            btn_2.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_3.Text = usuario;
            btn_3.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_4.Text = usuario;
            btn_4.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            btn_5.Text = usuario;
            btn_5.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            btn_6.Text = usuario;
            btn_6.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            btn_7.Text = usuario;
            btn_7.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            btn_8.Text = usuario;
            btn_8.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            btn_9.Text = usuario;
            btn_9.Enabled = false;
            verifica_vencedor();
            trocar_usuaraio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            usuario = "X";
            button3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            usuario = "O";
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            contador = contador + 1;

            if (contador == 20)
            {
                button3.Enabled = false;
                button3.Text = "TRAVOU O JOGO";
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            novojogo();
        }

        public void novojogo()
        {
            btn_1.Text = "";
            btn_2.Text = "";
            btn_3.Text = "";
            btn_4.Text = "";
            btn_5.Text = "";
            btn_6.Text = "";
            btn_7.Text = "";
            btn_8.Text = "";
            btn_9.Text = "";

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;

            btn_1.BackColor = SystemColors.ControlLight;
            btn_2.BackColor = SystemColors.ControlLight;
            btn_3.BackColor = SystemColors.ControlLight;
            btn_4.BackColor = SystemColors.ControlLight;
            btn_5.BackColor = SystemColors.ControlLight;
            btn_6.BackColor = SystemColors.ControlLight;
            btn_7.BackColor = SystemColors.ControlLight;
            btn_8.BackColor = SystemColors.ControlLight;
            btn_9.BackColor = SystemColors.ControlLight;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Visible = true;
            contador = 0;
 
        }
    }
}
