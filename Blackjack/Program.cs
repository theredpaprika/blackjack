// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices.ComTypes;
using Blackjack;

class GameManager
{
    private Deck _deck = new Deck();
    Player _player = new Player();
    
    public void NewGame()
    {
        _deck.ResetDeck();
        _deck.Shuffle();
        _player.ClearHand();
    }
    
    public void Assign
    
    
}

Deck deck = new Deck();
deck.ResetDeck();
deck.Shuffle();
Card card = deck.DrawCard();

namespace Blackjack
{

    public class Player
    {
        public List<Card> Hand = new List<Card>();

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public void ClearHand()
        {
            Hand.Clear();
        }
        
    }
    
    
    public class Card {

        public enum Suits
        {
            Spades = 0,
            Hearts,
            Diamonds,
            Clubs
        }
        
        public int Value { get; set; }
        public Suits Suit { get; set; }

        public string NamedValue
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                {
                    case 13:
                        name = "King"; break;
                    case 12:
                        name = "Queen"; break;
                    case 11:
                        name = "Jack"; break;
                    case 1:
                        name = "Ace"; break;
                    default:
                        name = Value.ToString(); break;
                }
                return name;
            }
        }

        public string Name
        {
            get
            {
                return NamedValue + " of " + Suit.ToString();
            }
        }

        public Card(int Value, Suits Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
        }
    }

    public class Deck
    {
        public List<Card> Cards = new List<Card>();

        public void ResetDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Card.Suits suit = (Card.Suits)(Math.Floor((decimal)i / 13));
                int val = i % 13 + 1;
                Cards.Add(new Card(val, suit));
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            var shuffledCards = Cards.OrderBy(x => random.Next());
            Cards = shuffledCards.ToList();
        }
        
        public void PrintDeck()
        {
            foreach (Card card in this.Cards)
            {
                Console.WriteLine(card.Name);
            }
        }

        public Card DrawCard()
        {
            if (Cards.Count > 0)
            {
                Card card = Cards[0];
                Cards.RemoveAt(0);
                return card;
            }
            else
            {
                return null;
            }
        }
        
    }
   
}

