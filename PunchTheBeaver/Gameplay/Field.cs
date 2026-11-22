using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PunchTheBeaver.GameObjects;


namespace PunchTheBeaver.Gameplay
{
    internal class Field
    {
        private GameObject currentObject;
        private bool inAction=false;
        private readonly PictureBox pictureBox;

        public event EventHandler FieldClicked; //не тип данных о событии, тип функции,которая умеет обрабатывать событие



        public Field(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;

            this.pictureBox.Click += Field_Clicked;
        }

        
        
        
        public int Size   //<--property/свойство
        {
            get { return pictureBox.Width; }   //assesor/getter
        }


        public bool InAction
        {
            get { return inAction; }
        }


        public GameObject CurrentObject
        {
            get { return currentObject; }
        }


        public void AddObject(GameObject obj)
        {
            if (!inAction)
            {
                currentObject = obj;
                pictureBox.Image = obj.VisualData;
                inAction = true; 
            }
        }

        public void RemoveObject()
        {
            if (inAction)
            {
                currentObject = null;
                pictureBox.Image = null;
                inAction = false;
            }
        }

         private void Field_Clicked(object sender, EventArgs e)
         { 
           FieldClicked?.Invoke(this, EventArgs.Empty);   //Invoke-«обработать любой клик»(вызывает событие)
                                                         //?.-вызвать только если !=null
                                                        // EventArgs.Empty — без доп. данных.
         }

        

    }
    

   

}
