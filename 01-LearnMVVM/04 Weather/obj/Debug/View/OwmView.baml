   M S B A M L   `   `   `  ����E  A04 Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:_04_Weather.View_04_Weather.View  5      =#clr-namespace:_04_Weather.ViewModel_04_Weather.ViewModel  5      7 clr-namespace:_04_Weather.Helper_04_Weather.Helper  5          _04_Weather.View.OwmView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:_04_Weather.View     5      4view#clr-namespace:_04_Weather.ViewModel     5      3helper clr-namespace:_04_Weather.Helper     5        � DataContext  5      (   "_04_Weather.ViewModel.OwmViewModel  5   
   6    � 	Resources 5      -   '_04_Weather.Helper.WeatherIconConverter   wiConverter��%   &	          5   
   6&   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5!   
   �� $��0��6   $��0��6   $
��City��6-   �� 5"   
   $��0��6   $��1��6   ��6/   ��  �� Path$
 City��� 5$   
   $��1��6   $��0��5%      $��2��5&      ��5'      �� $ WeatherCommand��� 5)   
   $��2��6   $��0��6   $��Minimal Temperature��6-   �� 5*   
   $��2��6   $��1��5+      ��5,      �� $ MinTemperature� �� Mode$ OneWay=��� 5.   
   $��3��6   $��0��6   $��Maximal Temperature��6-   �� 5/   
   $��3��6   $��1��50      ��51      �� $ MaxTemperature�$ OneWay=��� 53   
   $��4��6   $��0��6   $��Temperature��6-   �� 54   
   $��4��6   $��1��55      ��56      �� $ Temperature�$ OneWay=��� 58   
   $��5��6   $��0��6   $��Description��6-   �� 59   
   $��5��6   $��1��5:      ��5;      �� $ Description�$ OneWay=��� 5=   
   $��6��6   $��0��6   ��6/   �� $ Id�$ OneWay=��� 5?   
   $��6��6   $��1��6   ��5@      `� 5A       `� 	Converter# [  6   .1�5B      �� $ Id�6   �� 5C      $
 Icon�6   5D      5F      5G      5H      