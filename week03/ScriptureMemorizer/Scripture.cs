public class Scripture {
    private Reference _reference;
    public Scripture(string book, byte chapter, List<Verse> verses) {
        _reference = new Reference(book, chapter, verses);
    }

    private string DisplayReferenceWithSpaces() {
        return _reference.GetReference() + new string(' ', 40 - _reference.GetReference().Length);

    }

    public void Display() {
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("┌―― Scripture Reference: ――――――――――――――――――┐");
        Console.WriteLine("│                                          │");
        Console.WriteLine("│ "+ DisplayReferenceWithSpaces() +      " │");
        Console.WriteLine("│                                          │");
        Console.WriteLine("└――――――――――――――――――――――――――――――――――――――――――┘");
        Console.WriteLine("");

        _reference.GetVerses().ForEach(verse => Console.WriteLine(verse.GetVerse()));
        
        Console.WriteLine("");

    }

    public void Hide(int verse, int wordIndex) {
        _reference.Hide(verse, wordIndex);
    }

    private int GetAmountOfWords() {
        int amount = 0;
        foreach (Verse verse in _reference.GetVerses()) {
            amount += verse.GetWordCount();
        }
        return amount;
    }

    private int GetAmountHidden() {
        int amount = 0;
        foreach (Verse verse in _reference.GetVerses()) {
            for (int i = 0; i < verse.GetWordCount(); i++) {
                if (verse.GetWord(i).IsHidden()) {
                    amount++;
                }
            }
        }
        return amount;
    }

    public void HideRandom() {
        Random random = new Random();
        int verse = random.Next(0, _reference.GetVerses().Count);
        int wordIndex = random.Next(0, _reference.GetVerses()[verse].GetWordCount());
        while (_reference.GetVerses()[verse].GetWord(wordIndex).IsHidden() && !IsCompletelyEmpty()) {
            verse = random.Next(0, _reference.GetVerses().Count);
            wordIndex = random.Next(0, _reference.GetVerses()[verse].GetWordCount());
        }
        Hide(verse, wordIndex);
    }

    public bool IsCompletelyEmpty() {
        return GetAmountOfWords() == GetAmountHidden();
    }

    public Verse GetVerse(int index) {
        return _reference.GetVerses()[index];
    }
}