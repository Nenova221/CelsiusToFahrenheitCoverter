namespace CToFTest
{
    public class CToFTest
    {
        [Theory]
        [InlineData(12, 'F')]
        [InlineData(99, 'F')]

        public void CelsiusToFahrenheit_WithConvertCtoF_ShouldReturnF(float number,char simwol)
        {
            float result; 
            result = Converter.CelsiusToFahrenheit(number, simwol);
            Assert.Equal(number, result);

        }
    }
}