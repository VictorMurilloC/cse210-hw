
public class Reference {
    private string _book;
    private byte _chapter;
    private List<Verse> _verses;

    public Reference(string book, byte chapter, List<Verse> verses) {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    // Returns the end index of the consecutive list.
    private int CheckConsecutives(List<byte> numbers, int start) {
        int end = start;
        for (int i = start; i < numbers.Count; i++) {
            if (i != numbers.Count - 1) {
            int numberAfter = numbers[i + 1] - 1;
            if (numbers[i] == numberAfter) {
                end = i + 1;
            } else {
                break;
            }
            }
        }
        return end;
    }

    private string GenerateVerses(List<byte> numbers) {
        numbers.Sort();
        string verses = "";
        if (numbers.Count > 0) {
            int start = 0;
            int end = CheckConsecutives(numbers, start);

            do {

            if (end != start) {
                verses += numbers[start] + "-" + numbers[end];
                if (end < numbers.Count - 1) {
                    verses += ";";
                }
            } else {
                verses += numbers[end];
                if (end < numbers.Count - 1) {
                    verses += ";";
                }
            }

            start = end + 1;
            end = CheckConsecutives(numbers, start);  
            } while (end < numbers.Count);
        }
        return verses;
    }

    public string GetReference() {
        List<byte> numbers = _verses.Select(verse => verse.GetNumber()).ToList();
        if (numbers.Count == 1) {
            return _book + " " + _chapter + ":" + numbers[0];
        } else {
        string verses = GenerateVerses(numbers);
        return _book + " " + _chapter + ":" + verses;
        }
    }

    public void Hide(int verse, int wordIndex) {
        _verses[verse].Hide(wordIndex);
    }

    public List<Verse> GetVerses() {
        return _verses;
    }
}