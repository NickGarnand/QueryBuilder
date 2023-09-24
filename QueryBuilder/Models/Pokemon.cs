using QueryBuilder.Data;
using System;

public class Pokemon : IClassModel
{
    public int Id { get; set; }
    public int DexNumber { get; set; }
    public string Name { get; set; }
    public string Form { get; set; }
    public string Type1 { get; set; }
    public string Type2 { get; set; }
    public int Total { get; set; }
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpecialAttack { get; set; }
    public int SpecialDefense { get; set; }
    public int Speed { get; set; }
    public int Generation { get; set; }
    public Pokemon() { }
    Pokemon(int pokedexNum, string name, string form, string type1, string type2, int total, int hp, int att, int def, int spAtt, int spDef, int spd, int gen) 
    {
        DexNumber = pokedexNum;
        Name = name;
        Form = form;
        Type1 = type1;
        Type2 = type2;
        Total = total;
        Hp = hp;
        Attack = att; 
        Defense = def;
        SpecialAttack = spAtt;
        SpecialDefense = spDef;
        Speed = spd;
        Generation = gen;
        
    }
    public override string ToString()
    {
        string retu = $"\n\n\n{Name} / Generatoion: {Generation}\n-----------------------------------------\n";
        retu += $"Form: {Form} ";
        if (Type2 == "")
            retu += $"Typing: {Type1}";
        else 
            retu += $"Typing: {Type1}/{Type2}";
        retu += $"\nStats: Total: {Total} \n Hp: {Hp} \n Att: {Attack}          Def: {Defense}\n SpAtt: {SpecialAttack}         SpDefense: {SpecialDefense}\n Speed: {Speed}";
        return retu ;

    }


}
