using System.Windows.Input;

namespace ShakeDetectControl;

public interface IShakeDetect : IView
{
    /// <summary>
    /// シェイク検知時に呼び出されます。
    /// 内部使用
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnDetectShake(object? sender, EventArgs e);

    /// <summary>
    /// シェイク検知に発生するコマンドを定義します。
    /// </summary>
    public ICommand ShakeDetectCmd { get; set; }

    /// <summary>
    /// シェイク検知時に発生するイベントを定義します。
    /// </summary>
    public event EventHandler? DetectShake;
}

public class ShakeDetect : View, IShakeDetect
{
    #region クラスメソッド
    /// <summary>
    /// シェイク検知コマンド設定プロパティ
    /// </summary>
    public static BindableProperty ShakeDetectCmdProperty = BindableProperty.Create(
        nameof(ShakeDetectCmd),
        typeof(ICommand),
        typeof(ShakeDetect),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay);
    #endregion

    #region プロパティ
    /// <summary>
    /// シェイク検知に発生するコマンドを定義します。
    /// </summary>
    public ICommand ShakeDetectCmd
    {
        get { return (ICommand)GetValue(ShakeDetectCmdProperty); }
        set { SetValue(ShakeDetectCmdProperty, value); }
    }
    #endregion

    #region イベント
    /// <summary>
    /// シェイク検知時に発生するイベントを定義します。
    /// </summary>
    public event EventHandler? DetectShake;
    #endregion
    
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ShakeDetect()
    {
        // タッチなどはこのビューを透過させる
        InputTransparent = true;
    }

    /// <summary>
    /// シェイク検知時に呼び出されます。
    /// 内部使用
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnDetectShake(object? sender, EventArgs e)
    {
        // コマンドとイベントを発行する
        ShakeDetectCmd?.Execute(null);
        DetectShake?.Invoke(this, e);
    }
}
