using System;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        private bool[,] _cache; 

        public class PNode 
        {
            /// <summary>
            /// 是否为星
            /// </summary>
            public bool Star { get; set; }
            /// <summary>
            /// 匹配字符
            /// </summary>
            public char PChar { get; set; }

            internal bool Match(char s)
            {
                return s == PChar || PChar == '.';
            }
        }


        public bool IsMatch(string s, string p) 
        {
            List<PNode> nodes = new List<PNode>();
            int pIndex = 0;
            while (pIndex< p.Length)
            {
                if (pIndex + 1 < p.Length && p[pIndex + 1] == '*')
                {
                    nodes.Add(new PNode() { PChar = p[pIndex], Star = true });
                    pIndex += 2;
                }
                else
                {
                    nodes.Add(new PNode() { PChar = p[pIndex], Star = false });
                    pIndex++;
                }
            }
            _cache = new bool[s.Length, nodes.Count];
            int nodesIndex = 0;
            int sIndex = 0;
            return Match(s, sIndex,nodes, nodesIndex);
        }

        private bool Match(string s, int sIndex, List<PNode> nodes, int nodesIndex)
        {
            if (nodesIndex >= nodes.Count) //pnode结束，字符串必须结束才能为true
            {

                return sIndex >= s.Length;
            }

            PNode node = nodes[nodesIndex];
            if (sIndex >= s.Length)//字符串结束，后续必须全为*的pnode才可能为true
            {
                return node.Star && Match(s, sIndex, nodes, nodesIndex + 1);
            }
            bool state = node.Match(s[sIndex]);
            if (node.Star) //为星
            {
                bool next = state && Match(s, sIndex + 1, nodes, nodesIndex); //继续下一个字符验证
                bool skip = Match(s, sIndex, nodes, nodesIndex + 1); //跳过*
                return next || skip;
            }
            else
            {
                return state && Match(s, sIndex + 1, nodes, nodesIndex + 1);
            }
        }

    }
}
