   M S B A M L   `   `   `  ����F  Bbaikiemtra4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:baikiemtra4baikiemtra4  5   	       baikiemtra4.WinProduct   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:baikiemtra4     5   	     � Title$  
WinProduct��5   	   $	��450��6   $	��900��6)   .��5	      � .+�5
   
   �� $��Thông tin sản phẩm��6   $
��Left=�6-   $��
242,26,0,0q�6H   $	��Top=�6\   $	��346��6t   $
��Bold"�6�   $��36(�6�   ���	#FFA26B6B6�   �� 5   
   $��Mã Sản Phẩm��6   $
��Left=�6&   $��
27,104,0,0q�6A   $	��Top=�6U   $��18(�6m   �� 5   
   $��Tên Sản Phẩm:��6   $
��Left=�6(   $��
27,161,0,0q�6C   $	��Top=�6W   $��18(�6o   �� 5   
   $��Tổng số lượng:��6   $
��Left=�6)   $��
30,220,0,0q�6D   $	��Top=�6X   $��18(�6p   �� 5   
   $��Đơn giá:��6   $
��Left=�6#   $��
30,270,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ 0.524,0.619&�6j   $��18(�6�   �� 5   
   -   5         ��Name$ 
txt_id_SP_��5      $
��Left=�6&   $��164,104,0,0q�6A    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $��64��6�   $��38��6�   $��20(�6�   �� 5   
   -   5        $ txt_Name_SP_��5      $
��Left=�6(   $��164,159,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��129��6�   $��38��6�   $��20(�6�   �� 5   
   -   5        $ txt_sumQuantity_SP_��5      $
��Left=�6/   $��164,217,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��39��6�   $��20(�6�   �� 5   
   -   5        $ txt_Price_SP_��5      $
��Left=�6)   $��164,270,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��34��6�   $��20(�6�   �� 5   
   -   5        $��Thêm��5      $
��Left=�6    $��108,338,0,0q�6;   $	��Top=�6P   $��88��6h   $��52��6s   6   �� 5   
   -   5        $��Sửa��5      $
��Left=�6   $��515,338,0,0q�6:   $	��Top=�6O   $��89��6g   $��52��6r   6~   �� 5   
   -   5        $
��Xóa��5      $
��Left=�6   $��676,338,0,0q�6:   $	��Top=�6O   $��89��6g   $��52��6r   6~   �� 5   
   -   5         ��Name$ lv_SP_��5      $��350,104,0,115q�6N   $��14(�6e   $
��Left=�6s   $	��484��6�    �� View 5      �� 5      .P�5      �� $��Mã sản phẩm��6%    �� Width$	 100��6:    �� DisplayMemberBinding 6G   �� *	ProductID+�� 5      $��Tên sản phẩm��6%   $	 150��6;    6G   �� *ProductName+�� 5      $��Tổng Số lượng��6%   $	 120��6<    6H   �� *SumQuantity+�� 5      $��
Đơn giá��6%   $	 110��66    6B   �� *Price+5      5      5       5!      