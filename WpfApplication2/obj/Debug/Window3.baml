   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	       WpfApplication2.Window3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5          �Name$   AddProductorCategoryWindow��5   	    � Title$ Window3��5   	   $��670.868��6   $��852.779��6*    � WindowState$ 	Maximized=�6:    � WindowStartupLocation$ CenterScreen=�6R   ���	#FF216EF5
�������.��5	      �  J� 	AllowDrop .  � RowDefinitions 5
   
   �� 5      $	��45* �6   �� 5      $
��544* �6   �� 5      $��51 �6   .+�5   
   � -   5         �Name$ Category_Grid��5      $	��314��6&   $��426,141,137,89.5q�63   $	��282��6M   $��1��6Y   .+�5      � -   5        $ CategoriesImageList��5      $��24,10,30,10q�60   .+�5      �� -   5         ��Name$ image��5      $	��100��6'   $	��100��64   $��	10,10,0,0q�6@   �� 5      -   5        $ 
image_Copy��5      $	��100��6,   $	��100��69   $��
128,10,0,0q�6E    J� OpacityMask 5      �� 5      5      �� 5      -   5        $ image_Copy1��5      $	��100��6-   $	��100��6:   $��
16,158,0,0q�6F   �� 5      -   5        $ image_Copy2��5      $	��100��6-   $	��100��6:   $��128,153,0,0q�6F    5      �� 5      5      �� 5      -   5        	 ��Name$	 C1��5      $��
CATEGORY 1��6$   $��
16,127,0,0q�69   $��Segoe UI Black)�6M   
�������6i   �� 5      -	   5        $	 C2��5      $��
CATEGORY 2��6$   $��128,127,0,0q�69   $��Segoe UI Black)�6N   
�������6j   �� 5      -
   5        $	 C3��5      $��
CATEGORY 3��6$   $��
16,268,0,0q�69   $��Segoe UI Black)�6M   
�������6i   �� 5       -   5        $	 C4��5       $��
CATEGORY 4��6$   $��128,268,0,0q�69   $��Segoe UI Black)�6N   
�������6j   5!      5"      �� 5#   
   -   5        $	 label��5#      $��Products List��6   $��18,12,737,5q�67   
�������$��Segoe UI Black)�6u   ��6L   Z� 6u   �� 5$   
   -   5        $	 CategoriesList��5$      $��
Categories��6(   $��426,10,10,0q�6=   
�������$��Segoe UI Black)�6{   $��2��6�   ��6R   Z� 6�   �� 5%   
   -   5        
 ��Name$
 Add_Categories��5%      $��Add Category��6)   $��27��6@   $��702,8,29,16q�6L   $	��114��6a   $��2��6�   �� 5&   
   -   5        $
 Add_Product��5&      $��Add Product��6&   $��
32,8,699,0q�6<   $	��114��6P   $��2��6v   $��27��6�   $	��Top=�6�   � 5'   
   $
��Left=�6   $	��544��6*   $��10,0,0,0q�67   $��1��6I   $	��Top=�6V   $	��411��6n   �� 5(   
   -   5         ��Name$ listBox��5(      $
��Left=�6#   $	��534��6>   $��10,0,0,0q�6K   $��1��6]   $	��Top=�6j   $	��416��6�   ���	#FF005DFF$��16(�6�   $��Segoe UI Semibold)�6�   5*      5+      