namespace CalcTest.API.Models
{
  public class CalculaJurosView
  {
    public decimal ValorInicial { get; set; }
    public int Meses { get; set; }

    public CalculaJurosView()
    {
      this.ValorInicial = 0;
      this.Meses = 0;
    }
  }
}


