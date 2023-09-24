using QueryBuilder.Data;
using System;

public class BannedGame : IClassModel
{
    public int Id { get; set; }
    public string Title { get; set; }
   public string Series { get; set; }
    public string Country { get; set; }
    public string Details { get; set; }

    public BannedGame() 
    {
    }
    BannedGame(string title, string franchise, string location, string reason  ) 
    {
        Title = title;
        Series = franchise;
        Country = location;
        Details = reason;
    }
    public override string ToString()
    {
        return ($" \n\nTitle: {Title} \n Series: {Series}\n Country: {Country} \n Details: {Details} \n-----------------------------------------------------------------------------");
    }
}
