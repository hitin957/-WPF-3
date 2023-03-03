using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа__3_аудиоплеер
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        MediaPlayer player =new MediaPlayer();
        string filename;
        private void Button_Click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,//отвечает за выделение области
                DefaultExt = ".mp3"
            };
            bool? dialogOK = openFileDialog.ShowDialog();
            if (dialogOK==true)
            {
                filename=openFileDialog.FileName;
                TBFileName.Text = openFileDialog.SafeFileName;
                player.Open(new Uri(filename));
            }
        }

        private void Button_Click_Play(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void Button_Click_Pause(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_preview_Click(object sender, RoutedEventArgs e)
        {

        }

        private void audioSlider_ValueChanger(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
