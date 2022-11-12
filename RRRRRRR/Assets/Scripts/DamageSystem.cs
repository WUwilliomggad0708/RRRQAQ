using UnityEngine;

namespace xin
{ 
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱爆炸")]
        private string nameTarget;


    }
}
