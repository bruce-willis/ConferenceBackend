using Microsoft.Azure.Mobile.Server;

namespace sandboxappService.DataObjects
{
  public class Conference : EntityData
  {
    public int Number { get; set; }

    public string Action { get; set; }

  }
}