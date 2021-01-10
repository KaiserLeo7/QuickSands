using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sands
{   
   
    public static class SaveSystem
    {
        static string path = Application.persistentDataPath + "/player.savefile";
        static PlayerData data;

        static SaveSystem() {
            data = new PlayerData();


        }

public static SaveAll(){

 SavePlayer(Player player)
 SaveNest(Nest Nest)
 SaveVehicles(Vehicles vehicles)

}


LoadAll {



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
    }
}