   M S B A M L   `   `   `  ����S  OModel railway calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Model_railway_calculatorModel_railway_calculator  5   	   )    #Model_railway_calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Model_railway_calculator     5   	     � Title$  Model railway calculator��5   	   $	��600��6*   $	��900��67    � Icon$ 	train.png��6C    � 
ResizeMode$ CanMinimize=�6T    � WindowStartupLocation$ CenterScreen=�6m   .��5
      � #��� ��6   $��0,0,0,-5q�6b   .+�5   
   o� $
��Left=�6   $��20��6*   $��0q�66   $	��Top=�6A   $	��900��6Y   $��5��6e   #��� ��6y   .@�5      m� $
��File��6   $��20��6%   $��30��61   #��� ��6<   .@�5      m� -   5         m�Name$ 
MainWindow��5      $��
Mainwindow��6/   $
��Left=�6C   $��20��6^   $	��165��6j   {�.  6v   m� 5      -   5        $ FileExit��5      $
��Quit��6-   $
��Left=�6;   $��20��6V   $	��165��6b   5      m� 5      $��Scale calculator��6   $��20��61   $��90��6=   .@�5      m� -   5        $ 	Org_Scale��5      $��1:1 to scale��6.   $
��Left=�6D   $��20��6_   $	��160��6k   m� 5      -   5        $ 	Scale_Org��5      $��Scale to 1:1��6.   $
��Left=�6D   $��20��6_   $	��160��6k   m� 5      -   5        $ Scale_Scale��5      $��Scale to scale��60   $
��Left=�6H   $��20��6c   $	��160��6o   5      m� 5      $��Model railway��6   $��20��6.   $��90��6:   .@�5      m� -   5        $ Slope��5      $��Slope��6*   $
��Left=�69   $��20��6T   $	��150��6`   m� 5      -   5        $ Track_radius��5      $��Track radius��61   $
��Left=�6G   $��20��6b   $	��150��6n   m� 5      -   5        $ Helex��5      $��Helex��6*   $
��Left=�69   $��20��6T   $	��150��6`   5      m� 5      $	��DCC��6   $��20��6$   $��35��60   .@�5      m� -	   5        $ Bit_Calculator��5      $��Bit calculator��63   $
��Left=�6K   $��20��6f   $	��185��6r   m� 5      -
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
   $
��Left=�6   $	��550��6/   $��0,20,0,0q�6<   $
��Wrap=�6N   $	��Top=�6b   $	��900��6z   $	��130(�6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�   �� 6�   $�Model��6�   �� 6�   �� 6�   $�railway��6�   �� 6�   �� 6�   $�ca��6  �� 6  $�l��6  �� 6  $�culator��6"  64  5+      5-      