using System;

namespace Poker
{
  class Card
  {
    public Card(Suit suit, Value val)
    {
      Suit = suit;
      Value = val;
    }

    public Suit Suit
    {
      get; private set;
    }

    public Value Value
    {
      get; private set;
    }

    public override string ToString()
    {
      return ValueToString() + SuitToString();
    }

    private string SuitToString()
    {
      switch (Suit)
      {
        case Suit.Club:
          return "Club";
        case Suit.Heart:
          return "Heart";
        case Suit.Diamond:
          return "Diamond";
        case Suit.Spade:
          return "Spade";
        default:
          throw new NotImplementedException();
      }
    }

    private string ValueToString()
    {
      switch (Value)
      {
        case Value.Two:
          return "2";
        case Value.Three:
          return "3";
        case Value.Four:
          return "4";
        case Value.Five:
          return "5";
        case Value.Six:
          return "6";
        case Value.Seven:
          return "7";
        case Value.Eight:
          return "8";
        case Value.Nine:
          return "9";
        case Value.Ten:
          return "10";
        case Value.Jack:
          return "Jack";
        case Value.Queen:
          return "Queen";
        case Value.King:
          return "King";
        case Value.Ace:
          return "Ace";
        default:
          throw new NotImplementedException();
      }
    }
  }

  public enum Suit
  {
    Diamond,
    Club,
    Heart,
    Spade,
  }

  public enum Value
  {
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace,
  }
}
