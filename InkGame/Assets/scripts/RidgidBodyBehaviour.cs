using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RidgidBodyBehaviour : MonoBehaviour
{
   public float force = 100;
   private Rigidbody rigidbodyObj;
   

   void Awake()
   {
      rigidbodyObj = GetComponent<Rigidbody>();
      gameObject.SetActive (true);
   }

   void OnEnable()
   {
      rigidbodyObj.AddForce(Vector3.right * force);
   }

   void onTriggerEnter(Collider other)
   {
      rigidbodyObj.Sleep();
      gameObject.SetActive(false);
   }
}
