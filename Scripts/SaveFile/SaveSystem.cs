using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sands
{   
   
    public static class SaveSystem
    {
        static string path = Application.persistentDataPath + "/player.savefile";
        static PlayerData data;
        private static Player player = new Player();
         private static NestList nestList = new NestList();    
        static SaveSystem() {
            data = new PlayerData();
            SaveAll();
        }

    public static void SaveAll(){

        SaveSystem.SavePlayer(player);
        SaveNests(nestList);
    }







        public static void SavePlayer(Player player) {

            BinaryFormatter formatter = new BinaryFormatter();

          
            FileStream stream = new FileStream(path, FileMode.Create);
            
            data.AcceptedQuests = player.AcceptedQuests;
            data.CurrentLocation = player.CurrentLocation;

            formatter.Serialize(stream, data);
            stream.Close();
    

        }

        public static PlayerData LoadPlayer() {

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                
                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();

                return data;

            } else {

                Debug.LogError("Save file not found in " + path);

                return null;
            }
        }

        public static void SaveNests(NestList nestList) {

            BinaryFormatter formatter = new BinaryFormatter();

          
            FileStream stream = new FileStream(path, FileMode.Create);
            
            data.Nests = nestList.getNestList();

            formatter.Serialize(stream, data);
            stream.Close();
    

        }

        public static PlayerData LoadNests() {

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                
                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();

                return data;

            } else {

                Debug.LogError("Save file not found in " + path);

                return null;
            }
        }
    }
}