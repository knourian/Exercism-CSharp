using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (!dominoes.Any())
            return true;
        if (dominoes.Count() == 1)
            return dominoes.First().Item1 == dominoes.First().Item2;

        var dominoList = dominoes.ToList();
        for (int i = 0; i < dominoList.Count; i++)
        {
            var currentDomino = dominoList[i];
            var remainingDominoes = dominoes.Where((_, index) => index != i);

            if (CanChain(new List<(int, int)> { currentDomino }, remainingDominoes))
                return true;

            var reverseDomino = (currentDomino.Item2, currentDomino.Item1);
            if (CanChain(new List<(int, int)> { reverseDomino }, remainingDominoes))
                return true;
        }
        return false;
    }

    private static bool CanChain(IEnumerable<(int, int)> currentChain, IEnumerable<(int, int)> remainingDominoes)
    {
        if (!remainingDominoes.Any())
        {
            return currentChain.First().Item1 == currentChain.Last().Item2;
        }

        for (int i = 0; i < remainingDominoes.Count(); i++)
        {
            var currentDomino = remainingDominoes.ElementAt(i);
            var lastChainItem = currentChain.Last();

            if (lastChainItem.Item2 != currentDomino.Item1 && lastChainItem.Item2 != currentDomino.Item2)
                continue;

            (int, int) domino;

            if (lastChainItem.Item2 == currentDomino.Item1)
                domino = (currentDomino.Item1, currentDomino.Item2);
            else
                domino = (currentDomino.Item2, currentDomino.Item1);

            var newChain = new List<(int, int)>(currentChain) { domino };

            var newRemaining = remainingDominoes.Where((_, index) => index != i);

            if (CanChain(newChain, newRemaining))
                return true;
        }

        return false;
    }
}