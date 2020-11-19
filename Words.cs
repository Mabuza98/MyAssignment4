using System;
using System.Collections.Generic;
using System.Text;
public static class Words

{
    public static string CountCharactersInSentence(string inputString)

    {
        Dictionary<char, int> Newstring = new Dictionary<char, int>();
        string count = inputString;
        foreach (char characters in count.Replace(" ", string.Empty))
        {
            if (Newstring.ContainsKey(characters))
            {
                Newstring[characters] = Newstring[characters] + 1;
            }
            else
            {
                Newstring.Add(characters, 1);
            }
        }
        foreach (var item in Newstring.Keys)
        {
            count += " " + item + " -> " + Newstring[item] + " ";
        }
        return count;

    }
}