using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Editor.Model
{
    class Card
    {

        public string CardName { get; set; }

        public string CardType { get; set; }

        public int Strength { get; set; }
        public int Defense { get; set; }
        public int ManaCost { get; set; }

        public string ArtWork { get; set; }

        public Card()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            CardName = "";
            CardType = "";
            Strength = 1;
            Defense = 1;
            ManaCost = 1;
        }
        public static void Save(Cards card)
        {
            using (DataClassesDataContext cont = new DataClassesDataContext())
            {
                cont.Cards.InsertOnSubmit(card);
                cont.SubmitChanges();
            }
        }
        public void Browse()
        {
            // TODO: Replace code here with something that deserializes (loads) our data in an appropriate format.
            //       How about doing it with Json.NET, that we will learn about in a future lesson? :-)
        }
    }
}
