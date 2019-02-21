using Xunit;

namespace Somar
{
    public class Somar
    {
        [Fact]
        public void SomarDoisNumerosTeste()
        {
            int resultado = Somando.AdicionarDoisNumeros(1,2);
            Assert.Equal(3, resultado);
        }
        
        [Fact]
        public void SubtrariDoisNumerosTeste()
        {
            int resultado = Subtrair.SubtrairDoisNumeros(1,2);
            Assert.Equal(1, resultado);
        }

        [Fact]
        public void MultiplicarDoisNumerosTeste()
        {
            int resultado = Multiplicar.MultiplicarDoisNumeros(1, 2);
            Assert.Equal(4, resultado);
        }
        
        [Fact]
        public void DividirDoisNumerosTeste()
        {
            int resultado = Dividir.DividirDoisNumeros(1, 2);
            Assert.Equal(1, resultado);
        }
    }
}
