#pragma warning disable IDE1006 // ???????
using GameFramework;
using UnityEngine;
using UnityGameFramework.Runtime;

public class EntityParams : RefParams
{
    public Vector3? position { get; set; } = null;
    public Vector3? localPosition { get; set; } = null;
    public Vector3? localEulerAngles { get; set; } = null;
    public Vector3? eulerAngles { get; set; } = null;

    public Vector3? localScale { get; set; } = null;
    public int gameObjectLayer { get; set; } = -1;

    /// <summary>
    /// ????????
    /// </summary>
    public Entity AttchToEntity { get; set; } = null;
    /// <summary>
    /// ????????????????????
    /// </summary>
    public Transform ParentTransform { get; set; } = null;

    /// <summary>
    /// ??????????
    /// </summary>
    public GameFrameworkAction<EntityLogic> OnShowCallback { get; set; } = null;

    /// <summary>
    /// ???????????
    /// </summary>
    public GameFrameworkAction<EntityLogic> OnHideCallback { get; set; } = null;

    /// <summary>
    /// ??????????(?????????????)
    /// </summary>
    /// <param name="position"></param>
    /// <param name="eulerAngles"></param>
    /// <param name="localScale"></param>
    /// <returns></returns>
    public static EntityParams Create(Vector3? position = null, Vector3? eulerAngles = null, Vector3? localScale = null)
    {
        var eParams = ReferencePool.Acquire<EntityParams>();
        eParams.CreateRoot();
        eParams.position = position;
        eParams.eulerAngles = eulerAngles;
        eParams.localScale = localScale;
        return eParams;
    }
    protected override void ResetProperties()
    {
        base.ResetProperties();
        this.position = null;
        this.localPosition = null;
        this.eulerAngles = null;
        this.localEulerAngles = null;
        this.localScale = null;
        this.gameObjectLayer = -1;
        this.AttchToEntity = null;
        this.ParentTransform = null;
        OnShowCallback = null;
        OnHideCallback = null;
    }
}
#pragma warning restore IDE1006 // ???????
