using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections;
using System.Collections.Generic;   

namespace CustomListProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                CustomList<string> custom = new CustomList<string>();
                custom.Add();
                custom.Remove();
                custom.ToString();
                custom.Zip();
                custom.GetEnumerator();
            }
        }
    }
}