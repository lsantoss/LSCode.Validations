using LSCode.Validador.ValueObjects;
using Xunit;

namespace LSCode.Validador.TestsUnit.ValueObjects
{
    public class CEPTest
    {
        [Theory]
        [InlineData("36050-250")]
        [InlineData("36050250")]
        public void ValidarVO_Valido_Sucesso(string cepParamentro)
        {
            CEP cep = new CEP(cepParamentro);
            int numeroNotificacoes = cep.Notificacoes.Count;
            Assert.Equal(0, numeroNotificacoes);
        }

        [Theory]
        [InlineData("36050-25")]
        [InlineData("3605-250")]
        [InlineData("3605-25")]
        [InlineData("3605250")]
        [InlineData("3605025")]
        [InlineData("360525")]
        public void ValidarVO_FormatoInvalido_Sucesso(string cepParametro)
        {
            CEP cep = new CEP(cepParametro);
            int numeroNotificacoes = cep.Notificacoes.Count;
            Assert.NotEqual(0, numeroNotificacoes);
        }
    }
}