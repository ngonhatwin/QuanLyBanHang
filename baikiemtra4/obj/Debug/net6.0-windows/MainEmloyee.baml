   M S B A M L   `   `   `  ����F  Bbaikiemtra4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:baikiemtra4baikiemtra4  5   	       baikiemtra4.MainEmloyee   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:baikiemtra4     5   	     � Title$  Emloyee��5   	   $	��500��6   $
��1000��6&   .��5	      � .+�5
   
   �� $��Nhân Viên��6   $
��Left=�6$   $��	59,19,0,0q�6?   $	��Top=�6R   $	��131��6j   $��24(�6v   $
��Bold"�6�   ���	#FFCC285D6�   �� 5   
   $��
0,27,506,0q�6    �� TextWrapping$
 Wrap=�6&   $1��+Tìm theo mã nhân viên, tên nhân viên��6:   $	��Top=�6f   $	��261��6~   $��26��6�    �� TextAlignment$ Center=�6�   $��Right=�6�   �� 5   
   -   5         ��Name$ lv_Emloyee_��5      $��233,61,69,86q�6S    �� View 5      �� 5      .P�5      �� $	��MNV��6%    �� Width$ 40��62    �� DisplayMemberBinding 6=   �� *Id+�� 5      $��Tên Nhân viên��6%   $	 150��6<    6H   �� *	EmloyName+�� 5      $��Giới tính��6%   $ 50��68    6C   �� *
EmloySex+�� 5      $��
Ngày Sinh��6%   $	 100��68    6D   �� *EmloyDateofB+�� 5      $��Địa chỉ��6%   $	 230��66    6B   �� *EmloyAddress+�� 5      $��Số điện thoại��6%   $	 120��6<    6H   �� *
EmloyTel+5      5      �� 5   
   -   5        $��Cập Nhật��5      $
��Left=�5   	   $��582,413,0,0q�5   	   $	��Top=�5   	   $��89��5   	   $��52��5   	   ��5      �� 5        �� 
TargetType" ��6"   .R�5!      �� #��z��6   #��z��5"      $��2q�5#       �� CornerRadius$ 10��5$      ._�5%      �� $��Center=�6+   $��Center=�6H   5&      5'      5)      �� 5+   
   -   5        $
��Xóa��5+      $
��Left=�5,   	   $��743,413,0,0q�5-   	   $	��Top=�5.   	   $��89��5/   	   $��52��50   	   ��52      �� 53      " ��6"   .R�54      �� #��z��6   #��z��55      $��2q�56      $ 10��57      ._�58      �� $��Center=�6+   $��Center=�6H   59      5:      5<      �� 5=   
   -   5        	 ��Name$	 btn_addEmloyee_��5=      $��+ Nhân Viên��5>   	   $
��Left=�5?   	   $��
800,27,0,0q�5@   	   $	��Top=�5A   	   $	��107��5B   	   $��26��5C   	   $��16(�5D   	   ���	#FF318279��5F      �� 5G      " ��6"   .R�5H      �� #��z��6   #��z��5I      $��2q�5J      $ 10��5K      ._�5L      �� $��Center=�6+   $��Center=�6H   5M      5N      5P      5R      5S      