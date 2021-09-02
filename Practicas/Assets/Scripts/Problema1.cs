using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos el arreglo input
        int[] nums = new int[]{8,1,2,2,3};
        int[] result = ItemsLessThanElements(nums);
        int i;

        Debug.Log("Input: ");

        //Con un for imprimimos el arreglo input
        for(i=0;i<5;i++)
        {
            Debug.Log(nums[i]);
        }

        Debug.Log("Output: ");

        //Con un for imprimimos el arreglo output
        for(i=0;i<5;i++)
        {
            Debug.Log(result[i]);
        }
    }
    
    private int[] ItemsLessThanElements(int[] nums)
    {   
        //Inicializamos el arreglo donde se compararan los numeros
        int[] salida=new int[] {0,0,0,0,0}; 
        int i,j;

        //Con este for se cuentan las posiciones que van
        for(i=0;i<5;i++)
        {
            //Contador para cada repeticion de ciclo
            int contador=0;

            //Con este for se cuentan las comparaciones de los numeros
            for(j=0;j<5;j++)
            {
                //Aqui se comprara la posicion de nums[i] con la posicion de nums[j]
                if(nums[j]<nums[i])  
                    {
                        //Si se cumple la condicion se incrementa el contador
                        //Y se guarda el resultado en el arreglo salida
                        contador++;
                        salida[i]=contador;
                    }
            }
        }
        return salida;/*Regresamos el arreglo salida*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
