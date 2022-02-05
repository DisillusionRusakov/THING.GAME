namespace THING.GAME
{
    public class Game
    {
        public Lobby gameBoard = new Lobby();
        public Deck gameDeck = new Deck();
        public Deck discardDeck = new Deck();
        public int turn = 0;

        public void PlayerAdd(string Name)
        {
            gameBoard.Add(new Player(Name));
        }
        public void Start()
        {
            Deck _deck = new Deck();
            gameDeck.Start(gameBoard.Count);
            for (int i = 0; i < gameBoard.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    gameBoard[i].Deck.Add(gameDeck[0]);
                    gameDeck.RemoveAt(0);
                }

            }
            gameDeck.MixDec();

        }

        public void BeginTurn()
        {
            this.DrawCard(turn);
            if (turn < gameBoard.Count - 1)
            { turn++; }
            else { turn = 0; }


        }

        public void CheckPanic(int Pl)
        {

        }
        public void PlayCard(Card card)
        {
            switch (card.Name)
            {
                case "Свидание в слепую":
                    Console.WriteLine("ПАНИКА!!! \n поменяйте 1 курту с руки на верхнюю карту обще колоды \n выберете карту ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    DropCard(turn, value);
                    ChekDeck();
                    DrawCard(turn);
                    break;
                case "Забывчивость":
                    for (int i = 0; i < 3; i++)
                    {

                        DropCard(turn, Convert.ToInt32(Console.ReadLine()));
                    }
                    DrawCard(turn);
                    DrawCard(turn);
                    DrawCard(turn);
                    break;
                default:
                    ChekDeck();
                    DrawCard(turn);
                    break;

            };

        }

        public void DrawCard(int i) // какой игрок из лоби берет карту
        {
            ChekDeck();
            gameBoard[i].Deck.DrawCard(gameDeck);
            gameDeck.RemoveAt(0);

            int check = gameBoard[i].Deck.Count - 1;
            if (gameBoard[i].Deck[check].Panic)
            {

                Console.WriteLine($"Скинута карта: {gameBoard[i].Deck[check].Name} ");

                if (check == 4)
                {

                    DropCard(i, check);
                    PlayCard(discardDeck[discardDeck.Count() - 1]);

                }
                else
                {
                    DropCard(i, check);
                    ChekDeck();
                    DrawCard(i);
                }



            }


        }

        public void ChekDeck()
        {
            if (gameDeck.Count == 0)
            {
                foreach (Card card in discardDeck)
                {
                    gameDeck.Add(card);

                }
                discardDeck.Clear();
                gameDeck.MixDec();

            }
        }



        public void DropCard(int player, int card)
        {
            discardDeck.Add(gameBoard[player].Deck[card]);
            gameBoard[player].Deck.DropCard(card);
        }

        public void SwapCard(int player1, int card1, int player2, int card2)
        {

            Card _card = gameBoard[player1].Deck[card1];
            gameBoard[player1].Deck[card1] = gameBoard[player2].Deck[card2];
            gameBoard[player2].Deck[card2] = _card;

        }

    }
}
