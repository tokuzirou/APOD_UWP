using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace APOD_UWP
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //リクエスト先
        const string EndpointURL = "https://api.nasa.gov/planetary/apod";
        //Nasaのプロジェクト開始日
        DateTime launchDate = new DateTime(1995, 6, 15);
        //ダウンロード数
        int imageCount;

        public MainPage()
        {
            this.InitializeComponent();
            MonthCalender.MinDate = launchDate;
            MonthCalender.MaxDate = DateTime.Today;
        }

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            LimitRangeChackBox.IsChecked = false;
            MonthCalender.Date = launchDate;
        }
    }
}
