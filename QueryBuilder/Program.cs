using Microsoft.Data.Sqlite;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string filePath = projectFolder + Path.DirectorySeparatorChar + "Data\\AllPokemon.csv";
            string dataFile = "C:\\Users\\nicho\\source\\repos\\QueryBuilder\\Data\\data.db";


            List<Pokemon> pokedex = new List<Pokemon>();
            List<BannedGame> bannedGames = new List<BannedGame>();
            

            using (var sr = new StreamReader(filePath))
            {
             
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    string[] lineElements = line.Split(',');
                    Pokemon pokemon = new Pokemon();
                    {
                        pokemon.DexNumber = Convert.ToInt32(lineElements[0]);
                        pokemon.Name = lineElements[1];
                        pokemon.Form = lineElements[2];
                        pokemon.Type1 = lineElements[3];
                        pokemon.Type2 = lineElements[4];
                        pokemon.Total = Convert.ToInt32(lineElements[5]);
                        pokemon.Hp = Convert.ToInt32(lineElements[6]);
                        pokemon.Attack = Convert.ToInt32(lineElements[7]);
                        pokemon.Defense = Convert.ToInt32(lineElements[8]);
                        pokemon.SpecialAttack = Convert.ToInt32(lineElements[9]);
                        pokemon.SpecialDefense = Convert.ToInt32(lineElements[10]);
                        pokemon.Speed = Convert.ToInt32(lineElements[11]);
                        pokemon.Generation = Convert.ToInt32(lineElements[12]);
                    }
                    pokedex.Add(pokemon);
                }
                Pokemon customPoke = new Pokemon();
                {
                    customPoke.DexNumber = 1300;
                    customPoke.Name = "Scorpeon";
                    customPoke.Form = "Alolan";
                    customPoke.Type1 = "Poison";
                    customPoke.Type2 = "";
                    customPoke.Total = 525;
                    customPoke.Hp = 65;
                    customPoke.Attack = 110;
                    customPoke.Defense = 130;
                    customPoke.SpecialAttack = 60;
                    customPoke.SpecialDefense = 65;
                    customPoke.Speed = 95;
                    customPoke.Generation = 6;
                }
                pokedex.Add(customPoke);
                sr.Close();
            }
            using (var sr = new StreamReader("C:\\Users\\nicho\\source\\repos\\QueryBuilder\\Data\\BannedGames.csv")) 
            { 
                while (!sr.EndOfStream)
            {
                string? line = sr.ReadLine();
                string[] lineElements = line.Split(',');
                BannedGame games = new BannedGame();
                {
                        games.Title = lineElements[0];
                        games.Series = lineElements[1];
                        games.Country = lineElements[2];
                        games.Details = lineElements[3];
                }
                bannedGames.Add(games);
            }
                BannedGame bannedGame = new BannedGame();
                {
                    bannedGame.Title = "Your Mother";
                    bannedGame.Series = "Your family";
                    bannedGame.Country = "Russian";
                    bannedGame.Details = "Its Extrenely Homoerotic. Like to the point where it caused a new awakening.";
                }
                bannedGames.Add(bannedGame);
            sr.Close();
        }


            /*    using (QueryBuilderStarter.QueryBuilder db = new QueryBuilderStarter.QueryBuilder($"{projectFolder}\\Data\\data.db"))
                {
                           foreach (var pokemon in pokedex)
                            db.Create<Pokemon>(pokemon);
                    }
            */

            using (QueryBuilderStarter.QueryBuilder db = new QueryBuilderStarter.QueryBuilder($"{projectFolder}\\Data\\data.db"))
            {
                Console.WriteLine("Deleting the Database...");
                db.DeleteAll<Pokemon>();
                db.DeleteAll<BannedGame>();
                Console.WriteLine("Databases Cleared.");

                Console.WriteLine("Seeding the Pokemon Database....");
                foreach (var pokemon in pokedex) 
                   db.Create<Pokemon>(pokemon);
                Console.WriteLine("Database Seeded, moving on to the Banned Games database.");

                foreach (var bg in bannedGames)
                    db.Create<BannedGame>(bg);
                Console.WriteLine("Banned Games database seeded");
            }
            Console.WriteLine("Press anything to view the data entered");
            Console.ReadKey();
            Console.WriteLine("Pokemon Database: ");
            foreach(var pokemon in pokedex)
                Console.WriteLine(pokemon.ToString());

            Console.WriteLine("Banned Games: ");
            foreach(var games in bannedGames)
                Console.WriteLine(games.ToString());


            }
    }
}
