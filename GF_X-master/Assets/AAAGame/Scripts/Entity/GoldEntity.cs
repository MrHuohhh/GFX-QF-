using UnityEngine;

    public class GoldEntity: SampleEntity
    {
        Transform m_Gold;
        BoxCollider m_Collider;
        
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            m_Gold = GetComponent<Transform>();
            m_Collider = GetComponent<BoxCollider>();
            GF.StaticUI.JoystickEnable = true;
        }
        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
            m_Gold.Rotate(new Vector3(15,30,45)*Time.deltaTime);
        }
        
    }
