using static System.Runtime.InteropServices.JavaScript.JSType;


namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string filePath = projectFolder + Path.DirectorySeparatorChar + "Data\\AllPokemon.csv";


            List<Pokemon> pokedex = new List<Pokemon>();
            

            using (var sr = new StreamReader(filePath))
            {
             
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    string[] lineElements = line.Split(',');
                    Pokemon pokemon = new Pokemon();
                    {
                        pokemon.PokemonDexNumber = lineElements[0];
                        pokemon.Name = lineElements[1];
                        pokemon.Gender = lineElements[2];
                        pokemon.Type1 = lineElements[3];
                        pokemon.Type2 = lineElements[4];
                        pokemon.Total = lineElements[5];
                        pokemon.Hp = lineElements[6];
                        pokemon.Att = lineElements[7];
                        pokemon.Def = lineElements[8];
                        pokemon.SpAtt = lineElements[9];
                        pokemon.SpDef = lineElements[10];
                        pokemon.Spd = lineElements[11];
                        pokemon.Gen = lineElements[12];
                    }
                    pokedex.Add(pokemon);
                }
                sr.Close();
            }

            QueryBuilderStarter.QueryBuilder db = new QueryBuilderStarter.QueryBuilder($"{projectFolder}\\Data\\data.db");
            foreach (var pokemon in pokedex)
                    db.Create<Pokemon>(pokemon);

            db.ReadAll<Pokemon>();
           

                
        }
    }
}
