namespace DIO.Series
{
  public abstract class EntidadeBase
  {
  // ele ta protected para conseguir ser acessado apenas dentro da dll.
    public int Id { get; protected set; }
  }
}