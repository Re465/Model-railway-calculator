   M S B A M L   `   `   `  ����S  OModel railway calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Model_railway_calculatorModel_railway_calculator  5   	   -    'Model_railway_calculator.Bit_Calculator   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Model_railway_calculator     5   	     � Title$  Model railway calculator��5   	   $	��600��6*   $	��900��67    � Icon$ 	train.png��6C    � 
ResizeMode$ CanMinimize=�6T    � WindowStartupLocation$ CenterScreen=�6m   .��5
      � #��� ��6   $��0,0,0,-5q�6b   .+�5   
   o� $
��Left=�6   $��20��6*   $��0q�66   $	��Top=�6A   $	��900��6Y   $��5��6e   #��� ��6y   .@�5      m� $
��File��6   $��20��6%   $��30��61   #��� ��6<   .@�5      m� -   5         m�Name$ 
MainWindow��5      $��
Mainwindow��6/   $
��Left=�6C   $��20��6^   $	��165��6j   m� 5      -   5        $ FileExit��5      $
��Quit��6-   $
��Left=�6;   $��20��6V   $	��165��6b   5      m� 5      $��Scale calculator��6   $��20��61   $��90��6=   .@�5      m� -   5        $ 	Org_Scale��5      $��1:1 to scale��6.   $
��Left=�6D   $��20��6_   $	��160��6k   m� 5      -   5        $ 	Scale_Org��5      $��Scale to 1:1��6.   $
��Left=�6D   $��20��6_   $	��160��6k   m� 5      -   5        $ Scale_Scale��5      $��Scale to scale��60   $
��Left=�6H   $��20��6c   $	��160��6o   5      m� 5      $��Model railway��6   $��20��6.   $��90��6:   .@�5      m� -   5        $ Slope��5      $��Slope��6*   $
��Left=�69   $��20��6T   $	��150��6`   m� 5      -   5        $ Track_radius��5      $��Track radius��61   $
��Left=�6G   $��20��6b   $	��150��6n   m� 5      -   5        $ Helex��5      $��Helex��6*   $
��Left=�69   $��20��6T   $	��150��6`   5      m� 5      $	��DCC��6   $��20��6$   $��35��60   .@�5      m� -	   5        $ Bit_Calculator��5      $��Bit calculator��63   $
��Left=�6K   $��20��6f   $	��185��6r   {�.  6~   m� 5      -
   5        $ CV29_Calculator��5      $��CV29 calculator��64   $
��Left=�6M   $��20��6h   $	��185��6t   m� 5      -   5        $ Adres_Calculator��5      $��Address calculator��65   $
��Left=�6Q   $��20��6l   $	��185��6x   5      m� 5       $��Märklin��6   $��20��6(   $��55��64   .@�5!      m� -   5        $ 	Dipswitch��5!      $��	Dipswitch��6.   $��20��6A   $	��140��6M   5"      m� 5#      $
��Help��6   $��20��6%   $��40��61   .@�5$      m� -   5        $
 Info��5$      $
��Info��6)   $
��Left=�67   $��20��6R   $	��205��6^   m� 5%      -   5        $	 GNU��5%      $��General Public License��6(   $
��Left=�6H   $��20��6c   $	��205��6o   5&      5'      �� 5)   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   �� 5*   
   $��Bit calculator
��6   $
��Left=�63   $��57��6N   $��
263,25,0,0q�6Z   $	��Top=�6n   $	��386��6�   $��36(�6�   $
��Bold"�6�   �� 5,   
   -   5         ��Name$ LblBit00��5,      $��	Bit 0 (1)��6"   $
��Left=�66   $��30��6Q   $��	20,80,0,0q�6]   $	��Top=�6p   $��70��6�    J� OpacityMask# � ��6�   #��� ��6�   $��16(�66  �� 5-   
   -   5        $ LblBit02��5-      $��    0 = Off
    1 = On��6"   $
��Left=�6G   $��55��6b   $��	85,80,0,0q�6n   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6G  {�.  6U  �� 5.   
   -   5         ��Name$ ChkBit0��5.      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,111,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   $��16(�6?   J� RenderTransformOrigin$ 
-2.6,1.747&�6M  �� 5/   
   -   5        	 ��Name$	 TxtBit0��5/      $
��Left=�6#   $��48��6>   $��
230,80,0,0q�6J   
 �� TextWrapping$

 Wrap=�6^   $��0��6r   $	��Top=�6{   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6,  $��36(�6}   �� TextAlignment$ Right=�6�  ��6�   Z� ��6�  Z� F� 50   
   -   5         F�Name$ Lein1��50      ���� H�@_��V�	$
��Left=�6:   $��
17,130,0,0q�6U    �� Stretch$
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6Y  �� 52   
   -   5        $ LblBit10��52      $��	Bit 1 (2)��6"   $
��Left=�66   $��30��6Q   $��
20,130,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 53   
   -   5        $ LblBit12��53      $��    0 = Off
    2 = On��6"   $
��Left=�6G   $��55��6b   $��
85,130,0,0q�6n   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6H  �� 54   
   -   5        $ ChkBit1��54      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,161,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 55   
   -   5        $	 TxtBit1��55      $
��Left=�6#   $��48��6>   $��230,130,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6-  $��36(�6~  $ Right=�6�  ��6�   Z� ��6�  Z� F� 56   
   -   5        $ Lein2��56      ���� H�@_��V�	$
��Left=�6:   $��
17,180,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6X  �� 58   
   -   5        $ LblBit20��58      $��	Bit 2 (3)��6"   $
��Left=�66   $��35��6Q   $��
20,180,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 59   
   -   5        $ LblBit22��59      $��    0 = Off
    4 = On��6"   $
��Left=�6G   $��55��6b   $��
85,180,0,0q�6n   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6H  �� 5:   
   -   5        $ ChkBit2��5:      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,211,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 5;   
   -   5        $	 TxtBit2��5;      $
��Left=�6#   $��48��6>   $��230,180,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6-  $��36(�6~  $ Right=�6�  ��6�   Z� ��6�  Z� F� 5<   
   -   5        $ Lein3��5<      ���� H�@_��V�	$
��Left=�6:   $��
17,230,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6X  �� 5>   
   -   5        $ LblBit30��5>      $��	Bit 3 (4)��6"   $
��Left=�66   $��30��6Q   $��
20,230,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 5?   
   -   5        $ LblBit32��5?      $��    0 = Off
    8 = On��6"   $
��Left=�6G   $��55��6b   $��
84,230,0,0q�6n   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6H  �� 5@   
   -    5        $ ChkBit3��5@      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,261,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 5A   
   -!   5        $	 TxtBit3��5A      $
��Left=�6#   $��55��6>   $��230,230,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6-  $��36(�6~  $ Right=�6�  ��6�   Z� ��6�  Z� F� 5B   
   -"   5        $ Lein4��5B      ���� H�@_��V�	$
��Left=�6:   $��
17,280,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  �� 5D   
   -#   5        $ LblBit40��5D      $��	Bit 4 (5)��6"   $
��Left=�66   $��30��6Q   $��
20,280,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 5E   
   -$   5        $ LblBit42��5E      $��    0 = Off
  16 = On��6"   $
��Left=�6F   $��55��6a   $��
85,280,0,0q�6m   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6G  �� 5F   
   -%   5        $ ChkBit4��5F      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,311,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 5G   
   -&   5        $	 TxtBit4��5G      $
��Left=�6#   $��45��6>   $��230,280,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6-  $��36(�6~  $ Right=�6�  ��6�   Z� ��6�  Z� F� 5H   
   -'   5        $ Lein5��5H      ���� H�@_��V�	$
��Left=�6:   $��
17,330,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6X  �� 5J   
   -(   5        $ LblBit50��5J      $��	Bit 5 (6)��6"   $
��Left=�66   $��30��6Q   $��
20,330,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 5K   
   -)   5        $ LblBit52��5K      $��    0 = Off
  32 = On��6"   $
��Left=�6F   $��55��6a   $��
85,330,0,0q�6m   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6G  �� 5L   
   -*   5        $ ChkBit5��5L      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,361,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 5M   
   -+   5        $	 TxtBit5��5M      $
��Left=�6#   $��45��6>   $��230,330,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6-  $��36(�6~  $ Right=�6�  ��6�   Z� ��6�  Z� F� 5N   
   -,   5        $ Lein6��5N      ���� H�@_��V�	$
��Left=�6:   $��
17,380,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6X  �� 5P   
   --   5        $ LblBit60��5P      $��	Bit 6 (7)��6"   $
��Left=�66   $��30��6Q   $��
20,380,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 5Q   
   -.   5        $ LblBit62��5Q      $��    0 = Off
  64 = On��6"   $
��Left=�6F   $��55��6a   $��
85,380,0,0q�6m   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6G  �� 5R   
   -/   5        $ ChkBit6��5R      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,411,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 5S   
   -0   5        $	 TxtBit6��5S      $
��Left=�6#   $��45��6>   $��230,380,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��0q�6�   {�.  # � ��6�   #��� ��6-  $��36(�6~  $ Right=�6�  ��6�   Z� ��6�  Z� F� 5T   
   -1   5        $ Lein7��5T      ���� H�@_��V�	$
��Left=�6:   $��
17,430,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6X  �� 5V   
   -2   5        $ LblBit70��5V      $��	Bit 7 (8)��6"   $
��Left=�66   $��30��6Q   $��
20,430,0,0q�6]   $	��Top=�6q   $��70��6�   # � ��6�   #��� ��6�   $��16(�67  �� 5W   
   -3   5        $ LblBit72��5W      $��    0 = Off
128 = On��6"   $
��Left=�6E   $��55��6`   $��
85,430,0,0q�6l   $	��Top=�6�   $��85��6�   # � ��6�   #��� ��6�   $��16(�6F  �� 5X   
   -4   5        $ ChkBit7��5X      $��CheckBox��6$   $
��Left=�67   $��15��6R   $��180,461,0,0q�6^   $	��Top=�6s   $��15��6�   #��� ��6�   # � ��6�   �� 5Y   
   -5   5        $	 TxtBit7��5Y      $
��Left=�6#   $��45��6>   $��230,430,0,0q�6J   $

 Wrap=�6_   $��0��6s   $	��Top=�6|   $��70��6�   $��36(�6�   $��0q�6�   {�.  # � ��6�   #��� ��6;  $ Right=�6�  ��6�   Z� ��6�  Z� F� 5Z   
   -6   5        $ Lein8��5Z      ���� H�@_��V�	$
��Left=�6:   $��
17,480,0,0q�6U   $
 Fill=�6i   $	��Top=�6x   $	��290��6�   $��1��6�   # � ��6�   $��5��6�   #��� ��6  #��� ��6X  �� 5\   
   -7   5        $	 TxtSumme��5\      $
��Left=�6$   $��45��6?   $��230,480,0,0q�6K   $

 Wrap=�6`   $��0��6t   $	��Top=�6}   $��70��6�   $��36(�6�   $��0q�6�   {�.  # � ��6�   
����  �$ Right=�6R   �� 	UndoLimit$	 102��6h  ��6�   Z� ��6x  Z� �� 5]   
   -8   5        $ LblWert��5]      $ ��The value of this byte is:��6!   $
��Left=�6F   $��45��6a   $��
47,495,0,0q�6m   $	��Top=�6�   $	��185��6�   # � ��6�   #��� ��6�   $��16(�6H  �� 5^   
   -9   5        $ LblNote1��5^      $��Note :��6"   $
��Left=�63   $��45��6N   $��
400,75,0,0q�6Z   $	��Top=�6n   $	��120��6�   $
��Bold"�6�   # � ��6�   $��26(�6�   �� 5_   
   -:   5        $ LblNote2��5_      $q��kIf a bit is not used, the bit should remain at 0 unless
otherwise specified in the Operating instructions.��6"   $
��Left=�6�   $��80��6�   $��400,120,0,0q�6�   $	��Top=�6�   $	��440��6�   # � ��6   #��� ��6R  $��16(�6�  5a      5c      