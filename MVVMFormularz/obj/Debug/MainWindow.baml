   M S B A M L   `   `   `  ����H  DMVVMFormularz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MVVMFormularzMVVMFormularz  5   	   A%clr-namespace:MVVMFormularz.ViewModelMVVMFormularz.ViewModel  5   	       MVVMFormularz.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MVVMFormularz     5   	   4vm%clr-namespace:MVVMFormularz.ViewModel     5   	     � Title$  FormularzMVVM��5	   	   $	��650��6   $	��900��6,    � DataContext 5      -  'MVVMFormularz.ViewModel.MVVMFormularzVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      .+�5&   
   �� $��Imię��6   $��0��6   $��0��6,   $��10, 20q�6<   $��20(�6L   $��Center=�6Z   $��Center=�6w   �� 5'   
   $��Nazwisko��6   $��1��6#   $��0��60   $��5, 20q�6@   $��20(�6O   $��Center=�6]   $��Center=�6z   �� 5(   
   $
��Wiek��6   $��2��6   $��0��6,   $��10, 20q�6<   $��20(�6L   $��Center=�6Z   $��Center=�6w   �� 5)   
   $
��Waga��6   $��3��6   $��0��6,   $��10, 20q�6<   $��20(�6L   $��Center=�6Z   $��Center=�6w   �� 5+   
   -   5         ��Name$ name_tb��5+      $��1��6#   $��0��63   $��2��6@   $��10 30q�6T   ��5,      �� *
PlayerName+ �� Mode$ TwoWay=�6X   �� 5.   
   -   5        $ 
surname_tb��5.      $��1��6&   $��1��66   $��2��6C   $��10 30q�6W   ��5/      �� *PlayerSurrname+$ TwoWay=�6^   �� 51   
   $��2��6   $��1��6    $��2��60   $��80 20q�6E   $��20(�6T   ��52      �� *	cb_Weight+ �� SelectedValue 53      �� *	PlayerAge+$ TwoWay=��� 55   
   -   5         ��Name$ 	weight_sl��55      $��1��6$   $��3��64   $��2��6A   $��30 35q�6U    � Minimum$ 50Q�6d   	 � Maximum$		 100Q�6q   
 �� TickFrequency$	
 0.1Q�6    � Value 56      �� *PlayerWeight+$ TwoWay=��� 58   
   $��3��6   $��3��6    $��20q�6-   $��30(�6o   $��Center=�6}   $��Center=�6�   ��69   ��  �� ElementName$ 	weight_sl�� �� Path$ Value�6�   �� 5:   
   $��0��6   $��4��6    $��4��60   $��7��6D   $��10,20q�6U   ��5;      �� *PlayersOCol+ �� SelectedItem 67   �� *CurrSelected+$ TwoWay=���5<      �� 5=      .R�5>      ��  �� Orientation$ 
Horizontal=�6!   .+�5?      �� ��6    �� *Name+6;   �� 5@      ��6    �� *
Surrname+6?   �� 5A      ��6    �� *Weight+6=   �� 5B      ��6    �� *Age+6:   5C      5D      5F      �� 5H   
   $��4��6   $��0��6   $��2��6.   $��30 20q�6B   $��Create��6Q   $��30(�6b   ��5I      �� *CreatePlayerCommand+�� 5J   
   $��4��6   $��2��6   $��2��6.   $��30 20q�6B   $��Delete��6Q   $��30(�6b   ��5K      �� *DeletePlayerCommand+��69   �� *CurrSelected+�� 5L   
   $��5��6   $��0��6   $��2��6.   $��30 20q�6B   $
��Save��6Q   $��30(�6`   ��5M      �� *SavePlayers+�� 5N   
   $��5��6   $��2��6   $��2��6.   $��30 20q�6B   $
��Load��6Q   $��30(�6`   ��5O      �� *LoadPlayers+�� 5P   
   $��6��6   $��1��6   $��2��6.   $��30 20q�6B   $��Modify��6Q   $��30(�6b   ��5Q      �� *ModifyPLayerCommand+��69   �� *CurrSelected+5R      5S      