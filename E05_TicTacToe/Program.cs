using D00_Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_TicTacToe
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utils.SetUTF8Encoding();

            Utils.PrintHeader("Exercício global – Jogo do galo");
            StringBuilder sb = new StringBuilder();
            // ----------------------------------------------------------------------
            sb.AppendLine("Pretende-se implementar o Jogo do Galo utilizando a linguagem C#. As");
            sb.AppendLine("regras aplicáveis são as regras tradicionais:\n");
            sb.AppendLine("✓ um jogador vence a partida quando consegue um alinhamento completo de");
            sb.AppendLine("  jogadas numa linha, numa coluna ou numa diagonal do tabuleiro de jogo");
            sb.AppendLine("  de 3 por 3 células.");
            sb.AppendLine("✓ Os jogadores jogam de forma alternada, devendo para o efeito");
            sb.AppendLine("  introduzir as coordenadas (linha, coluna) da célula onde pretendem");
            sb.AppendLine("  fazer a jogada.");
            sb.AppendLine("✓ Deverá aplicar tudo o que aprendeu sobre C# até o momento (e que for");
            sb.AppendLine("  relevante para a resolução do exercício), nomeadamente estruturas de");
            sb.AppendLine("  repetição, de decisão e arrays.");
            sb.AppendLine("✓ Como desafio extra propõe-se que a resolução do exercício seja feita");
            sb.AppendLine("  de forma a que seja fácil alterar a dimensão do tabuleiro sem que");
            sb.AppendLine("  sejam necessárias grandes alterações no código-fonte.");

            Utils.PrintSubHeader(sb.ToString());

            Utils.CleanConsole();

        }

    }

}
