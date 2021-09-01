using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = new int[]{8, 1, 2, 4, 6};

        int[] result = ItemsLessThanElements(nums);

        foreach(var item in result)
        {
            object p = Debug.Log(item);
        }
    }

    private int[] ItemsLessThanElements(int[] nums)
    {
        return nums; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
