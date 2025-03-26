using System.Net;
using System.Reflection.Emit;

public class Word {
    private string _word;
    private bool _isHidden;

    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;
    }

    public void Show() {
        _isHidden = false;
    }

    public string GetWord() {
        if (_isHidden) {
            return new string('_', _word.Length);
        }
        return _word;
    }

    public bool IsHidden() {
        return _isHidden;
    }
}