using Desafio.Dominio;

namespace Desafio.FakeDB
{
    public static class FamiliaFakeDB
    {
        private static List<Familia> listaFamilias;

        public static List<Familia> ListaFamilias
        {
            get
            {
                if (listaFamilias == null)
                {
                    listaFamilias = new List<Familia>();
                    Preencher();
                }

                return listaFamilias;
            }
        }

        private static void Preencher()
        {
            Familia primeiraFamilia = new Familia(750);
            Pessoa pessoaDependente = new Pessoa(15);
            primeiraFamilia.AdicionarMembro(pessoaDependente);
            primeiraFamilia.CalcularPontuacao();

            listaFamilias.Add(primeiraFamilia);
        }
    }
}