using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public GameObject ballPrefab;
   public Transform InstatiatePos;
   void Start()
   {
    Instatiate(ballPrefab, InstatiatePos.position, Quaternion.identity);
   }
}
