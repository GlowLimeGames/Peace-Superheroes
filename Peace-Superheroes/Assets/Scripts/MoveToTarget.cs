using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

public class MoveToTarget : MonoBehaviour {

    public Transform target;
    public float speed = 1.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
	}

    public void ChangeTarget(Transform newtransform)
    {
        Assert.IsNotNull(newtransform, "Cannot change target to a null transform");

        target = newtransform;
    }
}
