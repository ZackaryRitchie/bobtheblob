using LaVieDeBob;

namespace LaVieDeBobTests
{
    public class PersonneTest
    {
        [Fact]
        public void Tempsavence()
        {
            ////arrange = prép
            Personne personne = new Personne("dame", 64);

            ////act appeler la méthode
            personne.Tempsavence();

            //// Assert = faire le test
            //Assert.Equal(65, personne.Age);
            Assert.Equal(65, personne.Age);
        }

        [InlineData(1)]
        [InlineData(10)]
        [InlineData(50)]
        [Theory]
        public void Tempsavence2(int nb)
        {
            //arrange = prép
            Personne personne = new Personne("dame", 64);
            int ageavant = personne.Age;

            //act appeler la méthode
            personne.Tempsavence(nb);

            // Assert = faire le test
            Assert.Equal(ageavant + nb, personne.Age);
        }
    }
}