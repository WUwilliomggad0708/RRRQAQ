using UnityEngine;

namespace xin
{ 
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField,Header("�l�u�w�m��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

            private void SpawnBullet()
            {
                //�l�u�w�m�� �y�� ���׻P�ͦ��I�ۦP
                Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
            }






    }
}
