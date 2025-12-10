using Microsoft.Maui;
using System.Drawing;

#if IOS
using UIKit;
using Foundation;
#endif

#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

namespace APP_RESTAURANTE.Handlers
{
    public static class FormHandler
    {

        public static void RemoveBorders()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                var textBox = handler.PlatformView;

                // Quitar borde
                textBox.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);

                // Fondo transparente
                textBox.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(
                    Microsoft.UI.Colors.Transparent
                );

                // Sin esquina redondeada
                textBox.CornerRadius = new Microsoft.UI.Xaml.CornerRadius(0);

                // Evitar borde al enfocar
                textBox.Style = new Microsoft.UI.Xaml.Style(typeof(Microsoft.UI.Xaml.Controls.TextBox))
                {
                    Setters =
                {
                    new Microsoft.UI.Xaml.Setter(
                        Microsoft.UI.Xaml.Controls.Control.BorderThicknessProperty,
                        new Microsoft.UI.Xaml.Thickness(0)
                    ),
                    new Microsoft.UI.Xaml.Setter(
                        Microsoft.UI.Xaml.Controls.Control.BackgroundProperty,
                        new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent)
                    ),
                    new Microsoft.UI.Xaml.Setter(
                        Microsoft.UI.Xaml.Controls.Control.ForegroundProperty,
                        new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Black)
                    )
                }
                };
#endif
            });

            Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
            handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
            handler.PlatformView.BorderBrush = null;
            handler.PlatformView.Background = null;
            handler.PlatformView.CornerRadius = new Microsoft.UI.Xaml.CornerRadius(0);
#endif
            });
        }


    }
}