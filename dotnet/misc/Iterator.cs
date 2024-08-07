using System;
using System.Collections.Generic;

namespace HelloWorld
{
	class AInumerable
{
 
    public static IEnumerable<int> getList()
    {
     
        List<int> myList = new List<int>();
        
        myList.Add(1);
        myList.Add(2);
        myList.Add(4);
         
        foreach (var values in myList)
        {
            
            if (values % 2 == 0)
                yield return values;
        }
    }
}
}
