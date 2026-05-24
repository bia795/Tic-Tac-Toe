namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        int pontosX = 0;
        int pontosO = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckVenc();
        }
        private void CheckVenc()
        {
            bool Venc = false;

            //horizontal
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                Venc = true;
            }
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
            {
                Venc = true;
            }
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
            {
                Venc = true;
            }

            //vertical

            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
            {
                Venc = true;
            }
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
            {
                Venc = true;
            }
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
            {
                Venc = true;
            }

            // diagonal

            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
            {
                Venc = true;
            }

            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
            {
                Venc = true;
            }

            if (Venc) //desativa o botao
            {
                DesativarButton();
                string d = "";
                if (turn) // mostra o vencedor
                {
                    d = "O";
                    pontosO++;
                    TextPontosO.Text = pontosO.ToString();
                }
                else
                {
                    d = "X";
                    pontosX++;
                    TextPontosX.Text = pontosX.ToString();
                }
                MessageBox.Show(d + " é o Vencedor!");
            }
            else if (turn_count == 9) //se atingir 9 
            {
                MessageBox.Show("Deu velha");
            }
        }

        private void DesativarButton()
        {
            foreach (Control c in Controls)//a variavel c percorre os botoes
            {// verefica se é um botao e se a tag é jogo
                if (c is Button b && b.Tag?.ToString() == "jogo")
                {
                    b.Enabled = false;//desativa eles
                }
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)//a variavel c percorre os botoes
            {// verefica se é um botao e se a tag é jogo
                if (c is Button b && b.Tag?.ToString() == "jogo")
                {
                    b.Enabled = true;//ativa eles
                    b.Text = "";
                }
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            pontosX = 0;
            pontosO = 0;

            TextPontosX.Text = "0";
            TextPontosO.Text = "0";

            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)//a variavel c percorre os botoes
            {
                if (c is Button b && b.Tag?.ToString() == "jogo")
                {
                    b.Enabled = true;//ativa eles
                    b.Text = "";
                }
            }
        }

        private void TextPontosO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
