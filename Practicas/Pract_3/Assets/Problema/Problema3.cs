using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema3 : MonoBehaviour
{
     public int num1, num2;
     int[] nums = new int[] {2,7,11,15,3,9};
     int target, i;   

    // Start is called before the first frame update
    void Start()
    {
        //Se inprime los valores de nums
        Debug.Log("Input: ");
        for(i=0;i<6;i++)
        {
            Debug.Log(nums[i]);
        }

        Debug.Log("Elija 2 numeros para el target:");

        //Se suman 2 numeros de la lista nums
        Debug.Log(num1 +" y " + num2);

        target = num1 + num2;

        Debug.Log("Target: " + target);

        Debug.Log("Output: ");

        //Se llama a la funcion SumaDos
        int[] result = SumaDos(nums,target);

        //Se imprime el resultado 
        for(int i=0;i<2;i++)
        {
            Debug.Log(result[i]);
        }   
    }

    public int[] SumaDos(int[] nums,int target)
    {   
        int[] result=new int[] {0,0,0,0,0};
        int i,j;
        for(i=0;i<5;i++)
        {
            for(j=i+1;j<6;j++)
            {
                //Se busca los 2 numeros que sumados sea igual al target
                if(nums[i]+nums[j]==target)
                {
                    //Se almacena el resultado en el vector
                    result[0]=i;
                    result[1]=j;
                    break;
                }
            }
        }

        return result;
    }    
    // Update is called once per frame
    void Update()
    {
         
    }
}