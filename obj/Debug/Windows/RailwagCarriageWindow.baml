   M S B A M L   `   `   `  ����J  FrailwayDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:railwayDatabase.WindowsrailwayDatabase.Windows  5   	   3    -railwayDatabase.Windows.RailwagCarriageWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:railwayDatabase.Windows     5   	     � Title$  RailwagCarriageWindow��5   	   $	��450��6'   $	��800��64    � 	Resources 5	       �� 
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
��0.5* �6   �� 53      $��0.05* �6   �� 54      �� 55      $��0.05* �6   �� 56      �� 57      $
��0.1* �6    � RowDefinitions 59   
   �� 5:      $��0.05* �6   �� 5;      $
��0.2* �6   �� 5<      $��0.05* �6   �� 5=      �� 5>      $��0.05* �6   �� 5?      $��0.12* �6   �� 5@      $��0.02* �6   �� 5A      $��0.12* �6   �� 5B      $��0.05* �6   .+�5D   
   �� -   5        $��DeleteButton��5D      $��Туда ее��6%   $��1��67   $��1��6G   $��Lucida Sans Unicode)�6o   $��20(�6�   #��[ 6�   
���<��
�������6�   �� 5E   
   -   5        $��
BackButton��5E      $��
Назад��6#   $��5��63   $��1��6C   $��Lucida Sans Unicode)�6i   $��20(�6�   #��[ 6�   
���<��
�������6�   �� 5F   
   -   5        $��ChangeButton��5F      $!��Редактировать/��6%   $��1��6>   $��5��6N   $��Lucida Sans Unicode)�6v   $��15(�6�   #��[ 6�   
���<��
�������6�   �� 5G   
   -   5        $��CreateButton��5G      $��/Создать��6%   $��1��68   $��7��6H   $��Lucida Sans Unicode)�6p   $��15(�6�   #��[ 6�   
���<��
�������6�   �� 5H   
   -   5        $��
TrainIdBox��5H       �� DisplayMemberPath$ TrainId��6%   $��3��6A   $��5��6Q   $��3��6^   $��Lucida Sans Unicode)�6o   $��15(�6�   �� 5I   
   -   5        $��RoomBox��5I      $��5��6!   $��5��61   $��3��6>    �� TextWrapping$
 Wrap=�6O   $��Lucida Sans Unicode)�6c   $��15(�6�   �� 5J   
   $��3��6   $��1��6$   $
��Wrap=�61   $`��ZОкно создания, редактирования и удаления вагонов��6E   $��Lucida Sans Unicode)�6}   $��15(�6�   &   System.Windows.Controls.DataGrid  5K   
   -   5        $��RailwagCarriageGrid��5K         AutoGenerateColumns .  $��1��6�   $��3��6�   $��5��6�   $��Lucida Sans Unicode)�6�   $��15(�6�      Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.1* 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *RailwayCarriageId+6f     5N      $ Номер поезда��6%   $
 0.2* 6W    6;   �� *	TrainId+6f     5O      $ Номер комнаты��6%   $
 0.2* 6d    6<   �� *RailwayCarriageRoom+6s   5Q      5R      5S      