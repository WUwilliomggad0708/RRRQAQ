using UnityEngine;

namespace xin
{ 
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField,Header("子彈預置物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

            protected void SpawnBullet()
            {
                //子彈預置物 座標 角度與生成點相同
                Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
            }






    }
}
