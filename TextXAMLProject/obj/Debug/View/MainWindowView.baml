   M S B A M L   `   `   `  ����J  FTextXAMLProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TextXAMLProjectTextXAMLProject  5   	   G(clr-namespace:TextXAMLProject.ConvertersTextXAMLProject.Converters  5   	   E'clr-namespace:TextXAMLProject.ViewModelTextXAMLProject.ViewModel  5   	   ;"clr-namespace:TextXAMLProject.ViewTextXAMLProject.View  5	   	   $    TextXAMLProject.MainWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TextXAMLProject     5   	   ?
converters(clr-namespace:TextXAMLProject.Converters     5   	   >
viewmodels'clr-namespace:TextXAMLProject.ViewModel     5   	   3view"clr-namespace:TextXAMLProject.View     5	   	     � Title$  Калькулятор��5   	   $	��515��6   $	��285��6-   $	��515��6<   $	��285��6I    � 	Resources 5      :   4TextXAMLProject.Converters.BoolToVisibilityConverter   BoolToVisibilityConverter��%   &	          5   
   6/   5      .��5      � .+�5   
   �  K� ZIndex$ 2��6   .+�5      �� $	��≡��6   $��30��6!   $��30��6-   $��20(�68   $
��Left=�6F   $	��Top=�6a   $��10, 10, 0, 0q�6y   ��6�   �� *ShowMenuCommand+�� 5      $��History��6   $��30��6'   $��50��63   $��Right=�6>   $	��Top=�6Z   $��0, 10, 10, 0q�6r   ��6�   �� *ShowHistoryCommand+5      � 5   
   $ 1��6   y�6    �� *VisibilityPanel+ �� 	Converter# [   � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   
���   � J� Opacity$	 0.8Q�69   �� 5      $��1��6   ���	#FF1D1D1D.+�5      �  5      �� 5      $
��Auto �6(   �� 5       $��* �6(   .+�5"      �� $��0��6   $	��150��6+   $��
0, 5, 0, 0q�68   ���	#FF1D1D1D���	#FF1D1D1D���	#FF3C3C3C��6c   �� *
Operations+��5#      �� 5$      .R�5%   "   �� .+�5&   &   �� 
�������$��15(�6C   ��6Q   ��  �� Path$ 	Operation��� 5'   &   
�������$��20(�6C   ��6Q   �� $ Result�5(   #   5)      5+      �� 5,      $��1��6   $��35��6*   $��25��65   $��Right=�6A   $��0, 10, 10, 10q�6]   $��Clear��6t   ��6�   �� *ClearHistoryCommand+5-      5.      5/      � 50   
   $ 1��6   y�6    �� *VisibilityMenu+# [  .+�51      �� $	��180��6   ���	#FF1D1D1D$
��Left=�6<   .+�52      �  53      �� 54      $
��Auto �6(   �� 55      $��* �6(   .+�57      �� $��0��6   $��Калькулятор��6)   $��16(�6?   ���	#FFC7C7C7$��7, 40, 0, 0q�6d   �� 58      $��1��6   $	��150��6+   $��
5, 5, 5, 0q�68   ���	#FF1D1D1D���	#FF1D1D1D���	#FF3C3C3C$��Disabled=�6�   .@�59      �� $��Обычный��6!   
����������	#FF1D1D1D$��17(�6�   ���	#FF1D1D1D��63   �� *OpenStandartCalcCommand+6�   �� 5:      $��Инженерный��6!   
����������	#FF1D1D1D$��17(�6�   ���	#FF1D1D1D��66   �� *OpenEngCalcCommand+6�   �� 5;      $��Карусель��6!   
����������	#FF1D1D1D$��17(�6�   ���	#FF1D1D1D��64   �� *OpenCarouselPageCommand+6�   5<      5=      5>      5?      � 5@   
   .+�5A      �� ��6   �� *CurrentView+5B      5C      5D      