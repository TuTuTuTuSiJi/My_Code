using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
   public int Xsize;
    public int Ysize;
    public int[,] Metrix;
    void Start()
    {
        Metrix = new int[Xsize, Ysize];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
