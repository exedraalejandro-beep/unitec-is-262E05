public class IntegrationTestApplication
{
[Theory]
[InlineData(4, 4, 64)] // Lado 4 -> Área 16 * Altura 4 = Volumen 64
[InlineData(5, 6, 150)] // Lado 5 -> Área 25 * Altura 6 = Volumen 150
public void CalcularVolumen_IntegrandoAreaCuadrado_Correcto(double lado, double altura, double expected)
{
// Arrange - Setup
// Obtenemos un dato real del Componente A.
double area = Cuadrado.Area(lado); 
// Act - Perform
// Le pasamos ese dato real al Componente B.
double actual = Cuadrado.Volumen(area, altura);
// Assert - Verify
// Verificamos si el flujo completo produjo el resultado correcto.
Assert.Equal(expected, actual);
}
}