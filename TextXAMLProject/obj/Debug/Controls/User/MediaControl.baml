   M S B A M L   `   `   `  ����J  FTextXAMLProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TextXAMLProject.Controls.UserTextXAMLProject.Controls.User  5      0    *TextXAMLProject.Controls.User.MediaControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:TextXAMLProject.Controls.User     5      
�������$��Center=�5	   7   $��Center=�6T   .��5
      �   � RowDefinitions  5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ StartPauseBTN��5      $��4��6(   $��1��65   $	��▶��6E   $��Stretch=�6Q   $��10q�6o   6{   �� 5   
   -   5        $ PrevBTN��5      $��4��6"   $��0��6/   $	��⏮��6?   $��Stretch=�6K   $��10q�6i   �� 5   
   -   5        $ NextBTN��5      $��4��6"   $��2��6/   $	��⏭��6?   $��Stretch=�6K   $��10q�6i   �� 5   
   -   5         ��Name$ 
TimeSlider��5      $��2��6%   $��0��62   $��3��6B   $��Center=�6V   $��35, 0, 35, 0q�6q   6�   �� 5   
   -   5        $ VolumeSlider��5      $��0��6'   $��3��64   $��3��6D    �� Orientation$ Vertical=�6U   $��15, 0, 0, 0q�6l    � Maximum$ 1Q�6�    � SmallChange$
 0.01Q�6�   �� 5   
   -   5         ��Name$ NameTrackLBL��5      $��1��6&   $��0��63   $��3��6C   $��
Name track��6W   $��Center=�6l   $��Center=�6�   �� 5   
   $��3��6   $��3��6   $��Громкость��6-   �� 5   
   $��2��6   $��3��6   $��0��6-   $��Center=�69   $��Bottom=�6V   �� 5   
   $��1��6   $��3��6   $��50��6-   $��Center=�6:   $��Center=�6W   �� 5    
   $��0��6   $��3��6   $	��100��6-   $��Center=�6;   $	��Top=�6X   �� 5!   
   -   5        $ TrackTimeLBL��5!      $��2��6&   $��2��63   $��00:00��6C   $��10(�6S   $��Right=�6a   $��Center=�6}   �� 5"   
   -   5        $ 
CurrentLBL��5"      $��2��6$   $��0��61   $��00:00��6A   $��10(�6Q   $
��Left=�6_   $��Center=�6z   �� 5#   
   -	   5        $ OpenTrackBTN��5#      $��0��6'   $��0��64   $
��Open��6D   $��Stretch=�6S   $��10q�6q   6}   5$      5%      