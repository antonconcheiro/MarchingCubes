using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class ReadMatrix : MonoBehaviour
{



    // Start is called before the first frame update
    public int[,,] GetMatrix()
    {
        string[] fCount = Directory.GetFiles("./Assets/matrixImages","*.txt", SearchOption.TopDirectoryOnly);
        Array.Sort(fCount, (a, b) => int.Parse(Regex.Replace(a, "[^0-9]", "")) - int.Parse(Regex.Replace(b, "[^0-9]", "")));

        List<List<List<int>>> fileList = new List<List<List<int>>>();
        int[] fileArray = new int[fCount.Length];

        //Debug.Log(fCount.Length);
        foreach (var file in fCount) {
            //Debug.Log(file);
            string[] text = File.ReadAllLines(file);
            List<List<int>> yList = new List<List<int>>();
            //int[] yArray = new int[text.Length];
            for(int i = 0; i<text.Length; i++) {
                string[] newArray = text[i].Split(' ');
                List<int> xList = new List<int>();
                //int[] xArray = new int[newArray.Length];
                for(int j = 0; j< newArray.Length; j++) {
                    //xArray[j] = Int32.Parse(newArray[j]);
                    xList.Add(Int32.Parse(newArray[j]));
                }
                //yArray[i] = xArray;
                yList.Add(xList);
            }
            fileList.Add(yList);
        }
        /*Debug.Log(fileList.Count); 
        Debug.Log(fileList[0].Count); 
        Debug.Log(fileList[0][0].Count);*/

        int[,,] finalArray = new int[fileList[0].Count, fileList[0][0].Count, fileList.Count];
        for(int i = 0; i < fileList.Count;i++) {
            for (int j = 0; j < fileList[0].Count; j++) {
                for (int k = 0; k < fileList[0][0].Count; k++) {
                    finalArray[j, k, i] = fileList[i][j][k];
                }
            }
        }
        return finalArray;
        //Debug.Log(finalArray[120,240,2]);
        //finalArray[row,column,depth]
        

        /*string[] text = File.ReadAllLines("./Assets/matrixImages/0output.txt");
        Debug.Log(text[1]);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
