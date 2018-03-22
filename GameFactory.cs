using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GameSerialization
{
    public class GameFactory
    {
        public List<Game> games = new List<Game>();
        public List<Game> debug = new List<Game>();

        StreamWriter list;
        XmlSerializer serial;
        public String result { get; set; }

        public Boolean SerializeGameList()
        {

            result = "";

            try
            {
                list = new StreamWriter(@"..\..\sports.xml");
                serial = new XmlSerializer(games.GetType());
                serial.Serialize(list, games);
                list.Close();

                result = "List Serialized.";

                return true;
            }
            catch
            {
                result = "There's nothing to serialize, silly!";
                return false;
            }
        }

        public void CreateGameList()
        {
            games.Add(new Game("Gungnir Punchers", 5, "Bengal Tigers", 2));
            games.Add(new Game("Gensokyo Tengus", 1, "Shrine Keepers", 10));
            games.Add(new Game("Stardust Crusaders", 3, "Egyptian Vampires", 2));
            games.Add(new Game("North Star Fists", 17, "Wasteland Sluggers", 1));
            games.Add(new Game("Superintendent Roasts", 2, "Principal Hams", 11));
            games.Add(new Game("South City Anti Spirals", 9, "North City Spirals", 10));
        }

        public void DeserializeGameList()
        {
            result = "";

            StreamReader name = new StreamReader(@"..\..\sports.xml");
            serial = new XmlSerializer(games.GetType());
            debug = (List<Game>)serial.Deserialize(name);

            foreach(Game g in debug)
            {
                result += g.ToString() + "\r\n";
            }

            name.Close();
        }
    }
}
