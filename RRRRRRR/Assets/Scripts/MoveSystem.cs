using UnityEngine;

namespace XIN
{
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-25, 0)]
        private float speed = -10.5f;

        private void Update()
        {
            transform.Translate(0,speed * Time.deltaTime, 0);
        }

    }

      
}
