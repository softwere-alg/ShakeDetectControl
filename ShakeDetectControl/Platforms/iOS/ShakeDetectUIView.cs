using UIKit;

namespace ShakeDetectControl;

public class ShakeDetectUIView : UIView
{
    /// <summary>
    /// シェイク検知時に発生するイベントを定義します。
    /// </summary>
    public event EventHandler? OnDetectShake;

    /// <summary>
    /// このオブジェクトがファースト レスポンダになれるようにします。
    /// </summary>
    public override bool CanBecomeFirstResponder => true;

    public ShakeDetectUIView()
    {
        // このオブジェクトをファースト レスポンダにする
        BecomeFirstResponder();
    }


    /// <summary>
    /// モーション イベントが終了したこと際に発生します。
    /// </summary>
    /// <param name="motion"></param>
    /// <param name="evt"></param>
    public override void MotionEnded(UIEventSubtype motion, UIEvent? evt)
    {
        base.MotionEnded(motion, evt);

        // シェイクの場合イベントを発行
        if (motion == UIEventSubtype.MotionShake)
        {
            OnDetectShake?.Invoke(this, new EventArgs());
        }
    }
}
