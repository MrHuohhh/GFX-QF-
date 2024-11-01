using System;
using QFramework;
using UnityEngine;
using Log = UnityGameFramework.Runtime.Log;
    public class BirdEntity: SampleEntity
    {
        private Rigidbody2D mRigidBody2D;
        private SpriteRenderer mSpriteRenderer;
        private bool mStart = false;
        public bool StartGame
        {
            get => mStart;
            set
            {
                mStart = value;
                //设置启用mRigidBody2D
                mRigidBody2D.isKinematic = !value;
            }
        }
        
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            mRigidBody2D = GetComponent<Rigidbody2D>();
            mRigidBody2D.isKinematic = false;
            mSpriteRenderer = GetComponent<SpriteRenderer>();
        }
        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
          if (Input.GetMouseButton(0))
          {
              mRigidBody2D.velocity = Vector2.up * 8;
          }

          if (!mSpriteRenderer.isVisible && mStart)
          {
              Log.Error(">>>>>>>>>>>>>>game over");
          }
        }
    }
