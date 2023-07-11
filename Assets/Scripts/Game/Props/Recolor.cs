using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

namespace Game
{
    public class Recolor : MonoBehaviour
    {
        [SerializeField] private float recolorSpeed = .5f;
        [SerializeField] private Ease recolorEase = Ease.OutCirc;
    
        private MeshRenderer mesh;

        private void Start()
        {
            mesh = GetComponent<MeshRenderer>();
            ChangeRandomColor();
        }

        private void OnMouseDown()
        {
            ChangeRandomColor();
        }

        private void ChangeRandomColor()
        {
            var color = Random.ColorHSV(0, 1, .5f, .7f, 1, 1);
            mesh.material.DOColor(color, recolorSpeed).SetEase(recolorEase);
        }
    }
}