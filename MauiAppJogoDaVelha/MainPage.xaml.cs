namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X"; // Variável vez com o valor de X para controlar a vez do jogador de X para O

        public MainPage()
        {
            InitializeComponent();
                zerarJogo(); // garante que todos os botões começam vazios
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false; // Desabilita o botão após ser clicado para evitar que seja clicado novamente

            if (vez == "X")
            {
                btn.Text = "X";  // Começa com o jogador X e a variável vez faz a troca para O
                vez = "O";
            }
                else
                {
                    btn.Text = "O"; // Quando o jogador O jogar, a variável vez faz a troca para X
                    vez = "X";
                }

            //Verificando se o X ganhou em todas as possibilidades de vitória
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                zerarJogo();
            }
                else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
                {
                    await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                    zerarJogo();
                }
                    else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
                    {
                        await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                        zerarJogo();
                    }
                        else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
                        {
                            await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                            zerarJogo();
                        }
                            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
                            {
                                await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                                zerarJogo();
                            }
                                else if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
                                {
                                    await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                                    zerarJogo();
                                }
                                    else if ( btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
                                    {
                                        await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                                        zerarJogo();
                                    }
                                        else if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
                                        {
                                            await DisplayAlertAsync("Parabéns!", "O jogador X ganhou!", "OK");
                                            zerarJogo();
                                        }//Fim da verificação if else para ver se o jogador X ganhou em todas as possibilidades de vitória


            //Verificando se o O ganhou em todas as possibilidades de vitória
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                zerarJogo();
            }
                else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
                {
                    await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                    zerarJogo();
                }
                    else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
                    {
                        await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                        zerarJogo();
                    }
                        else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
                        {
                            await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                            zerarJogo();
                        }
                            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
                            {
                                await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                                zerarJogo();
                            }
                                else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
                                {
                                    await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                                    zerarJogo();
                                }
                                    else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
                                    {
                                        await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                                        zerarJogo();
                                    }
                                        else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
                                        {
                                            await DisplayAlertAsync("Parabéns!", "O jogador O ganhou!", "OK");
                                            zerarJogo();
                                        }//Fim da verificação if else para ver se o jogador O ganhou em todas as possibilidades de vitória

            // Verificando se houve empate (velha)
            else
            {
                if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                   btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                   btn30.Text != "" && btn31.Text != "" && btn32.Text != "")
                {
                    await DisplayAlertAsync("Empate!", "O jogo deu Velha!", "OK");
                    zerarJogo();
                }
            }// Fim do else que verifica se houve empate

        }// Fim do método Button_Clicked

        // Método para zerar o jogo
        void zerarJogo()
        {
            btn10.Text = ""; // Zera o texto de todos os botões para reiniciar o jogo
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true; // Habilita todos os botões novamente para reiniciar o jogo
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        } // Fim do método zerarJogo

    } // Fim da classe MainPage
} // Fim do namespace MauiAppJogoDaVelha
