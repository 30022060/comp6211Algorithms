using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Include for the image and grid objects
using System.Windows;
using System.Windows.Controls;

namespace AlgorithmsStage3
{
    public static class Utils
    {
        #region Move using a key press
        /// <summary>
        /// Move an Image
        /// </summary>
        public static void Move(Image anImage, bool left, bool right, bool top, bool bottom, double speed)
        {
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;


            if (left == true) leftMargin = leftMargin - speed;
            if (right == true) leftMargin = leftMargin + speed;
            if (top == true) topMargin = topMargin - speed;
            if (bottom == true) topMargin = topMargin + speed;

            anImage.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }
        #endregion

        #region Lock_To_Grid

        // Add code here

        #endregion

        #region Move_Lock_To_Grid

        // Add code here

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



    }
}
