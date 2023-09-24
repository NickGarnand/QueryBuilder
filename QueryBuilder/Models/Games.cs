using QueryBuilder.Data;
using System;

public class Games : IClassModel
{
    public int Id { get; set; }
    public string Title { get; set; }
  public string Franchise { get; set; }
    public string Location { get; set; }
    public string Reason { get; set; }

    Games() 
    {
    }
    Games(int id, string title, string franchise, string location, string reason  ) 
    {
        Id = id;
        Title = title;
        Franchise = franchise;
        Location = location;
        Reason = reason;
    }
}
