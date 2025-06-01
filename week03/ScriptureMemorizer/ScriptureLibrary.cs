using System;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _random =new Random();

    public ScriptureLibrary()
    {
        _scriptures.Add(new Scripture(new Reference("John", 3, 16),
        "For God so loved the world that He gave His only begotten Son that whosoever believe in Him should not perish but have eternal life."));

        _scriptures.Add(new Scripture(new Reference("Proverbs", 3,5,6),
        "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge Him and He shall direct thy paths"));

       
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        Scripture original = _scriptures[index];
        Reference refCopy = new Reference(
            original.GetReference().GetBook(),
            original.GetReference().GetChapter(),
            original.GetReference().GetStartVerse(),
            original.GetReference().GetEndVerse() ?? -1 
        );

        return new Scripture(refCopy, original.GetText());
    }


}