   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	       WpfApplication2.Window2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5          � Title$  Admin Login��5   	   $��171.24��6   $��309.928��6-    � WindowStyle$ ThreeDBorderWindow=�6=    � WindowStartupLocation$ CenterScreen=�6^   .��5	      �  J� RenderTransformOrigin$	 0,0&�6   $��0,0,0,-6q�6'   $
��Left=�69   $	��302��6T   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF1A4CA2��6    � Offset$ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5        	 ��Name$	 btnOk��5      $��OK��6    $
��Left=�6-   $��
146,99,0,0q�6H   $	��Top=�6\   $��75��6t   
����������	#FF0046FF$��2��6�   6�   �� 5   
   -   5        
 ��Name$
 label��5      $��ID��6   $
��Left=�6,   $��6,36,0,0q�6G   $	��Top=�6Y   
�������$��2��6�   �� 5   
   -   5         ��Name$ adminid��5      $
��Left=�6#   $��18��6>   $��
101,41,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   ���	#FF002EFF � ForceCursor . $��2��6�   �� 5   
   -   5        $
 
label_Copy��5      $��Password��6$   $
��Left=�67   $��5,60,0,0q�6R   $	��Top=�6d   
�������$��2��6�   G� 5   
   -   5         G�Name$ admin_password��5      $��3��6.   $
��Left=�6B   $��
101,68,0,0q�6]   $	��Top=�6q   $	��120��6�    G� SelectionOpacity$	 0.1Q�6�   6�   5      5      