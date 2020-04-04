using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {


            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();//用于存放分组 

            for (int i = 0; i < strs.Length; i++)
            {
                var sortedStr = new string(strs[i].OrderBy(n => n).ToArray());//先使用Linq进行排序，再转化为string当Key

                if (!dic.ContainsKey(sortedStr))//如果不包含现在的key，则创建出来
                {
                    dic.Add(sortedStr, new List<string>());
                }
                
                dic[sortedStr].Add(strs[i]);
            }

            return dic.Values.Select(n => n).ToList();
        }
    }
}
