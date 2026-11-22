using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PunchTheBeaver.HighScores
{
    internal static class HighScoreManager
    {
        private const int MaxScores = 10;

        private static readonly string ScoresFolder =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "HighScores"
            );

        private static readonly string ScoresFile =
            Path.Combine(
                ScoresFolder,
                "highscores.xml"
            );


        public static void AddScore(int newScore)
        {
            List<int> scores = GetScores();

            scores.Add(newScore);

            scores.Sort();
            scores.Reverse();

            if (scores.Count > MaxScores)
            {
                scores.RemoveAt(scores.Count - 1);
            }

            SaveScores(scores);
        }


        public static List<int> GetScores()
        {
            Directory.CreateDirectory(ScoresFolder);

            if (!File.Exists(ScoresFile))
            {
                return new List<int>();
            }

            XmlSerializer serializer =
                new XmlSerializer(typeof(List<int>));

            using (FileStream stream =
                new FileStream(ScoresFile, FileMode.Open))
            {
                return (List<int>)serializer.Deserialize(stream);
            }
        }


        private static void SaveScores(List<int> scores)
        {
            Directory.CreateDirectory(ScoresFolder);

            XmlSerializer serializer =
                new XmlSerializer(typeof(List<int>));

            using (FileStream stream =
                new FileStream(ScoresFile, FileMode.Create))
            {
                serializer.Serialize(stream, scores);
            }
        }
    }
}