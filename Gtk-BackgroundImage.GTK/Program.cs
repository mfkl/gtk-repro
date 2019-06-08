using System;
using Xamarin.Forms.Platform.GTK;

namespace Gtk_BackgroundImage.GTK
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            global::Gtk.Application.Init();
            
            global::Xamarin.Forms.Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("GTK# sample");
            window.Show();

            global::Gtk.Application.Run();
        }
    }
}
