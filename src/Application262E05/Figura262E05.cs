public class Figura262E05
{
     public static double perimetro  (double lado, double L, double C)
     {
        return ((lado*lado)+L+C); 
    }
public static double area (double lado, double altura,double L, double C)
    {
        return ((L + C) * altura / 2);
        
    }
    public static double volumen (double lado, double altura,double L, double C)
    {
        return ((L + C) * (altura / 2)) * 15;
    }
}
