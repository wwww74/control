using System.Windows.Controls;
using System.Windows;

namespace TextXAMLProject.Base
{
    public static class ItemIndexHelper
    {
        public static readonly DependencyProperty ItemIndexProperty =
            DependencyProperty.RegisterAttached(
                "ItemIndex",
                typeof(int),
                typeof(ItemIndexHelper),
                new FrameworkPropertyMetadata(-1, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetItemIndex(UIElement element, int value)
        {
            element.SetValue(ItemIndexProperty, value);
        }

        public static int GetItemIndex(UIElement element)
        {
            return (int)element.GetValue(ItemIndexProperty);
        }
        public static void UpdateItemIndex(ItemsControl itemsControl)
        {
            if (itemsControl == null) return;

            foreach (var item in itemsControl.Items)
            {
                var container = itemsControl.ItemContainerGenerator.ContainerFromItem(item) as FrameworkElement;
                if (container != null)
                {
                    int index = itemsControl.Items.IndexOf(item);
                    SetItemIndex(container, index);
                }
            }
        }
    }
}
