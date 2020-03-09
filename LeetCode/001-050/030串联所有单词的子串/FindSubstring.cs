using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();
            if (s==""|| words.Length == 0) 
            {
                return result;
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, int> temp= new Dictionary<string, int>();
            int checkValue = 0;//记录子串所有字符ascii值之和
            int sLength = words.Length * words[0].Length;//取得子串长度
            int wLength = words[0].Length;//单词长度
            for (int i = 0; i < words.Length; i++)
            {
                if (dic.ContainsKey(words[i]))
                {
                    dic[words[i]] = dic[words[i]] + 1;
                }
                else
                {
                    dic.Add(words[i], 1);
                }
                for (int j = 0; j < words[i].Length; j++)
                {
                    checkValue += words[i][j];
                }
            }
            for (int i = 0; i < s.Length - sLength + 1; i++)
            {
                int sValue = 0;//记录i起始后子串的ascii值之和
                for (int k = 0; k < sLength; k++)
                {
                    sValue += s[i + k];
                }
                if (sValue != checkValue) 
                {
                    continue;//ascii值检测不通过，继续循环
                }
                int checkedNum = 0;
                for (int j = i; j < i + sLength; j = j + wLength)
                {
                    
                    string word = s.Substring(j, wLength);
                    if (dic.ContainsKey(word))
                    {
                        if (temp.ContainsKey(word))
                        {
                            if (temp[word] == dic[word])
                            {
                                break;
                            }
                            else
                            {
                                temp[word]++;
                                checkedNum++;
                            }
                        }
                        else
                        {
                            temp.Add(word, 1);
                            checkedNum++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (checkedNum == words.Length) 
                {
                    result.Add(i);
                }
                temp.Clear();//清空记录进行下次循环
            }
            return result;
        }
    }
}
