public class Figura262E05
{
    public static double perimetro(double lado, double L, double C)
    {
        return 2 * lado + L + C;
    }

    public static double area(double lado, double altura, double L, double C)
    {
        return (L + C) * altura / 2;
    }

    public static double volumen(double lado, double altura, double L, double C)
    {
        return (L + C) * altura / 2 * altura;
    }
}
