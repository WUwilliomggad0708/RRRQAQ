using UnityEngine;

namespace xin
{
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("子彈生成點"), Range(0, 3)]
        private float interval = 2.5f;
        private void Awake()
        {
            //SpawnBullet(); 單一顆
            InvokeRepeating("SpawnBullet",0,interval);
        }


    }
}


