using D00_Utils;
using System.Collections.Generic;

namespace D11_ColecaoGenerica_List
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utils.SetUTF8Encoding();

            #region Criar 1 pessoa com o 2º constructor e listar

            Utils.PrintHeader("Criar 1 pessoa com o 2º constructor e listar");

            Pessoa p1 = new Pessoa(1, "Leandro");
            Pessoa p2 = new Pessoa(2, "Leonardo");

            p1.List();
            p2.List();

            Utils.CleanConsole();

            #endregion

            #region List<Pessoa>

            Utils.PrintHeader("List<Pessoa>");

            List<Pessoa> listaPessoas = new List<Pessoa>();

            listaPessoas.Add(p1);
            listaPessoas.Add(p2);

            // Listar
            foreach (Pessoa item in listaPessoas)
            {
                item.List();
            }

            Utils.CleanConsole();

            #endregion

            #region List<int>

            Utils.PrintHeader("List<int>");

            List<int> listaInteiros = new List<int>();

            listaInteiros.Add(1);
            listaInteiros.Add(2);
            // listaInteiros.Add('a');      // Erro!!! Não aceita char pq deve ser int
            // listaInteiros.Add(1.5);      // Erro!!! Não aceita double pq deve ser int

            Utils.CleanConsole();

            #endregion

            #region IList vs IEnumerable

            Utils.PrintHeader("IList<int>");

            Generic generic01 = new Generic();

            // Neste caso, o valor passado é o tamanho da lista de retorno
            IList<int> list01 = generic01.EvenNumbers(30);

            foreach (var item in list01)
            {
                System.Console.WriteLine(item);
            }

            Utils.CleanConsole();

            Utils.PrintHeader("IEnumerable<int>");

            Generic generic02 = new Generic();

            // Neste caso, o valor passado é o último valor da lista de retorno
            IEnumerable<int> list02 = generic01.EvenNumbersImproved(30);

            foreach (var item in list02)
            {
                System.Console.WriteLine(item);
            }

            Utils.CleanConsole();

            #endregion


        }

    }

}
