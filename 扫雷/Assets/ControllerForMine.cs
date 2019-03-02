using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerForMine : MonoBehaviour
{
    [SerializeField] private Global global;
    public int Counter = 0;//用于实现随机生成雷
    void Start ()
	{
        int LandMine = 10;
	    int TheCount = 0;

	    while (TheCount < LandMine)
	    {
	        for (int i = 0; i < global.Xsize; i++)
	        {
	            for (int j = 0; j < global.Ysize; j++)
	            {    
	                int Num = Random.Range(0, 10);
	                if (Num == 0 && TheCount <LandMine && global.Metrix[i, j] != 9)
	                {
	                    global.Metrix[i, j] = 9; //10分之一生成雷，为9
	                    TheCount += 1;
	                }
	                else
	                {
	                    global.Metrix[i, j] = 0; //默认为空
	                }
	            }
	        }
	    }
    }
}
