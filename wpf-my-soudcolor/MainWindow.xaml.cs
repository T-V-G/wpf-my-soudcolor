using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_my_soudcolor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer player = new MediaPlayer();
        Ellipse el = new Ellipse();
        Line line = new Line();
        Rectangle rect = new Rectangle();
        Polygon triangle = new Polygon();
        Rectangle triangleRect = new Rectangle();


        bool SPuase = true;
        
        //Path trianglePath = new Path();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_MouseDownCard(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
      

        private void startSong_Click(object sender, RoutedEventArgs e)
        {

            if (comboBoxVoice.SelectedIndex == 0)
            {
                if (SPuase)
                {
                    player.Open(new Uri("../../Resources/Rosemary.wav", UriKind.Relative));
                    player.Play();
                    SPuase = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    SPuase = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }
              
            }
            else if (comboBoxVoice.SelectedIndex == 1)
            {
                if (SPuase)
                {
                    player.Open(new Uri("../../Resources/Be Quiet and Drive.wav", UriKind.Relative));
                    player.Play();
                    SPuase = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    SPuase = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 2)
            {
                if (SPuase)
                {
                    player.Open(new Uri("../../Resources/DVRST.wav", UriKind.Relative));
                    player.Play();
                    SPuase = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    SPuase = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 3)
            {
                if (SPuase)
                {
                    player.Open(new Uri("../../Resources/WARNING - MC ORSEN .wav", UriKind.Relative));
                    player.Play();
                    SPuase = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    SPuase = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
            else if (comboBoxVoice.SelectedIndex == 4)
            {
                if (SPuase)
                {
                    player.Open(new Uri("../../Resources/zetuv.wav", UriKind.Relative));
                    player.Play();
                    SPuase = false;
                    startSong.Content = "Stop";
                    comboBoxVoice.IsEnabled = false;
                }
                else
                {
                    player.Pause();
                    SPuase = true;
                    startSong.Content = "Start";
                    comboBoxVoice.IsEnabled = true;
                }

            }
        }


        private void speedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.SpeedRatio = (double)speedSlider.Value;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.Volume = e.NewValue;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShapeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButtonShape = sender as RadioButton;
            string shapeName = radioButtonShape.Tag.ToString();
            switch (shapeName)
            {
                case "line":
                    Line();
                    break;
                case "circle":
                    Circle();
                    break;
                case "square":
                    Square();                    
                    break;
            }
        }

        private void ColorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButtonCol = sender as RadioButton;

            if (radioButtonCol != null)
            {
                string colorName = radioButtonCol.Tag.ToString();
                ColorBrush(colorName);
            }
        }

        private void ColorBrush(string colorName)
        {
            switch (colorName)
            {
                case "black":
                    el.Fill = Brushes.Black;
                    el.Stroke = Brushes.Gray;
                    line.Stroke = Brushes.Black;
                    rect.Fill = Brushes.Black;
                    rect.Stroke = Brushes.Gray;
                    triangle.Stroke = Brushes.Gray;
                    triangle.Fill = Brushes.Black;
                    triangleRect.Stroke = Brushes.Gray;
                    triangleRect.Fill = Brushes.Black;
                    break;
                case "blue":
                    el.Fill = Brushes.Blue;
                    //el.Stroke = Brushes.Blue;
                    line.Stroke = Brushes.Blue;
                    rect.Fill = Brushes.Blue;
                    //rect.Stroke = Brushes.Blue;
                    //triangle.Stroke = Brushes.Blue;
                    triangle.Fill = Brushes.Blue;
                    triangleRect.Fill = Brushes.Blue;
                    break;
                case "green":
                    el.Fill = Brushes.Green;
                    line.Stroke = Brushes.Green;
                    rect.Fill = Brushes.Green;
                    //triangle.Stroke = Brushes.Green;
                    triangle.Fill = Brushes.Green;
                    triangleRect.Fill = Brushes.Green;
                    break;
                case "cyan":
                    el.Fill = Brushes.Cyan;
                    line.Stroke = Brushes.Cyan;
                    rect.Fill = Brushes.Cyan;
                    //triangle.Stroke = Brushes.Cyan;
                    triangle.Fill = Brushes.Cyan;
                    triangleRect.Fill = Brushes.Cyan;
                    break;
                case "red":
                    el.Fill = Brushes.Red;
                    line.Stroke = Brushes.Red;
                    rect.Fill = Brushes.Red;
                    //triangle.Stroke = Brushes.Red;
                    triangle.Fill = Brushes.Red;
                    triangleRect.Fill = Brushes.Red;
                    break;
                case "magenta":
                    el.Fill = Brushes.Magenta;
                    line.Stroke = Brushes.Magenta;
                    rect.Fill = Brushes.Magenta;
                    //triangle.Stroke = Brushes.Magenta;
                    triangle.Fill = Brushes.Magenta;
                    triangleRect.Fill = Brushes.Magenta;
                    break;
                case "yellow":
                    el.Fill = Brushes.Yellow;
                    line.Stroke = Brushes.Yellow;
                    rect.Fill = Brushes.Yellow;
                    //triangle.Stroke = Brushes.Yellow;
                    triangle.Fill = Brushes.Yellow;
                    triangleRect.Fill = Brushes.Yellow;
                    break;
                case "white":
                    el.Fill = Brushes.White;
                    line.Stroke = Brushes.White;
                    rect.Fill = Brushes.White;
                    //triangle.Stroke = Brushes.White;
                    triangle.Fill = Brushes.White;
                    triangleRect.Fill = Brushes.White;
                    break;
            }
        }

        private void rFigure_Checked(object sender, RoutedEventArgs e)
        {
            Figure();
        }

        private void rFigure_Unchecked(object sender, RoutedEventArgs e)
        {
            DrawingGroup.IsEnabled = true;
        }

        private void Line()
        {
            drawCanvas.Children.Clear();
            //drawCanvas.Children.Remove(trianglePath);
            //drawCanvas.Children.Remove(rect);
            //drawCanvas.Children.Remove(el);
            if (rPen.IsChecked == true)
            {
                drawCanvas.Children.Clear();
                //drawCanvas.Children.Remove(trianglePath);
                //drawCanvas.Children.Remove(line);
                line.X1 = 10;
                line.Y1 = 150;
                line.X2 = 10;
                line.Y2 = 10;
                line.VerticalAlignment = VerticalAlignment.Center;
                line.HorizontalAlignment = HorizontalAlignment.Center;
                line.StrokeThickness = 2;
                drawCanvas.Children.Add(line);
            }
            else if (rBrush.IsChecked == true)
            {
                drawCanvas.Children.Clear();
                //drawCanvas.Children.Remove(trianglePath);
                //drawCanvas.Children.Remove(line);
                line.X1 = 10;
                line.Y1 = 150;
                line.X2 = 10;
                line.Y2 = 10;
                line.VerticalAlignment = VerticalAlignment.Center;
                line.HorizontalAlignment = HorizontalAlignment.Center;
                line.StrokeThickness = 6;
                drawCanvas.Children.Add(line);
            }
        }

        private void Circle()
        {
            drawCanvas.Children.Clear();
            //drawCanvas.Children.Remove(line);
            //drawCanvas.Children.Remove(rect);
            //drawCanvas.Children.Remove(trianglePath);
            //el.Stroke = Brushes.Black;
            el.Width = 100;
            el.Height = 100;
            el.VerticalAlignment = VerticalAlignment.Center;
            el.HorizontalAlignment = HorizontalAlignment.Center;
            el.StrokeThickness = 2;
            drawCanvas.Children.Add(el);
        }

        private void Square()
        {
            drawCanvas.Children.Clear();
            //drawCanvas.Children.Remove(line);
            //drawCanvas.Children.Remove(el);
            //drawCanvas.Children.Remove(trianglePath);
            //rect.Stroke = Brushes.Black;
            rect.Width = 100;
            rect.Height = 100;
            rect.VerticalAlignment = VerticalAlignment.Center;
            rect.HorizontalAlignment = HorizontalAlignment.Center;
            rect.StrokeThickness = 2;
            drawCanvas.Children.Add(rect);
        }

        private void Figure()
        {
            DrawingGroup.IsEnabled = false;
            drawCanvas.Children.Clear();
            // trianglePath.Stretch = Stretch.Fill;
            // trianglePath.StrokeLineJoin = PenLineJoin.Round;
            // Thickness t = new Thickness();
            // //t.Left = 231;
            // //t.Top = 112;
            // //t.Right = 232;
            // //t.Bottom = 119;
            // t.Left = 150;
            // t.Top = 90;
            // t.Right = 150;
            // t.Bottom = 90;


            // var converter = TypeDescriptor.GetConverter(typeof(Geometry));
            // //string pathData = "m 50,0 l 50,50 -100,0 z  M 100,50 L 200,20  M 50,0 L 160,-28 m 0,0 l 40,50 ";
            // //string pathData = "m 50,0 l 50,50 -100,0 z  M 100,50 L 218,29  M 50,0 L 160,-20 m 0,0 l 59,49 ";

            // string pathData = "M 0,0 L 50,0 L 50,-25 z  ";
            // //string pathData = "m 50,0 l 50,50 -100,0 z  ";
            // trianglePath.Data = (Geometry)converter.ConvertFrom(pathData);
            //trianglePath.Margin = t;
            // //trianglePath.Stretch = Stretch.Fill;
            // // drawCanvas.Children.Remove(line);
            // //drawCanvas.Children.Remove(el);
            // //drawCanvas.Children.Remove(rect);
            // //drawCanvas.Children.Remove(trianglePath);
            // drawCanvas.Children.Add(trianglePath);


            //triangle.Fill = Brushes.White;
            PointCollection points = new PointCollection()
            {
                new Point(195,152),
                new Point(236,105),
                new Point(283,152),
            };
            //triangle.VerticalAlignment = VerticalAlignment.Center;
            //triangle.HorizontalAlignment = HorizontalAlignment.Center;
            triangle.StrokeThickness = 2;
            triangle.Points = points;
            drawCanvas.Children.Add(triangle);

            triangleRect.Width = 100;
            triangleRect.Height = 50;
            triangleRect.VerticalAlignment = VerticalAlignment.Center;
            triangleRect.HorizontalAlignment = HorizontalAlignment.Center;
            triangleRect.StrokeThickness = 2;
            SkewTransform angleX = new SkewTransform(45, -20);
            triangleRect.RenderTransform = angleX;
            drawCanvas.Children.Add(triangleRect);
        }


    }
}