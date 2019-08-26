using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        var list = new List<int>(A);
        int i, r;
        bool tiene_par;
        
        tiene_par = true;
      
        do 
        {
            r = list[0];
            list.RemoveAt(0);
            
            tiene_par = list.Contains(r);
            
            if(tiene_par) {
                i = list.IndexOf(r);
                list.RemoveAt(i);
            }
        }
        while(tiene_par);
        
        return r;
    }
}