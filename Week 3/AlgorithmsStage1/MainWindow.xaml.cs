using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlgorithmsStage1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Movement flags   
        bool testFlag1X = true;
        bool testFlag1Y = true;
        #endregion

        #region Key Pressed Flags
        bool flagA = false;
        bool flagD = false;
        bool flagW = false;
        bool flagS = false;
        #endregion

        #region Object location
        double leftMargin;
        double topMargin;
        double rightMargin;
        double bottomMargin;
        #endregion

        #region Random Number

        // Add code here

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            #region Random Number

            // Add code here

            #endregion

            // Set game loop timer
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(10000); // 10000 ticks = 1 milisecond
            dispatcherTimer.Start();

        }

        /// <summary>
        /// Our time event that fires the movement
        /// </summary>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            #region Move using a key press

            leftMargin = testImage1.Margin.Left;
            topMargin = testImage1.Margin.Top;
            rightMargin = testImage1.Margin.Right;
            bottomMargin = testImage1.Margin.Bottom;

            if (flagA == true)  leftMargin = leftMargin - 5.00;
            if (flagD == true)  leftMargin = leftMargin + 5.0;
            if (flagW == true)  topMargin = topMargin - 5.00;
            if (flagS == true)  topMargin = topMargin + 5.00;

            testImage1.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);


            #endregion

            #region Lock_To_Grid
            // Add code here
           
            #endregion

            #region Move_Lock_To_Grid

            // Add code here

            if (testFlag1X == true) leftMargin = leftMargin - 2;
            // if the object has passed the right edge of the grid stop it
            if ((leftMargin + testImage1.Width) > TestGrid.Width)
            {
                leftMargin = TestGrid.Width - testImage1.Width;
                testFlag1X = true;
            }

            #endregion

            #region Follow

            // Add code here

            #endregion

            #region Runaway

            // Add code here

            #endregion

            #region Collide

            // Add code here

            #endregion

            #region Random Number

            // Add code here

            #endregion

        }


        /// <summary>
        /// Resizes the grid to the screen size
        /// </summary>
        private void TestWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            TestGrid.Width = TestWindow.Width - 30;
            TestGrid.Height = TestWindow.Height - 50;
        }

        #region Key Pressed test

        private void TestWindow_KeyDown(object sender, KeyEventArgs e)
        {

            flagA = false;
            flagD = false;
            flagW = false;
            flagS = false;

            if (e.Key == Key.A) flagA = true;
            if (e.Key == Key.D) flagD = true;
            if (e.Key == Key.W) flagW = true;
            if (e.Key == Key.S) flagS = true;
        }

        #endregion
    }
}
