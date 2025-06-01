using System;
using System. Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;
        for (int i= 0; i < wordsToHide && visibleWords.Count >0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }


    public Reference GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}

