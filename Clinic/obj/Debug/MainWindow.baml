   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6,     � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      �� 5      $��Center=�6   .+�5      �� $��image/logo.png��6   $��70��60   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   ShadowDepth$
 5Q�6+      Opacity$	 0.5Q�6;   5!      �� 5"      $��کلینک درمانی ��6   $��22(�5#      $��Light"�5$      
�������$��Center=�5&      $��IRDavat)�5'      $��	0 10 0 0 q�5(      	 5)        5*      5,      5-      � 5.      -   5        
������ $��50��5.   \   $	��Top=�6h   5/      �� 50      $��1��6   .+�51      ��  �� Orientation$ 
Horizontal=�6   .+�52      � .+�53      �� -   5         ��Name$ UserNameTxt��54      $��IRANSans)�55      $��Light"�56      $��20(�57      $��Center=�58      
�������
������ $��0q�5;      $	��235��5>      $
��Left=�5@       J� Opacity$	 0.5Q�5A      $��32��6+   $��65,0,0,0q�67   �� 5C       J� IsHitTestVisible .  $��UserName��5D   $   $��Center=�5E   $   $��Center=�5F   $   $��	-92,0,0,0q�5G   $   
�������$��IRANSans)�5H   $   $��15(�5I   $   $	 0.5Q�62      textforTextBoxplaceHolder#��[  5J   $   5N      5O      .  (MahApps.Metro.IconPacks.PackIconMaterial  5P         Kind$ Account=�61   $��Center=�5Q   5   $��Center=�5R   5   
�������5S   5   5U      �� 5V      $	��250��6   $��2��5W      
�������$	 0.5Q�5Y      �� 5Z      $ 
Horizontal=�6   $��0,10,0,0q�67   .+�5[      � .+�5\      G� -   5         G�Name$ UserPasswordtxt��5]      $��IRANSans)�5^      $��Light"�5_      $��20(�5a      $��Center=�5b      
�������
������ $��0q�5e      $	��235��5f      $
��Left=�5g      $��32��5h      $��65,0,0,0q�6)   �� 5i       .  $��Password��5j   $   $��Center=�5k   $   $��Center=�5l   $   $��	-96,0,0,0q�5m   $   
�������$��IRANSans)�5n   $   $��15(�5o   $   $	 0.5Q�62   ��5p      �� 5q   "    �� 
TargetType" ��6(   .�5r   &   ��  �� Property � y� �� Value$ 	Collapsed=�6C    �� Triggers 5s   &   �� 5t   *    �� Binding 66   �� *Text+ �� ElementName$ UserPasswordtxt�� �� Value  6l   .a�5u   .   ��  � y�$ Visible=�6K   5v   +   5x   #   5z      5|        5}      $ FormTextboxPassword=�65   $��Center=�5~   5   $��Center=�5   5   
�������5�   5   5�      �� 5�      $	��250��6   $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0,50,0,0q�66   .+�5�      �� -   5         ��Name$ Loginbtn��5�      $	��100��6/   $��40��6Q   $��LOGIN��6]   $��	60,0,60,0q�6m     ButtonStyles#��[ 6�   �� 5�      -   5        $ Exitbtn��5�      $	��100��6D   $��40��6P   $
��Exit��6\   #��[ 6l   5�      �� 5�      5�      5�      5�      5�      5�      