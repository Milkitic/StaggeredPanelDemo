using System;
using System.Collections.Generic;
using System.Windows;

namespace StaggeredPanelDemo
{
    class ItemLinearContainerCalcStack
    {
        public List<UIElement> Children { get; } = new List<UIElement>();

        Size desired_size = new Size(0, 0);
        public Size DesiredSize => desired_size;

        public void Add(UIElement element)
        {
            Children.Add(element);

            //update DisiredSize
            desired_size.Width = Math.Max(desired_size.Width, element.DesiredSize.Width);
            desired_size.Height += element.DesiredSize.Height;
        }
    }
}