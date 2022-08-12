namespace SweetSavory.Models
{
  public class FlavorTreat
  {       
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public int FlavorTreatId {get; set;}
    public virtual Treat Treat { get; set; }
    public virtual Flavor Flavor { get; set; }
  }
}