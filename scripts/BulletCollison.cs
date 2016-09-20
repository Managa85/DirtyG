using UnityEngine;
using System.Collections;
/*
 * destroy bullet itself on hit
 * damage hit target if it is tagged "Destroyable"
 * bullet has to be trigger
 * attach this to bullets 
 */
public class BulletCollison : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Destroyable"))
        {
            Debug.Log(other.gameObject.name);
            Destroy(gameObject);
            Destroy(other.gameObject);//TODO: modify to damage()
        }
    }
}
