using UnityEngine;

namespace xin
{ 
    public class PlayLV : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField] private Sprite pictureUp;
        [SerializeField] private Sprite pictureRight;
        [SerializeField] private Sprite pictureLeft;
        [SerializeField] private Sprite pictureDown;

        [SerializeField, Header("圖片渲染元件")]
        private SpriteRenderer spr;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);
            if (v > 0)
            {
                print("往上");
                spr.sprite = pictureUp;
            }
            if (v < 0)
            {
                print("往下");
                spr.sprite = pictureDown;
            }
            if (v == 0)
            {
                print("中");
                spr.sprite = pictureDown;
            }
            if (h > 0)
            {
                print("往右");
                spr.sprite = pictureRight;
            }
            if (h < 0)
            {
                print("往左");
                spr.sprite = pictureLeft;
            }
            if (h == 0)
            {
                print("間");
                spr.sprite = pictureDown;
            }
        }
    }
}
