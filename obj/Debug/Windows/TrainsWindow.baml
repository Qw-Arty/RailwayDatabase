   M S B A M L   `   `   `  ����J  FrailwayDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:railwayDatabase.WindowsrailwayDatabase.Windows  5   	   *    $railwayDatabase.Windows.TrainsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:railwayDatabase.Windows     5   	     � Title$  TrainsWindow��5   	   $	��450��6   $	��800��6+    � 	Resources 5	       �� 
TargetType   
HaverColor �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  RoundButton	 �� CornerRadius��%�  &	        &	 �     �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&    5      P� 5       �@J�IsMouseOver . . �5   "   ��  � ��
 �""��6Z   5      5      5      5      �� 5   
   " ��6   .�5      ��  � ��
 �<��6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $	 10��5   !   #��z��5      #��z��5      ._�5       �� $��Center=�6/   $��Center=�5!       5"       5#      P� 5$       �@J�IsMouseCaptured . . �5&   "   ��  � ��
 �""��5'      5(      5*      5,      5-      5.      .��5/      � 
 � ColumnDefinitions
 50   
   �� 51      $
��0.1* �6   �� 52      $
��0.5* �6   �� 53      $��0.05* �6   �� 54      �� 55      $��0.05* �6   �� 56      $
��0.5* �6   �� 57      $
��0.1* �6    � RowDefinitions 59   
   �� 5:      $��0.05* �6   �� 5;      $
��0.2* �6   �� 5<      $��0.05* �6   �� 5=      �� 5>      $��0.05* �6   �� 5?      $��0.12* �6   �� 5@      $��0.02* �6   �� 5A      $��0.12* �6   �� 5B      $��0.05* �6   .+�5D   
   �� -   5        $��
BackButton��5D      $��
Назад��6#   $��5��63   $��1��6C   $��Lucida Sans Unicode)�6i   $��20(�6�   #��[ 6�   
���<��
�������6�   �� 5E   
   -   5        $��
NameWindow��5E      $��3��6&   $��1��66   $
��Wrap=�6C   $��1��6W   $`��ZОкно создания, редактирования и удаления поездов��6k   $��Lucida Sans Unicode)�6�   $��15(�6�   &   System.Windows.Controls.DataGrid  5F   
   -   5        $��TrainsDataGrid��5F         AutoGenerateColumns .  $��1��6x   $��3��6�   $��5��6�   $��Lucida Sans Unicode)�6�   $��15(�6�      Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.1* 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	TrainId+6\     5I      $
 Type��6%   $
 0.2* 6Q    63   �� *	TrainType+6`     5J      $
 Name��6%   $
 0.1* 6Q    63   �� *	TrainName+6`   5L      �� 5M   
   -   5        $��ChangeButton��5M      $!��Редактировать/��6%   $��1��6>   $��5��6N   $��Lucida Sans Unicode)�6v   $��15(�6�   #��[ 6�   
���<��
�������6�   �� 5N   
   -   5        $��CreateButton��5N      $��/Сотворить��6%   $��1��6:   $��7��6J   $��Lucida Sans Unicode)�6r   $��15(�6�   #��[ 6�   
���<��
�������6�   �� 5O   
   -   5        $��TrainTypeBox��5O      $��3��6&   $��5��66   $��3��6C    �� TextWrapping$
 Wrap=�6T   $��Lucida Sans Unicode)�6h   $��15(�6�   �� 5P   
   -   5        $��TrainNameBox��5P      $��5��6&   $��5��66   $��3��6C   $
 Wrap=�6T   $��Lucida Sans Unicode)�6h   $��15(�6�   �� 5Q   
   -   5        $��DeleteButton��5Q      $��Удалить��6%   $��1��67   $��1��6G   $��Lucida Sans Unicode)�6o   $��20(�6�   #��[ 6�   
���<��
�������6�   5R      5S      