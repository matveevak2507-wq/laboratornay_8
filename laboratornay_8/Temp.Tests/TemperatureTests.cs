using Temp;
using Xunit;

namespace Temp.Tests;

public class TemperatureTests
{
    // 1. Цельсий → Фаренгейт: эталонные точки
    [Theory]
    [InlineData(0, 32)]     // вода замерзает
    [InlineData(100, 212)]    // вода кипит
    [InlineData(-40, -40)]    // точка пересечения шкал
    [InlineData(37, 98.6)]   // тело человека
    public void CtoF_ReturnsExpected(double c, double f)
        => Assert.Equal(f, Temperature.CtoF(c), 4);

    // 2. Фаренгейт → Цельсий
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    [InlineData(98.6, 37)]
    public void FtoC_ReturnsExpected(double f, double c)
        => Assert.Equal(c, Temperature.FtoC(f), 4);

    // 3. Обратимость: C → F → C = исходное
    [Theory]
    [InlineData(0)]
    [InlineData(25.5)]
    [InlineData(-100)]
    public void CtoF_then_FtoC_ReturnsOriginal(double original)
        => Assert.Equal(original, Temperature.FtoC(Temperature.CtoF(original)), 6);
}
