   M S B A M L   `   `   `  ����J  FTextXAMLProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TextXAMLProject.ViewTextXAMLProject.View  5      4    .TextXAMLProject.View.EngineeringCalculatorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:TextXAMLProject.View     5      .��5      �   � ColumnDefinitions  5	   
   �� 5
      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��1��6   $��0��6   $��5��6,   .+�5      �� $��0��6   $��20, 20, 20, 0q�6(    �� TextAlignment$ Right=�6_   ��6?   �� *LastOutputText+6_   5       � 5!   
   $��2��6   $��0��6   $��5��6,   .+�5"      �� $��0��6   $��20, 0, 20, 0q�6(   
�������$ Right=�6k   $��35(�6�   ��6U   �� *Text+6�   5#      � 5%   
   $��0��6   $��4��6   $��4��6,   .+�5&      � $��0��6    � IsSharedSizeScope .   5'      �� 5(      �� 5)      �� 5*      �� 5+      .+�5-      �� $��0��6   $
��2^nd��6)   $��Stretch=�68   ��6V   �� *ProcentButton+�� 5.      $��1��6   $��Pi��6)   $��Stretch=�66   ��6T   �� *	CECommand+�� 5/      $��2��6   $��e��6)   $��Stretch=�65   ��6S   �� *
CCommand+�� 50      $��3��6   $��C��6)   $��Stretch=�65   ��6S   �� *
CCommand+51      52      � 53   
   $��0��6   $��5��6   $��4��6,   .+�54      � $��0��6    .   55      �� 56      �� 57      �� 58      �� 59      .+�5;      �� $��0��6   $	��x^2��6)   $��Stretch=�67   ��6U   �� *OneDelXCommand+�� 5<      $��1��6   $	��1/x��6)   $��Stretch=�67   ��6U   �� *DegreeCommand+�� 5=      $��2��6   $	��|x|��6)   $��Stretch=�67   ��6U   �� *SqrtCommand+�� 5>      $��3��6   $	��exp��6)   $��Stretch=�67   ��6U   �� *SqrtCommand+5?      5@      � 5A   
   $��0��6   $��6��6   $��4��6,   .+�5B      � $��0��6    .   5C      �� 5D      �� 5E      �� 5F      �� 5G      .+�5I      �� $��0��6   $
��√x��6)   $��Stretch=�66   ��6T   �� *OneDelXCommand+�� 5J      $��1��6   $��(��6)   $��Stretch=�65   ��6S   �� *DegreeCommand+�� 5K      $��2��6   $��)��6)   $��Stretch=�65   ��6S   �� *SqrtCommand+�� 5L      $��3��6   $��n!��6)   $��Stretch=�66   ��6T   �� *SqrtCommand+5M      5N      � 5O   
   $��4��6   $��4��6   $��7��6,   .+�5P      � $��0��6    .  5Q      �� 5R      �� 5S      �� 5T      �� 5U      �� 5V      �� 5W      �� 5X      .+�5Z      �� $��0��6   $	��Del��6&   $��Stretch=�64   ��6R   �� *
DelCommand+�� 5[      $��1��6   $	��mod��6&   $��Stretch=�64   ��6R   �� *
DelCommand+�� 5\      $��2��6   $��/��6&   $��Stretch=�62   ��6P   �� *DivisionCommand+�� 5]      $��3��6   $��*��6&   $��Stretch=�62   ��6P   �� *MultiplicationCommand+�� 5^      $��4��6   $��-��6&   $��Stretch=�62   ��6P   �� *SubtractionCommand+�� 5_      $��5��6   $��+��6&   $��Stretch=�62   ��6P   �� *
SumCommand+�� 5`      $��6��6   $��=��6&   $��Stretch=�62   
����ح���6g   �� *EquallyCommand+5a      5b      � 5c   
   $��0��6   $��7��6   $��7��6,   .+�5d      � $��0��6    .  5e      �� 5f      �� 5g      �� 5h      �� 5i      .+�5k      �� $��0��6   $	��x^y��6&   $��Stretch=�64   ��6R   �� *
DelCommand+�� 5l      $��1��6   $
��10^x��6&   $��Stretch=�65   ��6S   �� *
DelCommand+�� 5m      $��2��6   $	��log��6&   $��Stretch=�64   ��6R   �� *DivisionCommand+�� 5n      $��3��6   $��ln��6&   $��Stretch=�63   ��6Q   �� *MultiplicationCommand+5o      5p      � 5q   
   $��1��6   $��7��6   $��3��6,   $��4��6@    5r      �� 5s      �� 5t      �� 5u      �� 5v      .+�5x      � $��0��6    .   5y      �� 5z      �� 5{      �� 5|      .+�5~      �� $��0��6   $��1��6)   $��Stretch=�65   
���������6k   �� *Num1Command+�� 5      $��1��6   $��2��6)   $��Stretch=�65   
���������6l   �� *Num2Command+�� 5�      $��2��6   $��3��6)   $��Stretch=�65   
���������6l   �� *Num3Command+5�      � 5�      $��1��6    .   5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��4��6)   $��Stretch=�65   
���������6k   �� *Num4Command+�� 5�      $��1��6   $��5��6)   $��Stretch=�65   
���������6k   �� *Num5Command+�� 5�      $��2��6   $��6��6)   $��Stretch=�65   
���������6k   �� *Num6Command+5�      � 5�      $��2��6    .   5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��7��6)   $��Stretch=�65   
���������6k   �� *Num7Command+�� 5�      $��1��6   $��8��6)   $��Stretch=�65   
���������6k   �� *Num8Command+�� 5�      $��2��6   $��9��6)   $��Stretch=�65   
���������6k   �� *Num9Command+5�      � 5�      $��3��6    .   5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $	��+/-��6)   $��Stretch=�67   
���������6m   �� *PlusMinusCommand+�� 5�      $��1��6   $��0��6)   $��Stretch=�65   
���������6k   �� *Num0Command+�� 5�      $��2��6   $��,��6)   $��Stretch=�65   
���������6k   �� *CommCommand+5�      5�      5�      5�      