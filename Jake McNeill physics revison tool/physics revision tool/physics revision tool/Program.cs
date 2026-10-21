using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Player LoggedPlayer = new Player();
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Question1());
        }
        public static void RandomizeList<T>(IList<T> list)
        {
            Random r = new Random();

            for (int i = 0; i < list.Count - 1; i++)
            {
                int j = r.Next(i, list.Count);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
        public static void WriteToFile(List<Player> playerList)
        {
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sw = File.Open("PlayerList.bin", FileMode.Create);// opens the bin file and adds all the data to it in binary format
                bf.Serialize(sw, playerList);
                sw.Close();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("" + e.Message);
            }
        }
        public static List<Player> ReadFromFile(List<Player> playerList)// allows the program to access the information inside of the playerlist.bin file and use it in the form
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sr = File.OpenRead("PlayerList.bin");
                playerList = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
            return playerList;
        }
        public static void SortList(List<Player> obj)// sorts the highscore of all of the player objects inside from highest to lowest
        {
            Player temp = new Player();
            for (int i = 0; i < obj.Count - 1; i++)
            {
                for (int j = 0; j < obj.Count - 1; j++)
                {
                    if (obj[j].HighScore < obj[j + 1].HighScore)
                    {
                        temp = obj[j + 1];
                        obj[j + 1] = obj[j];
                        obj[j] = temp;
                    }
                }
            }
            return;
        }
        
       
    }
}
