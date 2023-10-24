using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurves : MonoBehaviour
{
    public Transform Point0;
    public Transform Point1;
    public Transform Point2;
    public Transform Point3;

    public LineRenderer lineRenderer;
    private int numPoints=50;
    private Vector3[] positions=new Vector3[50];

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.positionCount=numPoints;
        Point1.transform.position = new Vector3((Point0.transform.position.x+Point3.transform.position.x)/2, Point0.transform.position.y, (Point0.transform.position.z + Point3.transform.position.z) / 2);
        Point2.transform.position = new Vector3((Point0.transform.position.x+Point3.transform.position.x)/2, Point3.transform.position.y, (Point0.transform.position.z + Point3.transform.position.z) / 2);
        for (int i=1;i<numPoints+1;i++){
            float t=i/(float)numPoints;
            positions[i-1]=CalculateCubic(t,Point0.position, Point1.position,Point2.position,Point3.position);
        }
        lineRenderer.SetPositions(positions);

    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.positionCount=numPoints;
        Point1.transform.position = new Vector3((Point0.transform.position.x+Point3.transform.position.x)/2, Point0.transform.position.y, (Point0.transform.position.z + Point3.transform.position.z) / 2);
        Point2.transform.position = new Vector3((Point0.transform.position.x+Point3.transform.position.x)/2, Point3.transform.position.y, (Point0.transform.position.z + Point3.transform.position.z) / 2);
        for (int i=1;i<numPoints+1;i++){
            float t=i/(float)numPoints;
            positions[i-1]=CalculateCubic(t,Point0.position, Point1.position,Point2.position,Point3.position);
        }
        lineRenderer.SetPositions(positions);

    }

private Vector3 CalculateCubic(float t, Vector3 p0,Vector3 p1,Vector3 p2,Vector3 p3 ){
    float u=1-t;
    float tt=t*t;
    float uu=u*u;
    float uuu=uu*u;
    float ttt=tt*t;
    Vector3 p=uuu*p0;
    p+=3*uu*t*p1;
    p+=3*u*tt*p2;
    p+=ttt*p3;
    return p;
}

}