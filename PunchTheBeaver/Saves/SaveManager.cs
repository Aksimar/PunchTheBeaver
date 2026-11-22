using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace PunchTheBeaver.Saves
{
    internal static class SaveManager
    {
        private const int MaxSaves = 20;

        private static readonly string SavesFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SavesG");

        public static string SaveGame(GameSaveData saveData)
        {
            Directory.CreateDirectory(SavesFolder);

            saveData.SaveTime = DateTime.Now;

            string fileName =
                $"save_{saveData.SaveTime:yyyy-MM-dd_HH-mm-ss}.xml";

            string filePath =
                Path.Combine(SavesFolder, fileName);


            XmlSerializer serializer =
                new XmlSerializer(typeof(GameSaveData));

            using (FileStream stream =
                   new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, saveData);
            }


            DeleteOldSaves();

            return filePath;
        }


        public static GameSaveData LoadGame(string filePath)
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(GameSaveData));

            using (FileStream stream =
                   new FileStream(filePath, FileMode.Open))
            {
                return (GameSaveData)serializer.Deserialize(stream);
            }
        }


        public static List<string> GetSaveFiles()    
        {
            Directory.CreateDirectory(SavesFolder);

            return Directory
                .GetFiles(SavesFolder, "save_*.xml")
                .OrderByDescending(saveFilePath => Path.GetFileName(saveFilePath)).ToList();
        }


        private static void DeleteOldSaves()
        {
            List<string> saveFiles = GetSaveFiles();

            while (saveFiles.Count > MaxSaves)
            {
                string oldestSave =
                    saveFiles[saveFiles.Count - 1];

                File.Delete(oldestSave);

                saveFiles.RemoveAt(saveFiles.Count - 1);
            }
        }

                public static void AddSave(List<SaveInfo> saves, SaveInfo newSave)
                {
                    saves.Insert(0, newSave);

                    if (saves.Count > MaxSaves)
                    {
                        saves.RemoveAt(saves.Count - 1);
                    }
                }

        public static List<SaveInfo> GetSaveInfo()   
        {
            List<SaveInfo> saveInfos = new List<SaveInfo>();

            List<string> saveFiles = GetSaveFiles();

            foreach (string saveFilePath in saveFiles)   
            {
                GameSaveData saveData = LoadGame(saveFilePath);

                SaveInfo saveInfo = new SaveInfo(
                    saveData.Difficulty,
                    saveData.Score,
                    saveData.SaveTime,
                    saveFilePath                         
                );

                saveInfos.Add(saveInfo);
            }

            return saveInfos;
        }
    }
}