   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5      $    Clinic.ShowPatientsInformation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Clinic     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������  � RowDefinitions  5   
   �� 5      �� 5      $��2* �6   .+�5   
   � $	��220��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��RightToLeft=�62   ��5      �� 5      .��5      �  � Color$ #f9d89c��6'    � Offset$	 0.0Q�67   � 5      $ #f99c9c��6'   $ 1Q�67   5      .+�5      �� -   5         ��Name$ 	Searchbtn��5       � Cursor$
 Hand��6D   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6.   5      � 5        5      �� 5      $
��111* �6(   �� 5      $
��109* �6(   .+�5       �� -   5         ��Name$ UserNameTxt��5!      $��IRANSans)�5"      $��Light"�5#      $��20(�5$      $��Center=�5%      
�������
������ $��0q�5(      $	��235��5+      $
��Left=�5-       J� Opacity$	 0.5Q�5.      $��45��6+   $��
65,94,0,94q�67   $��2��6K   �� 50      	 J� IsHitTestVisible	 .  $��نام  کار بر��51   $   $��Center=�52   $   $��Center=�53   $   $��72,98,164,97q�54   $   
�������$��IRANSans)�55   $   $��15(�56   $   $	 0.5Q�62      textforTextBoxplaceHolder#��[  57   $   $��2��6W   5;      5<      � 5=        5>      �� 5?      $
��111* �6(   �� 5@      $
��109* �6(   .+�5B      �� -   5        $ PhoneNumberTxt��5C      $��IRANSans)�5D      $��Light"�5E      $��20(�5F      $��Center=�5G      
�������
������ $��0q�5J      $	��235��5K      $
��Left=�5M      $	 0.5Q�5N      $��45��6+   $��
65,94,0,94q�67   $��2��6K   �� 5P      	 .  $��شماره تلفن��5Q   $   $��Center=�5R   $   $��Center=�5S   $   $��72,98,164,97q�5T   $   
�������$��IRANSans)�5U   $   $��15(�5V   $   $	 0.5Q�62   $��2��5W   %   ��5Y      �� 5Z      
 �� 
TargetType"
 ��6$   .�5[   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?    �� Triggers 5\   "   �� 5]   &    �� Binding 62   �� *Text+ �� ElementName$ PhoneNumberTxt�� �� Value  6g   .a�5^   *   ��  � y�$ Visible=�6G   5_   '   5a      5e      5f      5g      5i      �� 5j   
   $��1��6   $
��10 0q�6$   $��Visible=�63   .��5k      �� -   5         ��Name$ dgridPatients��5k      $	��400��61   5m      5n      5o      5q      