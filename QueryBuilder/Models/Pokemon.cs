using QueryBuilder.Data;
using System;

public class Pokemon : IClassModel
{
    public int Id { get; set; }
    public string PokemonDexNumber { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Type1 { get; set; }
    public string Type2 { get; set; }
    public string Total { get; set; }
    public string Hp { get; set; }
    public string Att { get; set; }
    public string Def { get; set; }
    public string SpAtt { get; set; }
    public string SpDef { get; set; }
    public string Spd { get; set; }
    public string Gen { get; set; }
    public Pokemon() { }
    Pokemon(string pokedexNum, string name, string gender, string type1, string type2, string total, string hp, string att, string def, string spAtt, string spDef, string spd, string gen) 
    {
        PokemonDexNumber = pokedexNum;
        Name = name;
        Gender = gender;
        Type1 = type1;
        Type2 = type2;
        Total = total;
        Hp = hp;
        Att = att; 
        Def = def;
        SpAtt = spAtt;
        SpDef = spDef;
        Spd = spd;
        Gen = gen;
        
    }

    public override string ToString()
    {
        if (Type2 == null)
        {
            return ($"PokeDex Number: {PokemonDexNumber}\nName: {Name}\nGender: {Gender}\nType: {Type1} ");
        }
        else
        {
            return ($"PokeDex Number: {PokemonDexNumber}\nName: {Name}\nGender: {Gender}\nType: {Type1}/{Type2}");
        }
    }

}
