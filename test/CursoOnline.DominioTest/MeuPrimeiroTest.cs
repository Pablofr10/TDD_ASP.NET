using Xunit;

namespace CursoOnline.DominioTest
{
    public class MeuPrimeiroTest
    {
        [Fact(DisplayName = "Teste")]
        public void Testar()
        {
            string[] carro = new string[] {"Corsa", "Pálio", "Fox", "Honda"};

            Assert.Contains("Corsa", carro);
        }
    }
}
