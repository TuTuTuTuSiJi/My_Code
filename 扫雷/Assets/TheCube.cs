using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheCube : MonoBehaviour
{
    [SerializeField] Global global;
   //判定有没有雷,或者应该显示什么值。有雷为9，其他的数字对应数字，空对应0
    public int Xindex;
    public int Yindex;
    private void OnMouseDown()//OnMouse函数返回，直接是附带碰撞盒的对象，即是我添加了碰撞盒的Cube
    {   if (global.Metrix[Xindex, Yindex] == 9)
        {
            GameOver();
        }
        else
        {
            this.skim(Xindex, Yindex);
        }
    }
	public void skim(int Xindex,int Yindex)//用于检查，开辟空间
    {
        if (Xindex >= 0 && Xindex < global.Xsize && Yindex >= 0 && Yindex< global.Ysize)//为递归做准备   
        {
            if (global.Metrix[Xindex, Yindex] == 0 && Xindex != 0 && Yindex != 0)
            {
                if (global.Metrix[Xindex - 1, Yindex - 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex - 1, Yindex] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex - 1, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex, Yindex - 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex - 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                global.Metrix[Xindex, Yindex] = global.Metrix[Xindex, Yindex];
            }//检查中心周围
            else if (global.Metrix[Xindex, Yindex] == 0 && Xindex == 0 && Yindex == 0)
            {
                if (global.Metrix[Xindex + 1, Yindex - 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
            }
            else if (global.Metrix[Xindex, Yindex] == 0 && Xindex == 0 && Yindex != 0)
            {
                if (global.Metrix[Xindex, Yindex - 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex - 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
            }
            else if (global.Metrix[Xindex, Yindex] == 0 && Xindex != 0 && Yindex == 0)
            {
                if (global.Metrix[Xindex - 1, Yindex] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex - 1, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }
                if (global.Metrix[Xindex + 1, Yindex + 1] == 9)
                {
                    global.Metrix[Xindex, Yindex] += 1;
                }

            }
        }
        OpenArea(Xindex, Yindex);    
    }
    public void OpenArea(int Xindex,int Yindex)
    {
        if (global.Metrix[Xindex,Yindex]==0)
        {
            skim(Xindex-1, Yindex-1);
            skim(Xindex - 1, Yindex);
            skim(Xindex - 1, Yindex + 1);
            skim(Xindex, Yindex - 1);
            skim(Xindex, Yindex + 1);
            skim(Xindex + 1, Yindex - 1);
            skim(Xindex + 1, Yindex);
            skim(Xindex + 1, Yindex + 1);
        }
    }
    public void GameOver()//踩雷时结束
    {

    }
}
