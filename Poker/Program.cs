using System;
using System.Collections.Generic;

namespace Poker
{
  class Program
  {
    static readonly Dictionary<HandRanking, int> ranks = new Dictionary<HandRanking, int>();

    static void Main()
    {
      Hand[] hands = new Hand[10];
      Deck deck = new Deck();
      deck.Shuffle();

      for (int i = 0; i < hands.Length; i++)
      {
        hands[i] = new Hand();
      }

      for (int cardCount = 0; cardCount < 5; cardCount++)
      {
        foreach (Hand oneHand in hands)
        {
          oneHand.Add(deck.Deal());
        }
      }

      foreach (Hand hand in hands)
      {
        Console.WriteLine($"{hand.Rank} ({hand})");
      }

      Console.ReadKey();
    }
  }
}
