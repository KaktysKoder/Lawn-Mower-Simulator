using UnityEngine;

public class MyCastomComponent : MonoBehaviour
{
    //private Transform thisTransform = null;

    //private void Start()
    //{
    //    thisTransform = GetComponent<Transform>();
    //}

    private void Update()
    {
        //if (thisTransform != null)
        //{
        //    thisTransform.localPosition += Time.deltaTime * 10.0f * thisTransform.forward;
        //}

        if (transform != null)
        {
            transform.localPosition += Time.deltaTime * 10.0f * transform.forward;
        }
    }
}
