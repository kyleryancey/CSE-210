using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        var rnd = new Random();
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            var wordToHide = visibleWords[rnd.Next(visibleWords.Count)];
            wordToHide.IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }
}
