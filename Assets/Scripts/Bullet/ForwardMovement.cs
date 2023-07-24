using UnityEngine;

namespace Bullet
{
    public class ForwardMovement : MonoBehaviour
    {
        public float speed;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}