public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;
        char[] sArray= new char[s.Length+1];
        char[] tArray= new char[t.Length+1];

        for(int i=0;i<s.Length;i++){
            sArray[i]=s[i];
            tArray[i]=t[i];

        }

        Array.Sort(sArray);
        Array.Sort(tArray);

        return sArray.SequenceEqual(tArray);
    }
}
