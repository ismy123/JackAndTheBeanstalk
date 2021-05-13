using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{
   public static Singleton instance = null;

   public static Singleton Instance
   {
       get
       {
           if (instance == null)
           {
               instance = new Singleton();
           }
           return instance;
       }
   }

    public bool end = false ;
}
