   M S B A M L   `   `   `  ����@  <Demo2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Demo2Demo2  5   	       Demo2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Demo2     5   	     � Title$%  Data entry demo with validation��5   	   $	��350��61   $	��525��6>   .��5	      � .+�5
   
   �� $��5q�6    �� Padding$ 5q�6   $��1q�6(   
���  ��
������� �� CornerRadius$ 10��6h   ._�5      �� -   5         ��Name$ 	textBlock��5      $
��Left=�6+   $��
68,242,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $	��382��6�   $��52��6�   �� 5      $�Hello��6    �� 5      �6   �� *Customer.Name+ �� 5      �6   �� *Customer.LastN+ �� 5      $�(��6    �� 5      �6   �� *Customer.Email+ �� 5      $]�W) this is a data entry demo and you can modify the text that will be shown in this box.��6   6x   5      �� 5   
   -   5         ��Name$ label��5      $
��Name��6   $
��Left=�6.   $��	68,84,0,0q�6I   $	��Top=�6\   $��70��6t   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��
171,87,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   ��5      �� *Customer.Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5   
   -   5        $ 
label_Copy��5      $��	Last Name��6$   $
��Left=�68   $��
68,130,0,0q�6S   $	��Top=�6g   $��70��6   �� 5   
   -   5        $ textBox_Copy��5      $
��Left=�6(   $��23��6C   $��171,133,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   ��5      �� *Customer.LastN+$ PropertyChanged=� . �� 5   
   -   5        $ label_Copy1��5      $��Email��6%   $
��Left=�65   $��
68,181,0,0q�6P   $	��Top=�6d   $��70��6|   �� 5   
   -   5        $ textBox_Copy1��5      $
��Left=�6)   $��23��6D   $��171,184,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��164��6�   ��5      �� *Customer.Email+$ PropertyChanged=� . �� 5   
   $��Submit��6   $��368,109,47,164q�6D   ��6"   �� *UpdateCommand+6D   5!      5"      