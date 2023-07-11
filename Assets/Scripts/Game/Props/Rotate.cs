using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField] private float rotateSpeed = .5f;

        private bool canRotate = true;
        private readonly List<Vector3> directions = new() {Vector3.up, Vector3.down};
        private void OnMouseDown()
        {
            if (!canRotate)
                return;
            StartCoroutine(RotateObject());
        }

        private IEnumerator RotateObject()
        {
            canRotate = false;
            var direction = directions[Random.Range(0, directions.Count)] ;
            transform.DORotate(direction * 360, rotateSpeed, RotateMode.FastBeyond360);
        
            yield return new WaitForSeconds(rotateSpeed);
            canRotate = true;
        }
    }
}