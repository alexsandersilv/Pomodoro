   M S B A M L   `   `   `  ����C  ?Pomodoro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Pomodoro.Views.ControllersPomodoro.Views.Controllers  5      -    'Pomodoro.Views.Controllers.TimerControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Pomodoro.Views.Controllers     5        � 	Resources  5	       �� 
TargetType �� Property �� Value   Rajdhani��%j  '��       7   '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ 75(�6)   �� 5       � ��8   6+   �� 5       �@��Padding$ 10q�6(   �� 5       � �� �#2020246+   �� 5       � ��
 �����6+   5      �� 5   
   " ��6   .�5      ��  � ��$	 100��6)   �� 5       � ��$	 100��6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5       $
��Auto �6   �� 5!      $��* �6   .+�5$   
   � $��1��6   $��0��6   $��Right=�6,   $��Center=�6H    5%      �� 5&      $��* �6#   �� 5'      $��* �6#   .+�5*      �� -   5        $��MinutesLeft��5*   ^   $��
0, 0, 1, 0q�6   $��60��6,    �� TextAlignment$ Center=�67   $��0��6N   $��0��6q   �� 5+      -   5        $��MinutesRight��5+   ^   $��
1, 0, 0, 0q�6   $��60��6,   $ Center=�67   $��1��6N   $��1��6r   5,      � 5.   
   $��1��6   $��1��6   $��Center=�6,   $��Center=�6I   .+�5/      �� -   5        $��	Separator��5/      
������ 
�������$��:��6U   50      � 52   
   $��1��6   $��2��6   $
��Left=�6,   $��Center=�6G    53      �� 54      $��* �6#   �� 55      $��* �6#   .+�58      �� -   5        $��SecondsLeft��58   ^   $��
0, 0, 1, 0q�6   $��60��6,   $ Center=�67   $��0��6N   $��0��6q   �� 59      -   5        $��SecondsRight��59   ^   $��
1, 0, 0, 0q�6   $��60��6,   $ Center=�67   $��1��6N   $��0��6r   5:      5;      5<      