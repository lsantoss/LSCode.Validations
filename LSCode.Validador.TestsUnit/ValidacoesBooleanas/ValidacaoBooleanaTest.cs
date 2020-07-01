using LSCode.Validador.ValidacoesBooleanas;
using System;
using Xunit;

namespace LSCode.Validador.TestsUnit.ValidacoesBooleanas
{
    public class ValidacaoBooleanaTest
    {

        #region EhIgual -> Sbyte Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_SbyteESbyteIguais_Sucesso(sbyte valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        public void EhIgual_SbyteESbyteDiferentes_Sucesso(sbyte valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_SbyteEByteIguais_Sucesso(sbyte valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        public void EhIgual_SbyteEByteDiferentes_Sucesso(sbyte valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_SbyteEShortIguais_Sucesso(sbyte valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        public void EhIgual_SbyteEShortDiferentes_Sucesso(sbyte valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_SbyteEUshortIguais_Sucesso(sbyte valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        public void EhIgual_SbyteEUshortDiferentes_Sucesso(sbyte valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_SbyteEIntIguais_Sucesso(sbyte valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_SbyteEIntDiferentes_Sucesso(sbyte valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_SbyteEUintIguais_Sucesso(sbyte valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        public void EhIgual_SbyteEUintDiferentes_Sucesso(sbyte valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_SbyteELongIguais_Sucesso(sbyte valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        public void EhIgual_SbyteELongDiferentes_Sucesso(sbyte valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_SbyteEUlongIguais_Sucesso(sbyte valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        public void EhIgual_SbyteEUlongDiferentes_Sucesso(sbyte valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_SbyteEFloatIguais_Sucesso(sbyte valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_SbyteEFloatDiferentes_Sucesso(sbyte valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_SbyteEDoubleIguais_Sucesso(sbyte valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_SbyteEDoubleDiferentes_Sucesso(sbyte valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Sbyte Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_SbyteEDecimalIguais_Sucesso(sbyte valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_SbyteEDecimalDiferentes_Sucesso(sbyte valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Byte Sbyte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteESbyteIguais_Sucesso(byte valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_ByteESbyteDiferentes_Sucesso(byte valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteEByteIguais_Sucesso(byte valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_ByteEByteDiferentes_Sucesso(byte valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Short
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteEShortIguais_Sucesso(byte valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        public void EhIgual_ByteEShortDiferentes_Sucesso(byte valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteEUshortIguais_Sucesso(byte valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_ByteEUshortDiferentes_Sucesso(byte valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Int
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteEIntIguais_Sucesso(byte valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_ByteEIntDiferentes_Sucesso(byte valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteEUintIguais_Sucesso(byte valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_ByteEUintDiferentes_Sucesso(byte valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Long
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteELongIguais_Sucesso(byte valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_ByteELongDiferentes_Sucesso(byte valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ByteEUlongIguais_Sucesso(byte valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_ByteEUlongDiferentes_Sucesso(byte valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_ByteEFloatIguais_Sucesso(byte valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_ByteEFloatDiferentes_Sucesso(byte valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_ByteEDoubleIguais_Sucesso(byte valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_ByteEDoubleDiferentes_Sucesso(byte valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Byte Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_ByteEDecimalIguais_Sucesso(byte valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_ByteEDecimalDiferentes_Sucesso(byte valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Short Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_ShortESbyteIguais_Sucesso(short valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        public void EhIgual_ShortESbyteDiferentes_Sucesso(short valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ShortEByteIguais_Sucesso(short valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        public void EhIgual_ShortEByteDiferentes_Sucesso(short valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_ShortEShortIguais_Sucesso(short valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        public void EhIgual_ShortEShortDiferentes_Sucesso(short valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ShortEUshortIguais_Sucesso(short valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        public void EhIgual_ShortEUshortDiferentes_Sucesso(short valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_ShortEIntIguais_Sucesso(short valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_ShortEIntDiferentes_Sucesso(short valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ShortEUintIguais_Sucesso(short valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        public void EhIgual_ShortEUintDiferentes_Sucesso(short valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_ShortELongIguais_Sucesso(short valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        public void EhIgual_ShortELongDiferentes_Sucesso(short valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_ShortEUlongIguais_Sucesso(short valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        public void EhIgual_ShortEUlongDiferentes_Sucesso(short valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_ShortEFloatIguais_Sucesso(short valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_ShortEFloatDiferentes_Sucesso(short valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_ShortEDoubleIguais_Sucesso(short valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_ShortEDoubleDiferentes_Sucesso(short valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Short Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_ShortEDecimalIguais_Sucesso(short valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_ShortEDecimalDiferentes_Sucesso(short valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Ushort Sbyte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortESbyteIguais_Sucesso(ushort valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_UshortESbyteDiferentes_Sucesso(ushort valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortEByteIguais_Sucesso(ushort valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_UshortEByteDiferentes_Sucesso(ushort valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Short
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortEShortIguais_Sucesso(ushort valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        public void EhIgual_UshortEShortDiferentes_Sucesso(ushort valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortEUshortIguais_Sucesso(ushort valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_UshortEUshortDiferentes_Sucesso(ushort valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Int
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortEIntIguais_Sucesso(ushort valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_UshortEIntDiferentes_Sucesso(ushort valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortEUintIguais_Sucesso(ushort valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_UshortEUintDiferentes_Sucesso(ushort valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Long
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortELongIguais_Sucesso(ushort valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_UshortELongDiferentes_Sucesso(ushort valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UshortEUlongIguais_Sucesso(ushort valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_UshortEUlongDiferentes_Sucesso(ushort valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UshortEFloatIguais_Sucesso(ushort valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UshortEFloatDiferentes_Sucesso(ushort valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UshortEDoubleIguais_Sucesso(ushort valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UshortEDoubleDiferentes_Sucesso(ushort valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ushort Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UshortEDecimalIguais_Sucesso(ushort valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UshortEDecimalDiferentes_Sucesso(ushort valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Int Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_IntESbyteIguais_Sucesso(int valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        public void EhIgual_IntESbyteDiferentes_Sucesso(int valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_IntEByteIguais_Sucesso(int valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        public void EhIgual_IntEByteDiferentes_Sucesso(int valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_IntEShortIguais_Sucesso(int valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        public void EhIgual_IntEShortDiferentes_Sucesso(int valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_IntEUshortIguais_Sucesso(int valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        public void EhIgual_IntEUshortDiferentes_Sucesso(int valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_IntEIntIguais_Sucesso(int valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_IntEIntDiferentes_Sucesso(int valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_IntEUintIguais_Sucesso(int valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        public void EhIgual_IntEUintDiferentes_Sucesso(int valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_IntELongIguais_Sucesso(int valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        public void EhIgual_IntELongDiferentes_Sucesso(int valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_IntEUlongIguais_Sucesso(int valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        public void EhIgual_IntEUlongDiferentes_Sucesso(int valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_IntEFloatIguais_Sucesso(int valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_IntEFloatDiferentes_Sucesso(int valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_IntEDoubleIguais_Sucesso(int valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_IntEDoubleDiferentes_Sucesso(int valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Int Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_IntEDecimalIguais_Sucesso(int valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_IntEDecimalDiferentes_Sucesso(int valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Uint Sbyte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintESbyteIguais_Sucesso(uint valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_UintESbyteDiferentes_Sucesso(uint valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintEByteIguais_Sucesso(uint valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_UintEByteDiferentes_Sucesso(uint valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Short
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintEShortIguais_Sucesso(uint valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        public void EhIgual_UintEShortDiferentes_Sucesso(uint valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintEUshortIguais_Sucesso(uint valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_UintEUshortDiferentes_Sucesso(uint valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Int
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintEIntIguais_Sucesso(uint valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_UintEIntDiferentes_Sucesso(uint valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintEUintIguais_Sucesso(uint valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_UintEUintDiferentes_Sucesso(uint valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Long
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintELongIguais_Sucesso(uint valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_UintELongDiferentes_Sucesso(uint valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UintEUlongIguais_Sucesso(uint valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_UintEUlongDiferentes_Sucesso(uint valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UintEFloatIguais_Sucesso(uint valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UintEFloatDiferentes_Sucesso(uint valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UintEDoubleIguais_Sucesso(uint valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UintEDoubleDiferentes_Sucesso(uint valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Uint Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UintEDecimalIguais_Sucesso(uint valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UintEDecimalDiferentes_Sucesso(uint valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Long Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_LongESbyteIguais_Sucesso(long valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        public void EhIgual_LongESbyteDiferentes_Sucesso(long valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_LongEByteIguais_Sucesso(long valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        public void EhIgual_LongEByteDiferentes_Sucesso(long valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_LongEShortIguais_Sucesso(long valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        public void EhIgual_LongEShortDiferentes_Sucesso(long valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_LongEUshortIguais_Sucesso(long valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        public void EhIgual_LongEUshortDiferentes_Sucesso(long valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_LongEIntIguais_Sucesso(long valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_LongEIntDiferentes_Sucesso(long valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_LongEUintIguais_Sucesso(long valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        public void EhIgual_LongEUintDiferentes_Sucesso(long valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        public void EhIgual_LongELongIguais_Sucesso(long valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        public void EhIgual_LongELongDiferentes_Sucesso(long valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_LongEUlongIguais_Sucesso(long valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        public void EhIgual_LongEUlongDiferentes_Sucesso(long valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_LongEFloatIguais_Sucesso(long valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_LongEFloatDiferentes_Sucesso(long valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_LongEDoubleIguais_Sucesso(long valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_LongEDoubleDiferentes_Sucesso(long valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Long Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        public void EhIgual_LongEDecimalIguais_Sucesso(long valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        public void EhIgual_LongEDecimalDiferentes_Sucesso(long valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Ulong Sbyte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongESbyteIguais_Sucesso(ulong valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_UlongESbyteDiferentes_Sucesso(ulong valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Byte
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongEByteIguais_Sucesso(ulong valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_UlongEByteDiferentes_Sucesso(ulong valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Short
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongEShortIguais_Sucesso(ulong valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        public void EhIgual_UlongEShortDiferentes_Sucesso(ulong valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Ushort
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongEUshortIguais_Sucesso(ulong valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        public void EhIgual_UlongEUshortDiferentes_Sucesso(ulong valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Int
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongEIntIguais_Sucesso(ulong valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        public void EhIgual_UlongEIntDiferentes_Sucesso(ulong valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Uint
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongEUintIguais_Sucesso(ulong valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_UlongEUintDiferentes_Sucesso(ulong valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Long
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongELongIguais_Sucesso(ulong valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6)]
        public void EhIgual_UlongELongDiferentes_Sucesso(ulong valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Ulong
        [Theory]
        [InlineData(5, 5)]
        public void EhIgual_UlongEUlongIguais_Sucesso(ulong valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        public void EhIgual_UlongEUlongDiferentes_Sucesso(ulong valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UlongEFloatIguais_Sucesso(ulong valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UlongEFloatDiferentes_Sucesso(ulong valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UlongEDoubleIguais_Sucesso(ulong valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UlongEDoubleDiferentes_Sucesso(ulong valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Ulong Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        public void EhIgual_UlongEDecimalIguais_Sucesso(ulong valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        public void EhIgual_UlongEDecimalDiferentes_Sucesso(ulong valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Float Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_FloatESbyteIguais_Sucesso(float valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, -5)]
        public void EhIgual_FloatESbyteDiferentes_Sucesso(float valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Byte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_FloatEByteIguais_Sucesso(float valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, 5)]
        [InlineData(-5.0, 5)]
        public void EhIgual_FloatEByteDiferentes_Sucesso(float valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_FloatEShortIguais_Sucesso(float valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, -5)]
        public void EhIgual_FloatEShortDiferentes_Sucesso(float valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Ushort
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_FloatEUshortIguais_Sucesso(float valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(6.0, 5)]
        public void EhIgual_FloatEUshortDiferentes_Sucesso(float valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_FloatEIntIguais_Sucesso(float valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(-5.0, -6)]
        [InlineData(5.0, 6)]
        public void EhIgual_FloatEIntDiferentes_Sucesso(float valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Uint
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_FloatEUintIguais_Sucesso(float valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, 6)]
        public void EhIgual_FloatEUintDiferentes_Sucesso(float valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_FloatELongIguais_Sucesso(float valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, 6)]
        [InlineData(-5.0, -6)]
        public void EhIgual_FloatELongDiferentes_Sucesso(float valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Ulong
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_FloatEUlongIguais_Sucesso(float valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6)]
        public void EhIgual_FloatEUlongDiferentes_Sucesso(float valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_FloatEFloatIguais_Sucesso(float valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_FloatEFloatDiferentes_Sucesso(float valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_FloatEDoubleIguais_Sucesso(float valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_FloatEDoubleDiferentes_Sucesso(float valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Float Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_FloatEDecimalIguais_Sucesso(float valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_FloatEDecimalDiferentes_Sucesso(float valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Double Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DoubleESbyteIguais_Sucesso(double valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, -5)]
        public void EhIgual_DoubleESbyteDiferentes_Sucesso(double valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Byte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DoubleEByteIguais_Sucesso(double valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, 5)]
        [InlineData(-5.0, 5)]
        public void EhIgual_DoubleEByteDiferentes_Sucesso(double valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DoubleEShortIguais_Sucesso(double valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, -5)]
        public void EhIgual_DoubleEShortDiferentes_Sucesso(double valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Ushort
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DoubleEUshortIguais_Sucesso(double valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(6.0, 5)]
        public void EhIgual_DoubleEUshortDiferentes_Sucesso(double valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DoubleEIntIguais_Sucesso(double valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(-5.0, -6)]
        [InlineData(5.0, 6)]
        public void EhIgual_DoubleEIntDiferentes_Sucesso(double valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Uint
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DoubleEUintIguais_Sucesso(double valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, 6)]
        public void EhIgual_DoubleEUintDiferentes_Sucesso(double valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DoubleELongIguais_Sucesso(double valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, 6)]
        [InlineData(-5.0, -6)]
        public void EhIgual_DoubleELongDiferentes_Sucesso(double valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Ulong
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DoubleEUlongIguais_Sucesso(double valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6)]
        public void EhIgual_DoubleEUlongDiferentes_Sucesso(double valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_DoubleEFloatIguais_Sucesso(double valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_DoubleEFloatDiferentes_Sucesso(double valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_DoubleEDoubleIguais_Sucesso(double valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_DoubleEDoubleDiferentes_Sucesso(double valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Double Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_DoubleEDecimalIguais_Sucesso(double valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_DoubleEDecimalDiferentes_Sucesso(double valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Decimal Sbyte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DecimalESbyteIguais_Sucesso(decimal valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, -5)]
        public void EhIgual_DecimalESbyteDiferentes_Sucesso(decimal valor, sbyte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Byte
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DecimalEByteIguais_Sucesso(decimal valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(-6, 5)]
        [InlineData(-5, 5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, 5)]
        [InlineData(-5.0, 5)]
        public void EhIgual_DecimalEByteDiferentes_Sucesso(decimal valor, byte valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Short
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DecimalEShortIguais_Sucesso(decimal valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(6, 5)]
        [InlineData(-6, -5)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(6.0, 5)]
        [InlineData(-6.0, -5)]
        public void EhIgual_DecimalEShortDiferentes_Sucesso(decimal valor, short valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Ushort
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DecimalEUshortIguais_Sucesso(decimal valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(6, 5)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(6.0, 5)]
        public void EhIgual_DecimalEUshortDiferentes_Sucesso(decimal valor, ushort valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Int
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DecimalEIntIguais_Sucesso(decimal valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(-5, -6)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(-5.0, -6)]
        [InlineData(5.0, 6)]
        public void EhIgual_DecimalEIntDiferentes_Sucesso(decimal valor, int valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Uint
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DecimalEUintIguais_Sucesso(decimal valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, 6)]
        public void EhIgual_DecimalEUintDiferentes_Sucesso(decimal valor, uint valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Long
        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(5.0, 5)]
        [InlineData(-5.0, -5)]
        public void EhIgual_DecimalELongIguais_Sucesso(decimal valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(5, -5)]
        [InlineData(5, 6)]
        [InlineData(-5, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, 6)]
        [InlineData(-5.0, -6)]
        public void EhIgual_DecimalELongDiferentes_Sucesso(decimal valor, long valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Ulong
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5.0, 5)]
        public void EhIgual_DecimalEUlongIguais_Sucesso(decimal valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6)]
        public void EhIgual_DecimalEUlongDiferentes_Sucesso(decimal valor, ulong valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Float
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_DecimalEFloatIguais_Sucesso(decimal valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_DecimalEFloatDiferentes_Sucesso(decimal valor, float valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Double
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_DecimalEDoubleIguais_Sucesso(decimal valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_DecimalEDoubleDiferentes_Sucesso(decimal valor, double valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Decimal Decimal
        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 5.0)]
        [InlineData(-5, -5)]
        [InlineData(-5, -5.0)]
        [InlineData(5.0, 5)]
        [InlineData(5.0, 5.0)]
        [InlineData(-5.0, -5)]
        [InlineData(-5.0, -5.0)]
        public void EhIgual_DecimalEDecimalIguais_Sucesso(decimal valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5, 6)]
        [InlineData(5, -5)]
        [InlineData(5, -6)]
        [InlineData(-5, 5)]
        [InlineData(-5, 6)]
        [InlineData(5, 6.0)]
        [InlineData(5, -5.0)]
        [InlineData(5, -6.0)]
        [InlineData(-5, 5.0)]
        [InlineData(-5, 6.0)]
        [InlineData(5.0, 6)]
        [InlineData(5.0, -5)]
        [InlineData(5.0, -6)]
        [InlineData(-5.0, 5)]
        [InlineData(-5.0, 6)]
        [InlineData(5.0, 6.0)]
        [InlineData(5.0, -5.0)]
        [InlineData(5.0, -6.0)]
        [InlineData(-5.0, 5.0)]
        [InlineData(-5.0, 6.0)]
        public void EhIgual_DecimalEDecimalDiferentes_Sucesso(decimal valor, decimal valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        //====================================================================================================
        //====================================================================================================
        //====================================================================================================
        //====================================================================================================


        #region EhIgual -> Bool Bool
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void EhIgual_BoolEBoolIguais_Sucesso(bool valor, bool valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void EhIgual_BoolEBoolDiferentes_Sucesso(bool valor, bool valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> String String
        [Theory]
        [InlineData("teste", "teste")]
        public void EhIgual_StringEStringIguais_Sucesso(string valor, string valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData("teste123", "teste")]
        [InlineData("teste", "teste123")]
        public void EhIgual_StringEStringDiferentes_Sucesso(string valor, string valorComparado)
        {
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> String Guid
        [Fact]
        public void EhIgual_StringEGuidIguais_Sucesso()
        {
            string valor = "0f8fad5b-d9cb-469f-a165-70867728950e";
            Guid valorComparado = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e");
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Fact]
        public void EhIgual_StringEGuidDiferentes_Sucesso()
        {
            string valor = "0f8fad5b-d9cb-469f-a165-70867728950e";
            Guid valorComparado = Guid.Parse("0f8fad5b-d9cb-469f-a165-708677289999");
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Guid Guid
        [Fact]
        public void EhIgual_GuidEGuidIguais_Sucesso()
        {
            Guid valor = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e");
            Guid valorComparado = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e");
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Fact]
        public void EhIgual_GuidEGuidDiferentes_Sucesso()
        {
            Guid valor = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e");
            Guid valorComparado = Guid.Parse("0f8fad5b-d9cb-469f-a165-708677289999");
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Guid String
        [Fact]
        public void EhIgual_GuidEStringIguais_Sucesso()
        {
            Guid valor = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e");
            string valorComparado = "0f8fad5b-d9cb-469f-a165-70867728950e";
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Fact]
        public void EhIgual_GuidEStringDiferentes_Sucesso()
        {
            Guid valor = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e");
            string valorComparado = "0f8fad5b-d9cb-469f-a165-708677289999";
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion


        #region EhIgual -> Object Object
        [Fact]
        public void EhIgual_ObjectEObjectIguais_Sucesso()
        {
            object valor = new { Id = 1, Nome = "Lucas" };
            object valorComparado = new { Id = 1, Nome = "Lucas" };
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.True(resultado);
        }

        [Fact]
        public void EhIgual_ObjectEObjectDiferentes_Sucesso()
        {
            object valor = new { Id = 1, Nome = "Lucas" };
            object valorComparado = new { Id = 1, Nome = "Ronaldo" };
            bool resultado = ValidacaoBooleana.EhIgual(valor, valorComparado);
            Assert.False(resultado);
        }
        #endregion

    }
}