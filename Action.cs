using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 五子棋
{
    public class Action
    {
        public int nowPlayer = 1;
        public int[,] piece = new int[39, 39];
        public void init()
        {
            for(int i = 0;i<39;i++)
                for (int j = 0; j < 39; j++)
                {
                    piece[i, j] = 0;
                }
        }
        public void playerChange(ref int nowPlayer)
        {
            nowPlayer *= -1;
        }
        public bool isOnly(int x,int y)
        {
            bool flag = false;
            if (piece[x, y] == 0)
                flag = true;
            return flag;
        }
       
        public bool isWin(int nowPlayer)
        {
            bool flag = false;
            for (int i = 0; i < 34; i++)
            {
                
                for (int j = 0; j < 34; j++)
                {
                    int wh = 0;
                    int ws = 0;
                    int wx1 = 0;
                    int wx2 = 0;
                    if (piece[i, j] == nowPlayer|| piece[i+4, j] == nowPlayer)
                    {
                        for (int c = 0; c < 5; c++)
                        {
                            wh += piece[ i + c, j ];
                            ws += piece[ i, j + c ];
                            wx1 += piece[i + c, j+c];
                            wx2 += piece[i - c + 4, j + c];
                        }
                        if(wh*wh>=25|| ws*ws >= 25 || wx1*wx1 >= 25 || wx2 * wx2 >= 25)
                        {
                            return true;
                        }
                    }
                    else
                        continue;
                }
            }
                    return flag;
        }
    }
}
