﻿using UnityEngine;
using UnityEngine.UI;

namespace FM{
    public class CarouselItem : MonoBehaviour {

        private Canvas canvas;

        private float maxScale;
        private float minScale;

        private float rightLimit;
        private float scaleDiff;
        private float scaleRatio;

        CarouselView carouselView;
        RectTransform carouselViewT;
        RectTransform rectT;

        private float selectionMargin = 50f;

        void Start(){
            canvas = GameObject.FindObjectOfType<CarouselView>().parentCanvas;

            maxScale = GameObject.FindObjectOfType<CarouselView>().maxScale;
            minScale = GameObject.FindObjectOfType<CarouselView>().minScale;

            carouselViewT = transform.parent.parent.parent.GetComponent<RectTransform>();
            carouselView = carouselViewT.GetComponent<CarouselView>();
            rectT = GetComponent<RectTransform>();

            System.Action InitValues = () => {
                selectionMargin = (rectT.sizeDelta.x / 2f) * canvas.GetComponent<RectTransform>().localScale.x; ;

                rightLimit = (carouselViewT.rect.width * canvas.GetComponent<RectTransform>().localScale.x) / 2f;
                scaleDiff = maxScale - minScale;
                scaleRatio = scaleDiff / rightLimit;
            };

            InitValues();
        }

        void OnGUI(){
            Vector2 myPos = rectT.position - carouselViewT.position;
            float scaleFactor = (rightLimit - Mathf.Abs(myPos.x)) * scaleRatio;
            rectT.localScale = new Vector3(minScale + scaleFactor, minScale + scaleFactor, 1f);

            if(myPos.x >= -selectionMargin && myPos.x <= selectionMargin){
                carouselView.selectedIndex = transform.GetSiblingIndex();
                carouselView.selectedItem = transform;
            }
        }

    }
}

