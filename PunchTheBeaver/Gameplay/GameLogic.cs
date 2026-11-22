using PunchTheBeaver.GameObjects;
using PunchTheBeaver.Saves;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PunchTheBeaver.Gameplay
{
    internal class GameLogic
    {
        private readonly List<Field> logicFields;

        private readonly List<GameObject> gameObjects;

        private readonly Difficulty gameDifficulty;

        private int score = 0;


        private Timer gameTimer;// for game
        private Timer spawnTimer;//for spawn obj
        private Timer lifeTimeTimer;// life obj
        private int gameTime = 0;

        private readonly Dictionary<Field, int> fieldLifeTimes; //Dictionary<TKey, TValue>


        public event EventHandler ScoreChanged;

        public event EventHandler TimeChanged;
        public event EventHandler GameOver;





        public GameLogic(List<Field> fieldsFromGameField, Difficulty selectedDifficulty)  
        {
            logicFields = fieldsFromGameField;

            foreach (Field field in logicFields)
            {
                field.FieldClicked += Field_Clicked;
            }

            gameDifficulty = selectedDifficulty;

            gameObjects = new List<GameObject>
               {
                new Beaver(),
                new UniqueBeaver(),
                new ScamBeaver(),
                new BobrK(),
                new Bomb()
               };


            fieldLifeTimes = new Dictionary<Field, int>(); //коллекция //
                                                           //Field → сколько миллисекунд осталось жить объекту в этом поле



            //создание и запуск таймерov
            gameTimer = new Timer()
            {
                Interval = 1000
            };

            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();


            spawnTimer = new Timer()
            {
                Interval = gameDifficulty.SpawnSpeed
            };
            spawnTimer.Tick += SpawnTimer_Tick;
            spawnTimer.Start();


            lifeTimeTimer = new Timer()
            {
                Interval = 100
            };
            lifeTimeTimer.Tick += LifeTimeTimer_Tick;
            lifeTimeTimer.Start();

        }
        
        //End of Constractor


        private readonly Random random = new Random();

       private Field GetRandFreeField()
        {

            List<Field> freeFields = new List<Field>();

            foreach(Field field in logicFields)
            {
                if (!field.InAction)
                {
                    freeFields.Add(field);
                }
            }

            if (freeFields.Count <= 1)
            {
                return null;
            }

            int randomIndex = random.Next(freeFields.Count);

            Field selectedField = freeFields[randomIndex];

            return selectedField;

        }


        private GameObject GetRandObject()
        {
            int totalWeight = 0;

            foreach (GameObject gameObject in gameObjects)
            {
                totalWeight += gameObject.SpawnChance;
            }

            int randomValue = random.Next(totalWeight);

            int currentWeight = 0;

            foreach (GameObject gameObject in gameObjects)
            {
                currentWeight += gameObject.SpawnChance;

                if (randomValue < currentWeight)
                {
                    return gameObject;
                }
            }

            return null;
        }


        private void SpawnRandomObject()
        {
            Field selectedField = GetRandFreeField();

            if (selectedField == null)
            {
                return;
            }

            GameObject selectedObject = GetRandObject();

            if (selectedObject == null)
            {
                return;
            }

            selectedField.AddObject(selectedObject);

            fieldLifeTimes[selectedField] = gameDifficulty.LifeTime; // Dictionary<TKey, TValue>
                                                                     // [] — обращение к значению по ключу.
                                                                     // Здесь selectedField = ключ,
                                                                     // gameDifficulty.LifeTime = значение.
        }

        private void Field_Clicked(object sender, EventArgs e)
        {
            Field clickedField = sender as Field;

            if (clickedField == null || !clickedField.InAction)
            {
                return;
            }

            GameObject clickedObject = clickedField.CurrentObject;


            if(clickedObject is Beaver clickedBeaver)
            {
                CountScore(clickedBeaver);

                clickedField.RemoveObject();

                fieldLifeTimes.Remove(clickedField);
            }
            else if(clickedObject is Bomb)
            {
                EndGame();
            }
        }


        private int CountScore(Beaver clickedBeaver)
        {
            score += (int)(clickedBeaver.Score* gameDifficulty.ScoreMultiplier);

            ScoreChanged?.Invoke(this, EventArgs.Empty);

            return score;
        }

        public int Score
        {
            get { return score; }
        }

        //-------------------------RESTORE

        public void RestoreState(GameSaveData saveData)   
        {
            score = saveData.Score;                        
            gameTime = saveData.GameTime;

            switch (saveData.Difficulty)
            {
                case "Easy":
                    gameDifficulty.Easy();
                    break;

                case "Normal":
                    gameDifficulty.Normal();
                    break;

                case "Hard":
                    gameDifficulty.Hard();
                    break;
            }

            spawnTimer.Interval = gameDifficulty.SpawnSpeed;
            score = saveData.Score;
            gameTime = saveData.GameTime;


            foreach (Field field in logicFields)           
            {
                field.RemoveObject();
            }

            fieldLifeTimes.Clear();                        


            foreach (FieldSaveData fieldData in saveData.Fields)   
            {
                if (fieldData.FieldIndex < 0 ||fieldData.FieldIndex >= logicFields.Count)
                {
                    continue;
                }


                GameObject savedObject = null;            

                foreach (GameObject gameObject in gameObjects)
                {
                    if (gameObject.GetType().Name == fieldData.ObjectType)
                    {
                        savedObject = gameObject;
                        break;
                    }
                }


                if (savedObject == null)
                {
                    continue;
                }


                Field field = logicFields[fieldData.FieldIndex];

                field.AddObject(savedObject);             

                fieldLifeTimes[field] =
                    fieldData.RemainingLifeTime;           
            }


            ScoreChanged?.Invoke(this, EventArgs.Empty);    
            TimeChanged?.Invoke(this, EventArgs.Empty);    
        }

        //---------------------------

        //Time

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTime++;

            //int seconds = gameTime % 60;
            //int minutes = gameTime / 60;

            //string timeText = $"{minutes:D2}:{seconds:D2}";

            TimeChanged?.Invoke(this, EventArgs.Empty);
        }

        public string TimeText
        {
            get
            {
                int seconds = gameTime % 60;
                int minutes = gameTime / 60;

                return $"{minutes:D2}:{seconds:D2}";
            }
        }


        private void SpawnTimer_Tick(Object sender, EventArgs e)
        {
            SpawnRandomObject();
        }



        // Keys → временный List активных Field.
        // foreach → каждому Field уменьшаем оставшийся LifeTime.
        // List позволяет безопасно менять Dictionary во время прохода.
        private void LifeTimeTimer_Tick(object sender, EventArgs e)
        {
            List<Field> activeFields = new List<Field>(fieldLifeTimes.Keys);   
                                                                              
            foreach (Field field in activeFields)                             
            {                                                                 
                fieldLifeTimes[field] -= lifeTimeTimer.Interval;
                if (fieldLifeTimes[field] <= 0)
                {
                    field.RemoveObject();
                    fieldLifeTimes.Remove(field);
                }
            }

        }


        public void PauseTimers()
        {
            gameTimer.Stop();
            spawnTimer.Stop();
            lifeTimeTimer.Stop();
        }

        public void ResumeTimers()
        {
            gameTimer.Start();
            spawnTimer.Start();
            lifeTimeTimer.Start();
        }


        //SAVE

        public GameSaveData CreateSaveData()
        {
            GameSaveData saveData = new GameSaveData();

            saveData.Difficulty = gameDifficulty.Name;
            saveData.Score = score;
            saveData.GameTime = gameTime;
            saveData.SaveTime = DateTime.Now;


            foreach (KeyValuePair<Field, int> pair in fieldLifeTimes)
            {
                Field field = pair.Key;

                if (field.CurrentObject == null)
                {
                    continue;
                }


                FieldSaveData fieldData = new FieldSaveData();

                fieldData.FieldIndex = logicFields.IndexOf(field);
                fieldData.ObjectType = field.CurrentObject.GetType().Name;
                fieldData.RemainingLifeTime = pair.Value;


                saveData.Fields.Add(fieldData);
            }


            return saveData;
        }



        // END
        private void EndGame()
        {
            spawnTimer.Stop();
            gameTimer.Stop();
            lifeTimeTimer.Stop();

            GameOver?.Invoke(this, EventArgs.Empty);  
            

        }
    }
}
