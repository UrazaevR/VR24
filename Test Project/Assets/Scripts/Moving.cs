using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Moving : MonoBehaviour
    {
        public GameObject Camera = null;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            int mn = 1;
            Vector3 vector = new Vector3(0, 0, 0);

            if (Input.GetKey(KeyCode.LeftShift)){
                mn = 2;
            }
            if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
            {
                vector.x -= (float)0.1 * mn;
            }
            if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
            {
                vector.x += (float)0.1 * mn;
            }
            if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W))
            {
                vector.z += (float)0.1 * mn;
            }
            if (Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S))
            {
                vector.z -= (float)0.1 * mn;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                vector.y += (float)0.1 * mn;
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                vector.y -= (float)0.1 * mn;
            }
            this.gameObject.transform.Translate(vector);
            if (Camera != this) {
                if (vector.y == 0)
                {
                    float y = Camera.transform.position.y;
                    Camera.transform.Translate(vector);
                    y -= Camera.transform.position.y;
                    vector = new Vector3(0, y, 0);
                    Camera.transform.Translate(vector);
                }
                else
                {
                    Camera.transform.Translate(vector);
                }
                if (Input.GetKey(KeyCode.Minus))
                {
                    Camera.transform.Translate(new Vector3(0, 0, (float)-0.1));
                }
                if (Input.GetKey(KeyCode.Equals))
                {
                    Camera.transform.Translate(new Vector3(0, 0, (float)0.1));
                }
                
            }
            
        }
    }
}