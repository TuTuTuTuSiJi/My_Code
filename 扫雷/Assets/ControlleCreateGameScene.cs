using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlleCreateGameScene : MonoBehaviour
{
    [SerializeField] private TheCube DefaultCube;
    [SerializeField] private Global global;

    void Start()
    {
        TheCube cube;
        for (int i = 0; i < global.Xsize; i++)
        {
            for (int j = 0; j < global.Ysize; j++)
            {
                cube = Instantiate(DefaultCube) as TheCube;
                cube.Xindex = i;
                cube.Yindex = j;//将数组的序列与方块绑定
                cube.transform.position = new Vector3(i * 1.0f, j * 1.0f, 0);
            }
        }
    }
    void Update()
    {
        
    }
}
