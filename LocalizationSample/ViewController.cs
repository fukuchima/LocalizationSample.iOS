using Foundation;
using System;

using UIKit;

namespace LocalizationSample
{
    public partial class ViewController : UIViewController
    {
        // タッチ回数をカウントする変数
        int count = 0;
        // タッチ回数を表示するためのメッセージをLocalizable.stringsから取得
        string msgstring = NSBundle.MainBundle.LocalizedString("message", "optional");

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // 起動時にCultureInfoを取得して表示
            cultureText.Text += System.Globalization.CultureInfo.CurrentCulture.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }


        // ボタンをタッチしたタイミングで発生
        partial void BtnTouch_TouchUpInside(UIButton sender)
        {
            // タッチ回数をラベルに表示
            count += 1;            
            msgLabel.Text = String.Format(msgstring, count.ToString());
        }
    }
}