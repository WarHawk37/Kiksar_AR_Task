using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class ColorManager : MonoBehaviour
{

    public Material[] materials;
    public ARFaceManager faceManager;
    // Start is called before the first frame update
    

    public void  changeToBlack()
    {
        faceManager.GetComponent<ARFaceManager>().facePrefab.GetComponent<MeshRenderer>().material = materials[1];
      
    }


    public void changeToBlue()
    {
        faceManager.GetComponent<ARFaceManager>().facePrefab.GetComponent<MeshRenderer>().material = materials[2];

    }

   
    
}
