   M S B A M L   `   `   `  ����J  F05 SecondoGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:_05_SecondoGrado.View_05_SecondoGrado.View  5      G(clr-namespace:_05_SecondoGrado.ViewModel_05_SecondoGrado.ViewModel  5      ?$clr-namespace:_05_SecondoGrado.Model_05_SecondoGrado.Model  5      (    "_05_SecondoGrado.View.EquationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:_05_SecondoGrado.View     5      >	viewmodel(clr-namespace:_05_SecondoGrado.ViewModel     5      6model$clr-namespace:_05_SecondoGrado.Model     5        � DataContext  5      2   ,_05_SecondoGrado.ViewModel.EquationViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��0��5       $��3��5!      $��Center=�5"      $��Center=�5#      $#��Second Degree Equation Solver��5$      �� 5&   
   $��1��6   $��0��5'      $��Right=�5(      $��Center=�5)      $��A:��5*      �� 5+   
   $��1��6   $��1��5,      $��Center=�5-      ��5.      ��  �� Path$ A� �� UpdateSourceTrigger$ PropertyChanged=��� 50   
   $��2��6   $��0��51      $��Right=�52      $��Center=�53      $��B:��54      �� 55   
   $��2��6   $��1��56      $��Center=�57      ��58      �� $ B�$ PropertyChanged=��� 5:   
   $��3��6   $��0��5;      $��Right=�5<      $��Center=�5=      $��C:��5>      �� 5?   
   $��3��6   $��1��5@      $��Center=�5A      ��5B      �� $ C�$ PropertyChanged=��� 5D   
   $��4��6   $��0��5E      $��Right=�5F      $��Center=�5G      $��Root 1:��5H      �� 5I   
   $��4��6   $��1��5J      $��Center=�5K      ��5L      �� $ Root1� �� Mode$ OneWay=��� 5N   
   $��5��6   $��0��5O      $��Right=�5P      $��Center=�5Q      $��Root 2:��5R      �� 5S   
   $��5��6   $��1��5T      $��Center=�5U      ��5V      �� $ Root2�$ OneWay=��� 5X   
   $��6��6   $��0��5Y      $��Right=�5Z      $��Center=�5[      $��Vertex:��5\      �� 5]   
   $��6��6   $��1��5^      $��Center=�5_      ��5`      �� $ Vertex�$ OneWay=��� 5a   
   $��6��6   $��2��5b      $��Center=�5c      $��Center=�5d      $
��Draw��5e      ��5f      �� $ DrawCommand��� 5k   
   $��2��6   $��1��5l      $��5��5m      ��5n      �� $ Points���5p      �� 5q      .R�5r      �� 5s       � 	Resources 5v       �� DataType$   _05_SecondoGrado.Model.Point2D��%q   (��       5w      *, +)�� 6   "  6   .R�5x      A� $��3��6   $��3��6(   
����  �63   5y      5z      ��5|      �� 5}       �� 
TargetType" ��6   .�5~      �� 	 �� Property	 �@��Left
 �� Value
 64   �� $ X��� 5      	 �@��Top
 63   �� $ Y�5�      5�      5�      5�      