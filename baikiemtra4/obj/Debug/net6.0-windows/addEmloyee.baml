   M S B A M L   `   `   `  ����F  Bbaikiemtra4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:baikiemtra4baikiemtra4  5   	       baikiemtra4.WinEmloyee   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:baikiemtra4     5   	     � Title$  
WinEmloyee��5   	   $	��450��6   $
��1050��6)   .��5	      � .+�5
   
   �� $��Thông tin nhân viên��6   $
��Left=�6.   $��	360,9,0,0q�6I   $	��Top=�6\   $	��352��6t   $
��Bold"�6�   $��36(�6�   ���	#FFD69696
���""��6�   �� 5   
   $��Mã nhân viên: ��6   $
��Left=�6)   $��7,74,0,0q�6D   $	��Top=�6V   $	��121��6n   $��18(�6z   �� 5   
   $��Tên nhân viên��6   $
��Left=�6(   $��	3,128,0,0q�6C   $	��Top=�6V   $��18(�6n   $	��123��6|   �� 5   
   $��Địa chỉ��6   $
��Left=�6"   $��
10,274,0,0q�6=   $	��Top=�6Q   $��18(�6i   �� 5   
   $��Giới tính��6   $
��Left=�6$   $��	7,177,0,0q�6?   $	��Top=�6R   $��18(�6j   $��77��6x   �� 5   
   $��Số điện thoại��6   $
��Left=�6(   $��	7,321,0,0q�6C   $	��Top=�6V   $��18(�6n   �� 5   
   -   5         ��Name$ 
txt_ID_EL_��5      $
��Left=�6&   $��
135,77,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $��82��6�   $��28��6�   $��18(�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $ txt_Name_EL_��5      $
��Left=�6(   $��133,128,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��189��6�   $��37��6�   $��18(�6�   �� 5   
   -   5        $ txt_Adress_EL_��5      $
��Left=�6*   $��135,265,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��189��6�   $��51��6�   $��18(�6�   �� 5   
   -   5        $ txt_Tel_EL_��5      $
��Left=�6'   $��133,321,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��190��6�   $��34��6�   $��18(�6�   �� 5   
   -   5        $��
Đồng ý��5      $
��Left=�6"   $��492,365,0,0q�6=   $	��Top=�6R   $��88��6j   $��52��6u   $��1,1,1,1q�6�   
���   �6�   �� 5   
   $��Cập Nhật��6   $
��Left=�6$   $��668,365,0,0q�6?   $	��Top=�6T   $��89��6l   $��52��6w   �� 5   
   $
��Xóa��6   $
��Left=�6   $��927,365,0,0q�6:   $	��Top=�6O   $��89��6g   $��52��6r   �� 5   
   $��
Ngày Sinh��6   $
��Left=�6$   $��	7,211,0,0q�6?   $	��Top=�6R   $��20(�6j   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dp_DateobB_��5      $
��Left=�5      $��132,217,0,0q�5      $	��Top=�5      $	��190��5      $��31��5         SelectedDate 5      �� 5       �� Path$ EmloyDateofB�6    �� StringFormat$ 
dd/MM/yyyy��6.   5!      	� 5$   
   -   5         	�Name$ rb_Male_��5$      $	��Nam��6(   $
��Left=�66   $��135,186,0,0q�6Q   $	��Top=�6f   	� 5%   
   -   5        $ 
rb_Female_��5%      $
��Nữ��6*   $
��Left=�67   $��195,186,0,0q�6R   $	��Top=�6g   5'      5(      