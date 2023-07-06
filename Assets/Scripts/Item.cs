using UnityEngine;

namespace Scripts
{
    public class Item : MonoBehaviour
    {
        private Renderer _renderer;

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
        }

        public void SetColor()
        {
            _renderer.material.color = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
        }
    }
}