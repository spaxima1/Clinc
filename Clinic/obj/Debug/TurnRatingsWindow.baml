   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.TurnRatingsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  image/logo.png��5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ TurnRatingsWindow��5   	   $	��300��6#   $	��630��60   .��5      � ��5   
   �� 5      .��5      �  � Color$ #f9d89c��6    � Offset$	 0.0Q�6/   � 5      $ #f99c9c��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��1��6   $��2��6   .+�5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�66   $��RightToLeft=�6C   $��0��6a   .+�5      �� -   5         ��Name$ 	Searchbtn��5   *   $	��5 0q�6   	 � Cursor$
	 Hand��6V   .��5       '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Search=�62   5!      � 5"       5#      �� 5$      $	��10* �6,   �� 5%      $	��50* �6,   .+�5'      �� -   5         ��Name$ DoctorSpecialtyTxt��5(      $��IRANSans)�5)      $��Light"�5*      $��20(�5+      $��Center=�5,      
�������
������ $��0q�5/      $	��235��52      $
��Left=�54       J� Opacity$	 0.5Q�55      $��45��6+   $��0,0,0,0q�67   $��2��6H   �� 57       J� IsHitTestVisible .  $��تخصص دکتر��58   $   $��Center=�59   $   $��Center=�5:   $   $��	0,0,150,0q�5;   $   
�������$��IRANSans)�5<   $   $��15(�5=   $   $	 0.5Q�62   $��2��5>   %   ��5@      �� 5A   "    �� 
TargetType" ��6(   .�5B   &   ��  �� Property � y� �� Value$ 	Collapsed=�6C    �� Triggers 5C   &   �� 5D   *    �� Binding 66   �� *Text+ �� ElementName$ DoctorSpecialtyTxt�� �� Value  6o   .a�5E   .   ��  � y�$ Visible=�6K   5F   +   5H   #   5K      5L      5N      �� 5O      -   5         ��Name$ Drname��5O      5Q      5R      5T      � 5U   
   $��0��6   $��0��6   .+�5V      �� .+�5W      �� $��10q�6    �� Padding$ 5q�6&    �� CornerRadius$ 12��62    J� Effect 5X      3  -System.Windows.Media.Effects.DropShadowEffect  5Y         Opacity$	 0.8Q�6+      Color$ 	#FF323232��69   ��5[      �� 5\      .��5]      � $ #7be9f6��6+   $	 0.0Q�6;   � 5^      $ #8be398��6+   $ 1Q�6;   5_      ._�5a      �� $ 
Horizontal=�6!   $��RightToLeft=�5b   !   .+�5d      �� -   5         ��Name$ NamePtxt��5d   $   $��Center=�66   $��10 0 0 0q�6S   $��نام��6e   $	��100��6p   �� 5e      -   5        $ 
FmailyPtxt��5e   $   $��10 0 0 0q�68   $��نام خانواگی��6J   $	��100��6]   �� 5f      -   5        $ 
GenderPtxt��5f   $   $��
جنسیت��68   $��50��6E   5h      5i      �� 5j      -   5        $ DRforPatinSact��5j      5l      5m      5o      � 5p   
   $��1��6   .+�5q      �� -   5        $ Regster��5q      $	��100��6&   $��40��6J   $��ثبت نوبت��6V   $��	60,0,60,0q�6i      ButtonStyles#��[  6|   5r      5s      5t      