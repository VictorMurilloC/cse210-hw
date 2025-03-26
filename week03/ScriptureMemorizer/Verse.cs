public class Verse {
    private byte _number;
    private List<Word> _words = new List<Word>();

    public Verse(byte number, string verse) {
        _number = number;
        verse.Split(" ").ToList().ForEach(word => _words.Add(new Word(word)));
    }

    public byte GetNumber() {
        return _number;
    }

    public string GetVerse() {
        return _number + " " + string.Join(" ", _words.Select(word => word.GetWord()));
    }

    public int GetWordCount() {
        return _words.Count;
    }

    public Word GetWord(int index) {
        return _words[index];
    }

    public void Hide(int index) {
        _words[index].Hide();
    }
}