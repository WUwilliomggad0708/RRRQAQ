using UnityEngine;

namespace xin
{ 
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱爆炸")]
        private string nameTarget;

        private void OnCollisionEnter2D(Collision collision)
        {
            print(collision.gameObject.name);
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }


        }
        private void OnCollisionExit2D(Collision collision)
        {

        }
        private void OnCollisionStay2D(Collision collision)
        {

        }

    }
}
