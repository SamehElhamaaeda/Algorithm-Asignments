using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsATree
{
    public class CheckTree
    {
        //===============================================================================
        //Your Code is Here:
        public static bool test = true;
        public static bool IsTree(string[] vertices, List<KeyValuePair<string, string>> edges)
        {

            Dictionary<String, List<String>> arr = new Dictionary<String, List<String>>();
            Dictionary<string, string> color= new Dictionary<string, string>();
            HashSet<string> ver = new HashSet<string>();
            test = true;
            foreach(var Pair in edges )
            {
                if (arr.ContainsKey(Pair.Key))
                { 
                    arr[Pair.Key].Add(Pair.Value);
                    
                        
                }
                else
                {
                    color[Pair.Key] = "w";
                    ver.Add(Pair.Key);
                    arr.Add(Pair.Key, new List<string>());
                    arr[Pair.Key].Add(Pair.Value);
                }
                if (!arr.ContainsKey(Pair.Value))
                {
                    color[Pair.Value] = "w";
                    ver.Add(Pair.Value);
                    arr.Add(Pair.Value, new List<string>());
                }

            }
            
           

            foreach(var v in ver)
            {
                if(!test)
                {
                    return false;
                }
                if(color[v]=="w")
                {
                    //Console.WriteLine(arr[v].ElementAt(0));
                    dfs_visit(color,v ,arr);
                    
                }
                
            }
            return true;
        }
        public static void dfs_visit (Dictionary<string, string> color, string node, Dictionary<String, List<String>> adj)
        {
           
                color[node] = "g";
            
               
                foreach (var p in adj[node])
                {
                    if(color[p] == "w")
                    {
                      dfs_visit(color, p, adj);
                    }
                    else if (color[p] == "g")
                    {
                        test = false;
                        return;
                    }
                   
                }
                color[node] = "b";
              
          
        }
        

        //===============================================================================
       
        //===============================================================================
    }
}
