   M S B A M L   `   `   `  ����C  ?Pomodoro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Pomodoro.Views.ControllersPomodoro.Views.Controllers  5      -    'Pomodoro.Views.Controllers.TimerControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Pomodoro.Views.Controllers     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��	Separator��5   ?   $��80(�6   $��1��6"   $��1��6/   $��:��6P   $��Center=�5      $��Center=�61   �� 5   
   -   5        $��	MinutesUI��5   ?   $��80(�6   $��1��6"   $��0��6/   $��15��6P   $��0,0,10,0q�5      $��Right=�6&   $��Center=�6B   �� 5   
   -   5        $��	SecondsUI��5   ?   $��80(�6   $��1��6"   $��2��6/   $��00��6P   $��10,0,0,0q�5      $
��Left=�6&   $��Center=�6A   5      5      