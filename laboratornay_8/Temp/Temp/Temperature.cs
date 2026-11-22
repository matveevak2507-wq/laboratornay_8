namespace Temp;

public static class Temperature
{
    // Цельсий → Фаренгейт:  F = C × 9/5 + 32
    public static double CtoF(double c) => c * 9 / 5 + 32;

    // Фаренгейт → Цельсий:  C = (F − 32) × 5/9
    public static double FtoC(double f) => (f - 32) * 5 / 9;
}