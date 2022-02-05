using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THING.GAME
{
    public class Deck : List<Card>
    {
        public void Start (int number)
        {
            Card card0 = new ("Нечто",false);
            Card card1 = new("Заражение", false);
            Card card2 = new("Подозрение", false);
            Card card3 = new("Анализ", false);
            Card card4 = new("Виски", false);
            Card card5 = new("Огнемет", false);
            Card card6 = new("Никакого шашлыка!", false);
            Card card7 = new("Упорство", false);
            Card card8 = new("Сматывай удочки", false);
            Card card9 = new("Меняемся местами", false);
            Card card10 = new("Мне и здесь неплохо", false);
            Card card11 = new("Гляди по сторонам", false);
            Card card12= new("Соблазн", false);
            Card card13 = new("Топор", false);
            Card card14 = new("Заколоченная дверь", false);
            Card card15 = new("Карантин", false);
            Card card16 = new("Нет уж, спасибо", false);
            Card card17 = new("Страх", false);
            Card card18 = new("Мимо", false);
            Card card19 = new("Свидание в слепую", true);
            Card card20 = new("Цепная реакция", true);
            Card card21 = new("Забывчивость", true);
            Card card22 = new("...три, четыре...", true);
            Card card23 = new("Раз, два...", true);
            Card card24 = new("Убирайся прочь!", true);
            Card card25 = new("И это вы называете вечеринкой", true);
            Card card26 = new("Старые веревки", true);
            Card card27 = new("Давай дружить?", true);
            Card card28 = new("Только между нами", true);
            Card card29 = new("Время признаний", true);
            Card card30 = new("Уупс", true);
           


            Deck _deck = new Deck();

            this.Add(card0);
            for (int i = 0; i < 1 ; i++)
            {
                
                _deck.Add(card18);
                _deck.Add(card16); 
                _deck.Add(card14);
                _deck.Add(card13);
                _deck.Add(card11);
                _deck.Add(card10);
                _deck.Add(card6);
                _deck.Add(card4);

            }
            for (int i = 0; i < 2; i++)
            {

                _deck.Add(card9);
                _deck.Add(card12);
                _deck.Add(card8);
                _deck.Add(card7);
                _deck.Add(card5);
                
            }
            for (int i = 0; i < 4; i++)
            {

                _deck.Add(card2);
            
            }
            _deck.MixDec();
            for (int i = 0; i < number * 4 - 1 ; i++)
            {
                this.Add(_deck[0]);
                _deck.RemoveAt(0);

            }
            this.MixDec();
            if (_deck.Count > 0)
            {
                int count = _deck.Count-1;
                for (int i=0; i < count; i++)
                {
                    this.Add(_deck[0]);
                    _deck.RemoveAt(0);
                }
            }

            for (int i = 0; i < 1; i++)
            {

                this.Add(card19);
                this.Add(card20);
                this.Add(card21);
                this.Add(card22);
                

            }

            for (int i = 0; i < 8; i++)
            {
                this.Add(card1);                
            }



        }

        public void DrawCard(Deck deck)
        {
            
            this.Add(deck[0]);
            
        }
        public void DropCard(int card)
        {
            this.RemoveAt(card);
            
        }

        public void MixDec()
        {
            int number = this.Count;
            Deck _deck = new Deck();
            Random rnd = new Random();
            for (int i = 0;i < number;i++)
            {
                int count = this.Count;
                int random = rnd.Next(0, count);
                _deck.Add(this[random]);
                this.RemoveAt(random);
                                
            }
            for (int i = 0; i < number; i++)
            {
                
                this.Add(_deck[0]);
                _deck.RemoveAt(0);

            }

            
            
            
        }
    }
}
