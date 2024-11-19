using System.ComponentModel;
using System.Data;
using System.Globalization;
using Microsoft.VisualBasic;

public class Scripture {
    private string[] verse = {"And", "it", "came", "to", "pass", "that", "he", "said", "unto", "them:", "Behold", "here", "are", "the", "waters", "of", "Mormon", "(for", "thus", "were", "they", "called)", "and", "now,", "as", "ye", "are", "desirous", "to", "come", "into", "the", "fold", "of", "God,", "and", "to", "be", "called", "his", "people,", "and", "are", "willing", "to", "bear", "one", "another's", "burdens,", "that", "they", "may", "be", "light;"};

    public string[] getVerseArray() {
        return verse;
    }
    public string printVerse() {
        return (string.Join(" ", verse));
    }
}