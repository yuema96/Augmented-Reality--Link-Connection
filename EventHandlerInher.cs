using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class EventHandlerInher : DefaultObserverEventHandler
{
  public Vector3 position1;
  // public Vector3 position2;
protected override void OnTrackingFound()
{
  // base.OnTrackingFound ();
  Debug.Log(GameObject.Find("ImageTarget").transform.position); //return image target's position
  Debug.Log(GameObject.Find("ImageTargetA").transform.position); //return image targetA's position

  position1 = GameObject.Find("ImageTarget").transform.position;
  // position2 = GameObject.Find("ImageTargetA").transform.position;

  GameObject.Find("Cube").transform.position = GameObject.Find("ImageTarget").transform.position;
  GameObject.Find("CubeA").transform.position = GameObject.Find("ImageTargetA").transform.position;
  // GameObject.Find("Point1").transform.position = GameObject.Find("ImageTarget").transform.position;
  // GameObject.Find("Point4").transform.position = GameObject.Find("ImageTargetA").transform.position;

  GameObject.Find("Sphere").transform.position = new Vector3(position1.x-0.08f, position1.y, position1.z+0.08f);
  GameObject.Find("SphereA").transform.position = new Vector3(position1.x+0.07f, position1.y, position1.z-0.09f);
  // GameObject.Find("PointA").transform.position = GameObject.Find("Sphere").transform.position;
  // GameObject.Find("PointD").transform.position = GameObject.Find("Cube").transform.position;

  // GameObject.Find("Cube").transform.position = new Vector3(position1.x-0.198f, position1.y, position1.z+0.12f);
  // GameObject.Find("CubeA").transform.position = new Vector3(position2.x-0.12f, position2.y, position2.z+0.08f);
  // GameObject.Find("Point1").transform.position = new Vector3(position1.x-0.198f, position1.y, position1.z+0.12f);
  // GameObject.Find("Point4").transform.position = new Vector3(position2.x-0.12f, position2.y, position2.z+0.08f);

}

// protected override void OnTrackingLost()
// {
//   base.OnTrackingLost ();
//   //put logic here
// }

}
