using UnityEngine;

namespace xin
{
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("�l�u�ͦ��I"), Range(0, 3)]
        private float interval = 2.5f;
        private void Awake()
        {
            //SpawnBullet(); ��@��
            InvokeRepeating("SpawnBullet",0,interval);
        }


    }
}


